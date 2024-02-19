using System.Configuration;
using RecipeWinForms.Properties;

namespace RecipeWinForms
{
    public partial class frmLogin : Form
    {
        bool loginsuccess = false;
        public frmLogin()
        {
            InitializeComponent();
            btnOK.Click += BtnOK_Click;
            btnCancel.Click += BtnCancel_Click;
        }
        public bool ShowLogin()
        {
#if DEBUG
            this.Text = this.Text + " - DEV";
#endif
            txtUserId.Text = Settings.Default.userid;
            this.ShowDialog();
            return loginsuccess;
        }
        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            loginsuccess = true;
            this.Close();
        }

        private void BtnOK_Click(object? sender, EventArgs e)
        {
            try
            {
                string connstringkey = "";
#if DEBUG 
                connstringkey = "devconn";
#else
                connstringkey = "liveconn";
#endif
                string connstring = ConfigurationManager.ConnectionStrings[connstringkey].ConnectionString;
                DBManager.SetConnectionString(connstring, true, txtUserId.Text, txtPassword.Text);
                loginsuccess = true;
                Settings.Default.userid = txtUserId.Text;
                Settings.Default.Save();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid login. Try Again.", Application.ProductName);
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
