using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KimtToo.VisualReactive;
using System.Diagnostics;

namespace WindowsFormsApplication13
{
    public partial class subMenu : UserControl
    {
        internal pnlMainMenu Owner;

        public subMenu()
        {
            InitializeComponent();
            if (Program.IsInDesignMode()) return;
            hider.Height= 30;
            VSReactive<int>.Subscribe("menu", e => tabControl1.SelectedIndex = e); 
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            pnlMainMenu main;
            main = (pnlMainMenu)this.FindForm();
            form5.Owner = main;
            form5.ShowDialog();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
           
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void tab1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
                    }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            pnlMainMenu main;
            main = (pnlMainMenu)this.FindForm();
            for (int i = 0; i < main.bunifuDataGridView3.Rows.Count; i++)
            {
                if (MessageBox.Show("Вы уверены что хотите сохранить изменения?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {


                    main.izdTableAdapter.UpdateQuery(Convert.ToString(main.bunifuDataGridView3.Rows[i].Cells[1].Value),
                Convert.ToInt32(main.bunifuDataGridView3.Rows[i].Cells[7].Value),
                Convert.ToInt32(main.bunifuDataGridView3.Rows[i].Cells[8].Value),
                Convert.ToString(main.bunifuDataGridView3.Rows[i].Cells[5].Value),
                Convert.ToString(main.bunifuDataGridView3.Rows[i].Cells[6].Value),
                Convert.ToString(main.bunifuDataGridView3.Rows[i].Cells[0].Value));
                }
            }
        }
            

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            try
            {
                pnlMainMenu main;
                main = (pnlMainMenu)this.FindForm();
                if (MessageBox.Show("Вы уверены что хотите удалить?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    main.izdTableAdapter.DeleteQuery(System.Convert.ToString(main.bunifuDataGridView3.SelectedCells[0].Value));
                    main.izdTableAdapter.Fill(main.uchhet_izmDataSet.izd);
                }
            }
            catch
            {
                MessageBox.Show("Удаление невозможно!\nЕсть связующая запись в таблице <Ремонт>", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            pnlMainMenu main;
            main = (pnlMainMenu)this.FindForm();
            main.tableAdapterManager.UpdateAll(main.uchhet_izmDataSet);
            main.izdTableAdapter.Fill(main.uchhet_izmDataSet.izd);
            MessageBox.Show("Обновлено", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void hider_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton28_Click(object sender, EventArgs e)
        {

                }

        private void bunifuFlatButton13_Click(object sender, EventArgs e)
        {
            try
            {
            pnlMainMenu main;
             main = (pnlMainMenu)this.FindForm();
                if (MessageBox.Show("Вы уверены что хотите удалить?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    main.skladTableAdapter.DeleteQuery(System.Convert.ToInt32(main.bunifuDataGridView1.SelectedCells[0].Value));
                    main.skladTableAdapter.Fill(main.uchhet_izmDataSet.sklad);
                }
            }
            catch 
            {
                MessageBox.Show("Удаление невозможно!\nЕсть связующая запись в таблице <Учёт средства>", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton15_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            pnlMainMenu main;
            main = (pnlMainMenu)this.FindForm();
            form3.Owner = main;
            form3.ShowDialog();
        }

        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите сохранить изменения?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                pnlMainMenu main;
                main = (pnlMainMenu)this.FindForm();
                main.skladTableAdapter.Adapter.Update(main.uchhet_izmDataSet.sklad);
            }

        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы уверены что хотите очистить таблицу?\nВсе данные будут утеряны", "ВНИМАНИЕ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    pnlMainMenu main;
                    main = (pnlMainMenu)this.FindForm();
                    main.skladTableAdapter.DeleteQuery1();
                    main.skladTableAdapter.Fill(main.uchhet_izmDataSet.sklad);
                }
            }
            catch(Exception help)
            {
                MessageBox.Show(help.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton12_Click(object sender, EventArgs e)
        {
            pnlMainMenu main;
            main = (pnlMainMenu)this.FindForm();
            main.skladTableAdapter.Adapter.Update(main.uchhet_izmDataSet.sklad);
            main.skladTableAdapter.Fill(main.uchhet_izmDataSet.sklad);
            MessageBox.Show("Обновлено", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void bunifuFlatButton11_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            pnlMainMenu main;
            main = (pnlMainMenu)this.FindForm();
            form4.Owner = main;
            form4.ShowDialog();
        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите сохранить изменения?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                pnlMainMenu main;
                main = (pnlMainMenu)this.FindForm();
                main.tip_izdTableAdapter.Adapter.Update(main.uchhet_izmDataSet.tip_izd);
            }
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            try
            {
                pnlMainMenu main;
                main = (pnlMainMenu)this.FindForm();
                if (MessageBox.Show("Вы уверены что хотите удалить?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    main.tip_izdTableAdapter.DeleteQuery(System.Convert.ToInt32(main.bunifuDataGridView2.SelectedCells[0].Value));
                    main.tip_izdTableAdapter.Fill(main.uchhet_izmDataSet.tip_izd);
                }
            }
            catch
            {
                MessageBox.Show("Удаление невозможно!\nЕсть связующая запись в таблице <Учёт средства>", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            pnlMainMenu main;
            main = (pnlMainMenu)this.FindForm();
            main.tip_izdTableAdapter.Adapter.Update(main.uchhet_izmDataSet.tip_izd);
            main.tip_izdTableAdapter.Fill(main.uchhet_izmDataSet.tip_izd);
            MessageBox.Show("Обновлено", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bunifuFlatButton1_Click_2(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            pnlMainMenu main;
            main = (pnlMainMenu)this.FindForm();
            form6.Owner = main;
            form6.ShowDialog();
        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            pnlMainMenu main;
            main = (pnlMainMenu)this.FindForm();
            main.bunifuDataGridView3.Focus();
            if (MessageBox.Show("Вы уверены что хотите сохранить изменения?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                for (int i = 0; i < main.bunifuDataGridView4.Rows.Count; i++)
                {
                    main.kalibr_izdTableAdapter.UpdateQuery(Convert.ToString(main.bunifuDataGridView4.Rows[i].Cells[1].Value),
                    Convert.ToString(main.bunifuDataGridView4.Rows[i].Cells[2].Value),
                    Convert.ToString(main.bunifuDataGridView4.Rows[i].Cells[3].Value),
                    Convert.ToString(main.bunifuDataGridView4.Rows[i].Cells[4].Value),
                    Convert.ToInt32(main.bunifuDataGridView4.Rows[i].Cells[0].Value));
                }
            }
        }

        private void bunifuFlatButton3_Click_1(object sender, EventArgs e)
        {
            try
            {
                pnlMainMenu main;
                main = (pnlMainMenu)this.FindForm();
                if (MessageBox.Show("Вы уверены что хотите удалить?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    main.kalibr_izdTableAdapter.DeleteQuery(System.Convert.ToInt32(main.bunifuDataGridView4.SelectedCells[0].Value));
                    main.kalibr_izdTableAdapter.Fill(main.uchhet_izmDataSet.kalibr_izd);
                }
            }
            catch
            {
                MessageBox.Show("Удаление невозможно!\nЕсть связующая запись в таблице <Учёт средства>", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton20_Click(object sender, EventArgs e)
        {
            pnlMainMenu main;
            main = (pnlMainMenu)this.FindForm();
            main.tableAdapterManager.UpdateAll(main.uchhet_izmDataSet);
            main.kalibr_izdTableAdapter.Fill(main.uchhet_izmDataSet.kalibr_izd);
            MessageBox.Show("Обновлено", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bunifuFlatButton23_Click(object sender, EventArgs e)
        {
            try
            {
                Process SysInfo = new Process();
                SysInfo.StartInfo.ErrorDialog = true;
                SysInfo.StartInfo.FileName = "NewProject.chm";
                SysInfo.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
       
        }

        private void bunifuFlatButton18_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton19_Click(object sender, EventArgs e)
        {

        }
    }
    
}
