namespace animatiecucontroaleseparate
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
            this.button1 = new System.Windows.Forms.Button();
            this.controlanimat2 = new animatiecucontroaleseparate.controlanimat();
            this.controlanimat1 = new animatiecucontroaleseparate.controlanimat();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // controlanimat2
            // 
            this.controlanimat2.BackColor = System.Drawing.Color.Red;
            this.controlanimat2.Location = new System.Drawing.Point(177, 170);
            this.controlanimat2.Name = "controlanimat2";
            this.controlanimat2.Size = new System.Drawing.Size(113, 122);
            this.controlanimat2.TabIndex = 1;
            // 
            // controlanimat1
            // 
            this.controlanimat1.BackColor = System.Drawing.Color.Red;
            this.controlanimat1.Location = new System.Drawing.Point(114, 41);
            this.controlanimat1.Name = "controlanimat1";
            this.controlanimat1.Size = new System.Drawing.Size(113, 122);
            this.controlanimat1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 456);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.controlanimat2);
            this.Controls.Add(this.controlanimat1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private controlanimat controlanimat1;
        private controlanimat controlanimat2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

