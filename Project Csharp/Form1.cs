using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Csharp
{
    public partial class LoginForm : Form
    {
        private const int MAX_ATTEMPTS = 3;
        private int numAttempts = 0;
        private string password = "Admin";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.IconLeft = Properties.Resources._1_32;
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            txtPassword.IconLeft = Properties.Resources.icons8_password_32;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string enteredPassword = txtPassword.Text;

            if (enteredPassword == password)
            {
                MessageBox.Show("Mot de passe correct !");
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                numAttempts++;
                int remainingAttempts = MAX_ATTEMPTS - numAttempts;

                if (remainingAttempts > 0)
                {
                    MessageBox.Show("Mot de passe incorrect. Il vous reste " + remainingAttempts + " essai(s).");
                    txtPassword.Clear();
                }
                else
                {
                    MessageBox.Show("Vous avez épuisé vos 3 essais. L'application va se fermer.");
                    this.Close();
                }
            }
        }
    

        private void gunaImageCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(cbx.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string enteredPassword = txtPassword.Text;

                if (enteredPassword == password)
                {
                    MessageBox.Show("Mot de passe correct ");
                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    numAttempts++;
                    int remainingAttempts = MAX_ATTEMPTS - numAttempts;

                    if (remainingAttempts > 0)
                    {
                        MessageBox.Show("Mot de passe incorrect. Il vous reste " + remainingAttempts + " essai(s).");
                        txtPassword.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Vous avez épuisé vos 3 essais. L'application va se fermer.");
                        this.Close();
                    }
                }
            }
    }

    }
}