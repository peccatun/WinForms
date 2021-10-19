using InsertORM.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInsertORM
{
    public class ProizvodstvoList
    {
        public long Pk { get; set; }

        public short IsDel { get; set; }

        public string RegNumber { get; set; }

        public long StokiFk { get; set; }

        public double Kolichestvo { get; set; }

        public long SkldoveFk { get; set; }

        public long ProizvodstvoFk { get; set; }

        public long StokiMerniEdFk { get; set; }

        public string SerienNomer { get; set; }

        //[ColumnName("ZabelejaBatkaName")]
        public string ZabelejkaBatkaName { get; set; }

        public long ProizovdstoProduktiFk { get; set; }
    }
}
