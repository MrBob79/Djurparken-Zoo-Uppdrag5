namespace Djurparken_Zoo_Uppdrag5
{
    partial class Keeper
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
            lblWelcome = new Label();
            lblAgenda = new Label();
            btnRegister = new Button();
            btnFeed = new Button();
            btnHandle = new Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = SystemColors.Control;
            lblWelcome.Location = new Point(72, 45);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(132, 15);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Välkommen djurskötare";
            // 
            // lblAgenda
            // 
            lblAgenda.AutoSize = true;
            lblAgenda.BackColor = SystemColors.Control;
            lblAgenda.Location = new Point(72, 80);
            lblAgenda.Name = "lblAgenda";
            lblAgenda.Size = new Size(157, 15);
            lblAgenda.TabIndex = 1;
            lblAgenda.Text = "Vad står på din agenda idag?";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = SystemColors.Control;
            btnRegister.Location = new Point(34, 151);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(88, 64);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Registrera nya djur";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnTempReg;
            // 
            // btnFeed
            // 
            btnFeed.BackColor = SystemColors.Control;
            btnFeed.Location = new Point(128, 151);
            btnFeed.Name = "btnFeed";
            btnFeed.Size = new Size(88, 64);
            btnFeed.TabIndex = 3;
            btnFeed.Text = "Mata djuren";
            btnFeed.UseVisualStyleBackColor = false;
            btnFeed.Click += btnTenpFeed;
            // 
            // btnHandle
            // 
            btnHandle.BackColor = SystemColors.Control;
            btnHandle.Location = new Point(222, 151);
            btnHandle.Name = "btnHandle";
            btnHandle.Size = new Size(88, 64);
            btnHandle.TabIndex = 4;
            btnHandle.Text = "Hantera djuren";
            btnHandle.UseVisualStyleBackColor = false;
            btnHandle.Click += btnTempHandle;
            // 
            // Keeper
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(467, 402);
            Controls.Add(btnHandle);
            Controls.Add(btnFeed);
            Controls.Add(btnRegister);
            Controls.Add(lblAgenda);
            Controls.Add(lblWelcome);
            Name = "Keeper";
            Text = "Djurskötare";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Label lblAgenda;
        private Button btnRegister;
        private Button btnFeed;
        private Button btnHandle;
    }
}