using OpenQA.Selenium.Firefox;

namespace NugetPackageManager
{
    public partial class Form1 : Form
    {
        // FIREFOX DRIVER
        FirefoxDriver firefoxDriver ;

        public Form1()
        {
            InitializeComponent();
        }

        private void urltextBox_Click(object sender, EventArgs e)
        {
            if (urltextBox.Text == "URL -->")
            {
                urltextBox.Clear();
                urltextBox.ForeColor = Color.Black;

            }
        }

        private void urltextBox_TextChanged(object sender, EventArgs e)
        {
            if (urltextBox.Text == "URL -->")
            {
                urltextBox.Clear();
                urltextBox.ForeColor = Color.Black;
            }
        }

        private void goToUrlButton_Click(object sender, EventArgs e)
        {
            // INSTANTIATE FIREFOX DRIVER
            firefoxDriver = new FirefoxDriver(); 

            // GO TO URL
            string url = urltextBox.Text;
            firefoxDriver.Navigate().GoToUrl(url);
        }
    }
}
