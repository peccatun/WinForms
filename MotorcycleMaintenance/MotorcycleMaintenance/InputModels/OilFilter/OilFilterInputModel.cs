namespace MotorcycleMaintenance.InputModels.OilFilter
{
    public class OilFilterInputModel
    {
        public string Make { get; set; }

        public string ChangeDate { get; set; }

        public double Price { get; set; }

        public int MotorcycleId { get; set; }

        public int KilometersOnChange { get; set; }
    }
}
