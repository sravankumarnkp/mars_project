using System;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using TechTalk.SpecFlow;
using static MarsQA_1.Helpers.CommonMethods;


namespace MarsQA_1.Feature
{
    [Binding]
    public class ProfileSteps : MarsQA_1.Helpers.Driver
    {
        int i = 0;
        ProfilePage pageObj = new ProfilePage();
        [Given(@"I Logged into Profile Page sucessfully")]
        public void GivenILoggedIntoProfilePageSucessfully()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I clicked on edit button")]
        public void GivenIClickedOnEditButton()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I entered '(.*)' and '(.*)', And click on save button")]
        public void WhenIEnteredAndAndClickOnSaveButton(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the result sholud be saved\.")]
        public void ThenTheResultSholudBeSaved_()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I entered empty Firstname and Lastname, And click on save button")]
        public void WhenIEnteredEmptyFirstnameAndLastnameAndClickOnSaveButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"a popup should be shown with this message \(First Name, Last Name are reqired\)")]
        public void ThenAPopupShouldBeShownWithThisMessageFirstNameLastNameAreReqired()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I entered  with out Firstname and kumar as Lastname   , And click on save button")]
        public void WhenIEnteredWithOutFirstnameAndKumarAsLastnameAndClickOnSaveButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I logged into Trade Skills portal successfully")]
        public void GivenILoggedIntoTradeSkillsPortalSuccessfully()
        {
            // ScenarioContext.Current.Pending();
            test.Log(LogStatus.Info, "we are in profile page ");

        }

        [Given(@"I click on Availability pen icon")]
        public void GivenIClickOnAvailabilityPenIcon()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I select value from the dorpdown")]
        public void WhenISelectValueFromTheDorpdown()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Availability should be saved successfully")]
        public void ThenAvailabilityShouldBeSavedSuccessfully()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I click on Hours pen icon")]
        public void GivenIClickOnHoursPenIcon()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Hours should be saved successfully")]
        public void ThenHoursShouldBeSavedSuccessfully()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I click on Earn Target pen icon")]
        public void GivenIClickOnEarnTargetPenIcon()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Earn Target should be saved successfully")]
        public void ThenEarnTargetShouldBeSavedSuccessfully()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I click on Description edit pen icon")]
        public void GivenIClickOnDescriptionEditPenIcon()
        {
            pageObj.clickonDecscriptioneditpen(driver);
        }

        [When(@"I edit the '(.*)' And click on save button")]
        public void WhenIEditTheAndClickOnSaveButton(string p0)
        {
            test.Log(LogStatus.Info, "sending the description");

            pageObj.editDescription(driver, p0);
            string img = SaveScreenShotClass.SaveScreenshot(driver, "Report");
            test.Log(LogStatus.Info, "Snapshot below: " + test.AddScreenCapture(img));


        }

        [Then(@"'(.*)'  should be saved sucessfully on profile page")]
        public void ThenShouldBeSavedSucessfullyOnProfilePage(string p0)
        {
            string getdesc=pageObj.getProfileDescrption(driver);
            
            Assert.That(p0 == getdesc, "acutal description and expected descrption not equal");
        }

        [Then(@"'(.*)' should not be saved saved or  Pop up message displayed stat with letter or digit")]
        public void ThenShouldNotBeSavedSavedOrPopUpMessageDisplayedStatWithLetterOrDigit(string p0)
        {
            // ScenarioContext.Current.Pending();
            string getdesc = pageObj.GetPopUpMessage(driver);
            Console.WriteLine("popup is" + getdesc);
            Assert.That("First character can only be digit or letters" == getdesc, "acutal description and expected descrption not equal");

        }

        [When(@"i click on languages tab, and click on addnew button and chooselanguage as '(.*)'")]
        public void WhenIClickOnLanguagesTabAndClickOnAddnewButtonAndChooselanguageAs(string p0)
        {
            i=pageObj.addNewLanguages(driver, p0);
        }

        [When(@"i choose level as '(.*)' and clickon add button")]
        public void WhenIChooseLevelAsAndClickonAddButton(string p0)
        {
            if (i == -1)
            {
                test.Log(LogStatus.Info, "adding of lang more than 4");

            }
            else
            {
                pageObj.addLanguageLevel(driver, p0);
            }
        }

