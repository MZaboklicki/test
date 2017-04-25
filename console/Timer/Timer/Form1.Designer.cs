namespace Timer
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Start_Button = new System.Windows.Forms.Button();
            this.minute1 = new System.Windows.Forms.Label();
            this.minute2 = new System.Windows.Forms.Label();
            this.second1 = new System.Windows.Forms.Label();
            this.second2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stoper";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Start_Button
            // 
            this.Start_Button.Location = new System.Drawing.Point(94, 125);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(75, 23);
            this.Start_Button.TabIndex = 1;
            this.Start_Button.Text = "Start";
            this.Start_Button.UseVisualStyleBackColor = true;
            // 
            // minute1
            // 
            this.minute1.AutoSize = true;
            this.minute1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minute1.Location = new System.Drawing.Point(60, 60);
            this.minute1.Name = "minute1";
            this.minute1.Size = new System.Drawing.Size(29, 31);
            this.minute1.TabIndex = 2;
            this.minute1.Text = "0";
            // 
            // minute2
            // 
            this.minute2.AutoSize = true;
            this.minute2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minute2.Location = new System.Drawing.Point(88, 60);
            this.minute2.Name = "minute2";
            this.minute2.Size = new System.Drawing.Size(29, 31);
            this.minute2.TabIndex = 3;
            this.minute2.Text = "0";
            // 
            // second1
            // 
            this.second1.AutoSize = true;
            this.second1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.second1.Location = new System.Drawing.Point(140, 60);
            this.second1.Name = "second1";
            this.second1.Size = new System.Drawing.Size(29, 31);
            this.second1.TabIndex = 4;
            this.second1.Text = "0";
            // 
            // second2
            // 
            this.second2.AutoSize = true;
            this.second2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.second2.Location = new System.Drawing.Point(166, 60);
            this.second2.Name = "second2";
            this.second2.Size = new System.Drawing.Size(29, 31);
            this.second2.TabIndex = 5;
            this.second2.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label2.Location = new System.Drawing.Point(116, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = ":";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 176);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.second2);
            this.Controls.Add(this.second1);
            this.Controls.Add(this.minute2);
            this.Controls.Add(this.minute1);
            this.Controls.Add(this.Start_Button);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Start_Button;
        private System.Windows.Forms.Label minute1;
        private System.Windows.Forms.Label minute2;
        private System.Windows.Forms.Label second1;
        private System.Windows.Forms.Label second2;
        private System.Windows.Forms.Label label2;
    }
}

