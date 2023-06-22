namespace SkillsTest
{
    partial class frmMain
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
            this.cbStrategy = new System.Windows.Forms.ComboBox();
            this.lblString = new System.Windows.Forms.Label();
            this.tbString = new System.Windows.Forms.TextBox();
            this.pnlContainer1 = new System.Windows.Forms.Panel();
            this.lblPressEnter = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblStringNote = new System.Windows.Forms.Label();
            this.lblStrategy = new System.Windows.Forms.Label();
            this.lblResultLabel = new System.Windows.Forms.Label();
            this.lblResultValue = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.pnlContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbStrategy
            // 
            this.cbStrategy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.cbStrategy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStrategy.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStrategy.ForeColor = System.Drawing.Color.Black;
            this.cbStrategy.FormattingEnabled = true;
            this.cbStrategy.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.cbStrategy.Location = new System.Drawing.Point(299, 35);
            this.cbStrategy.Name = "cbStrategy";
            this.cbStrategy.Size = new System.Drawing.Size(176, 25);
            this.cbStrategy.TabIndex = 0;
            this.cbStrategy.TabStop = false;
            this.cbStrategy.SelectedIndexChanged += new System.EventHandler(this.cbStrategy_SelectedIndexChanged);
            // 
            // lblString
            // 
            this.lblString.AutoSize = true;
            this.lblString.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblString.ForeColor = System.Drawing.Color.White;
            this.lblString.Location = new System.Drawing.Point(3, 0);
            this.lblString.Name = "lblString";
            this.lblString.Size = new System.Drawing.Size(48, 20);
            this.lblString.TabIndex = 93;
            this.lblString.Text = "String";
            // 
            // tbString
            // 
            this.tbString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbString.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbString.ForeColor = System.Drawing.Color.Black;
            this.tbString.Location = new System.Drawing.Point(296, 32);
            this.tbString.Name = "tbString";
            this.tbString.Size = new System.Drawing.Size(175, 25);
            this.tbString.TabIndex = 1;
            // 
            // pnlContainer1
            // 
            this.pnlContainer1.BackColor = System.Drawing.Color.SlateGray;
            this.pnlContainer1.Controls.Add(this.lblPressEnter);
            this.pnlContainer1.Controls.Add(this.btnGenerate);
            this.pnlContainer1.Controls.Add(this.lblStringNote);
            this.pnlContainer1.Controls.Add(this.tbString);
            this.pnlContainer1.Controls.Add(this.lblString);
            this.pnlContainer1.Location = new System.Drawing.Point(4, 90);
            this.pnlContainer1.Name = "pnlContainer1";
            this.pnlContainer1.Size = new System.Drawing.Size(772, 85);
            this.pnlContainer1.TabIndex = 95;
            // 
            // lblPressEnter
            // 
            this.lblPressEnter.AutoSize = true;
            this.lblPressEnter.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Document, ((byte)(0)));
            this.lblPressEnter.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPressEnter.Location = new System.Drawing.Point(475, 60);
            this.lblPressEnter.Name = "lblPressEnter";
            this.lblPressEnter.Size = new System.Drawing.Size(66, 12);
            this.lblPressEnter.TabIndex = 95;
            this.lblPressEnter.Text = "Or press Enter";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(477, 32);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(72, 25);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblStringNote
            // 
            this.lblStringNote.AutoSize = true;
            this.lblStringNote.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Document, ((byte)(0)));
            this.lblStringNote.ForeColor = System.Drawing.Color.White;
            this.lblStringNote.Location = new System.Drawing.Point(294, 60);
            this.lblStringNote.Name = "lblStringNote";
            this.lblStringNote.Size = new System.Drawing.Size(97, 12);
            this.lblStringNote.TabIndex = 94;
            this.lblStringNote.Text = "Type your string here";
            // 
            // lblStrategy
            // 
            this.lblStrategy.AutoSize = true;
            this.lblStrategy.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblStrategy.ForeColor = System.Drawing.Color.SlateGray;
            this.lblStrategy.Location = new System.Drawing.Point(7, 4);
            this.lblStrategy.Name = "lblStrategy";
            this.lblStrategy.Size = new System.Drawing.Size(64, 20);
            this.lblStrategy.TabIndex = 94;
            this.lblStrategy.Text = "Strategy";
            // 
            // lblResultLabel
            // 
            this.lblResultLabel.AutoSize = true;
            this.lblResultLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblResultLabel.ForeColor = System.Drawing.Color.Black;
            this.lblResultLabel.Location = new System.Drawing.Point(7, 178);
            this.lblResultLabel.Name = "lblResultLabel";
            this.lblResultLabel.Size = new System.Drawing.Size(49, 20);
            this.lblResultLabel.TabIndex = 94;
            this.lblResultLabel.Text = "Result";
            // 
            // lblResultValue
            // 
            this.lblResultValue.AutoSize = true;
            this.lblResultValue.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblResultValue.ForeColor = System.Drawing.Color.Black;
            this.lblResultValue.Location = new System.Drawing.Point(0, 286);
            this.lblResultValue.Name = "lblResultValue";
            this.lblResultValue.Size = new System.Drawing.Size(0, 41);
            this.lblResultValue.TabIndex = 96;
            this.lblResultValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Red;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(695, 456);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(72, 25);
            this.btnReset.TabIndex = 3;
            this.btnReset.TabStop = false;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.BackColor = System.Drawing.Color.Red;
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCloseForm.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseForm.ForeColor = System.Drawing.Color.White;
            this.btnCloseForm.Location = new System.Drawing.Point(754, 4);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(22, 25);
            this.btnCloseForm.TabIndex = 4;
            this.btnCloseForm.TabStop = false;
            this.btnCloseForm.Text = "x";
            this.btnCloseForm.UseVisualStyleBackColor = false;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(779, 493);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblResultValue);
            this.Controls.Add(this.lblResultLabel);
            this.Controls.Add(this.lblStrategy);
            this.Controls.Add(this.pnlContainer1);
            this.Controls.Add(this.cbStrategy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SkillsTest";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlContainer1.ResumeLayout(false);
            this.pnlContainer1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbStrategy;
        private System.Windows.Forms.Label lblString;
        private System.Windows.Forms.TextBox tbString;
        private System.Windows.Forms.Panel pnlContainer1;
        private System.Windows.Forms.Label lblStrategy;
        private System.Windows.Forms.Label lblStringNote;
        private System.Windows.Forms.Label lblResultLabel;
        private System.Windows.Forms.Label lblResultValue;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Label lblPressEnter;
    }
}

