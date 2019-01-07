namespace MoqTestDemo
{
	public class User
    {
		public void ProcessPayment(IUser user)
		{
			if (user.IsAdmin)
			{
				user.MakePayment();
			}
		}

        public void UserUpdate(IUser user)
        {
            if (user.CheckUserExistance())
            {
                user.UpdateUser();
            }
        }
    }
}