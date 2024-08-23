using System.Xml.Linq;

namespace asm2.pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            string Username = tbUname.Text;
            string Password = tbPass.Text;

            if (string.IsNullOrEmpty(Username))
            {
                MessageBox.Show("Please enter your username!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbUname.Focus();
            }
            else if (string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Please enter your password!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbPass.Focus();
            }
            else
            {
                if (Username == "admin" && Password == "1234"
                  || Username == "admin1" && Password == "123")
                {
                    Calculate MainForm = new Calculate();
                    MainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            // button exit to exit program
            DialogResult confirm = MessageBox.Show("Do you want to exit?", "Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (confirm == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Continue...");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            int formWidth = this.Width;
            int formHeight = this.Height;

            int left = (screenWidth - formWidth) / 2;
            int top = (screenHeight - formHeight) / 2;

            // set the form's location to center screen
            this.Location = new Point(left, top);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }
    }
}