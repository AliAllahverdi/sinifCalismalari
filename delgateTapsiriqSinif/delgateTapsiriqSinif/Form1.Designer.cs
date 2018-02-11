namespace delgateTapsiriqSinif
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHsp = new System.Windows.Forms.Button();
            this.btnpls = new System.Windows.Forms.Button();
            this.mezunbox = new System.Windows.Forms.TextBox();
            this.vergibox = new System.Windows.Forms.TextBox();
            this.dsmfbox = new System.Windows.Forms.TextBox();
            this.netbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.netbox);
            this.groupBox1.Controls.Add(this.dsmfbox);
            this.groupBox1.Controls.Add(this.vergibox);
            this.groupBox1.Controls.Add(this.mezunbox);
            this.groupBox1.Location = new System.Drawing.Point(569, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 495);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnHsp
            // 
            this.btnHsp.Location = new System.Drawing.Point(402, 441);
            this.btnHsp.Name = "btnHsp";
            this.btnHsp.Size = new System.Drawing.Size(75, 23);
            this.btnHsp.TabIndex = 1;
            this.btnHsp.Text = "Hesapla";
            this.btnHsp.UseVisualStyleBackColor = true;
            this.btnHsp.Click += new System.EventHandler(this.btnHsp_Click);
            // 
            // btnpls
            // 
            this.btnpls.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpls.Location = new System.Drawing.Point(68, 432);
            this.btnpls.Name = "btnpls";
            this.btnpls.Size = new System.Drawing.Size(38, 32);
            this.btnpls.TabIndex = 2;
            this.btnpls.Text = "+";
            this.btnpls.UseVisualStyleBackColor = true;
            this.btnpls.Click += new System.EventHandler(this.btnpls_Click_1);
            // 
            // mezunbox
            // 
            this.mezunbox.Location = new System.Drawing.Point(103, 33);
            this.mezunbox.Name = "mezunbox";
            this.mezunbox.Size = new System.Drawing.Size(100, 20);
            this.mezunbox.TabIndex = 0;
            this.mezunbox.TextChanged += new System.EventHandler(this.mezunbox_TextChanged);
            // 
            // vergibox
            // 
            this.vergibox.Location = new System.Drawing.Point(103, 84);
            this.vergibox.Name = "vergibox";
            this.vergibox.Size = new System.Drawing.Size(100, 20);
            this.vergibox.TabIndex = 0;
            this.vergibox.TextChanged += new System.EventHandler(this.vergibox_TextChanged);
            // 
            // dsmfbox
            // 
            this.dsmfbox.Location = new System.Drawing.Point(103, 136);
            this.dsmfbox.Name = "dsmfbox";
            this.dsmfbox.Size = new System.Drawing.Size(100, 20);
            this.dsmfbox.TabIndex = 0;
            // 
            // netbox
            // 
            this.netbox.Location = new System.Drawing.Point(103, 182);
            this.netbox.Name = "netbox";
            this.netbox.Size = new System.Drawing.Size(100, 20);
            this.netbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mezun";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vergi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "DSMF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "NET";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 519);
            this.Controls.Add(this.btnpls);
            this.Controls.Add(this.btnHsp);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHsp;
        private System.Windows.Forms.Button btnpls;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox netbox;
        private System.Windows.Forms.TextBox dsmfbox;
        private System.Windows.Forms.TextBox vergibox;
        private System.Windows.Forms.TextBox mezunbox;
    }
}

