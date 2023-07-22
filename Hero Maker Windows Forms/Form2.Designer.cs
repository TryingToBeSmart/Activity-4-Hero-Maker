namespace Hero_Maker_Windows_Forms
{
    partial class Form2
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
            HerosListBox = new ListBox();
            HeroTriatsListBox = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // HerosListBox
            // 
            HerosListBox.FormattingEnabled = true;
            HerosListBox.ItemHeight = 15;
            HerosListBox.Location = new Point(12, 12);
            HerosListBox.Name = "HerosListBox";
            HerosListBox.Size = new Size(236, 349);
            HerosListBox.TabIndex = 0;
            HerosListBox.SelectedIndexChanged += HerosListBox_SelectedIndexChanged_1;
            // 
            // HeroTriatsListBox
            // 
            HeroTriatsListBox.FormattingEnabled = true;
            HeroTriatsListBox.HorizontalScrollbar = true;
            HeroTriatsListBox.ItemHeight = 15;
            HeroTriatsListBox.Location = new Point(254, 12);
            HeroTriatsListBox.Name = "HeroTriatsListBox";
            HeroTriatsListBox.Size = new Size(466, 349);
            HeroTriatsListBox.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.DialogResult = DialogResult.Cancel;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(568, 367);
            button1.Name = "button1";
            button1.Size = new Size(152, 61);
            button1.TabIndex = 2;
            button1.Text = "Create Hero";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 440);
            Controls.Add(button1);
            Controls.Add(HeroTriatsListBox);
            Controls.Add(HerosListBox);
            Name = "Form2";
            Text = "Heros";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox HerosListBox;
        private ListBox HeroTriatsListBox;
        private Button button1;
    }
}