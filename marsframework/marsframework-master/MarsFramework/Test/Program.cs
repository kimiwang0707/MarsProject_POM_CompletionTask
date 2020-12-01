using MarsFramework.Global;
using MarsFramework.Pages;
using NUnit.Framework;

namespace MarsFramework
{
    public class Program
    {
        [TestFixture]
        [Category("Sprint1")]
        class User : Base
        {
            // Profile Page
            [Test]
            public void EnterProfileTest()
            {
                test = extent.StartTest("Enter Profile");
                Profile profilePage = new Profile();
                profilePage.EnterProfile();

                profilePage.VerifyEnterProfile();
            }

            [Test]
            public void DeleteProfileTest()
            {
                test = extent.StartTest("Delete Profile");
                Profile profilePage = new Profile();
                profilePage.DeleteProfile();

                profilePage.VerifyDeleteProfile();
            }


            // Share Skill Page
            [Test]
            public void EnterShareSkillTest()
            {
                test = extent.StartTest("Enter Share Skill");
                ShareSkill shareSkillPage= new ShareSkill();
                shareSkillPage.EnterShareSkill();

                shareSkillPage.VerifyEnterShareSkill();
            }


            // Manage Listings Page
            [Test]
            public void ViewListingTest()
            {
                test = extent.StartTest("View Listing");
                ManageListingsLink manageListings = new ManageListingsLink();
                manageListings.ViewListing();

                manageListings.VerifyViewListing();
            }

            [Test]
            public void EditListingTest()
            {
                test = extent.StartTest("Edit Listing");
                ManageListingsLink manageListings = new ManageListingsLink();
                manageListings.EditListing();

                manageListings.VerifyEditListing();
            }

            [Test]
            public void DeleteListingTest()
            {
                test = extent.StartTest("Delete Listing");
                ManageListingsLink manageListings = new ManageListingsLink();
                manageListings.DeleteListing();

                manageListings.VerifyDeleteListing();
            }



        }
    }
}