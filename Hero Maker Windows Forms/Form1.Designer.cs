namespace Hero_Maker_Windows_Forms
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
            PowersGroupBox = new GroupBox();
            GrowingCheckBox = new CheckBox();
            WaterBreathingCheckBox = new CheckBox();
            LazerVisionCheckBox = new CheckBox();
            RegenerationCheckBox = new CheckBox();
            MindControlCheckBox = new CheckBox();
            ForceFieldCheckBox = new CheckBox();
            TelepathyCheckBox = new CheckBox();
            SuperSpeedCheckBox = new CheckBox();
            InvisibilityCheckBox = new CheckBox();
            XRayVisionCheckBox = new CheckBox();
            FlyingCheckBox = new CheckBox();
            SuperStrengthCheckBox = new CheckBox();
            HeroNameTextBox = new TextBox();
            groupBox2 = new GroupBox();
            BirthNameTextBox = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            ExperienceNumericUpDown = new NumericUpDown();
            DiscoveryDateTimePicker = new DateTimePicker();
            BirthdayDateTimePicker = new DateTimePicker();
            PreferedTransportGroupBox = new GroupBox();
            OtherRadioButton = new RadioButton();
            TeleportRadioButton = new RadioButton();
            VehicleRadioButton = new RadioButton();
            FlyingRadioButton = new RadioButton();
            RunningRadioButton = new RadioButton();
            groupBox4 = new GroupBox();
            LocationListBox = new ListBox();
            label4 = new Label();
            colorDialog1 = new ColorDialog();
            pictureBox1 = new PictureBox();
            groupBox5 = new GroupBox();
            StaminaLabel = new Label();
            StrengthLabel = new Label();
            SpeedLabel = new Label();
            StaminaTrackBar = new TrackBar();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            StrengthTrackBar = new TrackBar();
            SpeedTrackBar = new TrackBar();
            CreateButton = new Button();
            ViewHerosButton = new Button();
            PowersGroupBox.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ExperienceNumericUpDown).BeginInit();
            PreferedTransportGroupBox.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StaminaTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StrengthTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SpeedTrackBar).BeginInit();
            SuspendLayout();
            // 
            // PowersGroupBox
            // 
            PowersGroupBox.Controls.Add(GrowingCheckBox);
            PowersGroupBox.Controls.Add(WaterBreathingCheckBox);
            PowersGroupBox.Controls.Add(LazerVisionCheckBox);
            PowersGroupBox.Controls.Add(RegenerationCheckBox);
            PowersGroupBox.Controls.Add(MindControlCheckBox);
            PowersGroupBox.Controls.Add(ForceFieldCheckBox);
            PowersGroupBox.Controls.Add(TelepathyCheckBox);
            PowersGroupBox.Controls.Add(SuperSpeedCheckBox);
            PowersGroupBox.Controls.Add(InvisibilityCheckBox);
            PowersGroupBox.Controls.Add(XRayVisionCheckBox);
            PowersGroupBox.Controls.Add(FlyingCheckBox);
            PowersGroupBox.Controls.Add(SuperStrengthCheckBox);
            PowersGroupBox.Location = new Point(12, 51);
            PowersGroupBox.Name = "PowersGroupBox";
            PowersGroupBox.Size = new Size(255, 183);
            PowersGroupBox.TabIndex = 0;
            PowersGroupBox.TabStop = false;
            PowersGroupBox.Text = "Powers";
            // 
            // GrowingCheckBox
            // 
            GrowingCheckBox.AutoSize = true;
            GrowingCheckBox.Location = new Point(134, 144);
            GrowingCheckBox.Name = "GrowingCheckBox";
            GrowingCheckBox.Size = new Size(71, 19);
            GrowingCheckBox.TabIndex = 11;
            GrowingCheckBox.Text = "Growing";
            GrowingCheckBox.UseVisualStyleBackColor = true;
            // 
            // WaterBreathingCheckBox
            // 
            WaterBreathingCheckBox.AutoSize = true;
            WaterBreathingCheckBox.Location = new Point(134, 119);
            WaterBreathingCheckBox.Name = "WaterBreathingCheckBox";
            WaterBreathingCheckBox.Size = new Size(111, 19);
            WaterBreathingCheckBox.TabIndex = 10;
            WaterBreathingCheckBox.Text = "Water Breathing";
            WaterBreathingCheckBox.UseVisualStyleBackColor = true;
            // 
            // LazerVisionCheckBox
            // 
            LazerVisionCheckBox.AutoSize = true;
            LazerVisionCheckBox.Location = new Point(134, 94);
            LazerVisionCheckBox.Name = "LazerVisionCheckBox";
            LazerVisionCheckBox.Size = new Size(88, 19);
            LazerVisionCheckBox.TabIndex = 9;
            LazerVisionCheckBox.Text = "Lazer Vision";
            LazerVisionCheckBox.UseVisualStyleBackColor = true;
            // 
            // RegenerationCheckBox
            // 
            RegenerationCheckBox.AutoSize = true;
            RegenerationCheckBox.Location = new Point(134, 69);
            RegenerationCheckBox.Name = "RegenerationCheckBox";
            RegenerationCheckBox.Size = new Size(96, 19);
            RegenerationCheckBox.TabIndex = 8;
            RegenerationCheckBox.Text = "Regeneration";
            RegenerationCheckBox.UseVisualStyleBackColor = true;
            // 
            // MindControlCheckBox
            // 
            MindControlCheckBox.AutoSize = true;
            MindControlCheckBox.Location = new Point(134, 44);
            MindControlCheckBox.Name = "MindControlCheckBox";
            MindControlCheckBox.Size = new Size(97, 19);
            MindControlCheckBox.TabIndex = 7;
            MindControlCheckBox.Text = "Mind Control";
            MindControlCheckBox.UseVisualStyleBackColor = true;
            // 
            // ForceFieldCheckBox
            // 
            ForceFieldCheckBox.AutoSize = true;
            ForceFieldCheckBox.Location = new Point(134, 19);
            ForceFieldCheckBox.Name = "ForceFieldCheckBox";
            ForceFieldCheckBox.Size = new Size(83, 19);
            ForceFieldCheckBox.TabIndex = 6;
            ForceFieldCheckBox.Text = "Force Field";
            ForceFieldCheckBox.UseVisualStyleBackColor = true;
            // 
            // TelepathyCheckBox
            // 
            TelepathyCheckBox.AutoSize = true;
            TelepathyCheckBox.Location = new Point(3, 144);
            TelepathyCheckBox.Name = "TelepathyCheckBox";
            TelepathyCheckBox.Size = new Size(76, 19);
            TelepathyCheckBox.TabIndex = 5;
            TelepathyCheckBox.Text = "Telepathy";
            TelepathyCheckBox.UseVisualStyleBackColor = true;
            // 
            // SuperSpeedCheckBox
            // 
            SuperSpeedCheckBox.AutoSize = true;
            SuperSpeedCheckBox.Location = new Point(3, 119);
            SuperSpeedCheckBox.Name = "SuperSpeedCheckBox";
            SuperSpeedCheckBox.Size = new Size(91, 19);
            SuperSpeedCheckBox.TabIndex = 4;
            SuperSpeedCheckBox.Text = "Super Speed";
            SuperSpeedCheckBox.UseVisualStyleBackColor = true;
            // 
            // InvisibilityCheckBox
            // 
            InvisibilityCheckBox.AutoSize = true;
            InvisibilityCheckBox.Location = new Point(3, 94);
            InvisibilityCheckBox.Name = "InvisibilityCheckBox";
            InvisibilityCheckBox.Size = new Size(79, 19);
            InvisibilityCheckBox.TabIndex = 3;
            InvisibilityCheckBox.Text = "Invisibility";
            InvisibilityCheckBox.UseVisualStyleBackColor = true;
            // 
            // XRayVisionCheckBox
            // 
            XRayVisionCheckBox.AutoSize = true;
            XRayVisionCheckBox.Location = new Point(3, 69);
            XRayVisionCheckBox.Name = "XRayVisionCheckBox";
            XRayVisionCheckBox.Size = new Size(90, 19);
            XRayVisionCheckBox.TabIndex = 2;
            XRayVisionCheckBox.Text = "X Ray Vision";
            XRayVisionCheckBox.UseVisualStyleBackColor = true;
            // 
            // FlyingCheckBox
            // 
            FlyingCheckBox.AutoSize = true;
            FlyingCheckBox.Location = new Point(3, 44);
            FlyingCheckBox.Name = "FlyingCheckBox";
            FlyingCheckBox.Size = new Size(58, 19);
            FlyingCheckBox.TabIndex = 1;
            FlyingCheckBox.Text = "Flying";
            FlyingCheckBox.UseVisualStyleBackColor = true;
            // 
            // SuperStrengthCheckBox
            // 
            SuperStrengthCheckBox.AutoSize = true;
            SuperStrengthCheckBox.Location = new Point(3, 19);
            SuperStrengthCheckBox.Name = "SuperStrengthCheckBox";
            SuperStrengthCheckBox.Size = new Size(104, 19);
            SuperStrengthCheckBox.TabIndex = 0;
            SuperStrengthCheckBox.Text = "Super Strength";
            SuperStrengthCheckBox.UseVisualStyleBackColor = true;
            // 
            // HeroNameTextBox
            // 
            HeroNameTextBox.BackColor = SystemColors.ButtonHighlight;
            HeroNameTextBox.Location = new Point(115, 22);
            HeroNameTextBox.Name = "HeroNameTextBox";
            HeroNameTextBox.PlaceholderText = "Hero Name";
            HeroNameTextBox.Size = new Size(291, 23);
            HeroNameTextBox.TabIndex = 12;
            HeroNameTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BirthNameTextBox);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(ExperienceNumericUpDown);
            groupBox2.Controls.Add(DiscoveryDateTimePicker);
            groupBox2.Controls.Add(BirthdayDateTimePicker);
            groupBox2.Location = new Point(273, 51);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(281, 183);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Personal Info";
            // 
            // BirthNameTextBox
            // 
            BirthNameTextBox.Location = new Point(6, 128);
            BirthNameTextBox.Name = "BirthNameTextBox";
            BirthNameTextBox.PlaceholderText = "Birth Name";
            BirthNameTextBox.Size = new Size(269, 23);
            BirthNameTextBox.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 4;
            label1.Text = "Birthday";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 156);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 15;
            label3.Text = "Years Experience";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 71);
            label2.Name = "label2";
            label2.Size = new Size(127, 15);
            label2.TabIndex = 3;
            label2.Text = "Super Power Discovery";
            // 
            // ExperienceNumericUpDown
            // 
            ExperienceNumericUpDown.Location = new Point(106, 154);
            ExperienceNumericUpDown.Name = "ExperienceNumericUpDown";
            ExperienceNumericUpDown.Size = new Size(100, 23);
            ExperienceNumericUpDown.TabIndex = 1;
            // 
            // DiscoveryDateTimePicker
            // 
            DiscoveryDateTimePicker.Location = new Point(6, 89);
            DiscoveryDateTimePicker.Name = "DiscoveryDateTimePicker";
            DiscoveryDateTimePicker.Size = new Size(200, 23);
            DiscoveryDateTimePicker.TabIndex = 2;
            DiscoveryDateTimePicker.Value = new DateTime(2023, 7, 16, 21, 53, 7, 0);
            // 
            // BirthdayDateTimePicker
            // 
            BirthdayDateTimePicker.Location = new Point(6, 37);
            BirthdayDateTimePicker.Name = "BirthdayDateTimePicker";
            BirthdayDateTimePicker.Size = new Size(200, 23);
            BirthdayDateTimePicker.TabIndex = 0;
            BirthdayDateTimePicker.Value = new DateTime(2023, 7, 16, 21, 53, 7, 0);
            // 
            // PreferedTransportGroupBox
            // 
            PreferedTransportGroupBox.Controls.Add(OtherRadioButton);
            PreferedTransportGroupBox.Controls.Add(TeleportRadioButton);
            PreferedTransportGroupBox.Controls.Add(VehicleRadioButton);
            PreferedTransportGroupBox.Controls.Add(FlyingRadioButton);
            PreferedTransportGroupBox.Controls.Add(RunningRadioButton);
            PreferedTransportGroupBox.Location = new Point(211, 243);
            PreferedTransportGroupBox.Name = "PreferedTransportGroupBox";
            PreferedTransportGroupBox.Size = new Size(119, 147);
            PreferedTransportGroupBox.TabIndex = 13;
            PreferedTransportGroupBox.TabStop = false;
            PreferedTransportGroupBox.Text = "Prefered Transport";
            // 
            // OtherRadioButton
            // 
            OtherRadioButton.AutoSize = true;
            OtherRadioButton.Location = new Point(6, 119);
            OtherRadioButton.Name = "OtherRadioButton";
            OtherRadioButton.Size = new Size(55, 19);
            OtherRadioButton.TabIndex = 4;
            OtherRadioButton.Text = "Other";
            OtherRadioButton.UseVisualStyleBackColor = true;
            // 
            // TeleportRadioButton
            // 
            TeleportRadioButton.AutoSize = true;
            TeleportRadioButton.Location = new Point(6, 94);
            TeleportRadioButton.Name = "TeleportRadioButton";
            TeleportRadioButton.Size = new Size(67, 19);
            TeleportRadioButton.TabIndex = 3;
            TeleportRadioButton.Text = "Teleport";
            TeleportRadioButton.UseVisualStyleBackColor = true;
            // 
            // VehicleRadioButton
            // 
            VehicleRadioButton.AutoSize = true;
            VehicleRadioButton.Location = new Point(6, 69);
            VehicleRadioButton.Name = "VehicleRadioButton";
            VehicleRadioButton.Size = new Size(62, 19);
            VehicleRadioButton.TabIndex = 2;
            VehicleRadioButton.Text = "Vehicle";
            VehicleRadioButton.UseVisualStyleBackColor = true;
            // 
            // FlyingRadioButton
            // 
            FlyingRadioButton.AutoSize = true;
            FlyingRadioButton.Location = new Point(6, 44);
            FlyingRadioButton.Name = "FlyingRadioButton";
            FlyingRadioButton.Size = new Size(57, 19);
            FlyingRadioButton.TabIndex = 1;
            FlyingRadioButton.Text = "Flying";
            FlyingRadioButton.UseVisualStyleBackColor = true;
            // 
            // RunningRadioButton
            // 
            RunningRadioButton.AutoSize = true;
            RunningRadioButton.Checked = true;
            RunningRadioButton.Location = new Point(6, 19);
            RunningRadioButton.Name = "RunningRadioButton";
            RunningRadioButton.Size = new Size(70, 19);
            RunningRadioButton.TabIndex = 0;
            RunningRadioButton.TabStop = true;
            RunningRadioButton.Text = "Running";
            RunningRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(LocationListBox);
            groupBox4.Location = new Point(12, 243);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(193, 147);
            groupBox4.TabIndex = 14;
            groupBox4.TabStop = false;
            groupBox4.Text = "Office Locations";
            // 
            // LocationListBox
            // 
            LocationListBox.FormattingEnabled = true;
            LocationListBox.ItemHeight = 15;
            LocationListBox.Items.AddRange(new object[] { "New York", "Los Angeles", "Portland", "Seattle", "Denver", "Philadelphia", "Chicago", "Moscow", "London", "Paris", "Tokyo", "Rome", "Sydney" });
            LocationListBox.Location = new Point(6, 19);
            LocationListBox.Name = "LocationListBox";
            LocationListBox.SelectionMode = SelectionMode.MultiSimple;
            LocationListBox.Size = new Size(181, 124);
            LocationListBox.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(408, 243);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 16;
            label4.Text = "Primary Color";
            // 
            // colorDialog1
            // 
            colorDialog1.AllowFullOpen = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Navy;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(346, 265);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 125);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(StaminaLabel);
            groupBox5.Controls.Add(StrengthLabel);
            groupBox5.Controls.Add(SpeedLabel);
            groupBox5.Controls.Add(StaminaTrackBar);
            groupBox5.Controls.Add(label7);
            groupBox5.Controls.Add(label6);
            groupBox5.Controls.Add(label5);
            groupBox5.Controls.Add(StrengthTrackBar);
            groupBox5.Controls.Add(SpeedTrackBar);
            groupBox5.Location = new Point(18, 396);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(355, 260);
            groupBox5.TabIndex = 18;
            groupBox5.TabStop = false;
            groupBox5.Text = "Speed-Strength-Stamina";
            // 
            // StaminaLabel
            // 
            StaminaLabel.AutoSize = true;
            StaminaLabel.Location = new Point(67, 148);
            StaminaLabel.Name = "StaminaLabel";
            StaminaLabel.Size = new Size(13, 15);
            StaminaLabel.TabIndex = 7;
            StaminaLabel.Text = "0";
            // 
            // StrengthLabel
            // 
            StrengthLabel.AutoSize = true;
            StrengthLabel.Location = new Point(69, 85);
            StrengthLabel.Name = "StrengthLabel";
            StrengthLabel.Size = new Size(13, 15);
            StrengthLabel.TabIndex = 6;
            StrengthLabel.Text = "0";
            // 
            // SpeedLabel
            // 
            SpeedLabel.AutoSize = true;
            SpeedLabel.Location = new Point(55, 19);
            SpeedLabel.Name = "SpeedLabel";
            SpeedLabel.Size = new Size(13, 15);
            SpeedLabel.TabIndex = 5;
            SpeedLabel.Text = "0";
            // 
            // StaminaTrackBar
            // 
            StaminaTrackBar.LargeChange = 10;
            StaminaTrackBar.Location = new Point(6, 166);
            StaminaTrackBar.Maximum = 100;
            StaminaTrackBar.Name = "StaminaTrackBar";
            StaminaTrackBar.Size = new Size(343, 45);
            StaminaTrackBar.SmallChange = 10;
            StaminaTrackBar.TabIndex = 2;
            StaminaTrackBar.TickFrequency = 10;
            StaminaTrackBar.ValueChanged += trackBar3_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 148);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 4;
            label7.Text = "Stamina:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 85);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 3;
            label6.Text = "Strength:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 19);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 2;
            label5.Text = "Speed:";
            // 
            // StrengthTrackBar
            // 
            StrengthTrackBar.LargeChange = 10;
            StrengthTrackBar.Location = new Point(6, 100);
            StrengthTrackBar.Maximum = 100;
            StrengthTrackBar.Name = "StrengthTrackBar";
            StrengthTrackBar.Size = new Size(343, 45);
            StrengthTrackBar.SmallChange = 10;
            StrengthTrackBar.TabIndex = 1;
            StrengthTrackBar.TickFrequency = 10;
            StrengthTrackBar.ValueChanged += trackBar2_ValueChanged;
            // 
            // SpeedTrackBar
            // 
            SpeedTrackBar.LargeChange = 10;
            SpeedTrackBar.Location = new Point(6, 37);
            SpeedTrackBar.Maximum = 100;
            SpeedTrackBar.Name = "SpeedTrackBar";
            SpeedTrackBar.Size = new Size(343, 45);
            SpeedTrackBar.SmallChange = 10;
            SpeedTrackBar.TabIndex = 0;
            SpeedTrackBar.TickFrequency = 10;
            SpeedTrackBar.ValueChanged += trackBar1_ValueChanged;
            // 
            // CreateButton
            // 
            CreateButton.BackColor = SystemColors.AppWorkspace;
            CreateButton.FlatStyle = FlatStyle.Popup;
            CreateButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CreateButton.Location = new Point(408, 603);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(140, 53);
            CreateButton.TabIndex = 19;
            CreateButton.Text = "Create";
            CreateButton.UseVisualStyleBackColor = false;
            CreateButton.Click += CreateButton_Click;
            // 
            // ViewHerosButton
            // 
            ViewHerosButton.BackColor = SystemColors.AppWorkspace;
            ViewHerosButton.FlatStyle = FlatStyle.Popup;
            ViewHerosButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ViewHerosButton.Location = new Point(408, 520);
            ViewHerosButton.Name = "ViewHerosButton";
            ViewHerosButton.Size = new Size(140, 53);
            ViewHerosButton.TabIndex = 20;
            ViewHerosButton.Text = "View Heros";
            ViewHerosButton.UseVisualStyleBackColor = false;
            ViewHerosButton.Click += ViewHerosButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 694);
            Controls.Add(ViewHerosButton);
            Controls.Add(CreateButton);
            Controls.Add(groupBox5);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(groupBox4);
            Controls.Add(PreferedTransportGroupBox);
            Controls.Add(groupBox2);
            Controls.Add(HeroNameTextBox);
            Controls.Add(PowersGroupBox);
            Name = "Form1";
            Text = "Super Hero Maker";
            PowersGroupBox.ResumeLayout(false);
            PowersGroupBox.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ExperienceNumericUpDown).EndInit();
            PreferedTransportGroupBox.ResumeLayout(false);
            PreferedTransportGroupBox.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)StaminaTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)StrengthTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)SpeedTrackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox PowersGroupBox;
        private CheckBox GrowingCheckBox;
        private CheckBox WaterBreathingCheckBox;
        private CheckBox LazerVisionCheckBox;
        private CheckBox RegenerationCheckBox;
        private CheckBox MindControlCheckBox;
        private CheckBox ForceFieldCheckBox;
        private CheckBox TelepathyCheckBox;
        private CheckBox SuperSpeedCheckBox;
        private CheckBox InvisibilityCheckBox;
        private CheckBox XRayVisionCheckBox;
        private CheckBox FlyingCheckBox;
        private CheckBox SuperStrengthCheckBox;
        private TextBox HeroNameTextBox;
        private GroupBox groupBox2;
        private DateTimePicker BirthdayDateTimePicker;
        private Label label2;
        private DateTimePicker DiscoveryDateTimePicker;
        private Label label1;
        private TextBox BirthNameTextBox;
        private GroupBox PreferedTransportGroupBox;
        private GroupBox groupBox4;
        private RadioButton OtherRadioButton;
        private RadioButton TeleportRadioButton;
        private RadioButton VehicleRadioButton;
        private RadioButton FlyingRadioButton;
        private RadioButton RunningRadioButton;
        private ListBox LocationListBox;
        private NumericUpDown ExperienceNumericUpDown;
        private Label label3;
        private Label label4;
        private ColorDialog colorDialog1;
        private PictureBox pictureBox1;
        private GroupBox groupBox5;
        private TrackBar SpeedTrackBar;
        private TrackBar StaminaTrackBar;
        private Label label7;
        private Label label6;
        private Label label5;
        private TrackBar StrengthTrackBar;
        private Label SpeedLabel;
        private Label StaminaLabel;
        private Label StrengthLabel;
        private Button CreateButton;
        private Button ViewHerosButton;
    }
}