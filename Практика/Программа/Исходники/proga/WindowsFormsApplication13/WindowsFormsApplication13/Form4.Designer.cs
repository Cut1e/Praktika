namespace WindowsFormsApplication13
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuTextBox1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.bunifuFlatButton23 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuTextBox2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Тип изделия";
            // 
            // bunifuTextBox1
            // 
            this.bunifuTextBox1.AcceptsReturn = false;
            this.bunifuTextBox1.AcceptsTab = false;
            this.bunifuTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTextBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox1.BackgroundImage")));
            this.bunifuTextBox1.BorderColorActive = System.Drawing.Color.Black;
            this.bunifuTextBox1.BorderColorDisabled = System.Drawing.Color.WhiteSmoke;
            this.bunifuTextBox1.BorderColorHover = System.Drawing.Color.Black;
            this.bunifuTextBox1.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.bunifuTextBox1.BorderRadius = 1;
            this.bunifuTextBox1.BorderThickness = 2;
            this.bunifuTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTextBox1.DefaultFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuTextBox1.DefaultText = "";
            this.bunifuTextBox1.FillColor = System.Drawing.SystemColors.Window;
            this.bunifuTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.bunifuTextBox1.HideSelection = true;
            this.bunifuTextBox1.IconLeft = null;
            this.bunifuTextBox1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox1.IconPadding = 10;
            this.bunifuTextBox1.IconRight = null;
            this.bunifuTextBox1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox1.Location = new System.Drawing.Point(12, 33);
            this.bunifuTextBox1.MaxLength = 32767;
            this.bunifuTextBox1.MinimumSize = new System.Drawing.Size(100, 35);
            this.bunifuTextBox1.Modified = false;
            this.bunifuTextBox1.Name = "bunifuTextBox1";
            this.bunifuTextBox1.PasswordChar = '\0';
            this.bunifuTextBox1.ReadOnly = false;
            this.bunifuTextBox1.SelectedText = "";
            this.bunifuTextBox1.SelectionLength = 0;
            this.bunifuTextBox1.SelectionStart = 0;
            this.bunifuTextBox1.ShortcutsEnabled = true;
            this.bunifuTextBox1.Size = new System.Drawing.Size(305, 35);
            this.bunifuTextBox1.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.bunifuTextBox1.TabIndex = 10;
            this.bunifuTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBox1.TextMarginLeft = 5;
            this.bunifuTextBox1.TextPlaceholder = "Тип изделия...";
            this.bunifuTextBox1.UseSystemPasswordChar = false;
            this.bunifuTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bunifuTextBox1_KeyDown);
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
            this.bunifuFlatButton23.Location = new System.Drawing.Point(12, 136);
            this.bunifuFlatButton23.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bunifuFlatButton23.Name = "bunifuFlatButton23";
            this.bunifuFlatButton23.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton23.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton23.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton23.selected = false;
            this.bunifuFlatButton23.Size = new System.Drawing.Size(305, 35);
            this.bunifuFlatButton23.TabIndex = 11;
            this.bunifuFlatButton23.Tag = "0";
            this.bunifuFlatButton23.Text = "Добавить тип";
            this.bunifuFlatButton23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton23.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton23.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton23.Click += new System.EventHandler(this.bunifuFlatButton23_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.label2.Location = new System.Drawing.Point(8, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Предел измерений";
            // 
            // bunifuTextBox2
            // 
            this.bunifuTextBox2.AcceptsReturn = false;
            this.bunifuTextBox2.AcceptsTab = false;
            this.bunifuTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTextBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTextBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox2.BackgroundImage")));
            this.bunifuTextBox2.BorderColorActive = System.Drawing.Color.Black;
            this.bunifuTextBox2.BorderColorDisabled = System.Drawing.Color.WhiteSmoke;
            this.bunifuTextBox2.BorderColorHover = System.Drawing.Color.Black;
            this.bunifuTextBox2.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.bunifuTextBox2.BorderRadius = 1;
            this.bunifuTextBox2.BorderThickness = 2;
            this.bunifuTextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTextBox2.DefaultFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuTextBox2.DefaultText = "";
            this.bunifuTextBox2.FillColor = System.Drawing.SystemColors.Window;
            this.bunifuTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.bunifuTextBox2.HideSelection = true;
            this.bunifuTextBox2.IconLeft = null;
            this.bunifuTextBox2.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox2.IconPadding = 10;
            this.bunifuTextBox2.IconRight = null;
            this.bunifuTextBox2.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox2.Location = new System.Drawing.Point(12, 95);
            this.bunifuTextBox2.MaxLength = 32767;
            this.bunifuTextBox2.MinimumSize = new System.Drawing.Size(100, 35);
            this.bunifuTextBox2.Modified = false;
            this.bunifuTextBox2.Name = "bunifuTextBox2";
            this.bunifuTextBox2.PasswordChar = '\0';
            this.bunifuTextBox2.ReadOnly = false;
            this.bunifuTextBox2.SelectedText = "";
            this.bunifuTextBox2.SelectionLength = 0;
            this.bunifuTextBox2.SelectionStart = 0;
            this.bunifuTextBox2.ShortcutsEnabled = true;
            this.bunifuTextBox2.Size = new System.Drawing.Size(305, 35);
            this.bunifuTextBox2.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.bunifuTextBox2.TabIndex = 13;
            this.bunifuTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBox2.TextMarginLeft = 5;
            this.bunifuTextBox2.TextPlaceholder = "Предел измерений...";
            this.bunifuTextBox2.UseSystemPasswordChar = false;
            this.bunifuTextBox2.TextChange += new System.EventHandler(this.bunifuTextBox2_TextChange);
            this.bunifuTextBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bunifuTextBox2_KeyDown);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(329, 177);
            this.Controls.Add(this.bunifuTextBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuFlatButton23);
            this.Controls.Add(this.bunifuTextBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить тип изделия";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox bunifuTextBox1;
        public Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton23;
        public System.Windows.Forms.Label label2;
        public Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox bunifuTextBox2;
    }
}