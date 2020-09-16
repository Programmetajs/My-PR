namespace Login_RegisterTutorial
{
    partial class Registr
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
            this.txtREGusername = new System.Windows.Forms.TextBox();
            this.txtREGpassword = new System.Windows.Forms.TextBox();
            this.txtREGfirst_name = new System.Windows.Forms.TextBox();
            this.txtREGmiddle_name = new System.Windows.Forms.TextBox();
            this.txtREGlast_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegistr = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtREGusername
            // 
            this.txtREGusername.Location = new System.Drawing.Point(12, 37);
            this.txtREGusername.Name = "txtREGusername";
            this.txtREGusername.Size = new System.Drawing.Size(216, 22);
            this.txtREGusername.TabIndex = 0;
            // 
            // txtREGpassword
            // 
            this.txtREGpassword.Location = new System.Drawing.Point(12, 121);
            this.txtREGpassword.Name = "txtREGpassword";
            this.txtREGpassword.Size = new System.Drawing.Size(216, 22);
            this.txtREGpassword.TabIndex = 1;
            // 
            // txtREGfirst_name
            // 
            this.txtREGfirst_name.Location = new System.Drawing.Point(12, 207);
            this.txtREGfirst_name.Name = "txtREGfirst_name";
            this.txtREGfirst_name.Size = new System.Drawing.Size(216, 22);
            this.txtREGfirst_name.TabIndex = 2;
            // 
            // txtREGmiddle_name
            // 
            this.txtREGmiddle_name.Location = new System.Drawing.Point(12, 283);
            this.txtREGmiddle_name.Name = "txtREGmiddle_name";
            this.txtREGmiddle_name.Size = new System.Drawing.Size(216, 22);
            this.txtREGmiddle_name.TabIndex = 3;
            // 
            // txtREGlast_name
            // 
            this.txtREGlast_name.Location = new System.Drawing.Point(12, 366);
            this.txtREGlast_name.Name = "txtREGlast_name";
            this.txtREGlast_name.Size = new System.Drawing.Size(216, 22);
            this.txtREGlast_name.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "First name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Middle name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Last name";
            // 
            // btnRegistr
            // 
            this.btnRegistr.Location = new System.Drawing.Point(23, 438);
            this.btnRegistr.Name = "btnRegistr";
            this.btnRegistr.Size = new System.Drawing.Size(75, 27);
            this.btnRegistr.TabIndex = 10;
            this.btnRegistr.Text = "Registr";
            this.btnRegistr.UseVisualStyleBackColor = true;
            this.btnRegistr.Click += new System.EventHandler(this.btnRegistr_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(188, 438);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 27);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Registr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(332, 480);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegistr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtREGlast_name);
            this.Controls.Add(this.txtREGmiddle_name);
            this.Controls.Add(this.txtREGfirst_name);
            this.Controls.Add(this.txtREGpassword);
            this.Controls.Add(this.txtREGusername);
            this.Name = "Registr";
            this.Text = "Registr";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registr_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtREGusername;
        private System.Windows.Forms.TextBox txtREGpassword;
        private System.Windows.Forms.TextBox txtREGfirst_name;
        private System.Windows.Forms.TextBox txtREGmiddle_name;
        private System.Windows.Forms.TextBox txtREGlast_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRegistr;
        private System.Windows.Forms.Button btnCancel;
    }
}