        [Then(@"Pop up message displayed as '(.*)'  has been added to your languages")]
        public void ThenPopUpMessageDisplayedAsHasBeenAddedToYourLanguages(string p0)
        {
            if (i == -1) { }
            else
            {
                string popUp = pageObj.textGetPopUpMessage(driver);

                Console.WriteLine("popup is" + popUp);
                Assert.That(p0 + " has been added to your languages" == popUp, "Languages not added to profile ");
            }
        }

        [Then(@"Pop up message displayed as Duplicated data")]
        public void ThenPopUpMessageDisplayedAsDuplicatedData()
        {
            if (i == -1) { }
            else
            {
                string popUp = pageObj.textGetPopUpMessage(driver);

                Console.WriteLine("popup is" + popUp);
                Assert.That("Duplicated data" == popUp, "language some other error ");
            }
        }

        [When(@"i dont choose level and clickon add button")]
        public void WhenIDontChooseLevelAndClickonAddButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Pop up message displayed as please enter languages level")]
        public void ThenPopUpMessageDisplayedAsPleaseEnterLanguagesLevel()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"i click on languages tab, and click on  edit button   add choose language as '(.*)'")]
        public void WhenIClickOnLanguagesTabAndClickOnEditButtonAddChooseLanguageAs(string p0)
        {
            //geeting the row of the lang 
             i=pageObj.getlanguagerowfield(driver,p0);
            if (i == -1)
            {
                
                Console.WriteLine("can not find the lang ");
               // driver.Quit();
            }
            else
            {
                //sending the row number into the edit lang
                pageObj.clickoneditlangButton(driver, i);
            }
        }

        [When(@"i choose '(.*)' and clickon update button")]
        public void WhenIChooseAndClickonUpdateButton(string p0)
        {
            if (i == -1)
            {
                Console.WriteLine("can not find the lang ");
            }
            else
            {
                pageObj.updateLanguageLeve(driver, p0, i);
            }
        }

        [When(@"i choose level and clickon update button")]
        public void WhenIChooseLevelAndClickonUpdateButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Pop up message displayed english   has been updated  to your languages")]
        public void ThenPopUpMessageDisplayedEnglishHasBeenUpdatedToYourLanguages()
        {
            if (i == -1)
            {
                Console.WriteLine("can not find the lang u choosed");
            }
            else
            {
                string popUp = pageObj.textGetPopUpMessage(driver);

                Console.WriteLine("popup is" + popUp);
                Assert.That("english has been updated to your languages" == popUp, "language some other error ");
            }
        }


        [When(@"i click on languages tab, and click on  edit button   add choose language as english")]
        public void WhenIClickOnLanguagesTabAndClickOnEditButtonAddChooseLanguageAsEnglish()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Seller click on languages tab")]
        public void WhenSellerClickOnLanguagesTab()
        {
            pageObj.clickonlaungtab(driver);
        }


        [When(@"Seller delete his languages with '(.*)'")]
        public void WhenSellerDeleteHisLanguagesWith(string p0)
        {
            
            //geeting the row of the lang 
            i = pageObj.getlanguagerowfield(driver, p0);
            if (i == -1)
            {
                Console.WriteLine("canot find the lang for delete");
                test.Log(LogStatus.Info, "canot find the lang for delete");

            }
            else
            {
                //sending the row number into the edit lang
                pageObj.clickonedeleteButton(driver, i);
            }

        }


        [Then(@"Pop up massage displayed as languages entry successfully removed")]
        public void ThenPopUpMassageDisplayedAsLanguagesEntrySuccessfullyRemoved()
        {
            if (i == -1)
            {
                Console.WriteLine("canot find the lang for delete");
                test.Log(LogStatus.Info, "canot find the lang for delete");

            }
            else
            {
                string popUp = pageObj.textGetPopUpMessage(driver);

                Console.WriteLine("popup is" + popUp);
                Assert.That("english has been deleted from your languages" == popUp, "language some other error ");
            }
        }

        [When(@"i click on skill tab, and click on add new button and skill as html")]
        public void WhenIClickOnSkillTabAndClickOnAddNewButtonAndSkillAsHtml()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"i choose level as expert and clickon add button")]
        public void WhenIChooseLevelAsExpertAndClickonAddButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Pop up massage displayed as html  has been added to your skill")]
        public void ThenPopUpMassageDisplayedAsHtmlHasBeenAddedToYourSkill()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"i click on skill tab, and click on addnew button and choose skill as '(.*)'")]
        public void WhenIClickOnSkillTabAndClickOnAddnewButtonAndChooseSkillAs(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"i choose '(.*)'  and clickon add button")]
        public void WhenIChooseAndClickonAddButton(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"i click on addnew button and choose skill as '(.*)'")]
        public void WhenIClickOnAddnewButtonAndChooseSkillAs(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Pop up message displayed as please enter skill level")]
        public void ThenPopUpMessageDisplayedAsPleaseEnterSkillLevel()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"i click on edit button   add choose skill as '(.*)'")]
        public void WhenIClickOnEditButtonAddChooseSkillAs(string p0)
        {
            ScenarioContext.Current.Pending();
        }

       /* [When(@"i choose '(.*)'   and clickon update button")]
        public void WhenIChooseAndClickonUpdateButton(string p0)
        {
            ScenarioContext.Current.Pending();
        }*/

        [Then(@"Pop up message displayed html   has been added to your skill")]
        public void ThenPopUpMessageDisplayedHtmlHasBeenAddedToYourSkill()
        {
            ScenarioContext.Current.Pending();
        }

       
        [When(@"Seller click on education tab")]
        public void WhenSellerClickOnEducationTab()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Seller add his education university as jntu")]
        public void WhenSellerAddHisEducationUniversityAsJntu()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Seller select country as india and title as btech")]
        public void WhenSellerSelectCountryAsIndiaAndTitleAsBtech()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Seller add degree as Information Technology")]
        public void WhenSellerAddDegreeAsInformationTechnology()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Seller select education year as (.*)")]
        public void WhenSellerSelectEducationYearAs(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Pop up massage displayed as Education has been added")]
        public void ThenPopUpMassageDisplayedAsEducationHasBeenAdded()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click on education tab")]
        public void WhenIClickOnEducationTab()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"i click on  edit button and choose  education university as hyder")]
        public void WhenIClickOnEditButtonAndChooseEducationUniversityAsHyder()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Pop up massage displayed as Education as been updated")]
        public void ThenPopUpMassageDisplayedAsEducationAsBeenUpdated()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Pop up massage displayed as information already exist")]
        public void ThenPopUpMassageDisplayedAsInformationAlreadyExist()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Seller delete his education raw with university as NIBM")]
        public void WhenSellerDeleteHisEducationRawWithUniversityAsNIBM()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Pop up massage displayed as Education entry successfully removed")]
        public void ThenPopUpMassageDisplayedAsEducationEntrySuccessfullyRemoved()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Seller click on certification tab and Seller add his certificate name  as istqb")]
        public void WhenSellerClickOnCertificationTabAndSellerAddHisCertificateNameAsIstqb()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Seller select certificate from testing")]
        public void WhenSellerSelectCertificateFromTesting()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Seller select certificate year as (.*)")]
        public void WhenSellerSelectCertificateYearAs(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Pop up massage displayed as certificate has been added")]
        public void ThenPopUpMassageDisplayedAsCertificateHasBeenAdded()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click on certification tab")]
        public void WhenIClickOnCertificationTab()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"i click on  edit button and choose  certification from  software")]
        public void WhenIClickOnEditButtonAndChooseCertificationFromSoftware()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Pop up massage displayed as certification as been updated")]
        public void ThenPopUpMassageDisplayedAsCertificationAsBeenUpdated()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Pop up massage displayed as already exsits")]
        public void ThenPopUpMassageDisplayedAsAlreadyExsits()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Seller click on certification tab")]
        public void WhenSellerClickOnCertificationTab()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Seller delete his certification with istqb")]
        public void WhenSellerDeleteHisCertificationWithIstqb()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
