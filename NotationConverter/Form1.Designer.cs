namespace NotationConverter
{
    partial class Form1
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
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.ErrMsgBox = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.ToComBox = new System.Windows.Forms.ComboBox();
            this.FromComBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.shortcutsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.swapNotationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputTextBox
            // 
            this.InputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputTextBox.Location = new System.Drawing.Point(19, 34);
            this.InputTextBox.Margin = new System.Windows.Forms.Padding(10, 10, 10, 3);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(231, 27);
            this.InputTextBox.TabIndex = 1;
            this.InputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ErrMsgBox
            // 
            this.ErrMsgBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrMsgBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrMsgBox.ForeColor = System.Drawing.Color.Red;
            this.ErrMsgBox.Location = new System.Drawing.Point(324, 274);
            this.ErrMsgBox.Margin = new System.Windows.Forms.Padding(3);
            this.ErrMsgBox.Name = "ErrMsgBox";
            this.ErrMsgBox.Size = new System.Drawing.Size(0, 11);
            this.ErrMsgBox.TabIndex = 1022;
            this.ErrMsgBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Verdana", 12F);
            this.button1.Location = new System.Drawing.Point(263, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "==>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Calculate);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputTextBox.Location = new System.Drawing.Point(355, 34);
            this.OutputTextBox.Margin = new System.Windows.Forms.Padding(10, 10, 10, 3);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.Size = new System.Drawing.Size(231, 27);
            this.OutputTextBox.TabIndex = 5;
            this.OutputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ToComBox
            // 
            this.ToComBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ToComBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Name",
            "Contract number",
            "Contract term",
            "Deposit sum"});
            this.ToComBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ToComBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ToComBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToComBox.FormattingEnabled = true;
            this.ToComBox.Location = new System.Drawing.Point(355, 79);
            this.ToComBox.Name = "ToComBox";
            this.ToComBox.Size = new System.Drawing.Size(125, 26);
            this.ToComBox.TabIndex = 3;
            // 
            // FromComBox
            // 
            this.FromComBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Name",
            "Contract number",
            "Contract term",
            "Deposit sum"});
            this.FromComBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.FromComBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FromComBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FromComBox.FormattingEnabled = true;
            this.FromComBox.Location = new System.Drawing.Point(125, 79);
            this.FromComBox.Name = "FromComBox";
            this.FromComBox.Size = new System.Drawing.Size(125, 26);
            this.FromComBox.TabIndex = 2;
            this.FromComBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shortcutsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(605, 24);
            this.menuStrip1.TabIndex = 1030;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // shortcutsToolStripMenuItem
            // 
            this.shortcutsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.swapNotationsToolStripMenuItem});
            this.shortcutsToolStripMenuItem.Name = "shortcutsToolStripMenuItem";
            this.shortcutsToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.shortcutsToolStripMenuItem.Text = "Shortcuts";
            // 
            // swapNotationsToolStripMenuItem
            // 
            this.swapNotationsToolStripMenuItem.Name = "swapNotationsToolStripMenuItem";
            this.swapNotationsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.swapNotationsToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.swapNotationsToolStripMenuItem.Text = "Swap notations";
            this.swapNotationsToolStripMenuItem.Click += new System.EventHandler(this.swapNotationsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 118);
            this.Controls.Add(this.FromComBox);
            this.Controls.Add(this.ToComBox);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ErrMsgBox);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Notation Converter";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Label ErrMsgBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.ComboBox ToComBox;
        private System.Windows.Forms.ComboBox FromComBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem shortcutsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem swapNotationsToolStripMenuItem;
    }
}

