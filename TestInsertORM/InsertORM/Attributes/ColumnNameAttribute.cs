using System;

namespace InsertORM.Attributes
{
    public class ColumnNameAttribute : Attribute
    {
        private readonly string columnName;

        public ColumnNameAttribute(string columnName)
        {
            this.columnName = columnName;
        }

        public string ColumnName 
        {
            get 
            {
                return columnName;
            }
        }
    }
}
