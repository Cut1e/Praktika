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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton23_Click(object sender, EventArgs e)
        {
            try
            {
                string data = String.Format(bunifuDatepicker1.Value.ToShortDateString());
                string data2 = String.Format(bunifuDatepicker2.Value.ToShortDateString());
                pnlMainMenu main = this.Owner as pnlMainMenu;
                if (main != null)
                {
                    if (MessageBox.Show("Вы уверены что хотите добавить?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        main.kalibr_izdTableAdapter.InsertQuery(data, data2, bunifuTextBox3.Text, Convert.ToString(main.bunifuDataGridView3.Rows[main.bunifuDataGridView3.CurrentCell.RowIndex].Cells[0].Value));
                        main.kalibr_izdTableAdapter.Fill(main.uchhet_izmDataSet.kalibr_izd);
                        main.kalibr_izdTableAdapter.Adapter.Update(main.uchhet_izmDataSet.kalibr_izd);
                        bunifuTextBox3.Text = "";
                    }
                }
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton23_Load(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            try
            {
                bunifuDatepicker1.Value = DateTime.Now;
                bunifuDatepicker1.Value = DateTime.Now;
            }
            catch
            {
                return;
            }
        }
    }
}
