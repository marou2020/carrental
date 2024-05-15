namespace carrental
{
    partial class Splash
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            guna2CircleProgressBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            Myprogress = new PictureBox();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            guna2CircleProgressBar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Myprogress).BeginInit();
            SuspendLayout();
            // 
            // guna2CircleProgressBar1
            // 
            guna2CircleProgressBar1.Controls.Add(Myprogress);
            guna2CircleProgressBar1.FillColor = Color.DarkBlue;
            guna2CircleProgressBar1.FillThickness = 8;
            guna2CircleProgressBar1.Font = new Font("Segoe UI", 12F);
            guna2CircleProgressBar1.ForeColor = SystemColors.Window;
            guna2CircleProgressBar1.Location = new Point(260, 63);
            guna2CircleProgressBar1.Minimum = 0;
            guna2CircleProgressBar1.Name = "guna2CircleProgressBar1";
            guna2CircleProgressBar1.ProgressColor = Color.White;
            guna2CircleProgressBar1.ProgressColor2 = Color.White;
            guna2CircleProgressBar1.ShadowDecoration.CustomizableEdges = customizableEdges3;
            guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleProgressBar1.Size = new Size(301, 301);
            guna2CircleProgressBar1.TabIndex = 2;
            guna2CircleProgressBar1.Text = "guna2CircleProgressBar1";
            // 
            // Myprogress
            // 
            Myprogress.Image = (Image)resources.GetObject("Myprogress.Image");
            Myprogress.Location = new Point(56, 65);
            Myprogress.Name = "Myprogress";
            Myprogress.Size = new Size(195, 161);
            Myprogress.SizeMode = PictureBoxSizeMode.Zoom;
            Myprogress.TabIndex = 3;
            Myprogress.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(316, 23);
            label1.Name = "label1";
            label1.Size = new Size(198, 28);
            label1.TabIndex = 3;
            label1.Text = "Car Rental Sytem";
            label1.Click += label1_Click;
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(guna2CircleProgressBar1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Splash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            guna2CircleProgressBar1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Myprogress).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar1;
        private PictureBox Myprogress;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}
