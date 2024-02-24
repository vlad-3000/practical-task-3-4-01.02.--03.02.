namespace задание_3
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
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(4, 162, 0);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 174);
            panel1.Name = "panel1";
            panel1.Size = new Size(482, 99);
            panel1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(6, 221, 0);
            label2.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(124, 35);
            label2.Name = "label2";
            label2.Size = new Size(222, 39);
            label2.TabIndex = 4;
            label2.Text = "Вы вошли как";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(6, 221, 0);
            label1.Font = new Font("Times New Roman", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(106, 74);
            label1.Name = "label1";
            label1.Size = new Size(262, 42);
            label1.TabIndex = 3;
            label1.Text = "Администратор";
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(6, 221, 0);
            ClientSize = new Size(482, 273);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
    }
}