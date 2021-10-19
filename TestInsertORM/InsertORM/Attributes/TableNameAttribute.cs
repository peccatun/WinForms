using System;

namespace InsertORM.Attributes
{
    public class TableNameAttribute : Attribute
    {
        private readonly string tableName;

        public TableNameAttribute(string tableName)
        {
            this.tableName = tableName;
        }

        public string TableName 
        {
            get 
            {
                return tableName;
            }
        }
        
    }
}
