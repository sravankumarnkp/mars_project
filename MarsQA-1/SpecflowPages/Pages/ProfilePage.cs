using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace MarsQA_1.SpecflowPages.Pages
{
    class ProfilePage 
    {
        public void clickonDecscriptioneditpen(IWebDriver driver)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            //finding the descrption pen icon and click on that 
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i")).Click();
        }
        public void editDescription(IWebDriver driver, String dess)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

            //finding the descrption textbox element
            IWebElement descFiled = driver.FindElement(By.XPath ("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));
            descFiled.Click();
            descFiled.Clear();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //sending the profile desc to descreption
            descFiled.SendKeys(dess);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            //click on save button
            driver.FindElement(By.XPath(
                "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button")).Click();

        }
        public String getProfileDescrption(IWebDriver driver)
        {
            IWebElement profileDesc= driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/span"));
            return profileDesc.Text;

        }

        public String GetPopUpMessage(IWebDriver driver)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            // Wait.WaitForElementToBeClickable(driver, "Xpath", "/html/body/div[1]/div", 10);
            IWebElement successPopup = driver.FindElement(By.XPath("/html/body/div[1]/div"));
            //IWebElement successPopup = driver.FindElement(By.ClassName("ns-type-success"));
            // IWebElement successPopup = driver.FindElement(By.CssSelector("div[class='ns-box-inner']"));
            //string successPopup = driver.SwitchTo().Alert().Text;
            return successPopup.Text;
           
        }
        public String textGetPopUpMessage(IWebDriver driver)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            IWebElement successPopup = driver.FindElement(By.CssSelector("div[class='ns-box-inner']"));
            //IWebElement successPopup = driver.FindElement(By.XPath("/html/body/div[1]/div"));

            // Console.WriteLine(successPopup.Text);
            return successPopup.Text;

        }
        //add new laungages
        public void addNewLanguages(IWebDriver driver, string lang)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            //click on laungages tab
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]")).Click();

            IWebElement langField = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            langField.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            IWebElement addlangField= driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
             addlangField.Clear();
            addlangField.SendKeys(lang);

        }
        public int getlanguagerowfield(IWebDriver driver,string lang)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            int i = 1;
            IWebElement laxfield;
            try
            {
            Label:
                laxfield = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]"));

                if (laxfield.Text == lang)
                {
                    return i;
                }
                else if (i < 10)
                {
                    i++;
                    goto Label;

                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                
                
                return -1;
            }
           
        }
        public void clickoneditlangButton(IWebDriver driver, int i)
        {

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
           IWebElement edit= driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody["+i+"]/tr/td[3]/span[1]/i"));
            edit.Click();
        }
        public void clickonedeleteButton(IWebDriver driver, int i)
        {

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            IWebElement edit = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[3]/span[2]/i"));
            edit.Click();
        }

        public void addLanguageLevel(IWebDriver driver, string level)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            //click on dropdown list
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select")).Click();
           // "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));

            IWebElement Basic = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[2]"));
            IWebElement Conversational = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[3]"));
            IWebElement Fluent = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[4]"));
            IWebElement Native = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[4]"));
            IWebElement noselection = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[1]"));
           if (Native.Text== level)
            {
                Native.Click();
            }
            else if (Fluent.Text == level)
            {
                Fluent.Click();
                Console.WriteLine(Fluent.Text + " test is " + level);

            }
            else if(Conversational.Text == level)
            {
                Conversational.Click();
            }
            else if(Basic.Text == level)
            {
                Basic.Click();
            }
            else
            {
                noselection.Click();
            }

            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]")).Click();
            
        }
        public void updateLanguageLeve(IWebDriver driver, String level,int i)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            //click on dropdown list
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody["+i+"]/tr/td/div/div[2]/select")).Click();
            IWebElement Basic = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody["+i+"]/tr/td/div/div[2]/select/option[2]"));
            IWebElement Conversational = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody["+i+"]/tr/td/div/div[2]/select/option[3]"));
            IWebElement Fluent = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody["+i+"]/tr/td/div/div[2]/select/option[4]"));
            IWebElement Native = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody["+i+"]/tr/td/div/div[2]/select/option[5]"));
            IWebElement noselection = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody["+i+"]/tr/td/div/div[2]/select/option[1]"));
            if (Native.Text == level)
            {
                Native.Click();
            }
            else if (Fluent.Text == level)
            {
                Fluent.Click();
                Console.WriteLine(Fluent.Text + " test is " + level);

            }
            else if (Conversational.Text == level)
            {
                Conversational.Click();
            }
            else if (Basic.Text == level)
            {
                Basic.Click();
            }
            else
            {
                noselection.Click();
            }
            //click on update
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody["+i+"]/tr/td/div/span/input[1]")).Click();
        }
        public void clickonlaungtab(IWebDriver driver)
        {
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]")).Click();

        }

    }
}
