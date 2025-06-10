namespace EducationSystemApp
{
    partial class MainMenu
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
        private void InitializeComponent() {
            ListViewGroup listViewGroup2 = new ListViewGroup("Profiles", HorizontalAlignment.Left);
            ProfileView = new ListView();
            viewprofilebutton = new Button();
            CreateProfileButton = new Button();
            hideprofilebutton = new Button();
            NameType = new TextBox();
            NameBox = new Label();
            DisplayCreate = new Label();
            ConfirmCreation = new Button();
            CreationHide = new Button();
            ProfileName = new Label();
            SelectedProfile = new Label();
            ProfileHide = new Button();
            compareProfilesButton = new Button();
            profileStatTitles = new Label();
            profileStats = new Label();
            profilePanel = new Panel();
            mathsQuizButton = new Button();
            memoryTestButton = new Button();
            wordQuestionsButton = new Button();
            speedTestButton = new Button();
            profilePanel.SuspendLayout();
            SuspendLayout();
            // 
            // ProfileView
            // 
            ProfileView.Activation = ItemActivation.OneClick;
            ProfileView.Alignment = ListViewAlignment.Default;
            ProfileView.BackColor = SystemColors.Info;
            ProfileView.GridLines = true;
            listViewGroup2.Header = "Profiles";
            listViewGroup2.Name = "profile";
            listViewGroup2.Tag = "profile";
            ProfileView.Groups.AddRange(new ListViewGroup[] { listViewGroup2 });
            ProfileView.HotTracking = true;
            ProfileView.HoverSelection = true;
            ProfileView.ImeMode = ImeMode.Off;
            ProfileView.Location = new Point(328, 12);
            ProfileView.Name = "ProfileView";
            ProfileView.Size = new Size(926, 657);
            ProfileView.Sorting = SortOrder.Descending;
            ProfileView.TabIndex = 0;
            ProfileView.TileSize = new Size(15, 15);
            ProfileView.UseCompatibleStateImageBehavior = false;
            ProfileView.View = View.List;
            ProfileView.Visible = false;
            ProfileView.SelectedIndexChanged += ProfileView_SelectedIndexChanged;
            // 
            // viewprofilebutton
            // 
            viewprofilebutton.Location = new Point(12, 12);
            viewprofilebutton.Name = "viewprofilebutton";
            viewprofilebutton.Size = new Size(267, 25);
            viewprofilebutton.TabIndex = 1;
            viewprofilebutton.Text = "View Profiles";
            viewprofilebutton.UseVisualStyleBackColor = true;
            viewprofilebutton.Click += viewprofilebutton_Click;
            // 
            // CreateProfileButton
            // 
            CreateProfileButton.Location = new Point(12, 75);
            CreateProfileButton.Name = "CreateProfileButton";
            CreateProfileButton.Size = new Size(267, 24);
            CreateProfileButton.TabIndex = 2;
            CreateProfileButton.Text = "Create a profile";
            CreateProfileButton.UseVisualStyleBackColor = true;
            CreateProfileButton.Visible = false;
            CreateProfileButton.Click += CreateProfileButton_Click;
            // 
            // hideprofilebutton
            // 
            hideprofilebutton.Location = new Point(12, 43);
            hideprofilebutton.Name = "hideprofilebutton";
            hideprofilebutton.Size = new Size(267, 26);
            hideprofilebutton.TabIndex = 3;
            hideprofilebutton.Text = "Hide Profiles";
            hideprofilebutton.UseVisualStyleBackColor = true;
            hideprofilebutton.Visible = false;
            hideprofilebutton.Click += hideprofilebutton_Click;
            // 
            // NameType
            // 
            NameType.Location = new Point(97, 153);
            NameType.Name = "NameType";
            NameType.PlaceholderText = "Enter Name...";
            NameType.Size = new Size(140, 23);
            NameType.TabIndex = 4;
            NameType.Visible = false;
            // 
            // NameBox
            // 
            NameBox.AutoSize = true;
            NameBox.Location = new Point(49, 153);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(42, 15);
            NameBox.TabIndex = 5;
            NameBox.Text = "Name:";
            NameBox.Visible = false;
            // 
            // DisplayCreate
            // 
            DisplayCreate.AutoSize = true;
            DisplayCreate.Location = new Point(49, 129);
            DisplayCreate.Name = "DisplayCreate";
            DisplayCreate.Size = new Size(83, 15);
            DisplayCreate.TabIndex = 6;
            DisplayCreate.Text = "Profile Creator";
            DisplayCreate.Visible = false;
            // 
            // ConfirmCreation
            // 
            ConfirmCreation.Location = new Point(49, 182);
            ConfirmCreation.Name = "ConfirmCreation";
            ConfirmCreation.Size = new Size(188, 21);
            ConfirmCreation.TabIndex = 7;
            ConfirmCreation.Text = "Create Profile";
            ConfirmCreation.UseVisualStyleBackColor = true;
            ConfirmCreation.Visible = false;
            ConfirmCreation.Click += ConfirmCreation_Click;
            // 
            // CreationHide
            // 
            CreationHide.Location = new Point(12, 105);
            CreationHide.Name = "CreationHide";
            CreationHide.Size = new Size(267, 21);
            CreationHide.TabIndex = 8;
            CreationHide.Text = "Hide Creator";
            CreationHide.UseVisualStyleBackColor = true;
            CreationHide.Visible = false;
            CreationHide.Click += CreationHide_Click;
            // 
            // ProfileName
            // 
            ProfileName.AutoSize = true;
            ProfileName.Location = new Point(80, 2);
            ProfileName.Name = "ProfileName";
            ProfileName.Size = new Size(44, 15);
            ProfileName.TabIndex = 9;
            ProfileName.Text = "Profile:";
            // 
            // SelectedProfile
            // 
            SelectedProfile.AutoSize = true;
            SelectedProfile.Location = new Point(124, 2);
            SelectedProfile.Name = "SelectedProfile";
            SelectedProfile.Size = new Size(48, 15);
            SelectedProfile.TabIndex = 10;
            SelectedProfile.Text = "Name...";
            // 
            // ProfileHide
            // 
            ProfileHide.Location = new Point(12, 209);
            ProfileHide.Name = "ProfileHide";
            ProfileHide.Size = new Size(267, 23);
            ProfileHide.TabIndex = 13;
            ProfileHide.Text = "Hide Selected Profile";
            ProfileHide.UseVisualStyleBackColor = true;
            ProfileHide.Visible = false;
            ProfileHide.Click += ProfileHide_Click;
            // 
            // compareProfilesButton
            // 
            compareProfilesButton.Location = new Point(0, 97);
            compareProfilesButton.Name = "compareProfilesButton";
            compareProfilesButton.Size = new Size(267, 25);
            compareProfilesButton.TabIndex = 14;
            compareProfilesButton.Text = "Compare Profiles";
            compareProfilesButton.UseVisualStyleBackColor = true;
            compareProfilesButton.Click += compareProfilesButton_Click;
            // 
            // profileStatTitles
            // 
            profileStatTitles.AutoSize = true;
            profileStatTitles.Location = new Point(3, 19);
            profileStatTitles.Name = "profileStatTitles";
            profileStatTitles.Size = new Size(121, 75);
            profileStatTitles.TabIndex = 15;
            profileStatTitles.Text = "Math Score:\r\nMemory Score:\r\nWord Score:\r\nTotal Score:\r\nAverage Speed Time: ";
            profileStatTitles.TextAlign = ContentAlignment.TopRight;
            // 
            // profileStats
            // 
            profileStats.AutoSize = true;
            profileStats.Location = new Point(124, 19);
            profileStats.Name = "profileStats";
            profileStats.Size = new Size(13, 75);
            profileStats.TabIndex = 16;
            profileStats.Text = "1\r\n2\r\n3\r\n4\r\n5";
            // 
            // profilePanel
            // 
            profilePanel.Controls.Add(speedTestButton);
            profilePanel.Controls.Add(wordQuestionsButton);
            profilePanel.Controls.Add(memoryTestButton);
            profilePanel.Controls.Add(mathsQuizButton);
            profilePanel.Controls.Add(compareProfilesButton);
            profilePanel.Controls.Add(profileStats);
            profilePanel.Controls.Add(ProfileName);
            profilePanel.Controls.Add(profileStatTitles);
            profilePanel.Controls.Add(SelectedProfile);
            profilePanel.Location = new Point(12, 409);
            profilePanel.Name = "profilePanel";
            profilePanel.Size = new Size(267, 260);
            profilePanel.TabIndex = 17;
            profilePanel.Visible = false;
            // 
            // mathsQuizButton
            // 
            mathsQuizButton.Location = new Point(0, 139);
            mathsQuizButton.Name = "mathsQuizButton";
            mathsQuizButton.Size = new Size(267, 25);
            mathsQuizButton.TabIndex = 17;
            mathsQuizButton.Text = "Maths Quiz";
            mathsQuizButton.UseVisualStyleBackColor = true;
            mathsQuizButton.Click += mathsQuizButton_Click;
            // 
            // memoryTestButton
            // 
            memoryTestButton.Location = new Point(0, 170);
            memoryTestButton.Name = "memoryTestButton";
            memoryTestButton.Size = new Size(267, 25);
            memoryTestButton.TabIndex = 18;
            memoryTestButton.Text = "Memory Test";
            memoryTestButton.UseVisualStyleBackColor = true;
            memoryTestButton.Click += memoryTestButton_Click;
            // 
            // wordQuestionsButton
            // 
            wordQuestionsButton.Location = new Point(0, 201);
            wordQuestionsButton.Name = "wordQuestionsButton";
            wordQuestionsButton.Size = new Size(267, 25);
            wordQuestionsButton.TabIndex = 19;
            wordQuestionsButton.Text = "Word Questions";
            wordQuestionsButton.UseVisualStyleBackColor = true;
            wordQuestionsButton.Click += wordQuestionsButton_Click;
            // 
            // speedTestButton
            // 
            speedTestButton.Location = new Point(0, 232);
            speedTestButton.Name = "speedTestButton";
            speedTestButton.Size = new Size(267, 25);
            speedTestButton.TabIndex = 20;
            speedTestButton.Text = "Speed Test";
            speedTestButton.UseVisualStyleBackColor = true;
            speedTestButton.Click += speedTestButton_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(profilePanel);
            Controls.Add(ProfileHide);
            Controls.Add(CreationHide);
            Controls.Add(ConfirmCreation);
            Controls.Add(DisplayCreate);
            Controls.Add(NameBox);
            Controls.Add(NameType);
            Controls.Add(hideprofilebutton);
            Controls.Add(CreateProfileButton);
            Controls.Add(viewprofilebutton);
            Controls.Add(ProfileView);
            Name = "MainMenu";
            Text = "Form1";
            profilePanel.ResumeLayout(false);
            profilePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView ProfileView;
        private Button viewprofilebutton;
        private Button CreateProfileButton;
        private Button hideprofilebutton;
        private TextBox NameType;
        private Label NameBox;
        private Label DisplayCreate;
        private Button ConfirmCreation;
        private Button CreationHide;
        private Label ProfileName;
        private Label SelectedProfile;
        private Button ProfileHide;
        private Button compareProfilesButton;
        private Label profileStatTitles;
        private Label profileStats;
        private Panel profilePanel;
        private Button speedTestButton;
        private Button wordQuestionsButton;
        private Button memoryTestButton;
        private Button mathsQuizButton;
    }
}
