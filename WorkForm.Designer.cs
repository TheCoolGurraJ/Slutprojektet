namespace Slutprojektet
{
    partial class WorkForm
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
            this.btn8 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.illegal_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(218, 298);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(170, 72);
            this.btn8.TabIndex = 2;
            this.btn8.Text = "8 Hours";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(394, 298);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(170, 72);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4 Hours";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(570, 298);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(170, 72);
            this.btn2.TabIndex = 4;
            this.btn2.Text = "2 Hours";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 160);
            this.label1.MinimumSize = new System.Drawing.Size(100, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(693, 55);
            this.label1.TabIndex = 5;
            this.label1.Text = "How long do you want to work?";
            // 
            // illegal_btn
            // 
            this.illegal_btn.BackColor = System.Drawing.Color.YellowGreen;
            this.illegal_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.illegal_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.illegal_btn.Location = new System.Drawing.Point(659, 30);
            this.illegal_btn.Name = "illegal_btn";
            this.illegal_btn.Size = new System.Drawing.Size(296, 72);
            this.illegal_btn.TabIndex = 6;
            this.illegal_btn.Text = "Sell \"medicine\"";
            this.illegal_btn.UseVisualStyleBackColor = false;
            this.illegal_btn.Visible = false;
            this.illegal_btn.Click += new System.EventHandler(this.illegal_btn_Click);
            // 
            // WorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(1003, 506);
            this.Controls.Add(this.illegal_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn8);
            this.Name = "WorkForm";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button illegal_btn;
    }
}