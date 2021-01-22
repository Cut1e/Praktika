using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication13
{
    public partial class Form1 : Form
    {
        string writePath = @"put.dat";     
        public Form1()
        {
            InitializeComponent();
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }     

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                pnlMainMenu form2 = new pnlMainMenu();
                form2.Show();
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(writePath))
                {
                    using (StreamReader sr = new StreamReader(writePath))
                    {
                        comboBox1.Text = sr.ReadLine();
                        string connectionString = string.Format("Data Source={0};Initial Catalog={1};Integrated Security=True;", comboBox1.Text, textBox2.Text);
                        Class1 class1 = new Class1(connectionString);
                        if (class1.isConnection)
                        {
                            pnlMainMenu form2 = new pnlMainMenu();
                            this.Hide();
                            form2.ShowDialog();
                        }
                        else
                            this.Show();
                    }
                }
                else
                {
                    comboBox1.Items.Add(string.Format(@"{0}\SQLEXPRESPLS", Environment.MachineName));
                }
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string connectionString = string.Format("Data Source={0};Initial Catalog={1};Integrated Security=True;", comboBox1.Text, textBox2.Text);           
                File.Delete(writePath);
                try
                {
                    Class1 class1 = new Class1(connectionString);
                    if (class1.isConnection)
                    {
                        Class2 setting = new Class2();
                        setting.SaceConectionString("WindowsFormsApplication13.Properties.Settings.uchhet_izmConnectionString", connectionString);
                        MessageBox.Show("Для изменения настроек перезайдите в программу", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    using (StreamWriter sw = File.AppendText(writePath))
                    {

                        sw.WriteLine(comboBox1.Text);                    
                }
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton23_Click(object sender, EventArgs e)
        {
            string connectionString = string.Format("Data Source={0};Initial Catalog={1};Integrated Security=True;", comboBox1.Text, textBox2.Text);
            try
            {
                Class1 class1 = new Class1(connectionString);
                if (class1.isConnection)
                    MessageBox.Show("Соединение успешно установлено", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
