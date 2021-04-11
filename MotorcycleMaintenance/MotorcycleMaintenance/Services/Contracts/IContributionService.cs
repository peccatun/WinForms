using System;

namespace MotorcycleMaintenance.Services.Contracts
{
    public interface IContributionService
    {
        void CreateReviewNewContribution(DateTime payday, double price, int reviewId);

        void CreateTaxContribution(DateTime payday, double price);

        int GenerateContributionId();
    }
}
