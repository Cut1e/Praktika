using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication13
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton23_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)comboBox1.SelectedValue;
                int id2 = (int)comboBox2.SelectedValue;
                string data = String.Format(bunifuDatepicker1.Value.ToShortDateString());
                pnlMainMenu main = this.Owner as pnlMainMenu;
                if (main != null)
                {
                    if (MessageBox.Show("Вы уверены что хотите добавить?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        main.izdTableAdapter.InsertQuery(bunifuTextBox1.Text, bunifuTextBox2.Text, id, id2, data, bunifuTextBox3.Text);
                        main.izdTableAdapter.Fill(main.uchhet_izmDataSet.izd);
                        main.izdTableAdapter.Adapter.Update(main.uchhet_izmDataSet.izd);
                        bunifuTextBox1.Text = "";
                        bunifuTextBox2.Text = "";
                        bunifuTextBox3.Text = "";
                        bunifuTextBox1.Focus();
                    }
                }
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.tip_izdTableAdapter.Fill(this.uchhet_izmDataSet.tip_izd);
            this.skladTableAdapter.Fill(this.uchhet_izmDataSet.sklad);
            bunifuDatepicker1.Value = DateTime.Now;

        }

        private void bunifuTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                    bunifuTextBox2.Focus();
            }
            catch 
            {
               return;
            }
        }
    }
}
