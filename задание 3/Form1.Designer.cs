namespace задание_3
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
            registrationButton = new Button();
            label1 = new Label();
            loginBox = new TextBox();
            passBox = new TextBox();
            label2 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // registrationButton
            // 
            registrationButton.BackColor = Color.FromArgb(12, 117, 116);
            registrationButton.Cursor = Cursors.Hand;
            registrationButton.FlatStyle = FlatStyle.Flat;
            registrationButton.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            registrationButton.Location = new Point(8, 203);
            registrationButton.Name = "registrationButton";
            registrationButton.Size = new Size(126, 39);
            registrationButton.TabIndex = 0;
            registrationButton.Text = "регистрация";
            registrationButton.UseVisualStyleBackColor = false;
            registrationButton.Click += registrationButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(145, 13);
            label1.Name = "label1";
            label1.Size = new Size(101, 39);
            label1.TabIndex = 1;
            label1.Text = "логин";
            // 
            // loginBox
            // 
            loginBox.Location = new Point(134, 55);
            loginBox.Name = "loginBox";
            loginBox.Size = new Size(125, 27);
            loginBox.TabIndex = 2;
            // 
            // passBox
            // 
            passBox.Location = new Point(134, 134);
            passBox.Name = "passBox";
            passBox.Size = new Size(125, 27);
            passBox.TabIndex = 5;
            passBox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(145, 97);
            label2.Name = "label2";
            label2.Size = new Size(103, 34);
            label2.TabIndex = 4;
            label2.Text = "пароль";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(12, 117, 116);
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(270, 203);
            button2.Name = "button2";
            button2.Size = new Size(84, 39);
            button2.TabIndex = 3;
            button2.Text = "вход ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 162, 161);
            ClientSize = new Size(374, 267);
            Controls.Add(passBox);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(loginBox);
            Controls.Add(label1);
            Controls.Add(registrationButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button registrationButton;
        private Label label1;
        private TextBox loginBox;
        private TextBox passBox;
        private Label label2;
        private Button button2;
    }
}
