namespace MotorcycleMaintenance.Services.Contracts
{
    public interface IUserService
    {
        void CreateUser(string username, string password);

        bool HasUser(string username);

        bool HasPassword(string username, string password);

        int GetUserId(string username);

        void LogInUser(string username);

        void LogOutUser();
    }
}
