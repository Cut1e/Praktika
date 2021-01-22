namespace WindowsFormsApplication13
{
    partial class Form6
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuFlatButton23 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuTextBox3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.bunifuDatepicker2 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.SuspendLayout();
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuDatepicker1.BorderRadius = 1;
            this.bunifuDatepicker1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuDatepicker1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bunifuDatepicker1.FormatCustom = null;
            this.bunifuDatepicker1.Location = new System.Drawing.Point(12, 37);
            this.bunifuDatepicker1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(290, 33);
            this.bunifuDatepicker1.TabIndex = 42;
            this.bunifuDatepicker1.Value = new System.DateTime(2019, 12, 4, 18, 50, 42, 0);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.label3.Location = new System.Drawing.Point(8, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 37;
            this.label3.Text = "Описание";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.label2.Location = new System.Drawing.Point(8, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 34;
            this.label2.Text = "Дата конца";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 21);
            this.label1.TabIndex = 32;
            this.label1.Text = "Дата начала";
            // 
            // bunifuFlatButton23
            // 
            this.bunifuFlatButton23.Active = false;
            this.bunifuFlatButton23.Activecolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton23.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuFlatButton23.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton23.BorderRadius = 0;
            this.bunifuFlatButton23.ButtonText = "Добавить тип";
            this.bunifuFlatButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton23.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton23.Font = new System.Drawing.Font("Segoe UI Black", 6F, System.Drawing.FontStyle.Bold);
            this.bunifuFlatButton23.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton23.Iconimage = global::WindowsFormsApplication13.Properties.Resources.add_96px;
            this.bunifuFlatButton23.Iconimage_right = null;
            this.bunifuFlatButton23.Iconimage_right_Selected = null;
            this.bunifuFlatButton23.Iconimage_Selected = null;
            this.bunifuFlatButton23.IconMarginLeft = 0;
            this.bunifuFlatButton23.IconMarginRight = 0;
            this.bunifuFlatButton23.IconRightVisible = true;
            this.bunifuFlatButton23.IconRightZoom = 0D;
            this.bunifuFlatButton23.IconVisible = true;
            this.bunifuFlatButton23.IconZoom = 65D;
            this.bunifuFlatButton23.IsTab = true;
            this.bunifuFlatButton23.Location = new System.Drawing.Point(11, 202);
            this.bunifuFlatButton23.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bunifuFlatButton23.Name = "bunifuFlatButton23";
            this.bunifuFlatButton23.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton23.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton23.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton23.selected = false;
            this.bunifuFlatButton23.Size = new System.Drawing.Size(290, 35);
            this.bunifuFlatButton23.TabIndex = 41;
            this.bunifuFlatButton23.Tag = "0";
            this.bunifuFlatButton23.Text = "Добавить тип";
            this.bunifuFlatButton23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton23.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton23.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton23.Load += new System.EventHandler(this.bunifuFlatButton23_Load);
            this.bunifuFlatButton23.Click += new System.EventHandler(this.bunifuFlatButton23_Click);
            // 
            // bunifuTextBox3
            // 
            this.bunifuTextBox3.AcceptsReturn = false;
            this.bunifuTextBox3.AcceptsTab = false;
            this.bunifuTextBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTextBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBox3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTextBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox3.BackgroundImage")));
            this.bunifuTextBox3.BorderColorActive = System.Drawing.Color.Black;
            this.bunifuTextBox3.BorderColorDisabled = System.Drawing.Color.WhiteSmoke;
            this.bunifuTextBox3.BorderColorHover = System.Drawing.Color.Black;
            this.bunifuTextBox3.BorderColorIdle = System.Drawing.Color.Gray;
            this.bunifuTextBox3.BorderRadius = 1;
            this.bunifuTextBox3.BorderThickness = 1;
            this.bunifuTextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTextBox3.DefaultFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuTextBox3.DefaultText = "";
            this.bunifuTextBox3.FillColor = System.Drawing.SystemColors.Window;
            this.bunifuTextBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.bunifuTextBox3.HideSelection = true;
            this.bunifuTextBox3.IconLeft = null;
            this.bunifuTextBox3.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox3.IconPadding = 10;
            this.bunifuTextBox3.IconRight = null;
            this.bunifuTextBox3.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox3.Location = new System.Drawing.Point(12, 161);
            this.bunifuTextBox3.MaxLength = 32767;
            this.bunifuTextBox3.MinimumSize = new System.Drawing.Size(100, 35);
            this.bunifuTextBox3.Modified = false;
            this.bunifuTextBox3.Name = "bunifuTextBox3";
            this.bunifuTextBox3.PasswordChar = '\0';
            this.bunifuTextBox3.ReadOnly = false;
            this.bunifuTextBox3.SelectedText = "";
            this.bunifuTextBox3.SelectionLength = 0;
            this.bunifuTextBox3.SelectionStart = 0;
            this.bunifuTextBox3.ShortcutsEnabled = true;
            this.bunifuTextBox3.Size = new System.Drawing.Size(290, 35);
            this.bunifuTextBox3.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.bunifuTextBox3.TabIndex = 38;
            this.bunifuTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBox3.TextMarginLeft = 5;
            this.bunifuTextBox3.TextPlaceholder = "Описание...";
            this.bunifuTextBox3.UseSystemPasswordChar = false;
            // 
            // bunifuDatepicker2
            // 
            this.bunifuDatepicker2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuDatepicker2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuDatepicker2.BorderRadius = 1;
            this.bunifuDatepicker2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuDatepicker2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuDatepicker2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.bunifuDatepicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bunifuDatepicker2.FormatCustom = null;
            this.bunifuDatepicker2.Location = new System.Drawing.Point(12, 99);
            this.bunifuDatepicker2.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuDatepicker2.Name = "bunifuDatepicker2";
            this.bunifuDatepicker2.Size = new System.Drawing.Size(290, 33);
            this.bunifuDatepicker2.TabIndex = 45;
            this.bunifuDatepicker2.Value = new System.DateTime(2019, 12, 4, 18, 50, 42, 0);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(314, 247);
            this.Controls.Add(this.bunifuDatepicker2);
            this.Controls.Add(this.bunifuDatepicker1);
            this.Controls.Add(this.bunifuFlatButton23);
            this.Controls.Add(this.bunifuTextBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить ремонт";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
        public Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton23;
        public Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox bunifuTextBox3;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker2;
    }
}