using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esport_Register
{
    public partial class AddTeamForm : Form
    {
        public static string Setname = " ";
        public static string Setusername " ";
        public AddTeamForm()
        {
            InitializeComponent();
        }

        private void SelectPlayerButton(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            PlayForm playerForm= new PlayForm();
            playerForm.ShowDialog();

            if (PlayForm.DialogResult == DialogResult.OK)
            {
                string name = PlayForm.Setname
                string username = PlayForm.Setusername
                if (button.Name == "Add1")
                {
                    this.textBox2.Text = name;
                    this.textBox7.Text = username;
                }
                if (button.Name == "Add2")
                {
                    this.textBox3.Text = name;
                    this.textBox8.Text = username;
                }
                if (button.Name == "Add3")
                {
                    this.textBox4.Text = name;
                    this.textBox9.Text = username;
                }
                if (button.Name == "Add4")
                {
                    this.textBox5.Text = name;
                    this.textBox10.Text = username;
                }
                if (button.Name == "Add5")
                {
                    this.textBox6.Text = name;
                    this.textBox11.Text = username;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string team = this.teamText.Text;
            this.DialogResult= DialogResult.OK;
        }
    }
}