using System;

namespace MotorcycleMaintenance.InputModels
{
    public class MotorcycleInfoInputModel
    {
        public int UserId { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public int Kilometers { get; set; }

        public DateTime CreationDate { get; set; }
    }
}
