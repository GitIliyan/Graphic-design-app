namespace Kursova
{
    partial class FormEditTriangle
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
            this.textBoxA1 = new System.Windows.Forms.TextBox();
            this.textBoxB1 = new System.Windows.Forms.TextBox();
            this.textBoxC1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxA2 = new System.Windows.Forms.TextBox();
            this.textBoxB2 = new System.Windows.Forms.TextBox();
            this.textBoxC2 = new System.Windows.Forms.TextBox();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxA1
            // 
            this.textBoxA1.Location = new System.Drawing.Point(95, 64);
            this.textBoxA1.Name = "textBoxA1";
            this.textBoxA1.Size = new System.Drawing.Size(39, 20);
            this.textBoxA1.TabIndex = 0;
            // 
            // textBoxB1
            // 
            this.textBoxB1.Location = new System.Drawing.Point(280, 64);
            this.textBoxB1.Name = "textBoxB1";
            this.textBoxB1.Size = new System.Drawing.Size(42, 20);
            this.textBoxB1.TabIndex = 1;
            // 
            // textBoxC1
            // 
            this.textBoxC1.Location = new System.Drawing.Point(474, 64);
            this.textBoxC1.Name = "textBoxC1";
            this.textBoxC1.Size = new System.Drawing.Size(38, 20);
            this.textBoxC1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Point A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Point B:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Point C:";
            // 
            // textBoxA2
            // 
            this.textBoxA2.Location = new System.Drawing.Point(140, 64);
            this.textBoxA2.Name = "textBoxA2";
            this.textBoxA2.Size = new System.Drawing.Size(39, 20);
            this.textBoxA2.TabIndex = 6;
            // 
            // textBoxB2
            // 
            this.textBoxB2.Location = new System.Drawing.Point(328, 64);
            this.textBoxB2.Name = "textBoxB2";
            this.textBoxB2.Size = new System.Drawing.Size(42, 20);
            this.textBoxB2.TabIndex = 8;
            // 
            // textBoxC2
            // 
            this.textBoxC2.Location = new System.Drawing.Point(518, 64);
            this.textBoxC2.Name = "textBoxC2";
            this.textBoxC2.Size = new System.Drawing.Size(42, 20);
            this.textBoxC2.TabIndex = 10;
            // 
            // buttonFinish
            // 
            this.buttonFinish.Location = new System.Drawing.Point(253, 129);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(141, 33);
            this.buttonFinish.TabIndex = 11;
            this.buttonFinish.Text = "Finish";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(125, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(402, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Enter coordinates X and Y for each point of the triangle ";
            // 
            // FormEditTriangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 241);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonFinish);
            this.Controls.Add(this.textBoxC2);
            this.Controls.Add(this.textBoxB2);
            this.Controls.Add(this.textBoxA2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxC1);
            this.Controls.Add(this.textBoxB1);
            this.Controls.Add(this.textBoxA1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEditTriangle";
            this.Text = "FormEditTriangle";
            this.Load += new System.EventHandler(this.FormEditTriangle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxA1;
        private System.Windows.Forms.TextBox textBoxB1;
        private System.Windows.Forms.TextBox textBoxC1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxA2;
        private System.Windows.Forms.TextBox textBoxB2;
        private System.Windows.Forms.TextBox textBoxC2;
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.Label label4;
    }
}