using System;
using System.Windows.Forms;

namespace Delivery_System_Project
{
    public partial class Login : Form
    

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = this.userSecurity.ValidateUser(this.textBox1.Text, this.textBox2.Text);

            if (result == true)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Credenciales inválidas");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
