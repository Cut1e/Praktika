using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KimtToo.VisualReactive;

namespace WindowsFormsApplication13
{
    public partial class pnlMainMenu : Form
    {
        public pnlMainMenu()
        {
            InitializeComponent();

        }
        bool mnuExpanded =false;
        private void MouseDetect_Tick(object sender, EventArgs e)
        {
            try
            {
                if (!bunifuTransition1.IsCompleted) return;
                if (panel1.ClientRectangle.Contains(PointToClient(Control.MousePosition)))
                {
                    if (!mnuExpanded)
                    {
                        mnuExpanded = true;
                        panel1.Width = 230;
                    }
                }
                else
                {
                    if (mnuExpanded)
                    {
                        mnuExpanded = false;
                        panel1.Visible = false;
                        panel1.Width = 47;
                        bunifuTransition1.Show(panel1);
                    }
                }
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pnlMainMenu_Load(object sender, EventArgs e)
        {
            try
            {
                this.kalibr_izdTableAdapter.Fill(this.uchhet_izmDataSet.kalibr_izd);
                this.izdTableAdapter.Fill(this.uchhet_izmDataSet.izd);
                this.tip_izdTableAdapter.Fill(this.uchhet_izmDataSet.tip_izd);
                this.skladTableAdapter.Fill(this.uchhet_izmDataSet.sklad);
                subMenu pls = new subMenu();
                panel5.Visible = false;
                panel6.Visible = false;
                panel7.Visible = true;
                Form5 form5 = new Form5();
                form5.Owner = this;
                Form6 form6 = new Form6();
                form6.Owner = this;
                Form7 form7 = new Form7();
                form7.Owner = this;
                label2.Visible = true;
                label3.Visible = false;
                label4.Visible = false;
                dateTimePicker2.Value = DateTime.Now;
                bunifuTextBox3.Text = "1";
                bunifuTextBox3.Text = "";
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void skladBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.skladBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.uchhet_izmDataSet);
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tab1_Click(object sender, EventArgs e)
        {
            try
            {
                VSReactive<int>.SetState("menu", int.Parse(((Control)sender).Tag.ToString()));
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tab2_Click(object sender, EventArgs e)
        {
            try
            {
                panel5.Visible = false;
                panel6.Visible = false;
                panel7.Visible = true;
                label2.Visible = true;
                label3.Visible = false;
                label4.Visible = false;
                VSReactive<int>.SetState("menu", int.Parse(((Control)sender).Tag.ToString()));
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuTextBox1_TextChange(object sender, EventArgs e)
        {
            try
            {
                skladBindingSource.Filter = "[name_sklada] LIKE'" + bunifuTextBox1.Text + "%'";
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                skladBindingSource.Filter = null;
                bunifuTextBox1.Text = "";
                bunifuDataGridView1.Focus();
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pnlMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    e.Cancel = true;
                    if (MessageBox.Show("Вы уверены что хотите закрыть программу?", "Выйти?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                }
            }
            catch(Exception help)
            {
                MessageBox.Show(help.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tab3_Click(object sender, EventArgs e)
        {
            try
            {
                label2.Visible = false;
                label3.Visible = true;
                label4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = true;
                panel7.Visible = false;
                VSReactive<int>.SetState("menu", int.Parse(((Control)sender).Tag.ToString()));
                subMenu pls = new subMenu();
                pls.Owner = this;
                Form4 form4 = new Form4();
                form4.Owner = this;
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tab4_Click(object sender, EventArgs e)
        {
            try
            {
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = true;
                panel5.Visible = true;
                panel6.Visible = false;
                panel7.Visible = false;
                VSReactive<int>.SetState("menu", int.Parse(((Control)sender).Tag.ToString()));
                subMenu pls = new subMenu();
                pls.Owner = this;
                Form3 form3 = new Form3();
                form3.Owner = this;
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuTextBox2_TextChange(object sender, EventArgs e)
        {
            try
            {
                if (bunifuDropdown2.selectedIndex == 1)
                    tip_izdBindingSource.Filter = "[tip_izd] LIKE'" + bunifuTextBox2.Text + "%' or [predel_izm] LIKE'" + bunifuTextBox2.Text + "%'";
                if (bunifuDropdown2.selectedIndex == 0 && bunifuTextBox2.Text != "")
                    tip_izdBindingSource.Filter = "[kod_tipa_izd] = \'" + bunifuTextBox2.Text + "\'";
                if (bunifuTextBox2.Text == "")
                    tip_izdBindingSource.Filter = null;
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            try
            {
                tip_izdBindingSource.Filter = null;
                bunifuTextBox2.Text = "";
                bunifuDataGridView2.Focus();
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }

        private void bunifuDataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void bunifuDataGridView3_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in bunifuDataGridView3.Rows) //цикл
                {
                    int days = (DateTime.Parse(row.Cells[5].Value.ToString()) - DateTime.Now).Days; //дней осталось
                    if (days > 30)
                        row.Cells[9].Style.BackColor = System.Drawing.Color.Green; //красим зеленым
                    else if (days > -1)
                        row.Cells[9].Style.BackColor = System.Drawing.Color.Yellow;
                    else
                        row.Cells[9].Style.BackColor = System.Drawing.Color.Red;
                }
            }
            catch
            {
                return;
            }
                }
            

        

        private void bunifuTextBox3_TextChange(object sender, EventArgs e)
        {
            try
            {
                izdBindingSource.Filter = "[kod_izd] LIKE'" + bunifuTextBox3.Text + "%' or [name_izd] LIKE'" + bunifuTextBox3.Text + "%' or [tip_izd] LIKE'" + bunifuTextBox3.Text + "%' or [predel_izm] LIKE'" + bunifuTextBox3.Text + "%' or [name_sklada] LIKE'" + bunifuTextBox3.Text + "%' or [priznak] LIKE'" + bunifuTextBox3.Text + "%'";
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {
           
        
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            try
            {
                dateTimePicker2.Value = DateTime.Today;
                tip_izdBindingSource.Filter = null;
                bunifuTextBox3.Text = "1";
                bunifuTextBox3.Text = "";
                bunifuDataGridView3.Focus();
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                izdBindingSource.Filter = "[goden_do] =\'" + dateTimePicker2.Text + "\'";
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dateTimePicker2.Value = DateTime.Today;
                bunifuTextBox3.Text = "";
                bunifuDataGridView3.Focus();
                tip_izdBindingSource.Filter = null;
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in bunifuDataGridView3.Rows) //цикл
                {
                    int days = (DateTime.Parse(row.Cells[6].Value.ToString()) - DateTime.Now).Days; //дней осталось
                    if (days > 30)
                        row.Cells[0].Style.BackColor = System.Drawing.Color.Green; //красим зеленым
                    else if (days > -1)
                        row.Cells[0].Style.BackColor = System.Drawing.Color.Yellow;
                    else
                        row.Cells[0].Style.BackColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void tab5_Click(object sender, EventArgs e)
        {
            try
            {
                VSReactive<int>.SetState("menu", int.Parse(((Control)sender).Tag.ToString()));
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tab6_Click(object sender, EventArgs e)
        {
            try
            {
                VSReactive<int>.SetState("menu", int.Parse(((Control)sender).Tag.ToString()));
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                label2.Text = bunifuDataGridView3.RowCount.ToString();
                label3.Text = bunifuDataGridView2.RowCount.ToString();
                label4.Text = bunifuDataGridView1.RowCount.ToString();
            }
            catch (Exception help)
            {
                return;
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void просмотрЗапросовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Form7 form7 = new Form7();
                form7.Owner = this;
                form7.Show();
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
