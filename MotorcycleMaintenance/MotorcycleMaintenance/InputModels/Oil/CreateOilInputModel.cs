namespace MotorcycleMaintenance.InputModels.Oil
{
    public class CreateOilInputModel
    {
        public string Make { get; set; }

        public string ChangeDate { get; set; }

        public double Price { get; set; }

        public int MotorcycleId { get; set; }

        public int KilometersOnChange { get; set; }
    }
}
