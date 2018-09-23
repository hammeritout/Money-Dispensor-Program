namespace DenominationProject
{
    partial class FrmDenomination
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
            this.grpDenominations = new System.Windows.Forms.GroupBox();
            this.lblTIme = new System.Windows.Forms.Label();
            this.chk1 = new System.Windows.Forms.CheckBox();
            this.chk5 = new System.Windows.Forms.CheckBox();
            this.chk10 = new System.Windows.Forms.CheckBox();
            this.chk20 = new System.Windows.Forms.CheckBox();
            this.chk50 = new System.Windows.Forms.CheckBox();
            this.chk100 = new System.Windows.Forms.CheckBox();
            this.txtDispenseAmt = new System.Windows.Forms.TextBox();
            this.btnDispense = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblDispenseAmt = new System.Windows.Forms.Label();
            this.grpDenominations.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDenominations
            // 
            this.grpDenominations.Controls.Add(this.lblTIme);
            this.grpDenominations.Controls.Add(this.chk1);
            this.grpDenominations.Controls.Add(this.chk5);
            this.grpDenominations.Controls.Add(this.chk10);
            this.grpDenominations.Controls.Add(this.chk20);
            this.grpDenominations.Controls.Add(this.chk50);
            this.grpDenominations.Controls.Add(this.chk100);
            this.grpDenominations.Location = new System.Drawing.Point(13, 396);
            this.grpDenominations.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpDenominations.Name = "grpDenominations";
            this.grpDenominations.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpDenominations.Size = new System.Drawing.Size(276, 131);
            this.grpDenominations.TabIndex = 0;
            this.grpDenominations.TabStop = false;
            // 
            // lblTIme
            // 
            this.lblTIme.AutoSize = true;
            this.lblTIme.Location = new System.Drawing.Point(214, 105);
            this.lblTIme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTIme.Name = "lblTIme";
            this.lblTIme.Size = new System.Drawing.Size(0, 19);
            this.lblTIme.TabIndex = 6;
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.Checked = true;
            this.chk1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk1.Location = new System.Drawing.Point(110, 86);
            this.chk1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(52, 26);
            this.chk1.TabIndex = 5;
            this.chk1.TabStop = false;
            this.chk1.Text = "$1";
            this.chk1.UseVisualStyleBackColor = true;
            // 
            // chk5
            // 
            this.chk5.AutoSize = true;
            this.chk5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk5.Location = new System.Drawing.Point(110, 51);
            this.chk5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chk5.Name = "chk5";
            this.chk5.Size = new System.Drawing.Size(52, 26);
            this.chk5.TabIndex = 4;
            this.chk5.TabStop = false;
            this.chk5.Text = "$5";
            this.chk5.UseVisualStyleBackColor = true;
            // 
            // chk10
            // 
            this.chk10.AutoSize = true;
            this.chk10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk10.Location = new System.Drawing.Point(110, 16);
            this.chk10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chk10.Name = "chk10";
            this.chk10.Size = new System.Drawing.Size(62, 26);
            this.chk10.TabIndex = 3;
            this.chk10.TabStop = false;
            this.chk10.Text = "$10";
            this.chk10.UseVisualStyleBackColor = true;
            // 
            // chk20
            // 
            this.chk20.AutoSize = true;
            this.chk20.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk20.Location = new System.Drawing.Point(7, 86);
            this.chk20.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chk20.Name = "chk20";
            this.chk20.Size = new System.Drawing.Size(62, 26);
            this.chk20.TabIndex = 2;
            this.chk20.TabStop = false;
            this.chk20.Text = "$20";
            this.chk20.UseVisualStyleBackColor = true;
            // 
            // chk50
            // 
            this.chk50.AutoSize = true;
            this.chk50.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk50.Location = new System.Drawing.Point(7, 51);
            this.chk50.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chk50.Name = "chk50";
            this.chk50.Size = new System.Drawing.Size(62, 26);
            this.chk50.TabIndex = 1;
            this.chk50.TabStop = false;
            this.chk50.Text = "$50";
            this.chk50.UseVisualStyleBackColor = true;
            // 
            // chk100
            // 
            this.chk100.AutoSize = true;
            this.chk100.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk100.Location = new System.Drawing.Point(7, 16);
            this.chk100.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chk100.Name = "chk100";
            this.chk100.Size = new System.Drawing.Size(72, 26);
            this.chk100.TabIndex = 0;
            this.chk100.TabStop = false;
            this.chk100.Text = "$100";
            this.chk100.UseVisualStyleBackColor = true;
            this.chk100.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtDispenseAmt
            // 
            this.txtDispenseAmt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDispenseAmt.Location = new System.Drawing.Point(200, 328);
            this.txtDispenseAmt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDispenseAmt.Name = "txtDispenseAmt";
            this.txtDispenseAmt.Size = new System.Drawing.Size(573, 30);
            this.txtDispenseAmt.TabIndex = 0;
            // 
            // btnDispense
            // 
            this.btnDispense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDispense.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispense.Location = new System.Drawing.Point(297, 396);
            this.btnDispense.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDispense.Name = "btnDispense";
            this.btnDispense.Size = new System.Drawing.Size(122, 37);
            this.btnDispense.TabIndex = 1;
            this.btnDispense.Text = "&Dispense";
            this.btnDispense.UseVisualStyleBackColor = false;
            this.btnDispense.Click += new System.EventHandler(this.btnDispense_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(468, 396);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(122, 37);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(651, 396);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(122, 37);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblMessage.Location = new System.Drawing.Point(199, 32);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(574, 269);
            this.lblMessage.TabIndex = 5;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDispenseAmt
            // 
            this.lblDispenseAmt.AutoSize = true;
            this.lblDispenseAmt.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDispenseAmt.Location = new System.Drawing.Point(17, 341);
            this.lblDispenseAmt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDispenseAmt.Name = "lblDispenseAmt";
            this.lblDispenseAmt.Size = new System.Drawing.Size(175, 17);
            this.lblDispenseAmt.TabIndex = 6;
            this.lblDispenseAmt.Text = "Enter Whole Dollar Amount:";
            // 
            // FrmDenomination
            // 
            this.AcceptButton = this.btnDispense;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(923, 547);
            this.Controls.Add(this.lblDispenseAmt);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDispense);
            this.Controls.Add(this.txtDispenseAmt);
            this.Controls.Add(this.grpDenominations);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmDenomination";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sharyl Hammer Fun Cash Machine";
            this.Load += new System.EventHandler(this.FrmDenomination_Load);
            this.grpDenominations.ResumeLayout(false);
            this.grpDenominations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDenominations;
        private System.Windows.Forms.CheckBox chk100;
        private System.Windows.Forms.CheckBox chk1;
        private System.Windows.Forms.CheckBox chk5;
        private System.Windows.Forms.CheckBox chk10;
        private System.Windows.Forms.CheckBox chk20;
        private System.Windows.Forms.CheckBox chk50;
        private System.Windows.Forms.TextBox txtDispenseAmt;
        private System.Windows.Forms.Button btnDispense;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblDispenseAmt;
        private System.Windows.Forms.Label lblTIme;
    }
}

