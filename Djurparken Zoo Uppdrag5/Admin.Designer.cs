namespace Djurparken_Zoo_Uppdrag5
{
    partial class Admin
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
            label1 = new Label();
            label2 = new Label();
            btnChangeHour = new Button();
            btnChangePrice = new Button();
            btnStatics = new Button();
            txtBoxAdmin = new TextBox();
            txtBoxPrice = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(87, 31);
            label1.Name = "label1";
            label1.Size = new Size(143, 15);
            label1.TabIndex = 0;
            label1.Text = "Välkommen Adminstratör";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(87, 64);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 1;
            label2.Text = "Vad vill du göra idag?";
            // 
            // btnChangeHour
            // 
            btnChangeHour.BackColor = SystemColors.ActiveCaptionText;
            btnChangeHour.ForeColor = SystemColors.Control;
            btnChangeHour.Location = new Point(23, 136);
            btnChangeHour.Name = "btnChangeHour";
            btnChangeHour.Size = new Size(83, 65);
            btnChangeHour.TabIndex = 2;
            btnChangeHour.Text = "Ändra öppettider";
            btnChangeHour.UseVisualStyleBackColor = false;
            btnChangeHour.Click += btnTempHour;
            // 
            // btnChangePrice
            // 
            btnChangePrice.BackColor = SystemColors.ActiveCaptionText;
            btnChangePrice.ForeColor = SystemColors.Control;
            btnChangePrice.Location = new Point(112, 136);
            btnChangePrice.Name = "btnChangePrice";
            btnChangePrice.Size = new Size(83, 65);
            btnChangePrice.TabIndex = 3;
            btnChangePrice.Text = "Ändra biljettpris";
            btnChangePrice.UseVisualStyleBackColor = false;
            btnChangePrice.Click += btnTempPrice;
            // 
            // btnStatics
            // 
            btnStatics.BackColor = SystemColors.ActiveCaptionText;
            btnStatics.ForeColor = SystemColors.Control;
            btnStatics.Location = new Point(201, 136);
            btnStatics.Name = "btnStatics";
            btnStatics.Size = new Size(83, 65);
            btnStatics.TabIndex = 4;
            btnStatics.Text = "Se info om djuren";
            btnStatics.UseVisualStyleBackColor = false;
            btnStatics.Click += btnStatics_Click;
            // 
            // txtBoxAdmin
            // 
            txtBoxAdmin.Location = new Point(23, 227);
            txtBoxAdmin.Multiline = true;
            txtBoxAdmin.Name = "txtBoxAdmin";
            txtBoxAdmin.Size = new Size(83, 143);
            txtBoxAdmin.TabIndex = 5;
            // 
            // txtBoxPrice
            // 
            txtBoxPrice.Location = new Point(112, 227);
            txtBoxPrice.Multiline = true;
            txtBoxPrice.Name = "txtBoxPrice";
            txtBoxPrice.Size = new Size(83, 143);
            txtBoxPrice.TabIndex = 6;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(467, 402);
            Controls.Add(txtBoxPrice);
            Controls.Add(txtBoxAdmin);
            Controls.Add(btnStatics);
            Controls.Add(btnChangePrice);
            Controls.Add(btnChangeHour);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Admin";
            Text = "Administratör";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnChangeHour;
        private Button btnChangePrice;
        private Button btnStatics;
        private TextBox txtBoxAdmin;
        private TextBox txtBoxPrice;
    }
}