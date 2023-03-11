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
    public partial class PlayForm : Form
    {
        static BindingList<Player> listplayer = new BindingList<Player>();
        public static string Setname = " ";
        public static string Setusername = " ";
        public int setIndex;
        public PlayForm()
        {
            InitializeComponent();
            this.dataGridView1.SelectionMode= DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.DataSource= listplayer;
            this.button1.Enabled=false;
        }

        private void PlayForm_Load(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            AddPlayerForm addPlayerForm = new AddPlayerForm();
            addPlayerForm.ShowDialog();

            if(addPlayerForm.DialogResult == DialogResult.OK)
            {
                string name = AddPlayerForm.Setname;
                string username = AddPlayerForm.Setusername;

                Player newPlayer = new Player(name ,username);
                listplayer.Add(newPlayer);
                this.dataGridView1.DataSource= listplayer;
                this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private void SelectPlayer(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string name = row.Cells[0].Value.ToString();
                string username = row.Cells[1].Value.ToString();
                this.label3.Text = name;
                this.label5.Text = username;
                Setname = name;
                Setusername = username;
                setIndex = e.RowIndex;
            }
            this.button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listplayer.RemoveAt(setIndex);
            this.DialogResult= DialogResult.OK;
        }
    }
}   
