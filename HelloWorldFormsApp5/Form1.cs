namespace HelloWorldFormsApp5
{//JeffJohnson
 //CST-150
 //Activity 1
 //09/08/2022
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// ClickHereButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOnClick(object sender, EventArgs e)
        {
            lblHelloWorldLabel.Text = "HelloWorld!!!";
        }
    }
}