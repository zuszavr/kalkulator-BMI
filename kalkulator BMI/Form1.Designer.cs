namespace kalkulator_BMI
{
    partial class Form1
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
            oblicz = new Button();
            lwzrost = new Label();
            lwaga = new Label();
            lwynik = new Label();
            progressBar = new ProgressBar();
            twzrost = new TextBox();
            twaga = new TextBox();
            SuspendLayout();
            // 
            // oblicz
            // 
            oblicz.Location = new Point(32, 101);
            oblicz.Name = "oblicz";
            oblicz.Size = new Size(255, 23);
            oblicz.TabIndex = 0;
            oblicz.Text = "Oblicz BMI";
            oblicz.UseVisualStyleBackColor = true;
            oblicz.MouseClick += oblicz_MouseClick;
            // 
            // lwzrost
            // 
            lwzrost.AutoSize = true;
            lwzrost.Location = new Point(32, 44);
            lwzrost.Name = "lwzrost";
            lwzrost.Size = new Size(63, 15);
            lwzrost.TabIndex = 1;
            lwzrost.Text = "wzrost [m]";
            // 
            // lwaga
            // 
            lwaga.AutoSize = true;
            lwaga.Location = new Point(191, 44);
            lwaga.Name = "lwaga";
            lwaga.Size = new Size(59, 15);
            lwaga.TabIndex = 2;
            lwaga.Text = "waga [kg]";
            // 
            // lwynik
            // 
            lwynik.AutoSize = true;
            lwynik.Location = new Point(32, 139);
            lwynik.Name = "lwynik";
            lwynik.Size = new Size(12, 15);
            lwynik.TabIndex = 3;
            lwynik.Text = "-";
            // 
            // progressBar
            // 
            progressBar.Location = new Point(32, 169);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(255, 23);
            progressBar.TabIndex = 4;
            // 
            // twzrost
            // 
            twzrost.Location = new Point(32, 62);
            twzrost.Name = "twzrost";
            twzrost.Size = new Size(100, 23);
            twzrost.TabIndex = 5;
            // 
            // twaga
            // 
            twaga.Location = new Point(187, 62);
            twaga.Name = "twaga";
            twaga.Size = new Size(100, 23);
            twaga.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 229);
            Controls.Add(twaga);
            Controls.Add(twzrost);
            Controls.Add(progressBar);
            Controls.Add(lwynik);
            Controls.Add(lwaga);
            Controls.Add(lwzrost);
            Controls.Add(oblicz);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button oblicz;
        private Label lwzrost;
        private Label lwaga;
        private Label lwynik;
        private ProgressBar progressBar;
        private TextBox twzrost;
        private TextBox twaga;
    }
}
