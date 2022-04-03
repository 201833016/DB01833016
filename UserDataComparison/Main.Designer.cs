namespace UserDataComparison
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label_Age = new System.Windows.Forms.Label();
            this.label_birth_month = new System.Windows.Forms.Label();
            this.label_Hobby = new System.Windows.Forms.Label();
            this.label_address = new System.Windows.Forms.Label();
            this.label_religion = new System.Windows.Forms.Label();
            this.label_MBTI = new System.Windows.Forms.Label();
            this.button_Submission = new System.Windows.Forms.Button();
            this.comboBox_MBTI = new System.Windows.Forms.ComboBox();
            this.comboBox_address = new System.Windows.Forms.ComboBox();
            this.comboBox_religion = new System.Windows.Forms.ComboBox();
            this.comboBox_Hobby = new System.Windows.Forms.ComboBox();
            this.comboBox_birth_month = new System.Windows.Forms.ComboBox();
            this.groupBox_Gender = new System.Windows.Forms.GroupBox();
            this.radioButton_Female = new System.Windows.Forms.RadioButton();
            this.radioButton_Male = new System.Windows.Forms.RadioButton();
            this.label_gender_value = new System.Windows.Forms.Label();
            this.comboBox_Age = new System.Windows.Forms.ComboBox();
            this.label_ID = new System.Windows.Forms.Label();
            this.groupBox_Gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(295, 32);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(122, 18);
            this.Title.TabIndex = 0;
            this.Title.Text = "인적사항 작성";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(23, 111);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(44, 18);
            this.label_Name.TabIndex = 1;
            this.label_Name.Text = "이름";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(129, 111);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 28);
            this.textBox_Name.TabIndex = 2;
            // 
            // label_Age
            // 
            this.label_Age.AutoSize = true;
            this.label_Age.Location = new System.Drawing.Point(23, 288);
            this.label_Age.Name = "label_Age";
            this.label_Age.Size = new System.Drawing.Size(44, 18);
            this.label_Age.TabIndex = 4;
            this.label_Age.Text = "나이";
            // 
            // label_birth_month
            // 
            this.label_birth_month.AutoSize = true;
            this.label_birth_month.Location = new System.Drawing.Point(23, 370);
            this.label_birth_month.Name = "label_birth_month";
            this.label_birth_month.Size = new System.Drawing.Size(74, 18);
            this.label_birth_month.TabIndex = 5;
            this.label_birth_month.Text = "생일(월)";
            // 
            // label_Hobby
            // 
            this.label_Hobby.AutoSize = true;
            this.label_Hobby.Location = new System.Drawing.Point(26, 476);
            this.label_Hobby.Name = "label_Hobby";
            this.label_Hobby.Size = new System.Drawing.Size(44, 18);
            this.label_Hobby.TabIndex = 6;
            this.label_Hobby.Text = "취미";
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Location = new System.Drawing.Point(26, 581);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(62, 18);
            this.label_address.TabIndex = 7;
            this.label_address.Text = "거주지";
            // 
            // label_religion
            // 
            this.label_religion.AutoSize = true;
            this.label_religion.Location = new System.Drawing.Point(29, 674);
            this.label_religion.Name = "label_religion";
            this.label_religion.Size = new System.Drawing.Size(44, 18);
            this.label_religion.TabIndex = 8;
            this.label_religion.Text = "종교";
            // 
            // label_MBTI
            // 
            this.label_MBTI.AutoSize = true;
            this.label_MBTI.Location = new System.Drawing.Point(26, 757);
            this.label_MBTI.Name = "label_MBTI";
            this.label_MBTI.Size = new System.Drawing.Size(47, 18);
            this.label_MBTI.TabIndex = 9;
            this.label_MBTI.Text = "MBTI";
            // 
            // button_Submission
            // 
            this.button_Submission.Location = new System.Drawing.Point(592, 784);
            this.button_Submission.Name = "button_Submission";
            this.button_Submission.Size = new System.Drawing.Size(118, 70);
            this.button_Submission.TabIndex = 12;
            this.button_Submission.Text = "제출";
            this.button_Submission.UseVisualStyleBackColor = true;
            this.button_Submission.Click += new System.EventHandler(this.button_Submission_Click);
            // 
            // comboBox_MBTI
            // 
            this.comboBox_MBTI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_MBTI.FormattingEnabled = true;
            this.comboBox_MBTI.Location = new System.Drawing.Point(129, 754);
            this.comboBox_MBTI.Name = "comboBox_MBTI";
            this.comboBox_MBTI.Size = new System.Drawing.Size(121, 26);
            this.comboBox_MBTI.TabIndex = 13;
            this.comboBox_MBTI.SelectedIndexChanged += new System.EventHandler(this.comboBox_MBTI_SelectedIndexChanged);
            // 
            // comboBox_address
            // 
            this.comboBox_address.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_address.FormattingEnabled = true;
            this.comboBox_address.Location = new System.Drawing.Point(129, 578);
            this.comboBox_address.Name = "comboBox_address";
            this.comboBox_address.Size = new System.Drawing.Size(121, 26);
            this.comboBox_address.TabIndex = 14;
            this.comboBox_address.SelectedIndexChanged += new System.EventHandler(this.comboBox_address_SelectedIndexChanged);
            // 
            // comboBox_religion
            // 
            this.comboBox_religion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_religion.FormattingEnabled = true;
            this.comboBox_religion.Location = new System.Drawing.Point(129, 671);
            this.comboBox_religion.Name = "comboBox_religion";
            this.comboBox_religion.Size = new System.Drawing.Size(121, 26);
            this.comboBox_religion.TabIndex = 15;
            this.comboBox_religion.SelectedIndexChanged += new System.EventHandler(this.comboBox_religion_SelectedIndexChanged);
            // 
            // comboBox_Hobby
            // 
            this.comboBox_Hobby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Hobby.FormattingEnabled = true;
            this.comboBox_Hobby.Location = new System.Drawing.Point(129, 468);
            this.comboBox_Hobby.Name = "comboBox_Hobby";
            this.comboBox_Hobby.Size = new System.Drawing.Size(121, 26);
            this.comboBox_Hobby.TabIndex = 16;
            this.comboBox_Hobby.SelectedIndexChanged += new System.EventHandler(this.comboBox_Hobby_SelectedIndexChanged);
            // 
            // comboBox_birth_month
            // 
            this.comboBox_birth_month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_birth_month.FormattingEnabled = true;
            this.comboBox_birth_month.Location = new System.Drawing.Point(129, 362);
            this.comboBox_birth_month.Name = "comboBox_birth_month";
            this.comboBox_birth_month.Size = new System.Drawing.Size(121, 26);
            this.comboBox_birth_month.TabIndex = 17;
            this.comboBox_birth_month.SelectedIndexChanged += new System.EventHandler(this.comboBox_birth_month_SelectedIndexChanged);
            // 
            // groupBox_Gender
            // 
            this.groupBox_Gender.Controls.Add(this.radioButton_Female);
            this.groupBox_Gender.Controls.Add(this.radioButton_Male);
            this.groupBox_Gender.Location = new System.Drawing.Point(12, 178);
            this.groupBox_Gender.Name = "groupBox_Gender";
            this.groupBox_Gender.Size = new System.Drawing.Size(288, 58);
            this.groupBox_Gender.TabIndex = 19;
            this.groupBox_Gender.TabStop = false;
            this.groupBox_Gender.Text = "성별";
            // 
            // radioButton_Female
            // 
            this.radioButton_Female.AutoSize = true;
            this.radioButton_Female.Location = new System.Drawing.Point(147, 27);
            this.radioButton_Female.Name = "radioButton_Female";
            this.radioButton_Female.Size = new System.Drawing.Size(69, 22);
            this.radioButton_Female.TabIndex = 20;
            this.radioButton_Female.TabStop = true;
            this.radioButton_Female.Text = "여자";
            this.radioButton_Female.UseVisualStyleBackColor = true;
            this.radioButton_Female.CheckedChanged += new System.EventHandler(this.radioButton_Female_CheckedChanged);
            // 
            // radioButton_Male
            // 
            this.radioButton_Male.AutoSize = true;
            this.radioButton_Male.Location = new System.Drawing.Point(6, 27);
            this.radioButton_Male.Name = "radioButton_Male";
            this.radioButton_Male.Size = new System.Drawing.Size(69, 22);
            this.radioButton_Male.TabIndex = 0;
            this.radioButton_Male.TabStop = true;
            this.radioButton_Male.Text = "남자";
            this.radioButton_Male.UseVisualStyleBackColor = true;
            this.radioButton_Male.CheckedChanged += new System.EventHandler(this.radioButton_Male_CheckedChanged);
            // 
            // label_gender_value
            // 
            this.label_gender_value.AutoSize = true;
            this.label_gender_value.Location = new System.Drawing.Point(333, 193);
            this.label_gender_value.Name = "label_gender_value";
            this.label_gender_value.Size = new System.Drawing.Size(62, 18);
            this.label_gender_value.TabIndex = 20;
            this.label_gender_value.Text = "성별값";
            this.label_gender_value.Visible = false;
            // 
            // comboBox_Age
            // 
            this.comboBox_Age.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Age.FormattingEnabled = true;
            this.comboBox_Age.Location = new System.Drawing.Point(129, 288);
            this.comboBox_Age.Name = "comboBox_Age";
            this.comboBox_Age.Size = new System.Drawing.Size(121, 26);
            this.comboBox_Age.TabIndex = 21;
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(572, 47);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(67, 18);
            this.label_ID.TabIndex = 22;
            this.label_ID.Text = "label_ID";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 919);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.comboBox_Age);
            this.Controls.Add(this.label_gender_value);
            this.Controls.Add(this.groupBox_Gender);
            this.Controls.Add(this.comboBox_birth_month);
            this.Controls.Add(this.comboBox_Hobby);
            this.Controls.Add(this.comboBox_religion);
            this.Controls.Add(this.comboBox_address);
            this.Controls.Add(this.comboBox_MBTI);
            this.Controls.Add(this.button_Submission);
            this.Controls.Add(this.label_MBTI);
            this.Controls.Add(this.label_religion);
            this.Controls.Add(this.label_address);
            this.Controls.Add(this.label_Hobby);
            this.Controls.Add(this.label_birth_month);
            this.Controls.Add(this.label_Age);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.Title);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox_Gender.ResumeLayout(false);
            this.groupBox_Gender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label_Age;
        private System.Windows.Forms.Label label_birth_month;
        private System.Windows.Forms.Label label_Hobby;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.Label label_religion;
        private System.Windows.Forms.Label label_MBTI;
        private System.Windows.Forms.Button button_Submission;
        private System.Windows.Forms.ComboBox comboBox_MBTI;
        private System.Windows.Forms.ComboBox comboBox_address;
        private System.Windows.Forms.ComboBox comboBox_religion;
        private System.Windows.Forms.ComboBox comboBox_Hobby;
        private System.Windows.Forms.ComboBox comboBox_birth_month;
        private System.Windows.Forms.GroupBox groupBox_Gender;
        private System.Windows.Forms.RadioButton radioButton_Female;
        private System.Windows.Forms.RadioButton radioButton_Male;
        private System.Windows.Forms.Label label_gender_value;
        private System.Windows.Forms.ComboBox comboBox_Age;
        private System.Windows.Forms.Label label_ID;
    }
}

