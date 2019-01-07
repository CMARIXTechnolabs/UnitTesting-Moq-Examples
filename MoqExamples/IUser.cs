namespace MoqTestDemo
{
    public interface IUser
    {
        bool IsAdmin { get; }

        void MakePayment();

        bool CheckUserExistance();

        void UpdateUser();
    }
}