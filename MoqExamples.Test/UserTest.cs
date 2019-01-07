using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace MoqTestDemo.Test
{
    [TestClass]
	public class UserTest
    {
        /// <summary>
        /// Properties the test.
        /// </summary>
        [TestMethod]
		public void PropertyTest()
		{
			var mock = new Mock<IUser>();

			mock.Setup(User => User.IsAdmin).Returns(true);

			var user = new User();

            user.ProcessPayment(mock.Object);

			mock.Verify(x => x.MakePayment());
		}

        /// <summary>
        /// Methods the test.
        /// </summary>
        [TestMethod]
        public void MethodTest()
        {
            var mock = new Mock<IUser>();

            mock.Setup(User => User.CheckUserExistance()).Returns(true);

            var user = new User();

            user.UserUpdate(mock.Object);

            mock.Verify(x => x.UpdateUser());
        }
    }
}