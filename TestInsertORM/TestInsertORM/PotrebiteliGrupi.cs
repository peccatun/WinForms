using InsertORM.Attributes;

namespace TestInsertORM
{
    public class PotrebiteliGrupi
    {
        public long Pk { get; set; }

        public short IsDel { get; set; }

        //[ColumnName("RegNumber")]
        public string RegNumber { get; set; }

        public string Ime { get; set; }

        public string Komentar { get; set; }

        public string Zabelejka { get; set; }
    }
}
