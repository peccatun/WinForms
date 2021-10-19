using InsertORM.Attributes;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace InsertORM
{
    public class InsertStatementGenerator
    {
        public string InsertTableRow<T>(T insertObject)
        {
            string tableNameFB = GenerateTableName(insertObject);

            string[] columnNameArr = GenerateTableColumnList<T>();
            string[] columnValueArr = GenerateColumnValues(insertObject);

            string tableColumns = string.Join(",", columnNameArr);
            string tableColumnValues = string.Join(",", columnValueArr);

            string insertStatement = $"INSERT INTO {tableNameFB}({tableColumns})VALUES({tableColumnValues})";

            return insertStatement;
        }

        private string GenerateTableName<T>(T model)
        {
            string tableName = model.GetType().Name;
            string tableNameFB = PascalCaseToSnakeCaseConver(tableName);

            bool hasTableNameAttribute = Attribute.IsDefined(typeof(T), typeof(TableNameAttribute));

            if (hasTableNameAttribute)
            {
                var tableNameAttr = typeof(T).GetCustomAttribute<TableNameAttribute>();
                tableNameFB = tableNameAttr.TableName;
            }

            return tableNameFB;


        }

        private string[] GenerateTableColumnList<T>()
        {
            PropertyInfo[] properties = typeof(T).GetProperties();
            string[] columnNameArr = new string[properties.Length];

            for (int i = 0; i < properties.Length; i++)
            {
                PropertyInfo property = properties[i];

                string propertyName = property.Name;
                string columnNameFb = PascalCaseToSnakeCaseConver(propertyName);

                if (IsSpecialColumnName(columnNameFb))
                {
                    columnNameFb = EscapeSpecialColumnName(columnNameFb);
                }

                bool hasAttribute = Attribute.IsDefined(property, typeof(ColumnNameAttribute));

                if (hasAttribute)
                {
                    var attribute = property
                        .GetCustomAttribute<ColumnNameAttribute>();

                    columnNameFb = attribute.ColumnName;
                }

                columnNameArr[i] = columnNameFb;
            }

            return columnNameArr;
        }

        private string[] GenerateColumnValues<T>(T model)
        {
            PropertyInfo[] properties = typeof(T).GetProperties();
            string[] columnValueArr = new string[properties.Length];

            Type stringType = typeof(string);
            object modelObj = model;

            for (int i = 0; i < properties.Length; i++)
            {
                PropertyInfo property = properties[i];

                Type currentPropertyType = property.PropertyType;
                var value = property.GetValue(modelObj, null);
                string valueString = "null";

                bool isNull = Attribute.IsDefined(property, typeof(NullValueAttribute));

                if (!isNull && value != default)
                {
                    valueString = value.ToString();

                    if (currentPropertyType == stringType)
                    {
                        valueString = GenerateInsertString(valueString);
                    }
                }

                columnValueArr[i] = valueString;
            }

            return columnValueArr;

        }

        private bool IsSpecialColumnName(string columnName)
        {
            const string time = "time";
            const string admin = "admin";
            const string date = "date";
            const string user = "user";

            string columnNameToLower = columnName.ToLower();

            switch (columnNameToLower)
            {
                case time:
                    return true;
                case admin:
                    return true;
                case date:
                    return true;
                case user:
                    return true;

                default:
                    return false;
            }
        }

        private string EscapeSpecialColumnName(string columnName)
        {
            return $"\"{columnName.ToUpper()}\"";
        }

        private string GenerateInsertString(string value)
        {
            return $"'{value}'";
        }

        private string PascalCaseToSnakeCaseConver(string pascalCase)
        {
            StringBuilder snakeCaseBuild = new StringBuilder();

            for (int i = 0; i < pascalCase.Length; i++)
            {
                if (char.IsUpper(pascalCase[i]) && i > 0)
                {
                    snakeCaseBuild.Append("_");
                    snakeCaseBuild.Append(pascalCase[i]);
                    continue;
                }

                snakeCaseBuild.Append(pascalCase[i]);
            }

            return snakeCaseBuild.ToString().ToUpper();
        }
    }
}
