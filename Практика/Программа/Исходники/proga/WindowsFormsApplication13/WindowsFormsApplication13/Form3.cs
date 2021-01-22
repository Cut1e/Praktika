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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void tab2_Click(object sender, EventArgs e)
        {
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                Form3 form3 = new Form3();
                form3.Focus();
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                        main.skladTableAdapter.InsertQuery(bunifuTextBox1.Text);
                        main.skladTableAdapter.Fill(main.uchhet_izmDataSet.sklad);
                        main.skladTableAdapter.Adapter.Update(main.uchhet_izmDataSet.sklad);
                        bunifuTextBox1.Text = "";
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
                {
                    pnlMainMenu main = this.Owner as pnlMainMenu;
                    if (main != null)
                    {
                        if (MessageBox.Show("Вы уверены что хотите добавить?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            main.skladTableAdapter.InsertQuery(bunifuTextBox1.Text);
                            main.skladTableAdapter.Fill(main.uchhet_izmDataSet.sklad);
                            main.skladTableAdapter.Adapter.Update(main.uchhet_izmDataSet.sklad);
                            bunifuTextBox1.Text = "";
                        }
                    }
                }
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
