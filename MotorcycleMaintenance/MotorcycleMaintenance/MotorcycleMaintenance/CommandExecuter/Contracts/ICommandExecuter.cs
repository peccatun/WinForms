namespace MotorcycleMaintenance.CommandExecuter.Contracts
{
    public interface ICommandExecuter
    {
        void ExecuteNonQuery(string query);
    }
}
