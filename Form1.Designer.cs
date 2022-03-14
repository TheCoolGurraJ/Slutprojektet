namespace Slutprojektet
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
            this.Work_btn = new System.Windows.Forms.Button();
            this.Sova_btn = new System.Windows.Forms.Button();
            this.Shop_btn = new System.Windows.Forms.Button();
            this.Inv_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.HeatLbl = new System.Windows.Forms.Label();
            this.HeatActual = new System.Windows.Forms.Label();
            this.Desc_Lbl = new System.Windows.Forms.Label();
            this.ClockLbl = new System.Windows.Forms.Label();
            this.ClockActual = new System.Windows.Forms.Label();
            this.MoneyLbl = new System.Windows.Forms.Label();
            this.MoneyActual = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Work_btn
            // 
            this.Work_btn.BackColor = System.Drawing.Color.Silver;
            this.Work_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Work_btn.Location = new System.Drawing.Point(12, 152);
            this.Work_btn.Name = "Work_btn";
            this.Work_btn.Size = new System.Drawing.Size(170, 72);
            this.Work_btn.TabIndex = 0;
            this.Work_btn.Text = "Work";
            this.Work_btn.UseVisualStyleBackColor = false;
            this.Work_btn.Click += new System.EventHandler(this.ActionBtn_Click);
            // 
            // Sova_btn
            // 
            this.Sova_btn.BackColor = System.Drawing.Color.Silver;
            this.Sova_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sova_btn.Location = new System.Drawing.Point(12, 386);
            this.Sova_btn.Name = "Sova_btn";
            this.Sova_btn.Size = new System.Drawing.Size(170, 72);
            this.Sova_btn.TabIndex = 1;
            this.Sova_btn.Text = "Sleep";
            this.Sova_btn.UseVisualStyleBackColor = false;
            this.Sova_btn.Click += new System.EventHandler(this.ActionBtn_Click);
            // 
            // Shop_btn
            // 
            this.Shop_btn.BackColor = System.Drawing.Color.Silver;
            this.Shop_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shop_btn.Location = new System.Drawing.Point(12, 230);
            this.Shop_btn.Name = "Shop_btn";
            this.Shop_btn.Size = new System.Drawing.Size(170, 72);
            this.Shop_btn.TabIndex = 2;
            this.Shop_btn.Text = "Shop";
            this.Shop_btn.UseVisualStyleBackColor = false;
            this.Shop_btn.Click += new System.EventHandler(this.ActionBtn_Click);
            // 
            // Inv_btn
            // 
            this.Inv_btn.BackColor = System.Drawing.Color.Silver;
            this.Inv_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inv_btn.Location = new System.Drawing.Point(12, 308);
            this.Inv_btn.Name = "Inv_btn";
            this.Inv_btn.Size = new System.Drawing.Size(170, 72);
            this.Inv_btn.TabIndex = 3;
            this.Inv_btn.Text = "Inventory";
            this.Inv_btn.UseVisualStyleBackColor = false;
            this.Inv_btn.Click += new System.EventHandler(this.ActionBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 120);
            this.label1.MinimumSize = new System.Drawing.Size(100, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Event Box";
            // 
            // HeatLbl
            // 
            this.HeatLbl.AutoSize = true;
            this.HeatLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeatLbl.Location = new System.Drawing.Point(12, 18);
            this.HeatLbl.MinimumSize = new System.Drawing.Size(25, 20);
            this.HeatLbl.Name = "HeatLbl";
            this.HeatLbl.Size = new System.Drawing.Size(74, 32);
            this.HeatLbl.TabIndex = 6;
            this.HeatLbl.Text = "Heat:";
            // 
            // HeatActual
            // 
            this.HeatActual.AutoSize = true;
            this.HeatActual.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeatActual.Location = new System.Drawing.Point(92, 18);
            this.HeatActual.MinimumSize = new System.Drawing.Size(50, 20);
            this.HeatActual.Name = "HeatActual";
            this.HeatActual.Size = new System.Drawing.Size(50, 32);
            this.HeatActual.TabIndex = 7;
            this.HeatActual.Text = "0%";
            // 
            // Desc_Lbl
            // 
            this.Desc_Lbl.AutoSize = true;
            this.Desc_Lbl.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Desc_Lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Desc_Lbl.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desc_Lbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Desc_Lbl.Location = new System.Drawing.Point(364, 152);
            this.Desc_Lbl.MinimumSize = new System.Drawing.Size(600, 300);
            this.Desc_Lbl.Name = "Desc_Lbl";
            this.Desc_Lbl.Size = new System.Drawing.Size(600, 300);
            this.Desc_Lbl.TabIndex = 4;
            // 
            // ClockLbl
            // 
            this.ClockLbl.AutoSize = true;
            this.ClockLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockLbl.Location = new System.Drawing.Point(208, 18);
            this.ClockLbl.MinimumSize = new System.Drawing.Size(25, 20);
            this.ClockLbl.Name = "ClockLbl";
            this.ClockLbl.Size = new System.Drawing.Size(74, 32);
            this.ClockLbl.TabIndex = 8;
            this.ClockLbl.Text = "Time:";
            // 
            // ClockActual
            // 
            this.ClockActual.AutoSize = true;
            this.ClockActual.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockActual.Location = new System.Drawing.Point(288, 18);
            this.ClockActual.MinimumSize = new System.Drawing.Size(50, 20);
            this.ClockActual.Name = "ClockActual";
            this.ClockActual.Size = new System.Drawing.Size(73, 32);
            this.ClockActual.TabIndex = 9;
            this.ClockActual.Text = "00:00";
            // 
            // MoneyLbl
            // 
            this.MoneyLbl.AutoSize = true;
            this.MoneyLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoneyLbl.Location = new System.Drawing.Point(409, 18);
            this.MoneyLbl.MinimumSize = new System.Drawing.Size(25, 20);
            this.MoneyLbl.Name = "MoneyLbl";
            this.MoneyLbl.Size = new System.Drawing.Size(96, 32);
            this.MoneyLbl.TabIndex = 10;
            this.MoneyLbl.Text = "Money:";
            // 
            // MoneyActual
            // 
            this.MoneyActual.AutoSize = true;
            this.MoneyActual.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoneyActual.Location = new System.Drawing.Point(511, 18);
            this.MoneyActual.MinimumSize = new System.Drawing.Size(50, 20);
            this.MoneyActual.Name = "MoneyActual";
            this.MoneyActual.Size = new System.Drawing.Size(50, 32);
            this.MoneyActual.TabIndex = 11;
            this.MoneyActual.Text = "0$";
            this.MoneyActual.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 613);
            this.Controls.Add(this.MoneyActual);
            this.Controls.Add(this.MoneyLbl);
            this.Controls.Add(this.ClockActual);
            this.Controls.Add(this.ClockLbl);
            this.Controls.Add(this.HeatActual);
            this.Controls.Add(this.HeatLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Desc_Lbl);
            this.Controls.Add(this.Inv_btn);
            this.Controls.Add(this.Shop_btn);
            this.Controls.Add(this.Sova_btn);
            this.Controls.Add(this.Work_btn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Work_btn;
        private System.Windows.Forms.Button Sova_btn;
        private System.Windows.Forms.Button Shop_btn;
        private System.Windows.Forms.Button Inv_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label HeatLbl;
        private System.Windows.Forms.Label HeatActual;
        private System.Windows.Forms.Label Desc_Lbl;
        private System.Windows.Forms.Label ClockLbl;
        private System.Windows.Forms.Label ClockActual;
        private System.Windows.Forms.Label MoneyLbl;
        private System.Windows.Forms.Label MoneyActual;
    }
}

