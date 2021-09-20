using System.Threading;
using CrossPlatformEATest.Pages;
using EAAutoFramework.Base;
using EAAutoFramework.Config;
using TechTalk.SpecFlow;
using EAAutoFramework.Extensions;

namespace CrossPlatformEATest.Steps
{
    [Binding]
    public class HudlLoginStep: BaseStep
    {
        private readonly ParallelConfig _parallelConfig;
        
        public HudlLoginStep(ParallelConfig parallelConfig) : base(parallelConfig)
        {

            _parallelConfig = parallelConfig;
        }

        [Given(@"Navigate to hudl login")]
        public void GivenNavigateToHudlLogin()
        {
            _parallelConfig.Driver.Navigate().GoToUrl(Settings.AUT);
            Thread.Sleep(5000);
            _parallelConfig.CurrentPage = new HudlLogin(_parallelConfig);
        }

        [Given(@"Enter username")]
        public void GivenEnterUsername()
        {
            _parallelConfig.CurrentPage.As<HudlLogin>().EnterUserName();
        }

        [When(@"Enter password")]
        public void WhenEnterPassword()
        {
            _parallelConfig.CurrentPage.As<HudlLogin>().EnterPassword();
        }

        [Then(@"verify the user is loggedin")]
        public void ThenVerifyTheUserIsLoggedin()
        {
            _parallelConfig.CurrentPage.As<HudlLogin>().ClickOnLoginButton();
            _parallelConfig.CurrentPage.As<HudlLogin>().UserIsLoggedInSuccessfully();
        }



    }
}
