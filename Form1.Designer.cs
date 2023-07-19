namespace Elevator
{
    partial class Asansor
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
            components = new System.ComponentModel.Container();
            Elevator = new Label();
            kat1 = new Label();
            kat2 = new Label();
            kat3 = new Label();
            zemin = new Label();
            k0buton = new Button();
            k1buton = new Button();
            kat2buton = new Button();
            kat3buton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // Elevator
            // 
            Elevator.BackColor = SystemColors.ControlDark;
            Elevator.Location = new Point(232, 539);
            Elevator.Name = "Elevator";
            Elevator.Size = new Size(68, 107);
            Elevator.TabIndex = 0;
            Elevator.Text = "Elevator";
            Elevator.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // kat1
            // 
            kat1.AutoSize = true;
            kat1.Location = new Point(315, 458);
            kat1.Name = "kat1";
            kat1.Size = new Size(29, 15);
            kat1.TabIndex = 1;
            kat1.Text = "kat1";
            // 
            // kat2
            // 
            kat2.AutoSize = true;
            kat2.Location = new Point(315, 286);
            kat2.Name = "kat2";
            kat2.Size = new Size(29, 15);
            kat2.TabIndex = 2;
            kat2.Text = "kat2";
            // 
            // kat3
            // 
            kat3.AutoSize = true;
            kat3.Location = new Point(306, 114);
            kat3.Name = "kat3";
            kat3.Size = new Size(29, 15);
            kat3.TabIndex = 3;
            kat3.Text = "kat3";
            // 
            // zemin
            // 
            zemin.AutoSize = true;
            zemin.Location = new Point(306, 630);
            zemin.Name = "zemin";
            zemin.Size = new Size(39, 15);
            zemin.TabIndex = 5;
            zemin.Text = "zemin";
            // 
            // k0buton
            // 
            k0buton.Location = new Point(759, 608);
            k0buton.Name = "k0buton";
            k0buton.Size = new Size(50, 23);
            k0buton.TabIndex = 6;
            k0buton.Text = "0";
            k0buton.UseVisualStyleBackColor = true;
            k0buton.Click += k0buton_Click;
            // 
            // k1buton
            // 
            k1buton.Location = new Point(703, 608);
            k1buton.Name = "k1buton";
            k1buton.Size = new Size(50, 23);
            k1buton.TabIndex = 7;
            k1buton.Text = "1";
            k1buton.UseVisualStyleBackColor = true;
            k1buton.Click += k1buton_Click;
            // 
            // kat2buton
            // 
            kat2buton.Location = new Point(759, 579);
            kat2buton.Name = "kat2buton";
            kat2buton.Size = new Size(50, 23);
            kat2buton.TabIndex = 8;
            kat2buton.Text = "2";
            kat2buton.UseVisualStyleBackColor = true;
            kat2buton.Click += kat2buton_Click;
            // 
            // kat3buton
            // 
            kat3buton.Location = new Point(703, 579);
            kat3buton.Name = "kat3buton";
            kat3buton.Size = new Size(50, 23);
            kat3buton.TabIndex = 9;
            kat3buton.Text = "3";
            kat3buton.UseVisualStyleBackColor = true;
            kat3buton.Click += kat3buton_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Asansor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 655);
            Controls.Add(kat3buton);
            Controls.Add(kat2buton);
            Controls.Add(k1buton);
            Controls.Add(k0buton);
            Controls.Add(zemin);
            Controls.Add(kat3);
            Controls.Add(kat2);
            Controls.Add(kat1);
            Controls.Add(Elevator);
            Name = "Asansor";
            Text = "Asansor";
            Load += Asansor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label Elevator;
        private Label kat1;
        private Label kat2;
        private Label kat3;
        private Label zemin;
        private Button k0buton;
        private Button k1buton;
        private Button kat2buton;
        private Button kat3buton;
        private System.Windows.Forms.Timer timer1;
    }
}