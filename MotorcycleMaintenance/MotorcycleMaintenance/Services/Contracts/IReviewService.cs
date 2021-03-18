using MotorcycleMaintenance.InputModels.Reviews;
using System;
using System.Collections.Generic;

namespace MotorcycleMaintenance.Services.Contracts
{
    public interface IReviewService
    {
        void CreateReview(CreateReviewInputModel model);

        string GenerateReviewHeader(DateTime reviewedDate);

        bool HasAngecy(int motorcycleId);

        List<string> GetCurrentBikeInsuranceAgensies(int motorcycleId);

        DateTime GenerateEndDate(DateTime startDate, int months);
    }
}
