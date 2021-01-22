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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton23_Click(object sender, EventArgs e)
        {
            try
            {
                pnlMainMenu main = this.Owner as pnlMainMenu;
                if (main != null)
                {
                    if (MessageBox.Show("Вы уверены что хотите добавить?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        main.tip_izdTableAdapter.InsertQuery(bunifuTextBox1.Text, bunifuTextBox2.Text);
                        main.tip_izdTableAdapter.Fill(main.uchhet_izmDataSet.tip_izd);
                        main.tip_izdTableAdapter.Adapter.Update(main.uchhet_izmDataSet.tip_izd);
                        bunifuTextBox1.Text = "";
                        bunifuTextBox2.Text = "";
                        bunifuTextBox1.Focus();
                    }
                }
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuTextBox2_TextChange(object sender, EventArgs e)
        {
           
            }

        private void bunifuTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    pnlMainMenu main = this.Owner as pnlMainMenu;
                    if (main != null)
                    {
                        if (MessageBox.Show("Вы уверены что хотите добавить?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            main.tip_izdTableAdapter.InsertQuery(bunifuTextBox1.Text, bunifuTextBox2.Text);
                            main.tip_izdTableAdapter.Fill(main.uchhet_izmDataSet.tip_izd);
                            main.tip_izdTableAdapter.Adapter.Update(main.uchhet_izmDataSet.tip_izd);
                            bunifuTextBox1.Text = "";
                            bunifuTextBox2.Text = "";
                            bunifuTextBox1.Focus();
                        }
                    }
                }
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
