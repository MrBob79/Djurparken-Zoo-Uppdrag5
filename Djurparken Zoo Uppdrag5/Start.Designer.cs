namespace Djurparken_Zoo_Uppdrag5
{
    partial class Start
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            btnVisitor = new Button();
            btnKeeper = new Button();
            btnAdmin = new Button();
            lblOpeningTime = new Label();
            lblTicket = new Label();
            txtOpeningTime = new TextBox();
            txtTicket = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Location = new Point(120, 25);
            label1.Name = "label1";
            label1.Size = new Size(200, 15);
            label1.TabIndex = 0;
            label1.Text = "Hej och Välkommen till vår Djurpark!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Location = new Point(120, 224);
            label2.Name = "label2";
            label2.Size = new Size(182, 15);
            label2.TabIndex = 1;
            label2.Text = "Här väljer du vem du agerar som!";
            // 
            // btnVisitor
            // 
            btnVisitor.Location = new Point(12, 265);
            btnVisitor.Name = "btnVisitor";
            btnVisitor.Size = new Size(133, 79);
            btnVisitor.TabIndex = 2;
            btnVisitor.Text = "Besökare";
            btnVisitor.UseVisualStyleBackColor = true;
            btnVisitor.Click += btnVisitor_Click;
            // 
            // btnKeeper
            // 
            btnKeeper.Location = new Point(160, 265);
            btnKeeper.Name = "btnKeeper";
            btnKeeper.Size = new Size(133, 79);
            btnKeeper.TabIndex = 3;
            btnKeeper.Text = "Djurskötare";
            btnKeeper.UseVisualStyleBackColor = true;
            btnKeeper.Click += btnKeeper_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.Location = new Point(309, 265);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(133, 79);
            btnAdmin.TabIndex = 4;
            btnAdmin.Text = "Administratör";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // lblOpeningTime
            // 
            lblOpeningTime.AutoSize = true;
            lblOpeningTime.BackColor = SystemColors.Control;
            lblOpeningTime.Location = new Point(72, 66);
            lblOpeningTime.Name = "lblOpeningTime";
            lblOpeningTime.Size = new Size(73, 15);
            lblOpeningTime.TabIndex = 5;
            lblOpeningTime.Text = "Öppettider:  ";
            // 
            // lblTicket
            // 
            lblTicket.AutoSize = true;
            lblTicket.BackColor = SystemColors.Control;
            lblTicket.Location = new Point(265, 66);
            lblTicket.Name = "lblTicket";
            lblTicket.Size = new Size(75, 15);
            lblTicket.TabIndex = 6;
            lblTicket.Text = "Biljettpriser:  ";
            // 
            // txtOpeningTime
            // 
            txtOpeningTime.Location = new Point(29, 84);
            txtOpeningTime.Multiline = true;
            txtOpeningTime.Name = "txtOpeningTime";
            txtOpeningTime.Size = new Size(165, 119);
            txtOpeningTime.TabIndex = 7;
            // 
            // txtTicket
            // 
            txtTicket.Location = new Point(234, 84);
            txtTicket.Multiline = true;
            txtTicket.Name = "txtTicket";
            txtTicket.Size = new Size(208, 119);
            txtTicket.TabIndex = 8;
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(468, 548);
            Controls.Add(txtTicket);
            Controls.Add(txtOpeningTime);
            Controls.Add(lblTicket);
            Controls.Add(lblOpeningTime);
            Controls.Add(btnAdmin);
            Controls.Add(btnKeeper);
            Controls.Add(btnVisitor);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Start";
            Text = "Välkommen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblOpeningTime;
        private Label lblTicket;
        public Button btnVisitor;
        public Button btnKeeper;
        public TextBox txtOpeningTime;
        public TextBox txtTicket;
        public Button btnAdmin;
    }
}
