namespace MotorcycleMaintenance.InputModels.Coolant
{
    public class CreateCoolantInputModel
    {
        public string Make { get; set; }

        public string ChangeDate { get; set; }

        public double Price { get; set; }

        public int MotorcycleId { get; set; }

        public int KilometersOnChange { get; set; }
    }
}
