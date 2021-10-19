namespace TestInsertORM
{
    public class Brak
    {
        public long Pk { get; set; }

        public short IsDel { get; set; }

        public string RegNumber { get; set; }

        public string Data { get; set; }

        public string Time { get; set; }

        public long MagaziniFk { get; set; }

        public long SlujiteliFk { get; set; }

        public long SkladoveFk { get; set; }

        public string Comment { get; set; }
    }
}
