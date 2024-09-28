namespace Anzult_Win_UI
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            UserRegistrationPanel1 = new Panel();
            UserRegistrationPanel2 = new Panel();
            UserRegistrationGroupBox1 = new GroupBox();
            LoginRedirectLinkLabel = new LinkLabel();
            RegisterButton = new Button();
            UserRoleComboBox = new ComboBox();
            UserRoleLabel = new Label();
            PasswordTextBox = new TextBox();
            UserPaswordLabel = new Label();
            UsernameTextBox = new TextBox();
            UserNameLabel = new Label();
            UserLastNameTextBox = new TextBox();
            UserLastNameLabel = new Label();
            UserFirstNameTextBox1 = new TextBox();
            UserFirstNameLabel = new Label();
            UserRegistrationPanel2.SuspendLayout();
            UserRegistrationGroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // UserRegistrationPanel1
            // 
            UserRegistrationPanel1.BackColor = Color.FloralWhite;
            UserRegistrationPanel1.BackgroundImage = (Image)resources.GetObject("UserRegistrationPanel1.BackgroundImage");
            UserRegistrationPanel1.BackgroundImageLayout = ImageLayout.Zoom;
            UserRegistrationPanel1.Location = new Point(-2, 0);
            UserRegistrationPanel1.Name = "UserRegistrationPanel1";
            UserRegistrationPanel1.Size = new Size(377, 446);
            UserRegistrationPanel1.TabIndex = 0;
            // 
            // UserRegistrationPanel2
            // 
            UserRegistrationPanel2.BackColor = Color.FromArgb(0, 165, 79);
            UserRegistrationPanel2.Controls.Add(UserRegistrationGroupBox1);
            UserRegistrationPanel2.ForeColor = Color.FloralWhite;
            UserRegistrationPanel2.Location = new Point(371, 0);
            UserRegistrationPanel2.Name = "UserRegistrationPanel2";
            UserRegistrationPanel2.Size = new Size(380, 446);
            UserRegistrationPanel2.TabIndex = 1;
            // 
            // UserRegistrationGroupBox1
            // 
            UserRegistrationGroupBox1.BackColor = Color.FromArgb(0, 165, 79);
            UserRegistrationGroupBox1.Controls.Add(LoginRedirectLinkLabel);
            UserRegistrationGroupBox1.Controls.Add(RegisterButton);
            UserRegistrationGroupBox1.Controls.Add(UserRoleComboBox);
            UserRegistrationGroupBox1.Controls.Add(UserRoleLabel);
            UserRegistrationGroupBox1.Controls.Add(PasswordTextBox);
            UserRegistrationGroupBox1.Controls.Add(UserPaswordLabel);
            UserRegistrationGroupBox1.Controls.Add(UsernameTextBox);
            UserRegistrationGroupBox1.Controls.Add(UserNameLabel);
            UserRegistrationGroupBox1.Controls.Add(UserLastNameTextBox);
            UserRegistrationGroupBox1.Controls.Add(UserLastNameLabel);
            UserRegistrationGroupBox1.Controls.Add(UserFirstNameTextBox1);
            UserRegistrationGroupBox1.Controls.Add(UserFirstNameLabel);
            UserRegistrationGroupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserRegistrationGroupBox1.ForeColor = Color.FloralWhite;
            UserRegistrationGroupBox1.Location = new Point(31, 21);
            UserRegistrationGroupBox1.Name = "UserRegistrationGroupBox1";
            UserRegistrationGroupBox1.Size = new Size(314, 398);
            UserRegistrationGroupBox1.TabIndex = 0;
            UserRegistrationGroupBox1.TabStop = false;
            UserRegistrationGroupBox1.Text = "User Registration";
            UserRegistrationGroupBox1.Enter += UserRegistrationGroupBox1_Enter;
            // 
            // LoginRedirectLinkLabel
            // 
            LoginRedirectLinkLabel.ActiveLinkColor = Color.FloralWhite;
            LoginRedirectLinkLabel.AutoSize = true;
            LoginRedirectLinkLabel.LinkBehavior = LinkBehavior.NeverUnderline;
            LoginRedirectLinkLabel.LinkColor = Color.FloralWhite;
            LoginRedirectLinkLabel.Location = new Point(15, 351);
            LoginRedirectLinkLabel.Name = "LoginRedirectLinkLabel";
            LoginRedirectLinkLabel.Size = new Size(105, 21);
            LoginRedirectLinkLabel.TabIndex = 11;
            LoginRedirectLinkLabel.TabStop = true;
            LoginRedirectLinkLabel.Text = "Back to login";
            // 
            // RegisterButton
            // 
            RegisterButton.BackColor = Color.FromArgb(238, 29, 35);
            RegisterButton.FlatAppearance.BorderColor = Color.Red;
            RegisterButton.FlatAppearance.BorderSize = 0;
            RegisterButton.FlatStyle = FlatStyle.Flat;
            RegisterButton.Location = new Point(175, 343);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(109, 29);
            RegisterButton.TabIndex = 10;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = false;
            // 
            // UserRoleComboBox
            // 
            UserRoleComboBox.FormattingEnabled = true;
            UserRoleComboBox.Items.AddRange(new object[] { "Admin", "Teacher" });
            UserRoleComboBox.Location = new Point(15, 292);
            UserRoleComboBox.Name = "UserRoleComboBox";
            UserRoleComboBox.Size = new Size(269, 29);
            UserRoleComboBox.TabIndex = 9;
            // 
            // UserRoleLabel
            // 
            UserRoleLabel.AutoSize = true;
            UserRoleLabel.Location = new Point(15, 268);
            UserRoleLabel.Name = "UserRoleLabel";
            UserRoleLabel.Size = new Size(43, 21);
            UserRoleLabel.TabIndex = 8;
            UserRoleLabel.Text = "Role";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(15, 236);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(269, 29);
            PasswordTextBox.TabIndex = 7;
            // 
            // UserPaswordLabel
            // 
            UserPaswordLabel.AutoSize = true;
            UserPaswordLabel.Location = new Point(15, 212);
            UserPaswordLabel.Name = "UserPaswordLabel";
            UserPaswordLabel.Size = new Size(79, 21);
            UserPaswordLabel.TabIndex = 6;
            UserPaswordLabel.Text = "Password";
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Location = new Point(15, 180);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(269, 29);
            UsernameTextBox.TabIndex = 5;
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Location = new Point(15, 156);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(83, 21);
            UserNameLabel.TabIndex = 4;
            UserNameLabel.Text = "Username";
            // 
            // UserLastNameTextBox
            // 
            UserLastNameTextBox.Location = new Point(15, 124);
            UserLastNameTextBox.Name = "UserLastNameTextBox";
            UserLastNameTextBox.Size = new Size(269, 29);
            UserLastNameTextBox.TabIndex = 3;
            // 
            // UserLastNameLabel
            // 
            UserLastNameLabel.AutoSize = true;
            UserLastNameLabel.Location = new Point(15, 100);
            UserLastNameLabel.Name = "UserLastNameLabel";
            UserLastNameLabel.Size = new Size(86, 21);
            UserLastNameLabel.TabIndex = 2;
            UserLastNameLabel.Text = "Last Name";
            // 
            // UserFirstNameTextBox1
            // 
            UserFirstNameTextBox1.Location = new Point(15, 68);
            UserFirstNameTextBox1.Name = "UserFirstNameTextBox1";
            UserFirstNameTextBox1.Size = new Size(269, 29);
            UserFirstNameTextBox1.TabIndex = 1;
            // 
            // UserFirstNameLabel
            // 
            UserFirstNameLabel.AutoSize = true;
            UserFirstNameLabel.Location = new Point(15, 44);
            UserFirstNameLabel.Name = "UserFirstNameLabel";
            UserFirstNameLabel.Size = new Size(88, 21);
            UserFirstNameLabel.TabIndex = 0;
            UserFirstNameLabel.Text = "First Name";
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(751, 446);
            Controls.Add(UserRegistrationPanel2);
            Controls.Add(UserRegistrationPanel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Registration";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
            Load += Registration_Load;
            UserRegistrationPanel2.ResumeLayout(false);
            UserRegistrationGroupBox1.ResumeLayout(false);
            UserRegistrationGroupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel UserRegistrationPanel1;
        private Panel UserRegistrationPanel2;
        private GroupBox UserRegistrationGroupBox1;
        private TextBox UserFirstNameTextBox1;
        private Label UserFirstNameLabel;
        private TextBox PasswordTextBox;
        private Label UserPaswordLabel;
        private TextBox UsernameTextBox;
        private Label UserNameLabel;
        private TextBox UserLastNameTextBox;
        private Label UserLastNameLabel;
        private Label UserRoleLabel;
        private ComboBox UserRoleComboBox;
        private Button RegisterButton;
        private LinkLabel LoginRedirectLinkLabel;
    }
}