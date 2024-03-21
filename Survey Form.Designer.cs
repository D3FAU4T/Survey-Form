namespace Survey_Form
{
    partial class SurveyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SurveyForm));
            this.improveText = new System.Windows.Forms.Label();
            this.YourName = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.AgeBox = new System.Windows.Forms.NumericUpDown();
            this.Role = new System.Windows.Forms.Label();
            this.RoleSelection = new System.Windows.Forms.ComboBox();
            this.RecommendLine = new System.Windows.Forms.Label();
            this.DefinitelyRadio = new System.Windows.Forms.RadioButton();
            this.MostLikelyRadio = new System.Windows.Forms.RadioButton();
            this.NotSureRadio = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.FCCselection = new System.Windows.Forms.ComboBox();
            this.ImprovementLabel = new System.Windows.Forms.Label();
            this.FrontEndRadio = new System.Windows.Forms.RadioButton();
            this.BackEndRadio = new System.Windows.Forms.RadioButton();
            this.DataVisualizationRadio = new System.Windows.Forms.RadioButton();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ImprovementsGroup = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.AgeBox)).BeginInit();
            this.ImprovementsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // improveText
            // 
            this.improveText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.improveText.AutoSize = true;
            this.improveText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.improveText.Location = new System.Drawing.Point(216, 21);
            this.improveText.Name = "improveText";
            this.improveText.Size = new System.Drawing.Size(333, 18);
            this.improveText.TabIndex = 0;
            this.improveText.Text = "Let us know how we can improve freeCodeCamp";
            // 
            // YourName
            // 
            this.YourName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.YourName.AutoSize = true;
            this.YourName.Location = new System.Drawing.Point(224, 72);
            this.YourName.Name = "YourName";
            this.YourName.Size = new System.Drawing.Size(45, 13);
            this.YourName.TabIndex = 1;
            this.YourName.Text = "* Name:";
            // 
            // Email
            // 
            this.Email.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(224, 106);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(42, 13);
            this.Email.TabIndex = 1;
            this.Email.Text = "* Email:";
            // 
            // Age
            // 
            this.Age.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Age.AutoSize = true;
            this.Age.Location = new System.Drawing.Point(230, 139);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(36, 13);
            this.Age.TabIndex = 1;
            this.Age.Text = "* Age:";
            // 
            // NameBox
            // 
            this.NameBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NameBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.NameBox.Location = new System.Drawing.Point(304, 69);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(218, 20);
            this.NameBox.TabIndex = 2;
            this.NameBox.Text = "Enter your name";
            // 
            // EmailBox
            // 
            this.EmailBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EmailBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.EmailBox.Location = new System.Drawing.Point(304, 103);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(218, 20);
            this.EmailBox.TabIndex = 3;
            this.EmailBox.Text = "Enter your email";
            // 
            // AgeBox
            // 
            this.AgeBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AgeBox.Location = new System.Drawing.Point(304, 137);
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(218, 20);
            this.AgeBox.TabIndex = 4;
            // 
            // Role
            // 
            this.Role.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Role.AutoSize = true;
            this.Role.Location = new System.Drawing.Point(43, 185);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(226, 13);
            this.Role.TabIndex = 5;
            this.Role.Text = "Which option best describes your current role?";
            // 
            // RoleSelection
            // 
            this.RoleSelection.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RoleSelection.FormattingEnabled = true;
            this.RoleSelection.Location = new System.Drawing.Point(304, 182);
            this.RoleSelection.Name = "RoleSelection";
            this.RoleSelection.Size = new System.Drawing.Size(218, 21);
            this.RoleSelection.TabIndex = 6;
            this.RoleSelection.Text = "Select an option";
            // 
            // RecommendLine
            // 
            this.RecommendLine.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RecommendLine.AutoSize = true;
            this.RecommendLine.Location = new System.Drawing.Point(96, 226);
            this.RecommendLine.Name = "RecommendLine";
            this.RecommendLine.Size = new System.Drawing.Size(331, 13);
            this.RecommendLine.TabIndex = 7;
            this.RecommendLine.Text = "* How likely is that you would recommend freeCodeCamp to a friend?";
            this.RecommendLine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DefinitelyRadio
            // 
            this.DefinitelyRadio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DefinitelyRadio.AutoSize = true;
            this.DefinitelyRadio.Location = new System.Drawing.Point(320, 224);
            this.DefinitelyRadio.Name = "DefinitelyRadio";
            this.DefinitelyRadio.Size = new System.Drawing.Size(68, 17);
            this.DefinitelyRadio.TabIndex = 8;
            this.DefinitelyRadio.TabStop = true;
            this.DefinitelyRadio.Text = "Definitely";
            this.DefinitelyRadio.UseVisualStyleBackColor = true;
            // 
            // MostLikelyRadio
            // 
            this.MostLikelyRadio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MostLikelyRadio.AutoSize = true;
            this.MostLikelyRadio.Location = new System.Drawing.Point(320, 247);
            this.MostLikelyRadio.Name = "MostLikelyRadio";
            this.MostLikelyRadio.Size = new System.Drawing.Size(78, 17);
            this.MostLikelyRadio.TabIndex = 9;
            this.MostLikelyRadio.TabStop = true;
            this.MostLikelyRadio.Text = "Most Likely";
            this.MostLikelyRadio.UseVisualStyleBackColor = true;
            // 
            // NotSureRadio
            // 
            this.NotSureRadio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NotSureRadio.AutoSize = true;
            this.NotSureRadio.Location = new System.Drawing.Point(320, 270);
            this.NotSureRadio.Name = "NotSureRadio";
            this.NotSureRadio.Size = new System.Drawing.Size(65, 17);
            this.NotSureRadio.TabIndex = 10;
            this.NotSureRadio.TabStop = true;
            this.NotSureRadio.Text = "Not sure";
            this.NotSureRadio.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "What do you like the most in FCC?";
            // 
            // FCCselection
            // 
            this.FCCselection.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FCCselection.FormattingEnabled = true;
            this.FCCselection.Location = new System.Drawing.Point(304, 303);
            this.FCCselection.Name = "FCCselection";
            this.FCCselection.Size = new System.Drawing.Size(218, 21);
            this.FCCselection.TabIndex = 12;
            this.FCCselection.Text = "Select an option";
            // 
            // ImprovementLabel
            // 
            this.ImprovementLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ImprovementLabel.AutoSize = true;
            this.ImprovementLabel.Location = new System.Drawing.Point(71, 360);
            this.ImprovementLabel.Name = "ImprovementLabel";
            this.ImprovementLabel.Size = new System.Drawing.Size(298, 13);
            this.ImprovementLabel.TabIndex = 13;
            this.ImprovementLabel.Text = "Things that should be improved in future (Check all that apply)";
            // 
            // FrontEndRadio
            // 
            this.FrontEndRadio.AutoSize = true;
            this.FrontEndRadio.Location = new System.Drawing.Point(0, 7);
            this.FrontEndRadio.Name = "FrontEndRadio";
            this.FrontEndRadio.Size = new System.Drawing.Size(110, 17);
            this.FrontEndRadio.TabIndex = 14;
            this.FrontEndRadio.TabStop = true;
            this.FrontEndRadio.Text = "Front-end projects";
            this.FrontEndRadio.UseVisualStyleBackColor = true;
            // 
            // BackEndRadio
            // 
            this.BackEndRadio.AutoSize = true;
            this.BackEndRadio.Location = new System.Drawing.Point(0, 30);
            this.BackEndRadio.Name = "BackEndRadio";
            this.BackEndRadio.Size = new System.Drawing.Size(111, 17);
            this.BackEndRadio.TabIndex = 14;
            this.BackEndRadio.TabStop = true;
            this.BackEndRadio.Text = "Back-end projects";
            this.BackEndRadio.UseVisualStyleBackColor = true;
            // 
            // DataVisualizationRadio
            // 
            this.DataVisualizationRadio.AutoSize = true;
            this.DataVisualizationRadio.Location = new System.Drawing.Point(0, 53);
            this.DataVisualizationRadio.Name = "DataVisualizationRadio";
            this.DataVisualizationRadio.Size = new System.Drawing.Size(109, 17);
            this.DataVisualizationRadio.TabIndex = 14;
            this.DataVisualizationRadio.TabStop = true;
            this.DataVisualizationRadio.Text = "Data Visualization";
            this.DataVisualizationRadio.UseVisualStyleBackColor = true;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SubmitButton.Location = new System.Drawing.Point(352, 443);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 15;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ImprovementsGroup
            // 
            this.ImprovementsGroup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ImprovementsGroup.Controls.Add(this.BackEndRadio);
            this.ImprovementsGroup.Controls.Add(this.FrontEndRadio);
            this.ImprovementsGroup.Controls.Add(this.DataVisualizationRadio);
            this.ImprovementsGroup.Location = new System.Drawing.Point(313, 344);
            this.ImprovementsGroup.Name = "ImprovementsGroup";
            this.ImprovementsGroup.Size = new System.Drawing.Size(114, 79);
            this.ImprovementsGroup.TabIndex = 16;
            this.ImprovementsGroup.TabStop = false;
            // 
            // SurveyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.ImprovementsGroup);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.ImprovementLabel);
            this.Controls.Add(this.FCCselection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NotSureRadio);
            this.Controls.Add(this.MostLikelyRadio);
            this.Controls.Add(this.DefinitelyRadio);
            this.Controls.Add(this.RecommendLine);
            this.Controls.Add(this.RoleSelection);
            this.Controls.Add(this.Role);
            this.Controls.Add(this.AgeBox);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.YourName);
            this.Controls.Add(this.improveText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 550);
            this.Name = "SurveyForm";
            this.Text = "Survey Form";
            ((System.ComponentModel.ISupportInitialize)(this.AgeBox)).EndInit();
            this.ImprovementsGroup.ResumeLayout(false);
            this.ImprovementsGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label improveText;
        private System.Windows.Forms.Label YourName;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.NumericUpDown AgeBox;
        private System.Windows.Forms.Label Role;
        private System.Windows.Forms.ComboBox RoleSelection;
        private System.Windows.Forms.Label RecommendLine;
        private System.Windows.Forms.RadioButton DefinitelyRadio;
        private System.Windows.Forms.RadioButton MostLikelyRadio;
        private System.Windows.Forms.RadioButton NotSureRadio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FCCselection;
        private System.Windows.Forms.Label ImprovementLabel;
        private System.Windows.Forms.RadioButton FrontEndRadio;
        private System.Windows.Forms.RadioButton BackEndRadio;
        private System.Windows.Forms.RadioButton DataVisualizationRadio;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.GroupBox ImprovementsGroup;
    }
}

