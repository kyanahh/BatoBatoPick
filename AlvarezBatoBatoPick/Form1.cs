using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlvarezBatoBatoPick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            Random ran = new Random();
            int num = ran.Next(1, 4);
            string compChoice = "";

            if (num == 1)
            {
                compChoice = "Bato";
            }else if(num == 2)
            {
                compChoice = "Papel";
            }else if(num == 3)
            {
                compChoice = "Gunting";
            }

            lblResult.Text = compChoice;

            int comp = Convert.ToInt32(lblComputer.Text);
            int you = Convert.ToInt32(lblYou.Text);

            while (!((comp == 3 && you < comp) || (you == 3 && comp < you))) { 
                if (rbBato.Checked == true && compChoice == "Bato" || rbPapel.Checked == true && compChoice == "Papel" || rbGunting.Checked == true && compChoice == "Gunting")
                {
                    lblResult.Text = "It's a tie! Computer's choice is " + compChoice;
                    rbBato.Checked = false;
                    rbGunting.Checked = false;
                    rbPapel.Checked = false;
                    return;
                }
                else if (rbBato.Checked == true && compChoice == "Papel" || rbPapel.Checked == true && compChoice == "Gunting" || rbGunting.Checked == true && compChoice == "Bato")
                {
                    lblResult.Text = "Computer Wins! Computer's choice is " + compChoice;
                    comp++;
                    lblComputer.Text = comp.ToString();
                    rbBato.Checked = false;
                    rbGunting.Checked = false;
                    rbPapel.Checked = false;
                    return;
                }
                else if (rbBato.Checked == true && compChoice == "Gunting" || rbPapel.Checked == true && compChoice == "Bato" || rbGunting.Checked == true && compChoice == "Papel")
                {
                    lblResult.Text = "User Wins! Computer's choice is " + compChoice;
                    you++;
                    lblYou.Text = you.ToString();
                    rbBato.Checked = false;
                    rbGunting.Checked = false;
                    rbPapel.Checked = false;
                    return;
                }
            }

            if (comp == 3 && you < comp)
            {
                MessageBox.Show("The winner is Computer. Congratulations!", "Result", MessageBoxButtons.OK);
                rbBato.Checked = false;
                rbGunting.Checked = false;
                rbPapel.Checked = false;
                comp = 0;
                you = 0;
                lblYou.Text = you.ToString();
                lblComputer.Text = comp.ToString();
            }
            else if (you == 3 && you > comp)
            {
                MessageBox.Show("The winner is User. Congratulations!", "Result", MessageBoxButtons.OK);
                rbBato.Checked = false;
                rbGunting.Checked = false;
                rbPapel.Checked = false;
                comp = 0;
                you = 0;
                lblYou.Text = you.ToString();
                lblComputer.Text = comp.ToString();
            }

        }
    }
}
