namespace Utility
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtChargeStatus = new System.Windows.Forms.TextBox();
            this.txtFullLifetime = new System.Windows.Forms.TextBox();
            this.txtCharge = new System.Windows.Forms.TextBox();
            this.txtLifeRemaining = new System.Windows.Forms.TextBox();
            this.txtLineStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carga";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Carga %";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tempo (sec)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Conectado";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Atualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtChargeStatus
            // 
            this.txtChargeStatus.Location = new System.Drawing.Point(111, 43);
            this.txtChargeStatus.Name = "txtChargeStatus";
            this.txtChargeStatus.Size = new System.Drawing.Size(100, 20);
            this.txtChargeStatus.TabIndex = 6;
            // 
            // txtFullLifetime
            // 
            this.txtFullLifetime.Location = new System.Drawing.Point(111, 83);
            this.txtFullLifetime.Name = "txtFullLifetime";
            this.txtFullLifetime.Size = new System.Drawing.Size(100, 20);
            this.txtFullLifetime.TabIndex = 7;
            // 
            // txtCharge
            // 
            this.txtCharge.Location = new System.Drawing.Point(111, 122);
            this.txtCharge.Name = "txtCharge";
            this.txtCharge.Size = new System.Drawing.Size(100, 20);
            this.txtCharge.TabIndex = 8;
            // 
            // txtLifeRemaining
            // 
            this.txtLifeRemaining.Location = new System.Drawing.Point(125, 174);
            this.txtLifeRemaining.Name = "txtLifeRemaining";
            this.txtLifeRemaining.Size = new System.Drawing.Size(100, 20);
            this.txtLifeRemaining.TabIndex = 9;
            // 
            // txtLineStatus
            // 
            this.txtLineStatus.Location = new System.Drawing.Point(125, 210);
            this.txtLineStatus.Name = "txtLineStatus";
            this.txtLineStatus.Size = new System.Drawing.Size(100, 20);
            this.txtLineStatus.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 313);
            this.Controls.Add(this.txtLineStatus);
            this.Controls.Add(this.txtLifeRemaining);
            this.Controls.Add(this.txtCharge);
            this.Controls.Add(this.txtFullLifetime);
            this.Controls.Add(this.txtChargeStatus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtChargeStatus;
        private System.Windows.Forms.TextBox txtFullLifetime;
        private System.Windows.Forms.TextBox txtCharge;
        private System.Windows.Forms.TextBox txtLifeRemaining;
        private System.Windows.Forms.TextBox txtLineStatus;
    }
}

