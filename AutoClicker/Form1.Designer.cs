namespace AutoClicker
{
    partial class AutoClicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoClicker));
            TopPanel = new Panel();
            MinButton = new PictureBox();
            CloseButton = new PictureBox();
            label1 = new Label();
            MainPanel = new Panel();
            GroupBoxDcOc = new GroupBox();
            ButtonOne = new RadioButton();
            ButtonDouble = new RadioButton();
            GroupBoxLeftRight = new GroupBox();
            ButtonRight = new RadioButton();
            ButtonLeft = new RadioButton();
            LabelY = new Label();
            LabelX = new Label();
            TextBoxForY = new TextBox();
            TextBoxForX = new TextBox();
            ButtonPickLoc = new Button();
            ButtonStop = new Button();
            ButtonStart = new Button();
            LabelSecs = new Label();
            TextBoxForSecs = new TextBox();
            LabelMins = new Label();
            TextBoxForMins = new TextBox();
            ClickOptions = new Label();
            ClickInterval = new Label();
            TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MinButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseButton).BeginInit();
            MainPanel.SuspendLayout();
            GroupBoxDcOc.SuspendLayout();
            GroupBoxLeftRight.SuspendLayout();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.Transparent;
            TopPanel.BackgroundImage = (Image)resources.GetObject("TopPanel.BackgroundImage");
            TopPanel.Controls.Add(MinButton);
            TopPanel.Controls.Add(CloseButton);
            TopPanel.Controls.Add(label1);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(300, 30);
            TopPanel.TabIndex = 0;
            TopPanel.Paint += TopPanel_Paint;
            TopPanel.MouseDown += TopPanel_MouseDown;
            TopPanel.MouseMove += TopPanel_MouseMove;
            // 
            // MinButton
            // 
            MinButton.Cursor = Cursors.Hand;
            MinButton.Image = (Image)resources.GetObject("MinButton.Image");
            MinButton.Location = new Point(236, 3);
            MinButton.Name = "MinButton";
            MinButton.Size = new Size(25, 25);
            MinButton.SizeMode = PictureBoxSizeMode.StretchImage;
            MinButton.TabIndex = 1;
            MinButton.TabStop = false;
            MinButton.Click += MinButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.Image = (Image)resources.GetObject("CloseButton.Image");
            CloseButton.Location = new Point(267, 3);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(25, 25);
            CloseButton.SizeMode = PictureBoxSizeMode.StretchImage;
            CloseButton.TabIndex = 2;
            CloseButton.TabStop = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(0, 3);
            label1.Name = "label1";
            label1.Size = new Size(100, 22);
            label1.TabIndex = 0;
            label1.Text = "AutoCliker";
            label1.Click += label1_Click;
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.FromArgb(28, 28, 28);
            MainPanel.BackgroundImage = (Image)resources.GetObject("MainPanel.BackgroundImage");
            MainPanel.Controls.Add(GroupBoxDcOc);
            MainPanel.Controls.Add(GroupBoxLeftRight);
            MainPanel.Controls.Add(LabelY);
            MainPanel.Controls.Add(LabelX);
            MainPanel.Controls.Add(TextBoxForY);
            MainPanel.Controls.Add(TextBoxForX);
            MainPanel.Controls.Add(ButtonPickLoc);
            MainPanel.Controls.Add(ButtonStop);
            MainPanel.Controls.Add(ButtonStart);
            MainPanel.Controls.Add(LabelSecs);
            MainPanel.Controls.Add(TextBoxForSecs);
            MainPanel.Controls.Add(LabelMins);
            MainPanel.Controls.Add(TextBoxForMins);
            MainPanel.Controls.Add(ClickOptions);
            MainPanel.Controls.Add(ClickInterval);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 30);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(300, 270);
            MainPanel.TabIndex = 1;
            // 
            // GroupBoxDcOc
            // 
            GroupBoxDcOc.BackColor = Color.Transparent;
            GroupBoxDcOc.BackgroundImageLayout = ImageLayout.None;
            GroupBoxDcOc.Controls.Add(ButtonOne);
            GroupBoxDcOc.Controls.Add(ButtonDouble);
            GroupBoxDcOc.FlatStyle = FlatStyle.Flat;
            GroupBoxDcOc.Location = new Point(151, 109);
            GroupBoxDcOc.Name = "GroupBoxDcOc";
            GroupBoxDcOc.Size = new Size(149, 49);
            GroupBoxDcOc.TabIndex = 15;
            GroupBoxDcOc.TabStop = false;
            // 
            // ButtonOne
            // 
            ButtonOne.AutoSize = true;
            ButtonOne.Font = new Font("Segoe UI", 8F);
            ButtonOne.ForeColor = Color.White;
            ButtonOne.Location = new Point(3, 14);
            ButtonOne.Name = "ButtonOne";
            ButtonOne.Size = new Size(58, 23);
            ButtonOne.TabIndex = 3;
            ButtonOne.Text = "ONE";
            ButtonOne.UseVisualStyleBackColor = true;
            // 
            // ButtonDouble
            // 
            ButtonDouble.AutoSize = true;
            ButtonDouble.Font = new Font("Segoe UI", 8F);
            ButtonDouble.ForeColor = Color.White;
            ButtonDouble.Location = new Point(63, 14);
            ButtonDouble.Name = "ButtonDouble";
            ButtonDouble.Size = new Size(83, 23);
            ButtonDouble.TabIndex = 2;
            ButtonDouble.Text = "DOUBLE";
            ButtonDouble.UseVisualStyleBackColor = true;
            // 
            // GroupBoxLeftRight
            // 
            GroupBoxLeftRight.BackColor = Color.Transparent;
            GroupBoxLeftRight.BackgroundImageLayout = ImageLayout.None;
            GroupBoxLeftRight.Controls.Add(ButtonRight);
            GroupBoxLeftRight.Controls.Add(ButtonLeft);
            GroupBoxLeftRight.Location = new Point(3, 109);
            GroupBoxLeftRight.Name = "GroupBoxLeftRight";
            GroupBoxLeftRight.Size = new Size(142, 49);
            GroupBoxLeftRight.TabIndex = 14;
            GroupBoxLeftRight.TabStop = false;
            // 
            // ButtonRight
            // 
            ButtonRight.AutoSize = true;
            ButtonRight.BackColor = Color.Transparent;
            ButtonRight.Font = new Font("Segoe UI", 8F);
            ButtonRight.ForeColor = Color.White;
            ButtonRight.Location = new Point(64, 14);
            ButtonRight.Name = "ButtonRight";
            ButtonRight.Size = new Size(69, 23);
            ButtonRight.TabIndex = 1;
            ButtonRight.Text = "RIGHT";
            ButtonRight.UseVisualStyleBackColor = false;
            // 
            // ButtonLeft
            // 
            ButtonLeft.AutoSize = true;
            ButtonLeft.Checked = true;
            ButtonLeft.Font = new Font("Segoe UI", 8F);
            ButtonLeft.ForeColor = Color.White;
            ButtonLeft.Location = new Point(4, 14);
            ButtonLeft.Name = "ButtonLeft";
            ButtonLeft.Size = new Size(58, 23);
            ButtonLeft.TabIndex = 0;
            ButtonLeft.TabStop = true;
            ButtonLeft.Text = "LEFT";
            ButtonLeft.UseVisualStyleBackColor = true;
            // 
            // LabelY
            // 
            LabelY.AutoSize = true;
            LabelY.BackColor = Color.Transparent;
            LabelY.Font = new Font("Segoe UI", 10F);
            LabelY.ForeColor = Color.White;
            LabelY.Location = new Point(96, 161);
            LabelY.Name = "LabelY";
            LabelY.Size = new Size(19, 23);
            LabelY.TabIndex = 12;
            LabelY.Text = "Y";
            LabelY.Click += label2_Click;
            // 
            // LabelX
            // 
            LabelX.AutoSize = true;
            LabelX.BackColor = Color.Transparent;
            LabelX.Font = new Font("Segoe UI", 10F);
            LabelX.ForeColor = Color.White;
            LabelX.Location = new Point(22, 161);
            LabelX.Name = "LabelX";
            LabelX.Size = new Size(20, 23);
            LabelX.TabIndex = 11;
            LabelX.Text = "X";
            // 
            // TextBoxForY
            // 
            TextBoxForY.BackColor = Color.Gray;
            TextBoxForY.BorderStyle = BorderStyle.None;
            TextBoxForY.Font = new Font("Segoe UI", 15F);
            TextBoxForY.ForeColor = Color.FloralWhite;
            TextBoxForY.Location = new Point(73, 187);
            TextBoxForY.MaxLength = 2;
            TextBoxForY.Name = "TextBoxForY";
            TextBoxForY.ReadOnly = true;
            TextBoxForY.Size = new Size(63, 34);
            TextBoxForY.TabIndex = 10;
            TextBoxForY.Text = "0";
            TextBoxForY.TextAlign = HorizontalAlignment.Center;
            // 
            // TextBoxForX
            // 
            TextBoxForX.BackColor = Color.Gray;
            TextBoxForX.BorderStyle = BorderStyle.None;
            TextBoxForX.Font = new Font("Segoe UI", 15F);
            TextBoxForX.ForeColor = Color.FloralWhite;
            TextBoxForX.Location = new Point(1, 187);
            TextBoxForX.MaxLength = 2;
            TextBoxForX.Name = "TextBoxForX";
            TextBoxForX.ReadOnly = true;
            TextBoxForX.Size = new Size(64, 34);
            TextBoxForX.TabIndex = 9;
            TextBoxForX.Text = "0";
            TextBoxForX.TextAlign = HorizontalAlignment.Center;
            // 
            // ButtonPickLoc
            // 
            ButtonPickLoc.AutoSize = true;
            ButtonPickLoc.BackColor = Color.Transparent;
            ButtonPickLoc.FlatStyle = FlatStyle.Flat;
            ButtonPickLoc.Font = new Font("Segoe UI", 6F);
            ButtonPickLoc.ForeColor = Color.White;
            ButtonPickLoc.Location = new Point(3, 229);
            ButtonPickLoc.Name = "ButtonPickLoc";
            ButtonPickLoc.Size = new Size(142, 38);
            ButtonPickLoc.TabIndex = 8;
            ButtonPickLoc.Text = "PICK LOCTION (F3)";
            ButtonPickLoc.UseVisualStyleBackColor = false;
            ButtonPickLoc.Click += button1_Click;
            // 
            // ButtonStop
            // 
            ButtonStop.AutoSize = true;
            ButtonStop.BackColor = Color.Transparent;
            ButtonStop.FlatStyle = FlatStyle.Flat;
            ButtonStop.Font = new Font("Segoe UI", 10F);
            ButtonStop.ForeColor = Color.White;
            ButtonStop.Location = new Point(149, 229);
            ButtonStop.Name = "ButtonStop";
            ButtonStop.Size = new Size(149, 38);
            ButtonStop.TabIndex = 7;
            ButtonStop.Text = "STOP (F12)";
            ButtonStop.UseVisualStyleBackColor = false;
            ButtonStop.Click += ButtonStop_Click;
            // 
            // ButtonStart
            // 
            ButtonStart.AutoSize = true;
            ButtonStart.BackColor = Color.Transparent;
            ButtonStart.FlatStyle = FlatStyle.Flat;
            ButtonStart.Font = new Font("Segoe UI", 10F);
            ButtonStart.ForeColor = Color.White;
            ButtonStart.Location = new Point(149, 190);
            ButtonStart.Name = "ButtonStart";
            ButtonStart.Size = new Size(146, 36);
            ButtonStart.TabIndex = 6;
            ButtonStart.Text = "START (F2)";
            ButtonStart.UseVisualStyleBackColor = false;
            ButtonStart.Click += ButtonStart_Click;
            // 
            // LabelSecs
            // 
            LabelSecs.AutoSize = true;
            LabelSecs.BackColor = Color.Transparent;
            LabelSecs.ForeColor = Color.White;
            LabelSecs.Location = new Point(250, 50);
            LabelSecs.Name = "LabelSecs";
            LabelSecs.Size = new Size(42, 20);
            LabelSecs.TabIndex = 5;
            LabelSecs.Text = "SECS";
            LabelSecs.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TextBoxForSecs
            // 
            TextBoxForSecs.BackColor = Color.Silver;
            TextBoxForSecs.BorderStyle = BorderStyle.None;
            TextBoxForSecs.Font = new Font("Segoe UI", 15F);
            TextBoxForSecs.ForeColor = Color.FloralWhite;
            TextBoxForSecs.Location = new Point(149, 38);
            TextBoxForSecs.MaxLength = 2;
            TextBoxForSecs.Name = "TextBoxForSecs";
            TextBoxForSecs.Size = new Size(100, 34);
            TextBoxForSecs.TabIndex = 4;
            TextBoxForSecs.Text = "0";
            TextBoxForSecs.TextAlign = HorizontalAlignment.Center;
            // 
            // LabelMins
            // 
            LabelMins.AutoSize = true;
            LabelMins.BackColor = Color.Transparent;
            LabelMins.ForeColor = Color.White;
            LabelMins.Location = new Point(106, 52);
            LabelMins.Name = "LabelMins";
            LabelMins.Size = new Size(45, 20);
            LabelMins.TabIndex = 3;
            LabelMins.Text = "MINS";
            LabelMins.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TextBoxForMins
            // 
            TextBoxForMins.BackColor = Color.Silver;
            TextBoxForMins.BorderStyle = BorderStyle.None;
            TextBoxForMins.Font = new Font("Segoe UI", 15F);
            TextBoxForMins.ForeColor = Color.FloralWhite;
            TextBoxForMins.Location = new Point(0, 38);
            TextBoxForMins.MaxLength = 2;
            TextBoxForMins.Name = "TextBoxForMins";
            TextBoxForMins.Size = new Size(100, 34);
            TextBoxForMins.TabIndex = 2;
            TextBoxForMins.Text = "0";
            TextBoxForMins.TextAlign = HorizontalAlignment.Center;
            TextBoxForMins.TextChanged += TextBoxForMins_TextChanged;
            TextBoxForMins.KeyPress += TextBoxForMins_KeyPress;
            // 
            // ClickOptions
            // 
            ClickOptions.AutoSize = true;
            ClickOptions.BackColor = Color.Transparent;
            ClickOptions.Font = new Font("Segoe UI", 12F);
            ClickOptions.ForeColor = Color.White;
            ClickOptions.Location = new Point(-3, 75);
            ClickOptions.Name = "ClickOptions";
            ClickOptions.Size = new Size(128, 28);
            ClickOptions.TabIndex = 1;
            ClickOptions.Text = "Click Options";
            // 
            // ClickInterval
            // 
            ClickInterval.AutoSize = true;
            ClickInterval.BackColor = Color.Transparent;
            ClickInterval.Font = new Font("Segoe UI", 14F);
            ClickInterval.ForeColor = Color.White;
            ClickInterval.Location = new Point(0, 3);
            ClickInterval.Name = "ClickInterval";
            ClickInterval.Size = new Size(150, 32);
            ClickInterval.TabIndex = 0;
            ClickInterval.Text = "Click Interval";
            // 
            // AutoClicker
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 300);
            Controls.Add(MainPanel);
            Controls.Add(TopPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AutoClicker";
            Text = "Form1";
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MinButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)CloseButton).EndInit();
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            GroupBoxDcOc.ResumeLayout(false);
            GroupBoxDcOc.PerformLayout();
            GroupBoxLeftRight.ResumeLayout(false);
            GroupBoxLeftRight.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel TopPanel;
        private Label label1;
        private PictureBox CloseButton;
        private PictureBox MinButton;
        private Panel MainPanel;
        private Label ClickInterval;
        private Label ClickOptions;
        private TextBox TextBoxForMins;
        private TextBox TextBoxForSecs;
        private Label LabelMins;
        private Label LabelSecs;
        private Button ButtonStart;
        private Button ButtonStop;
        private Button ButtonPickLoc;
        private TextBox TextBoxForX;
        private TextBox TextBoxForY;
        private Label LabelY;
        private Label LabelX;
        private GroupBox GroupBoxLeftRight;
        private GroupBox GroupBoxDcOc;
        private RadioButton ButtonLeft;
        private RadioButton ButtonRight;
        private RadioButton ButtonOne;
        private RadioButton ButtonDouble;
    }
}
