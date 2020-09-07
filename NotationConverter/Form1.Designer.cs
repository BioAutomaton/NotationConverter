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
            this.EnteringTextBox = new System.Windows.Forms.TextBox();
            this.ErrMsgBox = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EnteringTextBox
            // 
            this.EnteringTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EnteringTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnteringTextBox.Location = new System.Drawing.Point(19, 19);
            this.EnteringTextBox.Margin = new System.Windows.Forms.Padding(10, 10, 10, 3);
            this.EnteringTextBox.Name = "EnteringTextBox";
            this.EnteringTextBox.Size = new System.Drawing.Size(231, 27);
            this.EnteringTextBox.TabIndex = 5;
            this.EnteringTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.ErrMsgBox.Size = new System.Drawing.Size(0, 0);
            this.ErrMsgBox.TabIndex = 1022;
            this.ErrMsgBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(263, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 23);
            this.button1.TabIndex = 1023;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputTextBox.Location = new System.Drawing.Point(355, 19);
            this.OutputTextBox.Margin = new System.Windows.Forms.Padding(10, 10, 10, 3);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(231, 27);
            this.OutputTextBox.TabIndex = 1024;
            this.OutputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 113);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ErrMsgBox);
            this.Controls.Add(this.EnteringTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EnteringTextBox;
        private System.Windows.Forms.Label ErrMsgBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox OutputTextBox;
    }
}

