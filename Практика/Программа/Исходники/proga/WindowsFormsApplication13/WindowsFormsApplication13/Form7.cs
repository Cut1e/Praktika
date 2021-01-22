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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void большеЗаданнойДатыСНазваниемИнстрементаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Visible = false; panel9.Visible = false;
                panel2.Visible = false; panel10.Visible = false;
                panel3.Visible = false; panel11.Visible = false;
                panel4.Visible = true; panel12.Visible = false;
                panel5.Visible = false; panel13.Visible = false;
                panel6.Visible = false; panel14.Visible = false;
                panel7.Visible = false; panel15.Visible = false;
                panel8.Visible = false;
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void меньшеЗаданнойДатыСНазваниемToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Visible = false; panel9.Visible = false;
                panel2.Visible = false; panel10.Visible = false;
                panel3.Visible = true; panel11.Visible = false;
                panel4.Visible = false; panel12.Visible = false;
                panel5.Visible = false; panel13.Visible = false;
                panel6.Visible = false; panel14.Visible = false;
                panel7.Visible = false; panel15.Visible = false;
                panel8.Visible = false;
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void большеЗаданнойДатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Visible = false; panel9.Visible = false;
                panel2.Visible = true; panel10.Visible = false;
                panel3.Visible = false; panel11.Visible = false;
                panel4.Visible = false; panel12.Visible = false;
                panel5.Visible = false; panel13.Visible = false;
                panel6.Visible = false; panel14.Visible = false;
                panel7.Visible = false; panel15.Visible = false;
                panel8.Visible = false;
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void меньшеЗаданнойДатыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Visible = true; panel9.Visible = false;
                panel2.Visible = false; panel10.Visible = false;
                panel3.Visible = false; panel11.Visible = false;
                panel4.Visible = false; panel12.Visible = false;
                panel5.Visible = false; panel13.Visible = false;
                panel6.Visible = false; panel14.Visible = false;
                panel7.Visible = false; panel15.Visible = false;
                panel8.Visible = false;
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
                    main.izdTableAdapter.FillBy(main.uchhet_izmDataSet.izd, Convert.ToString(bunifuDatepicker1.Value.ToShortDateString()));
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton23_Load(object sender, EventArgs e)
        {
            
        }

        private void сброситьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                pnlMainMenu main = this.Owner as pnlMainMenu;
                if (main != null)
                    main.izdTableAdapter.Fill(main.uchhet_izmDataSet.izd);
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void равноЗаданнойДатыСНазванемСкщадаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Visible = false; panel9.Visible = false;
                panel2.Visible = false; panel10.Visible = true;
                panel3.Visible = false; panel11.Visible = false;
                panel4.Visible = false; panel12.Visible = false;
                panel5.Visible = false; panel13.Visible = false;
                panel6.Visible = false; panel14.Visible = false;
                panel7.Visible = false; panel15.Visible = false;
                panel8.Visible = false;
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                pnlMainMenu main = this.Owner as pnlMainMenu;
                if (main != null)
                    main.izdTableAdapter.FillBy1(main.uchhet_izmDataSet.izd, Convert.ToString(bunifuDatepicker2.Value.ToShortDateString()));
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                pnlMainMenu main = this.Owner as pnlMainMenu;
                if (main != null)
                    main.izdTableAdapter.FillBy1(main.uchhet_izmDataSet.izd, Convert.ToString(bunifuDatepicker2.Value.ToShortDateString()));
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            try
            {
                this.skladTableAdapter.Fill(this.uchhet_izmDataSet1.sklad);
                this.izdTableAdapter.Fill(this.uchhet_izmDataSet.izd);
                bunifuDatepicker1.Value = DateTime.Now;
                bunifuDatepicker2.Value = DateTime.Now;
                bunifuDatepicker3.Value = DateTime.Now;
                bunifuDatepicker4.Value = DateTime.Now;
                bunifuDatepicker5.Value = DateTime.Now;
                bunifuDatepicker6.Value = DateTime.Now;
                bunifuDatepicker7.Value = DateTime.Now;
                bunifuDatepicker8.Value = DateTime.Now;
                bunifuDatepicker9.Value = DateTime.Now;
                bunifuDatepicker10.Value = DateTime.Now;
                bunifuDatepicker11.Value = DateTime.Now;
                bunifuDatepicker12.Value = DateTime.Now;
                bunifuDatepicker13.Value = DateTime.Now;
                bunifuDatepicker14.Value = DateTime.Now;
                bunifuDatepicker15.Value = DateTime.Now;
                panel1.Visible = false; panel9.Visible = false;
                panel2.Visible = false; panel10.Visible = false;
                panel3.Visible = false; panel11.Visible = false;
                panel4.Visible = false; panel12.Visible = false;
                panel5.Visible = false; panel13.Visible = false;
                panel6.Visible = false; panel14.Visible = false;
                panel7.Visible = false; panel15.Visible = false;
                panel8.Visible = false;
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            try
            {
                pnlMainMenu main = this.Owner as pnlMainMenu;
                if (main != null)
                    main.izdTableAdapter.FillBy2(main.uchhet_izmDataSet.izd, Convert.ToString(bunifuDatepicker3.Value.ToShortDateString()), bunifuTextBox3.Text);
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            try
            {
                pnlMainMenu main = this.Owner as pnlMainMenu;
                if (main != null)
                    main.izdTableAdapter.FillBy3(main.uchhet_izmDataSet.izd, Convert.ToString(bunifuDatepicker4.Value.ToShortDateString()), bunifuTextBox1.Text);
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)comboBox1.SelectedValue;
                pnlMainMenu main = this.Owner as pnlMainMenu;
                if (main != null)
                    main.izdTableAdapter.FillBy4(main.uchhet_izmDataSet.izd, Convert.ToString(bunifuDatepicker5.Value.ToShortDateString()), id);
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)comboBox2.SelectedValue;
                pnlMainMenu main = this.Owner as pnlMainMenu;
                if (main != null)
                    main.izdTableAdapter.FillBy5(main.uchhet_izmDataSet.izd, Convert.ToString(bunifuDatepicker6.Value.ToShortDateString()), id);
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)comboBox3.SelectedValue;
                pnlMainMenu main = this.Owner as pnlMainMenu;
                if (main != null)
                    main.izdTableAdapter.FillBy6(main.uchhet_izmDataSet.izd, Convert.ToString(bunifuDatepicker7.Value.ToShortDateString()), bunifuTextBox2.Text, id);
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)comboBox4.SelectedValue;
                pnlMainMenu main = this.Owner as pnlMainMenu;
                if (main != null)
                    main.izdTableAdapter.FillBy7(main.uchhet_izmDataSet.izd, Convert.ToString(bunifuDatepicker8.Value.ToShortDateString()), bunifuTextBox4.Text, id);
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)comboBox5.SelectedValue;
                pnlMainMenu main = this.Owner as pnlMainMenu;
                if (main != null)
                    main.izdTableAdapter.FillBy8(main.uchhet_izmDataSet.izd, Convert.ToString(bunifuDatepicker10.Value.ToShortDateString()), id);
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            try
            {
                pnlMainMenu main = this.Owner as pnlMainMenu;
                if (main != null)
                    main.izdTableAdapter.FillBy9(main.uchhet_izmDataSet.izd, Convert.ToString(bunifuDatepicker9.Value.ToShortDateString()), bunifuTextBox5.Text);
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            try
            {
                pnlMainMenu main = this.Owner as pnlMainMenu;
                if (main != null)
                    main.izdTableAdapter.FillBy10(main.uchhet_izmDataSet.izd, Convert.ToString(bunifuDatepicker11.Value.ToShortDateString()), Convert.ToString(bunifuDatepicker12.Value.ToShortDateString()));
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton11_Click(object sender, EventArgs e)
        {
            try
            {
                pnlMainMenu main = this.Owner as pnlMainMenu;
                if (main != null)
                    main.izdTableAdapter.FillBy11(main.uchhet_izmDataSet.izd, bunifuTextBox6.Text, Convert.ToString(bunifuDatepicker14.Value.ToShortDateString()), Convert.ToString(bunifuDatepicker13.Value.ToShortDateString()));
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton12_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)comboBox6.SelectedValue;
                pnlMainMenu main = this.Owner as pnlMainMenu;
                if (main != null)
                    main.izdTableAdapter.FillBy12(main.uchhet_izmDataSet.izd, Convert.ToString(bunifuDatepicker16.Value.ToShortDateString()), Convert.ToString(bunifuDatepicker15.Value.ToShortDateString()), id);
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton13_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)comboBox7.SelectedValue;
                pnlMainMenu main = this.Owner as pnlMainMenu;
                if (main != null)
                    main.izdTableAdapter.FillBy13(main.uchhet_izmDataSet.izd, Convert.ToString(bunifuDatepicker17.Value.ToShortDateString()), bunifuTextBox7.Text, id);
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)comboBox8.SelectedValue;
                pnlMainMenu main = this.Owner as pnlMainMenu;
                if (main != null)
                    main.izdTableAdapter.FillBy14(main.uchhet_izmDataSet.izd, bunifuTextBox8.Text, id);
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void меньшеЗаданнойДатыСНазваниемСкладаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Visible = false; panel9.Visible = false;
                panel2.Visible = false; panel10.Visible = false;
                panel3.Visible = false; panel11.Visible = false;
                panel4.Visible = false; panel12.Visible = false;
                panel5.Visible = true; panel13.Visible = false;
                panel6.Visible = false; panel14.Visible = false;
                panel7.Visible = false; panel15.Visible = false;
                panel8.Visible = false;
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void большеЗаданнойДатыСНазваниемСкладаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Visible = false; panel9.Visible = false;
                panel2.Visible = false; panel10.Visible = false;
                panel3.Visible = false; panel11.Visible = false;
                panel4.Visible = false; panel12.Visible = false;
                panel5.Visible = false; panel13.Visible = false;
                panel6.Visible = true; panel14.Visible = false;
                panel7.Visible = false; panel15.Visible = false;
                panel8.Visible = false;
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void меньшеЗаданнойДатыСНазваниемСкаладаИИнстрементаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Visible = false; panel9.Visible = false;
                panel2.Visible = false; panel10.Visible = false;
                panel3.Visible = false; panel11.Visible = false;
                panel4.Visible = false; panel12.Visible = false;
                panel5.Visible = false; panel13.Visible = false;
                panel6.Visible = false; panel14.Visible = false;
                panel7.Visible = true; panel15.Visible = false;
                panel8.Visible = false;
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void большеЗаданнойДатыСНазваниемСкладаИИнструментаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Visible = false; panel9.Visible = false;
                panel2.Visible = false; panel10.Visible = false;
                panel3.Visible = false; panel11.Visible = false;
                panel4.Visible = false; panel12.Visible = false;
                panel5.Visible = false; panel13.Visible = false;
                panel6.Visible = false; panel14.Visible = false;
                panel7.Visible = false; panel15.Visible = false;
                panel8.Visible = true;
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void равноЗаданнойДатыСНазваниемИнстрементаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Visible = false; panel9.Visible = true;
                panel2.Visible = false; panel10.Visible = false;
                panel3.Visible = false; panel11.Visible = false;
                panel4.Visible = false; panel12.Visible = false;
                panel5.Visible = false; panel13.Visible = false;
                panel6.Visible = false; panel14.Visible = false;
                panel7.Visible = false; panel15.Visible = false;
                panel8.Visible = false;
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void срокГодностиИНазваниеИнстремнтаНаСкаледToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Visible = false; panel9.Visible = false;
                panel2.Visible = false; panel10.Visible = false;
                panel3.Visible = false; panel11.Visible = false;
                panel4.Visible = false; panel12.Visible = false;
                panel5.Visible = false; panel13.Visible = false;
                panel6.Visible = false; panel14.Visible = true;
                panel7.Visible = false; panel15.Visible = false;
                panel8.Visible = false;
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void срокГодностиВВыбранныхДатахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Visible = false; panel9.Visible = false;
                panel2.Visible = false; panel10.Visible = false;
                panel3.Visible = false; panel11.Visible = true;
                panel4.Visible = false; panel12.Visible = false;
                panel5.Visible = false; panel13.Visible = false;
                panel6.Visible = false; panel14.Visible = false;
                panel7.Visible = false; panel15.Visible = false;
                panel8.Visible = false;
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void срокГодностиВВыбранныхДатахСНазваниемИнстрементаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Visible = false; panel9.Visible = false;
                panel2.Visible = false; panel10.Visible = false;
                panel3.Visible = false; panel11.Visible = false;
                panel4.Visible = false; panel12.Visible = true;
                panel5.Visible = false; panel13.Visible = false;
                panel6.Visible = false; panel14.Visible = false;
                panel7.Visible = false; panel15.Visible = false;
                panel8.Visible = false;
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void срокГодностиВВыбранныхДатахСНазваниемСкладаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Visible = false; panel9.Visible = false;
                panel2.Visible = false; panel10.Visible = false;
                panel3.Visible = false; panel11.Visible = false;
                panel4.Visible = false; panel12.Visible = false;
                panel5.Visible = false; panel13.Visible = true;
                panel6.Visible = false; panel14.Visible = false;
                panel7.Visible = false; panel15.Visible = false;
                panel8.Visible = false;
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void названиеНаСкладеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Visible = false; panel9.Visible = false;
                panel2.Visible = false; panel10.Visible = false;
                panel3.Visible = false; panel11.Visible = false;
                panel4.Visible = false; panel12.Visible = false;
                panel5.Visible = false; panel13.Visible = false;
                panel6.Visible = false; panel14.Visible = false;
                panel7.Visible = false; panel15.Visible = true;
                panel8.Visible = false;
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
