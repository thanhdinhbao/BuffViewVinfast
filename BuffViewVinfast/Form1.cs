using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace BuffViewVinfast
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Sleep(int time)
        {
            Thread.Sleep(time * 1000);
        }

        void CreateChrome(string url)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--start-maximized");
            //options.AddArgument("--no-sandbox");
            options.AddArgument("--disable-popup-blocking");
            options.AddArgument("--ignore-certificate-errors");
            options.AddArguments($"--user-data-dir=C:/Users/{Environment.UserName}/AppData/Local/Google/Chrome/User Data/");
            options.AddArgument("--profile-directory=Default");
            var service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            service.SuppressInitialDiagnosticInformation = true;
            ChromeDriver driver = new ChromeDriver(service, options);
            //Go to Zefoy
            driver.Navigate().GoToUrl("https://zefoy.com/");
            //Xu li xpath
            string btnXpath = string.Empty;
            string sbXpath = string.Empty;
            string cfXpath = string.Empty;
            if (radView.Checked == true)
            {
                btnXpath = "/html/body/div[6]/div/div[2]/div/div/div[6]/div/button";
                sbXpath = "/html/body/div[10]/div/form/div/input";
                cfXpath = "/html/body/div[10]/div/div/div[1]/div/form/button";
            }
            else
            {

            }
            if (radShare.Checked == true)
            {
                btnXpath = "/html/body/div[6]/div/div[2]/div/div/div[7]/div/button";
                sbXpath = "/html/body/div[11]/div/form/div/input";
                cfXpath = "/html/body/div[11]/div/div/div[1]/div/form/button";
            }
            else
            {

            }

            //Wait view button
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            var btn = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(btnXpath)));
            btn.Click();
            //Input searchbox link video
            var searchBox = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(sbXpath)));
            searchBox.SendKeys(url + OpenQA.Selenium.Keys.Enter);
            //Click buff button
            var btnBuff = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(cfXpath)));
            btnBuff.Click();
            //Get time remain
            Sleep(1);
            //lblTimeRemain.Text = driver.FindElement(By.XPath("/html/body/div[10]/div/div/span")).Text;

            Sleep(1);
            driver.Close();
            driver.Quit();
        }

        public string GetRandomLink()
        {
            string[] lines = File.ReadAllLines(txtFilePath.Text);
            Random rand = new Random();
            string result = lines[rand.Next(lines.Length)];
            txtLink.Text = result;
            return result;
        }

        private void btnStartView_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < 20; i++)
            {
                string rand_url = GetRandomLink();
                CreateChrome(rand_url);
                Sleep(110);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "TXT files|*.txt";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = theDialog.FileName;
                btnStartView.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnStartView.Enabled = false;
            foreach (var process in Process.GetProcessesByName("chrome"))
            {
                process.Kill();
            }
        }
    }
}
