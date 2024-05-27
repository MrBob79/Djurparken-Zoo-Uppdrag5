namespace Djurparken_Zoo_Uppdrag5
{
    partial class Visitor
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
            lblToDo = new Label();
            btbBuyTicket = new Button();
            btnLookAnimal = new Button();
            btbFeedAnimal = new Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = SystemColors.Highlight;
            lblWelcome.ForeColor = SystemColors.Control;
            lblWelcome.Location = new Point(57, 37);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(129, 15);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Välkommen besökare!  ";
            // 
            // lblToDo
            // 
            lblToDo.AutoSize = true;
            lblToDo.BackColor = SystemColors.Highlight;
            lblToDo.ForeColor = SystemColors.Control;
            lblToDo.Location = new Point(57, 78);
            lblToDo.Name = "lblToDo";
            lblToDo.Size = new Size(125, 15);
            lblToDo.TabIndex = 1;
            lblToDo.Text = "Vad vill du göra idag?  ";
            // 
            // btbBuyTicket
            // 
            btbBuyTicket.BackColor = SystemColors.Highlight;
            btbBuyTicket.ForeColor = SystemColors.Control;
            btbBuyTicket.Location = new Point(12, 131);
            btbBuyTicket.Name = "btbBuyTicket";
            btbBuyTicket.Size = new Size(81, 59);
            btbBuyTicket.TabIndex = 2;
            btbBuyTicket.Text = "Köpa biljett";
            btbBuyTicket.UseVisualStyleBackColor = false;
            btbBuyTicket.Click += btnBuyTicket_Click;
            // 
            // btnLookAnimal
            // 
            btnLookAnimal.BackColor = SystemColors.Highlight;
            btnLookAnimal.ForeColor = SystemColors.Control;
            btnLookAnimal.Location = new Point(99, 131);
            btnLookAnimal.Name = "btnLookAnimal";
            btnLookAnimal.Size = new Size(81, 59);
            btnLookAnimal.TabIndex = 3;
            btnLookAnimal.Text = "Titta på djuren";
            btnLookAnimal.UseVisualStyleBackColor = false;
            btnLookAnimal.Click += btnLookAnimal_Click;
            // 
            // btbFeedAnimal
            // 
            btbFeedAnimal.BackColor = SystemColors.Highlight;
            btbFeedAnimal.ForeColor = SystemColors.Control;
            btbFeedAnimal.Location = new Point(186, 131);
            btbFeedAnimal.Name = "btbFeedAnimal";
            btbFeedAnimal.Size = new Size(81, 59);
            btbFeedAnimal.TabIndex = 4;
            btbFeedAnimal.Text = "Mata djuren";
            btbFeedAnimal.UseVisualStyleBackColor = false;
            btbFeedAnimal.Click += btnFeedAnimal_Click;
            // 
            // Visitor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(467, 402);
            Controls.Add(btbFeedAnimal);
            Controls.Add(btnLookAnimal);
            Controls.Add(btbBuyTicket);
            Controls.Add(lblToDo);
            Controls.Add(lblWelcome);
            Name = "Visitor";
            Text = "Besökare";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Label lblToDo;
        private Button btbBuyTicket;
        private Button btnLookAnimal;
        private Button btbFeedAnimal;
    }
}