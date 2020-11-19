using NUnit.Framework;

namespace MarsFramework
{
    public class Program
    {
        [TestFixture]
        [Category("Sprint1")]
        class User : Global.Base
        {

            [Test]
            public void EnterProfileTest()
            {
                Profile profilePage = new Profile();
                profilePage.EnterProfile();

                profilePage.VerifyEnterProfile();
            }

            [Test]
            public void DeleteProfileTest()
            {
                Profile profilePage = new Profile();
                profilePage.DeleteProfile();

                profilePage.VerifyDeleteProfile();
            }


        }
    }
}