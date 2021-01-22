namespace WindowsFormsApplication13
{
    partial class subMenu
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.hider = new System.Windows.Forms.Panel();
            this.uchhet_izmDataSet = new WindowsFormsApplication13.uchhet_izmDataSet();
            this.izdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.izdTableAdapter = new WindowsFormsApplication13.uchhet_izmDataSetTableAdapters.izdTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication13.uchhet_izmDataSetTableAdapters.TableAdapterManager();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.bunifuFlatButton23 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.bunifuFlatButton15 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton14 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton13 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton12 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.bunifuFlatButton11 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton10 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton9 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton8 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton7 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton20 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.uchhet_izmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.izdBindingSource)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hider
            // 
            this.hider.BackColor = System.Drawing.Color.WhiteSmoke;
            this.hider.Location = new System.Drawing.Point(0, 0);
            this.hider.Name = "hider";
            this.hider.Size = new System.Drawing.Size(238, 10);
            this.hider.TabIndex = 1;
            this.hider.Paint += new System.Windows.Forms.PaintEventHandler(this.hider_Paint);
            // 
            // uchhet_izmDataSet
            // 
            this.uchhet_izmDataSet.DataSetName = "uchhet_izmDataSet";
            this.uchhet_izmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // izdBindingSource
            // 
            this.izdBindingSource.DataMember = "izd";
            this.izdBindingSource.DataSource = this.uchhet_izmDataSet;
            // 
            // izdTableAdapter
            // 
            this.izdTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.kalibr_izdTableAdapter = null;
            this.tableAdapterManager.skladTableAdapter = null;
            this.tableAdapterManager.tip_izdTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication13.uchhet_izmDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage6.Controls.Add(this.label5);
            this.tabPage6.Controls.Add(this.bunifuFlatButton23);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(257, 555);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "5";
            this.tabPage6.Click += new System.EventHandler(this.tabPage6_Click);
            // 
            // bunifuFlatButton23
            // 
            this.bunifuFlatButton23.Active = false;
            this.bunifuFlatButton23.Activecolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton23.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton23.BorderRadius = 0;
            this.bunifuFlatButton23.ButtonText = "Справка";
            this.bunifuFlatButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton23.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton23.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton23.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton23.Iconimage = global::WindowsFormsApplication13.Properties.Resources.menu_96px;
            this.bunifuFlatButton23.Iconimage_right = null;
            this.bunifuFlatButton23.Iconimage_right_Selected = null;
            this.bunifuFlatButton23.Iconimage_Selected = null;
            this.bunifuFlatButton23.IconMarginLeft = 0;
            this.bunifuFlatButton23.IconMarginRight = 0;
            this.bunifuFlatButton23.IconRightVisible = false;
            this.bunifuFlatButton23.IconRightZoom = 0D;
            this.bunifuFlatButton23.IconVisible = false;
            this.bunifuFlatButton23.IconZoom = 65D;
            this.bunifuFlatButton23.IsTab = true;
            this.bunifuFlatButton23.Location = new System.Drawing.Point(3, 3);
            this.bunifuFlatButton23.Name = "bunifuFlatButton23";
            this.bunifuFlatButton23.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton23.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton23.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton23.selected = false;
            this.bunifuFlatButton23.Size = new System.Drawing.Size(251, 43);
            this.bunifuFlatButton23.TabIndex = 6;
            this.bunifuFlatButton23.Tag = "0";
            this.bunifuFlatButton23.Text = "Справка";
            this.bunifuFlatButton23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton23.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton23.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton23.Click += new System.EventHandler(this.bunifuFlatButton23_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.label5.Location = new System.Drawing.Point(60, 523);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "О программе";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.bunifuFlatButton12);
            this.tabPage4.Controls.Add(this.bunifuFlatButton13);
            this.tabPage4.Controls.Add(this.bunifuFlatButton14);
            this.tabPage4.Controls.Add(this.bunifuFlatButton15);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(257, 555);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "3";
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // bunifuFlatButton15
            // 
            this.bunifuFlatButton15.Active = false;
            this.bunifuFlatButton15.Activecolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton15.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton15.BorderRadius = 0;
            this.bunifuFlatButton15.ButtonText = "Добавить";
            this.bunifuFlatButton15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton15.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton15.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton15.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton15.Iconimage = global::WindowsFormsApplication13.Properties.Resources.menu_96px;
            this.bunifuFlatButton15.Iconimage_right = null;
            this.bunifuFlatButton15.Iconimage_right_Selected = null;
            this.bunifuFlatButton15.Iconimage_Selected = null;
            this.bunifuFlatButton15.IconMarginLeft = 0;
            this.bunifuFlatButton15.IconMarginRight = 0;
            this.bunifuFlatButton15.IconRightVisible = false;
            this.bunifuFlatButton15.IconRightZoom = 0D;
            this.bunifuFlatButton15.IconVisible = false;
            this.bunifuFlatButton15.IconZoom = 65D;
            this.bunifuFlatButton15.IsTab = true;
            this.bunifuFlatButton15.Location = new System.Drawing.Point(3, 3);
            this.bunifuFlatButton15.Name = "bunifuFlatButton15";
            this.bunifuFlatButton15.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton15.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton15.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton15.selected = false;
            this.bunifuFlatButton15.Size = new System.Drawing.Size(251, 43);
            this.bunifuFlatButton15.TabIndex = 6;
            this.bunifuFlatButton15.Tag = "0";
            this.bunifuFlatButton15.Text = "Добавить";
            this.bunifuFlatButton15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton15.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton15.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton15.Click += new System.EventHandler(this.bunifuFlatButton15_Click);
            // 
            // bunifuFlatButton14
            // 
            this.bunifuFlatButton14.Active = false;
            this.bunifuFlatButton14.Activecolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton14.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton14.BorderRadius = 0;
            this.bunifuFlatButton14.ButtonText = "Сохранить изменения";
            this.bunifuFlatButton14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton14.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton14.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton14.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton14.Iconimage = global::WindowsFormsApplication13.Properties.Resources.menu_96px;
            this.bunifuFlatButton14.Iconimage_right = null;
            this.bunifuFlatButton14.Iconimage_right_Selected = null;
            this.bunifuFlatButton14.Iconimage_Selected = null;
            this.bunifuFlatButton14.IconMarginLeft = 0;
            this.bunifuFlatButton14.IconMarginRight = 0;
            this.bunifuFlatButton14.IconRightVisible = false;
            this.bunifuFlatButton14.IconRightZoom = 0D;
            this.bunifuFlatButton14.IconVisible = false;
            this.bunifuFlatButton14.IconZoom = 65D;
            this.bunifuFlatButton14.IsTab = true;
            this.bunifuFlatButton14.Location = new System.Drawing.Point(3, 46);
            this.bunifuFlatButton14.Name = "bunifuFlatButton14";
            this.bunifuFlatButton14.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton14.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton14.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton14.selected = false;
            this.bunifuFlatButton14.Size = new System.Drawing.Size(251, 43);
            this.bunifuFlatButton14.TabIndex = 7;
            this.bunifuFlatButton14.Tag = "0";
            this.bunifuFlatButton14.Text = "Сохранить изменения";
            this.bunifuFlatButton14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton14.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton14.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton14.Click += new System.EventHandler(this.bunifuFlatButton14_Click);
            // 
            // bunifuFlatButton13
            // 
            this.bunifuFlatButton13.Active = false;
            this.bunifuFlatButton13.Activecolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton13.BorderRadius = 0;
            this.bunifuFlatButton13.ButtonText = "Удалить";
            this.bunifuFlatButton13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton13.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton13.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton13.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton13.Iconimage = global::WindowsFormsApplication13.Properties.Resources.menu_96px;
            this.bunifuFlatButton13.Iconimage_right = null;
            this.bunifuFlatButton13.Iconimage_right_Selected = null;
            this.bunifuFlatButton13.Iconimage_Selected = null;
            this.bunifuFlatButton13.IconMarginLeft = 0;
            this.bunifuFlatButton13.IconMarginRight = 0;
            this.bunifuFlatButton13.IconRightVisible = false;
            this.bunifuFlatButton13.IconRightZoom = 0D;
            this.bunifuFlatButton13.IconVisible = false;
            this.bunifuFlatButton13.IconZoom = 65D;
            this.bunifuFlatButton13.IsTab = true;
            this.bunifuFlatButton13.Location = new System.Drawing.Point(3, 89);
            this.bunifuFlatButton13.Name = "bunifuFlatButton13";
            this.bunifuFlatButton13.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton13.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton13.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton13.selected = false;
            this.bunifuFlatButton13.Size = new System.Drawing.Size(251, 43);
            this.bunifuFlatButton13.TabIndex = 8;
            this.bunifuFlatButton13.Tag = "0";
            this.bunifuFlatButton13.Text = "Удалить";
            this.bunifuFlatButton13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton13.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton13.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton13.Click += new System.EventHandler(this.bunifuFlatButton13_Click);
            // 
            // bunifuFlatButton12
            // 
            this.bunifuFlatButton12.Active = false;
            this.bunifuFlatButton12.Activecolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton12.BorderRadius = 0;
            this.bunifuFlatButton12.ButtonText = "Обновить";
            this.bunifuFlatButton12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton12.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton12.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton12.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton12.Iconimage = global::WindowsFormsApplication13.Properties.Resources.menu_96px;
            this.bunifuFlatButton12.Iconimage_right = null;
            this.bunifuFlatButton12.Iconimage_right_Selected = null;
            this.bunifuFlatButton12.Iconimage_Selected = null;
            this.bunifuFlatButton12.IconMarginLeft = 0;
            this.bunifuFlatButton12.IconMarginRight = 0;
            this.bunifuFlatButton12.IconRightVisible = false;
            this.bunifuFlatButton12.IconRightZoom = 0D;
            this.bunifuFlatButton12.IconVisible = false;
            this.bunifuFlatButton12.IconZoom = 65D;
            this.bunifuFlatButton12.IsTab = true;
            this.bunifuFlatButton12.Location = new System.Drawing.Point(3, 132);
            this.bunifuFlatButton12.Name = "bunifuFlatButton12";
            this.bunifuFlatButton12.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton12.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton12.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton12.selected = false;
            this.bunifuFlatButton12.Size = new System.Drawing.Size(251, 43);
            this.bunifuFlatButton12.TabIndex = 9;
            this.bunifuFlatButton12.Tag = "0";
            this.bunifuFlatButton12.Text = "Обновить";
            this.bunifuFlatButton12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton12.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton12.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton12.Click += new System.EventHandler(this.bunifuFlatButton12_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.label3.Location = new System.Drawing.Point(87, 524);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Склад";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.bunifuFlatButton8);
            this.tabPage3.Controls.Add(this.bunifuFlatButton9);
            this.tabPage3.Controls.Add(this.bunifuFlatButton10);
            this.tabPage3.Controls.Add(this.bunifuFlatButton11);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(257, 555);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "2";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // bunifuFlatButton11
            // 
            this.bunifuFlatButton11.Active = false;
            this.bunifuFlatButton11.Activecolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton11.BorderRadius = 0;
            this.bunifuFlatButton11.ButtonText = "Добавить";
            this.bunifuFlatButton11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton11.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton11.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton11.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton11.Iconimage = global::WindowsFormsApplication13.Properties.Resources.menu_96px;
            this.bunifuFlatButton11.Iconimage_right = null;
            this.bunifuFlatButton11.Iconimage_right_Selected = null;
            this.bunifuFlatButton11.Iconimage_Selected = null;
            this.bunifuFlatButton11.IconMarginLeft = 0;
            this.bunifuFlatButton11.IconMarginRight = 0;
            this.bunifuFlatButton11.IconRightVisible = false;
            this.bunifuFlatButton11.IconRightZoom = 0D;
            this.bunifuFlatButton11.IconVisible = false;
            this.bunifuFlatButton11.IconZoom = 65D;
            this.bunifuFlatButton11.IsTab = true;
            this.bunifuFlatButton11.Location = new System.Drawing.Point(3, 3);
            this.bunifuFlatButton11.Name = "bunifuFlatButton11";
            this.bunifuFlatButton11.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton11.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton11.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton11.selected = false;
            this.bunifuFlatButton11.Size = new System.Drawing.Size(251, 43);
            this.bunifuFlatButton11.TabIndex = 6;
            this.bunifuFlatButton11.Tag = "0";
            this.bunifuFlatButton11.Text = "Добавить";
            this.bunifuFlatButton11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton11.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton11.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton11.Click += new System.EventHandler(this.bunifuFlatButton11_Click);
            // 
            // bunifuFlatButton10
            // 
            this.bunifuFlatButton10.Active = false;
            this.bunifuFlatButton10.Activecolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton10.BorderRadius = 0;
            this.bunifuFlatButton10.ButtonText = "Сохранить изменения";
            this.bunifuFlatButton10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton10.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton10.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton10.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton10.Iconimage = global::WindowsFormsApplication13.Properties.Resources.menu_96px;
            this.bunifuFlatButton10.Iconimage_right = null;
            this.bunifuFlatButton10.Iconimage_right_Selected = null;
            this.bunifuFlatButton10.Iconimage_Selected = null;
            this.bunifuFlatButton10.IconMarginLeft = 0;
            this.bunifuFlatButton10.IconMarginRight = 0;
            this.bunifuFlatButton10.IconRightVisible = false;
            this.bunifuFlatButton10.IconRightZoom = 0D;
            this.bunifuFlatButton10.IconVisible = false;
            this.bunifuFlatButton10.IconZoom = 65D;
            this.bunifuFlatButton10.IsTab = true;
            this.bunifuFlatButton10.Location = new System.Drawing.Point(3, 46);
            this.bunifuFlatButton10.Name = "bunifuFlatButton10";
            this.bunifuFlatButton10.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton10.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton10.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton10.selected = false;
            this.bunifuFlatButton10.Size = new System.Drawing.Size(251, 43);
            this.bunifuFlatButton10.TabIndex = 7;
            this.bunifuFlatButton10.Tag = "0";
            this.bunifuFlatButton10.Text = "Сохранить изменения";
            this.bunifuFlatButton10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton10.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton10.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton10.Click += new System.EventHandler(this.bunifuFlatButton10_Click);
            // 
            // bunifuFlatButton9
            // 
            this.bunifuFlatButton9.Active = false;
            this.bunifuFlatButton9.Activecolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton9.BorderRadius = 0;
            this.bunifuFlatButton9.ButtonText = "Удалить";
            this.bunifuFlatButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton9.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton9.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton9.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton9.Iconimage = global::WindowsFormsApplication13.Properties.Resources.menu_96px;
            this.bunifuFlatButton9.Iconimage_right = null;
            this.bunifuFlatButton9.Iconimage_right_Selected = null;
            this.bunifuFlatButton9.Iconimage_Selected = null;
            this.bunifuFlatButton9.IconMarginLeft = 0;
            this.bunifuFlatButton9.IconMarginRight = 0;
            this.bunifuFlatButton9.IconRightVisible = false;
            this.bunifuFlatButton9.IconRightZoom = 0D;
            this.bunifuFlatButton9.IconVisible = false;
            this.bunifuFlatButton9.IconZoom = 65D;
            this.bunifuFlatButton9.IsTab = true;
            this.bunifuFlatButton9.Location = new System.Drawing.Point(3, 89);
            this.bunifuFlatButton9.Name = "bunifuFlatButton9";
            this.bunifuFlatButton9.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton9.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton9.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton9.selected = false;
            this.bunifuFlatButton9.Size = new System.Drawing.Size(251, 43);
            this.bunifuFlatButton9.TabIndex = 8;
            this.bunifuFlatButton9.Tag = "0";
            this.bunifuFlatButton9.Text = "Удалить";
            this.bunifuFlatButton9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton9.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton9.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton9.Click += new System.EventHandler(this.bunifuFlatButton9_Click);
            // 
            // bunifuFlatButton8
            // 
            this.bunifuFlatButton8.Active = false;
            this.bunifuFlatButton8.Activecolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton8.BorderRadius = 0;
            this.bunifuFlatButton8.ButtonText = "Обновить";
            this.bunifuFlatButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton8.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton8.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton8.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton8.Iconimage = global::WindowsFormsApplication13.Properties.Resources.menu_96px;
            this.bunifuFlatButton8.Iconimage_right = null;
            this.bunifuFlatButton8.Iconimage_right_Selected = null;
            this.bunifuFlatButton8.Iconimage_Selected = null;
            this.bunifuFlatButton8.IconMarginLeft = 0;
            this.bunifuFlatButton8.IconMarginRight = 0;
            this.bunifuFlatButton8.IconRightVisible = false;
            this.bunifuFlatButton8.IconRightZoom = 0D;
            this.bunifuFlatButton8.IconVisible = false;
            this.bunifuFlatButton8.IconZoom = 65D;
            this.bunifuFlatButton8.IsTab = true;
            this.bunifuFlatButton8.Location = new System.Drawing.Point(3, 132);
            this.bunifuFlatButton8.Name = "bunifuFlatButton8";
            this.bunifuFlatButton8.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton8.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton8.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton8.selected = false;
            this.bunifuFlatButton8.Size = new System.Drawing.Size(251, 43);
            this.bunifuFlatButton8.TabIndex = 9;
            this.bunifuFlatButton8.Tag = "0";
            this.bunifuFlatButton8.Text = "Обновить";
            this.bunifuFlatButton8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton8.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton8.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton8.Click += new System.EventHandler(this.bunifuFlatButton8_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.label2.Location = new System.Drawing.Point(63, 523);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Тип средства";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.bunifuFlatButton20);
            this.tabPage2.Controls.Add(this.bunifuFlatButton3);
            this.tabPage2.Controls.Add(this.bunifuFlatButton2);
            this.tabPage2.Controls.Add(this.bunifuFlatButton1);
            this.tabPage2.Controls.Add(this.bunifuFlatButton7);
            this.tabPage2.Controls.Add(this.bunifuFlatButton6);
            this.tabPage2.Controls.Add(this.bunifuFlatButton5);
            this.tabPage2.Controls.Add(this.bunifuFlatButton4);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(257, 555);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "1";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.label1.Location = new System.Drawing.Point(33, 521);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Средства измерений";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Active = false;
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "Добавить";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = global::WindowsFormsApplication13.Properties.Resources.menu_96px;
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = false;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = false;
            this.bunifuFlatButton4.IconZoom = 65D;
            this.bunifuFlatButton4.IsTab = true;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(3, 3);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(251, 43);
            this.bunifuFlatButton4.TabIndex = 9;
            this.bunifuFlatButton4.Tag = "0";
            this.bunifuFlatButton4.Text = "Добавить";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton4.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Active = false;
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "Сохранить изменения";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = global::WindowsFormsApplication13.Properties.Resources.menu_96px;
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 0;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = false;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = false;
            this.bunifuFlatButton5.IconZoom = 65D;
            this.bunifuFlatButton5.IsTab = true;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(3, 46);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(251, 43);
            this.bunifuFlatButton5.TabIndex = 8;
            this.bunifuFlatButton5.Tag = "0";
            this.bunifuFlatButton5.Text = "Сохранить изменения";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton5.Click += new System.EventHandler(this.bunifuFlatButton5_Click);
            // 
            // bunifuFlatButton6
            // 
            this.bunifuFlatButton6.Active = false;
            this.bunifuFlatButton6.Activecolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton6.BorderRadius = 0;
            this.bunifuFlatButton6.ButtonText = "Удалить";
            this.bunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton6.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.Iconimage = global::WindowsFormsApplication13.Properties.Resources.menu_96px;
            this.bunifuFlatButton6.Iconimage_right = null;
            this.bunifuFlatButton6.Iconimage_right_Selected = null;
            this.bunifuFlatButton6.Iconimage_Selected = null;
            this.bunifuFlatButton6.IconMarginLeft = 0;
            this.bunifuFlatButton6.IconMarginRight = 0;
            this.bunifuFlatButton6.IconRightVisible = false;
            this.bunifuFlatButton6.IconRightZoom = 0D;
            this.bunifuFlatButton6.IconVisible = false;
            this.bunifuFlatButton6.IconZoom = 65D;
            this.bunifuFlatButton6.IsTab = true;
            this.bunifuFlatButton6.Location = new System.Drawing.Point(3, 89);
            this.bunifuFlatButton6.Name = "bunifuFlatButton6";
            this.bunifuFlatButton6.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton6.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton6.selected = false;
            this.bunifuFlatButton6.Size = new System.Drawing.Size(251, 43);
            this.bunifuFlatButton6.TabIndex = 7;
            this.bunifuFlatButton6.Tag = "0";
            this.bunifuFlatButton6.Text = "Удалить";
            this.bunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton6.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton6.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton6.Click += new System.EventHandler(this.bunifuFlatButton6_Click);
            // 
            // bunifuFlatButton7
            // 
            this.bunifuFlatButton7.Active = false;
            this.bunifuFlatButton7.Activecolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton7.BorderRadius = 0;
            this.bunifuFlatButton7.ButtonText = "Обновить";
            this.bunifuFlatButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton7.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton7.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton7.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.Iconimage = global::WindowsFormsApplication13.Properties.Resources.menu_96px;
            this.bunifuFlatButton7.Iconimage_right = null;
            this.bunifuFlatButton7.Iconimage_right_Selected = null;
            this.bunifuFlatButton7.Iconimage_Selected = null;
            this.bunifuFlatButton7.IconMarginLeft = 0;
            this.bunifuFlatButton7.IconMarginRight = 0;
            this.bunifuFlatButton7.IconRightVisible = false;
            this.bunifuFlatButton7.IconRightZoom = 0D;
            this.bunifuFlatButton7.IconVisible = false;
            this.bunifuFlatButton7.IconZoom = 65D;
            this.bunifuFlatButton7.IsTab = true;
            this.bunifuFlatButton7.Location = new System.Drawing.Point(3, 132);
            this.bunifuFlatButton7.Name = "bunifuFlatButton7";
            this.bunifuFlatButton7.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton7.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton7.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton7.selected = false;
            this.bunifuFlatButton7.Size = new System.Drawing.Size(251, 43);
            this.bunifuFlatButton7.TabIndex = 6;
            this.bunifuFlatButton7.Tag = "0";
            this.bunifuFlatButton7.Text = "Обновить";
            this.bunifuFlatButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton7.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton7.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton7.Click += new System.EventHandler(this.bunifuFlatButton7_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = false;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Добавить ремонт";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::WindowsFormsApplication13.Properties.Resources.menu_96px;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = false;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = false;
            this.bunifuFlatButton1.IconZoom = 65D;
            this.bunifuFlatButton1.IsTab = true;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(-7, 323);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(251, 43);
            this.bunifuFlatButton1.TabIndex = 12;
            this.bunifuFlatButton1.Tag = "0";
            this.bunifuFlatButton1.Text = "Добавить ремонт";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click_2);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Active = false;
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Сохр. изменения рем.";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = global::WindowsFormsApplication13.Properties.Resources.menu_96px;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = false;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = false;
            this.bunifuFlatButton2.IconZoom = 65D;
            this.bunifuFlatButton2.IsTab = true;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(-7, 372);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(251, 43);
            this.bunifuFlatButton2.TabIndex = 13;
            this.bunifuFlatButton2.Tag = "0";
            this.bunifuFlatButton2.Text = "Сохр. изменения рем.";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click_1);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Active = false;
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Удалить ремонт";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = global::WindowsFormsApplication13.Properties.Resources.menu_96px;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = false;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = false;
            this.bunifuFlatButton3.IconZoom = 65D;
            this.bunifuFlatButton3.IsTab = true;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(-7, 421);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(251, 43);
            this.bunifuFlatButton3.TabIndex = 14;
            this.bunifuFlatButton3.Tag = "0";
            this.bunifuFlatButton3.Text = "Удалить ремонт";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click_1);
            // 
            // bunifuFlatButton20
            // 
            this.bunifuFlatButton20.Active = false;
            this.bunifuFlatButton20.Activecolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuFlatButton20.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton20.BorderRadius = 0;
            this.bunifuFlatButton20.ButtonText = "Обновить ремонты";
            this.bunifuFlatButton20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton20.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton20.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton20.Iconimage = global::WindowsFormsApplication13.Properties.Resources.menu_96px;
            this.bunifuFlatButton20.Iconimage_right = null;
            this.bunifuFlatButton20.Iconimage_right_Selected = null;
            this.bunifuFlatButton20.Iconimage_Selected = null;
            this.bunifuFlatButton20.IconMarginLeft = 0;
            this.bunifuFlatButton20.IconMarginRight = 0;
            this.bunifuFlatButton20.IconRightVisible = false;
            this.bunifuFlatButton20.IconRightZoom = 0D;
            this.bunifuFlatButton20.IconVisible = false;
            this.bunifuFlatButton20.IconZoom = 65D;
            this.bunifuFlatButton20.IsTab = true;
            this.bunifuFlatButton20.Location = new System.Drawing.Point(-9, 470);
            this.bunifuFlatButton20.Name = "bunifuFlatButton20";
            this.bunifuFlatButton20.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton20.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton20.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton20.selected = false;
            this.bunifuFlatButton20.Size = new System.Drawing.Size(251, 43);
            this.bunifuFlatButton20.TabIndex = 15;
            this.bunifuFlatButton20.Tag = "0";
            this.bunifuFlatButton20.Text = "Обновить ремонты";
            this.bunifuFlatButton20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton20.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton20.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton20.Click += new System.EventHandler(this.bunifuFlatButton20_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(-10, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(265, 581);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Tag = "5";
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // subMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.hider);
            this.Controls.Add(this.tabControl1);
            this.Name = "subMenu";
            this.Size = new System.Drawing.Size(236, 568);
            ((System.ComponentModel.ISupportInitialize)(this.uchhet_izmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.izdBindingSource)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel hider;
        private uchhet_izmDataSet uchhet_izmDataSet;
        private System.Windows.Forms.BindingSource izdBindingSource;
        private uchhet_izmDataSetTableAdapters.izdTableAdapter izdTableAdapter;
        private uchhet_izmDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.TabPage tabPage6;
        public System.Windows.Forms.Label label5;
        public Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton23;
        public System.Windows.Forms.TabPage tabPage4;
        public System.Windows.Forms.Label label3;
        public Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton12;
        public Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton13;
        public Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton14;
        public Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton15;
        public System.Windows.Forms.TabPage tabPage3;
        public System.Windows.Forms.Label label2;
        public Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton8;
        public Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton9;
        public Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton10;
        public Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton11;
        public System.Windows.Forms.TabPage tabPage2;
        public Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton20;
        public Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        public Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        public Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        public Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton7;
        public Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton6;
        public Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;
        public Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TabControl tabControl1;
    }
}
