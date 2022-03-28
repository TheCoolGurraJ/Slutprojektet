namespace Slutprojektet
{
    partial class ShopForm
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
            this.Pot1Btn = new System.Windows.Forms.Button();
            this.Pot2Btn = new System.Windows.Forms.Button();
            this.Strain1Btn = new System.Windows.Forms.Button();
            this.Pot3Btn = new System.Windows.Forms.Button();
            this.Strain3Btn = new System.Windows.Forms.Button();
            this.Strain2Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Pot1Btn
            // 
            this.Pot1Btn.BackColor = System.Drawing.Color.Silver;
            this.Pot1Btn.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pot1Btn.Location = new System.Drawing.Point(71, 32);
            this.Pot1Btn.Name = "Pot1Btn";
            this.Pot1Btn.Size = new System.Drawing.Size(170, 72);
            this.Pot1Btn.TabIndex = 1;
            this.Pot1Btn.Tag = "1";
            this.Pot1Btn.Text = "Pot 1";
            this.Pot1Btn.UseVisualStyleBackColor = false;
            this.Pot1Btn.Click += new System.EventHandler(this.ShopBtn_Click);
            // 
            // Pot2Btn
            // 
            this.Pot2Btn.BackColor = System.Drawing.Color.Silver;
            this.Pot2Btn.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pot2Btn.Location = new System.Drawing.Point(71, 110);
            this.Pot2Btn.Name = "Pot2Btn";
            this.Pot2Btn.Size = new System.Drawing.Size(170, 72);
            this.Pot2Btn.TabIndex = 2;
            this.Pot2Btn.Tag = "2";
            this.Pot2Btn.Text = "Pot 2";
            this.Pot2Btn.UseVisualStyleBackColor = false;
            this.Pot2Btn.Click += new System.EventHandler(this.ShopBtn_Click);
            // 
            // Strain1Btn
            // 
            this.Strain1Btn.BackColor = System.Drawing.Color.Silver;
            this.Strain1Btn.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Strain1Btn.Location = new System.Drawing.Point(71, 266);
            this.Strain1Btn.Name = "Strain1Btn";
            this.Strain1Btn.Size = new System.Drawing.Size(170, 72);
            this.Strain1Btn.TabIndex = 4;
            this.Strain1Btn.Tag = "4";
            this.Strain1Btn.Text = "Strain 1";
            this.Strain1Btn.UseVisualStyleBackColor = false;
            this.Strain1Btn.Click += new System.EventHandler(this.ShopBtn_Click);
            // 
            // Pot3Btn
            // 
            this.Pot3Btn.BackColor = System.Drawing.Color.Silver;
            this.Pot3Btn.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pot3Btn.Location = new System.Drawing.Point(71, 188);
            this.Pot3Btn.Name = "Pot3Btn";
            this.Pot3Btn.Size = new System.Drawing.Size(170, 72);
            this.Pot3Btn.TabIndex = 3;
            this.Pot3Btn.Tag = "3";
            this.Pot3Btn.Text = "Pot 3";
            this.Pot3Btn.UseVisualStyleBackColor = false;
            this.Pot3Btn.Click += new System.EventHandler(this.ShopBtn_Click);
            // 
            // Strain3Btn
            // 
            this.Strain3Btn.BackColor = System.Drawing.Color.Silver;
            this.Strain3Btn.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Strain3Btn.Location = new System.Drawing.Point(71, 422);
            this.Strain3Btn.Name = "Strain3Btn";
            this.Strain3Btn.Size = new System.Drawing.Size(170, 72);
            this.Strain3Btn.TabIndex = 6;
            this.Strain3Btn.Tag = "6";
            this.Strain3Btn.Text = "Strain 3";
            this.Strain3Btn.UseVisualStyleBackColor = false;
            this.Strain3Btn.Click += new System.EventHandler(this.ShopBtn_Click);
            // 
            // Strain2Btn
            // 
            this.Strain2Btn.BackColor = System.Drawing.Color.Silver;
            this.Strain2Btn.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Strain2Btn.Location = new System.Drawing.Point(71, 344);
            this.Strain2Btn.Name = "Strain2Btn";
            this.Strain2Btn.Size = new System.Drawing.Size(170, 72);
            this.Strain2Btn.TabIndex = 5;
            this.Strain2Btn.Tag = "5";
            this.Strain2Btn.Text = "Strain 2";
            this.Strain2Btn.UseVisualStyleBackColor = false;
            this.Strain2Btn.Click += new System.EventHandler(this.ShopBtn_Click);
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 537);
            this.Controls.Add(this.Strain3Btn);
            this.Controls.Add(this.Strain2Btn);
            this.Controls.Add(this.Strain1Btn);
            this.Controls.Add(this.Pot3Btn);
            this.Controls.Add(this.Pot2Btn);
            this.Controls.Add(this.Pot1Btn);
            this.Name = "ShopForm";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Pot1Btn;
        private System.Windows.Forms.Button Pot2Btn;
        private System.Windows.Forms.Button Strain1Btn;
        private System.Windows.Forms.Button Pot3Btn;
        private System.Windows.Forms.Button Strain3Btn;
        private System.Windows.Forms.Button Strain2Btn;
    }
}