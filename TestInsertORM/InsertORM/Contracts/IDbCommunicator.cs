namespace InsertORM.Contracts
{
    public interface IDbCommunicator
    {
        void Add<T>(T inputModel);

        void CommitTransaction();
    }
}
