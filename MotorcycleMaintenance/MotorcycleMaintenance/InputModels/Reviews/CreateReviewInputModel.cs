namespace MotorcycleMaintenance.InputModels.Reviews
{
    public class CreateReviewInputModel
    {
        public string ReviewedDate { get; set; }

        public double Price { get; set; }

        public short ContributionCount { get; set; }

        public short MonthCount { get; set; }

        public string ReviewHeader { get; set; }

        public int MotorcycleDataId { get; set; }

        public string InsuranceAgency { get; set; }

        public string EndDate { get; set; }
    }
}
