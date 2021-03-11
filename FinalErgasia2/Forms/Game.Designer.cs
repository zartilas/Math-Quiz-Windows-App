namespace FinalErgasia2
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.timer_Countdown = new System.Windows.Forms.Timer(this.components);
            this.labelTimeLeft = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelAddition = new System.Windows.Forms.Label();
            this.textboxAdditionAns = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.labelSubtraction = new System.Windows.Forms.Label();
            this.textboxSubtractionAns = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.labelMultiplication = new System.Windows.Forms.Label();
            this.textboxMultiplicationAns = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.labelDivision = new System.Windows.Forms.Label();
            this.textboxDivisionAns = new System.Windows.Forms.TextBox();
            this.button_Start = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.timer_Playing_Duration = new System.Windows.Forms.Timer(this.components);
            this.button_Check = new System.Windows.Forms.Button();
            this.pictureBoxDivision = new System.Windows.Forms.PictureBox();
            this.pictureBoxMultiplication = new System.Windows.Forms.PictureBox();
            this.pictureBoxSubtraction = new System.Windows.Forms.PictureBox();
            this.pictureBoxAddition = new System.Windows.Forms.PictureBox();
            this.button_Calculator = new System.Windows.Forms.Button();
            this.labelAdditionResult = new System.Windows.Forms.Label();
            this.labelSubtractionResult = new System.Windows.Forms.Label();
            this.labelMultiplicationResult = new System.Windows.Forms.Label();
            this.labelDivisionResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDivision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMultiplication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSubtraction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddition)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_Countdown
            // 
            this.timer_Countdown.Interval = 1000;
            this.timer_Countdown.Tick += new System.EventHandler(this.timergame_Tick);
            // 
            // labelTimeLeft
            // 
            this.labelTimeLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTimeLeft.AutoSize = true;
            this.labelTimeLeft.BackColor = System.Drawing.Color.DarkKhaki;
            this.labelTimeLeft.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeLeft.Location = new System.Drawing.Point(128, 20);
            this.labelTimeLeft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTimeLeft.Name = "labelTimeLeft";
            this.labelTimeLeft.Size = new System.Drawing.Size(89, 27);
            this.labelTimeLeft.TabIndex = 2;
            this.labelTimeLeft.Text = "Time Left:";
            this.labelTimeLeft.Visible = false;
            // 
            // labelTime
            // 
            this.labelTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.DarkKhaki;
            this.labelTime.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.Green;
            this.labelTime.Location = new System.Drawing.Point(217, 20);
            this.labelTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(56, 27);
            this.labelTime.TabIndex = 3;
            this.labelTime.Text = "02:00";
            this.labelTime.Visible = false;
            // 
            // labelAddition
            // 
            this.labelAddition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAddition.AutoSize = true;
            this.labelAddition.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelAddition.Location = new System.Drawing.Point(99, 66);
            this.labelAddition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAddition.Name = "labelAddition";
            this.labelAddition.Size = new System.Drawing.Size(89, 29);
            this.labelAddition.TabIndex = 8;
            this.labelAddition.Text = "0   +   0";
            this.labelAddition.Visible = false;
            // 
            // textboxAdditionAns
            // 
            this.textboxAdditionAns.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textboxAdditionAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.textboxAdditionAns.Location = new System.Drawing.Point(239, 68);
            this.textboxAdditionAns.Margin = new System.Windows.Forms.Padding(2);
            this.textboxAdditionAns.MaxLength = 2;
            this.textboxAdditionAns.Name = "textboxAdditionAns";
            this.textboxAdditionAns.ShortcutsEnabled = false;
            this.textboxAdditionAns.Size = new System.Drawing.Size(36, 28);
            this.textboxAdditionAns.TabIndex = 10;
            this.textboxAdditionAns.Visible = false;
            this.textboxAdditionAns.TextChanged += new System.EventHandler(this.textboxAdditionAns_TextChanged);
            this.textboxAdditionAns.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxAnswers_KeyDown);
            this.textboxAdditionAns.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAnswers_KeyPress);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label8.Location = new System.Drawing.Point(111, 101);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 29);
            this.label8.TabIndex = 13;
            this.label8.Text = "-";
            this.label8.Visible = false;
            // 
            // labelSubtraction
            // 
            this.labelSubtraction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSubtraction.AutoSize = true;
            this.labelSubtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelSubtraction.Location = new System.Drawing.Point(99, 102);
            this.labelSubtraction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSubtraction.Name = "labelSubtraction";
            this.labelSubtraction.Size = new System.Drawing.Size(83, 29);
            this.labelSubtraction.TabIndex = 14;
            this.labelSubtraction.Text = "0   -   0";
            this.labelSubtraction.Visible = false;
            // 
            // textboxSubtractionAns
            // 
            this.textboxSubtractionAns.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textboxSubtractionAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.textboxSubtractionAns.Location = new System.Drawing.Point(239, 102);
            this.textboxSubtractionAns.Margin = new System.Windows.Forms.Padding(2);
            this.textboxSubtractionAns.MaxLength = 2;
            this.textboxSubtractionAns.Name = "textboxSubtractionAns";
            this.textboxSubtractionAns.ShortcutsEnabled = false;
            this.textboxSubtractionAns.Size = new System.Drawing.Size(36, 28);
            this.textboxSubtractionAns.TabIndex = 16;
            this.textboxSubtractionAns.Visible = false;
            this.textboxSubtractionAns.TextChanged += new System.EventHandler(this.textboxSubtractionAns_TextChanged);
            this.textboxSubtractionAns.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxAnswers_KeyDown);
            this.textboxSubtractionAns.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAnswers_KeyPress);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label12.Location = new System.Drawing.Point(111, 135);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 29);
            this.label12.TabIndex = 18;
            this.label12.Text = "x";
            this.label12.Visible = false;
            // 
            // labelMultiplication
            // 
            this.labelMultiplication.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMultiplication.AutoSize = true;
            this.labelMultiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelMultiplication.Location = new System.Drawing.Point(99, 136);
            this.labelMultiplication.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMultiplication.Name = "labelMultiplication";
            this.labelMultiplication.Size = new System.Drawing.Size(86, 29);
            this.labelMultiplication.TabIndex = 19;
            this.labelMultiplication.Text = "0   x   0";
            this.labelMultiplication.Visible = false;
            // 
            // textboxMultiplicationAns
            // 
            this.textboxMultiplicationAns.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textboxMultiplicationAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.textboxMultiplicationAns.Location = new System.Drawing.Point(239, 136);
            this.textboxMultiplicationAns.Margin = new System.Windows.Forms.Padding(2);
            this.textboxMultiplicationAns.MaxLength = 3;
            this.textboxMultiplicationAns.Name = "textboxMultiplicationAns";
            this.textboxMultiplicationAns.ShortcutsEnabled = false;
            this.textboxMultiplicationAns.Size = new System.Drawing.Size(36, 28);
            this.textboxMultiplicationAns.TabIndex = 21;
            this.textboxMultiplicationAns.Visible = false;
            this.textboxMultiplicationAns.TextChanged += new System.EventHandler(this.textboxMultiplicationAns_TextChanged);
            this.textboxMultiplicationAns.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxAnswers_KeyDown);
            this.textboxMultiplicationAns.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAnswers_KeyPress);
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label16.Location = new System.Drawing.Point(111, 168);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 29);
            this.label16.TabIndex = 23;
            this.label16.Text = "÷";
            this.label16.Visible = false;
            // 
            // labelDivision
            // 
            this.labelDivision.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDivision.AutoSize = true;
            this.labelDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelDivision.Location = new System.Drawing.Point(99, 169);
            this.labelDivision.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDivision.Name = "labelDivision";
            this.labelDivision.Size = new System.Drawing.Size(89, 29);
            this.labelDivision.TabIndex = 24;
            this.labelDivision.Text = "1   ÷   1";
            this.labelDivision.Visible = false;
            // 
            // textboxDivisionAns
            // 
            this.textboxDivisionAns.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textboxDivisionAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.textboxDivisionAns.Location = new System.Drawing.Point(239, 169);
            this.textboxDivisionAns.Margin = new System.Windows.Forms.Padding(2);
            this.textboxDivisionAns.MaxLength = 2;
            this.textboxDivisionAns.Name = "textboxDivisionAns";
            this.textboxDivisionAns.ShortcutsEnabled = false;
            this.textboxDivisionAns.Size = new System.Drawing.Size(36, 28);
            this.textboxDivisionAns.TabIndex = 26;
            this.textboxDivisionAns.Visible = false;
            this.textboxDivisionAns.TextChanged += new System.EventHandler(this.textboxDivisionAns_TextChanged);
            this.textboxDivisionAns.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxAnswers_KeyDown);
            this.textboxDivisionAns.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAnswers_KeyPress);
            // 
            // button_Start
            // 
            this.button_Start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Start.BackColor = System.Drawing.Color.DarkOrange;
            this.button_Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Start.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Start.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Start.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Start.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_Start.Location = new System.Drawing.Point(89, 88);
            this.button_Start.Margin = new System.Windows.Forms.Padding(2);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(182, 76);
            this.button_Start.TabIndex = 28;
            this.button_Start.Text = "Start";
            this.button_Start.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Start.UseVisualStyleBackColor = false;
            this.button_Start.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Calculator.png");
            // 
            // timer_Playing_Duration
            // 
            this.timer_Playing_Duration.Interval = 1000;
            this.timer_Playing_Duration.Tick += new System.EventHandler(this.timer_Playing_Duration_Tick);
            // 
            // button_Check
            // 
            this.button_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Check.BackColor = System.Drawing.Color.DarkOrange;
            this.button_Check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Check.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_Check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Check.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Check.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Check.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_Check.Location = new System.Drawing.Point(133, 209);
            this.button_Check.Margin = new System.Windows.Forms.Padding(2);
            this.button_Check.Name = "button_Check";
            this.button_Check.Size = new System.Drawing.Size(110, 44);
            this.button_Check.TabIndex = 34;
            this.button_Check.Text = "Check";
            this.button_Check.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Check.UseVisualStyleBackColor = false;
            this.button_Check.Visible = false;
            this.button_Check.Click += new System.EventHandler(this.button_Check_Click);
            // 
            // pictureBoxDivision
            // 
            this.pictureBoxDivision.Image = global::FinalErgasia2.Properties.Resources.Correct;
            this.pictureBoxDivision.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBoxDivision.Location = new System.Drawing.Point(280, 169);
            this.pictureBoxDivision.Name = "pictureBoxDivision";
            this.pictureBoxDivision.Size = new System.Drawing.Size(26, 29);
            this.pictureBoxDivision.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDivision.TabIndex = 33;
            this.pictureBoxDivision.TabStop = false;
            this.pictureBoxDivision.Visible = false;
            // 
            // pictureBoxMultiplication
            // 
            this.pictureBoxMultiplication.Image = global::FinalErgasia2.Properties.Resources.Correct;
            this.pictureBoxMultiplication.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBoxMultiplication.Location = new System.Drawing.Point(280, 136);
            this.pictureBoxMultiplication.Name = "pictureBoxMultiplication";
            this.pictureBoxMultiplication.Size = new System.Drawing.Size(26, 29);
            this.pictureBoxMultiplication.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMultiplication.TabIndex = 32;
            this.pictureBoxMultiplication.TabStop = false;
            this.pictureBoxMultiplication.Visible = false;
            // 
            // pictureBoxSubtraction
            // 
            this.pictureBoxSubtraction.Image = global::FinalErgasia2.Properties.Resources.Correct;
            this.pictureBoxSubtraction.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBoxSubtraction.Location = new System.Drawing.Point(280, 102);
            this.pictureBoxSubtraction.Name = "pictureBoxSubtraction";
            this.pictureBoxSubtraction.Size = new System.Drawing.Size(26, 29);
            this.pictureBoxSubtraction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSubtraction.TabIndex = 31;
            this.pictureBoxSubtraction.TabStop = false;
            this.pictureBoxSubtraction.Visible = false;
            // 
            // pictureBoxAddition
            // 
            this.pictureBoxAddition.Image = global::FinalErgasia2.Properties.Resources.Correct;
            this.pictureBoxAddition.Location = new System.Drawing.Point(280, 67);
            this.pictureBoxAddition.Name = "pictureBoxAddition";
            this.pictureBoxAddition.Size = new System.Drawing.Size(26, 29);
            this.pictureBoxAddition.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAddition.TabIndex = 30;
            this.pictureBoxAddition.TabStop = false;
            this.pictureBoxAddition.Visible = false;
            // 
            // button_Calculator
            // 
            this.button_Calculator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Calculator.BackColor = System.Drawing.Color.DarkOrange;
            this.button_Calculator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Calculator.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_Calculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Calculator.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Calculator.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Calculator.ImageIndex = 0;
            this.button_Calculator.ImageList = this.imageList;
            this.button_Calculator.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_Calculator.Location = new System.Drawing.Point(11, 270);
            this.button_Calculator.Margin = new System.Windows.Forms.Padding(2);
            this.button_Calculator.Name = "button_Calculator";
            this.button_Calculator.Size = new System.Drawing.Size(208, 46);
            this.button_Calculator.TabIndex = 29;
            this.button_Calculator.TabStop = false;
            this.button_Calculator.Text = " Calculator";
            this.button_Calculator.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Calculator.UseVisualStyleBackColor = false;
            this.button_Calculator.Visible = false;
            this.button_Calculator.Click += new System.EventHandler(this.buttonCalculator_Click);
            // 
            // labelAdditionResult
            // 
            this.labelAdditionResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAdditionResult.AutoSize = true;
            this.labelAdditionResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelAdditionResult.Location = new System.Drawing.Point(211, 68);
            this.labelAdditionResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAdditionResult.Name = "labelAdditionResult";
            this.labelAdditionResult.Size = new System.Drawing.Size(27, 29);
            this.labelAdditionResult.TabIndex = 35;
            this.labelAdditionResult.Text = "=";
            this.labelAdditionResult.Visible = false;
            // 
            // labelSubtractionResult
            // 
            this.labelSubtractionResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSubtractionResult.AutoSize = true;
            this.labelSubtractionResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelSubtractionResult.Location = new System.Drawing.Point(211, 101);
            this.labelSubtractionResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSubtractionResult.Name = "labelSubtractionResult";
            this.labelSubtractionResult.Size = new System.Drawing.Size(27, 29);
            this.labelSubtractionResult.TabIndex = 36;
            this.labelSubtractionResult.Text = "=";
            this.labelSubtractionResult.Visible = false;
            // 
            // labelMultiplicationResult
            // 
            this.labelMultiplicationResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMultiplicationResult.AutoSize = true;
            this.labelMultiplicationResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelMultiplicationResult.Location = new System.Drawing.Point(211, 136);
            this.labelMultiplicationResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMultiplicationResult.Name = "labelMultiplicationResult";
            this.labelMultiplicationResult.Size = new System.Drawing.Size(27, 29);
            this.labelMultiplicationResult.TabIndex = 37;
            this.labelMultiplicationResult.Text = "=";
            this.labelMultiplicationResult.Visible = false;
            // 
            // labelDivisionResult
            // 
            this.labelDivisionResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDivisionResult.AutoSize = true;
            this.labelDivisionResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelDivisionResult.Location = new System.Drawing.Point(211, 169);
            this.labelDivisionResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDivisionResult.Name = "labelDivisionResult";
            this.labelDivisionResult.Size = new System.Drawing.Size(27, 29);
            this.labelDivisionResult.TabIndex = 38;
            this.labelDivisionResult.Text = "=";
            this.labelDivisionResult.Visible = false;
            // 
            // Game
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(151)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(363, 327);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.labelDivisionResult);
            this.Controls.Add(this.labelMultiplicationResult);
            this.Controls.Add(this.labelSubtractionResult);
            this.Controls.Add(this.labelAdditionResult);
            this.Controls.Add(this.button_Check);
            this.Controls.Add(this.pictureBoxDivision);
            this.Controls.Add(this.pictureBoxMultiplication);
            this.Controls.Add(this.pictureBoxSubtraction);
            this.Controls.Add(this.pictureBoxAddition);
            this.Controls.Add(this.button_Calculator);
            this.Controls.Add(this.textboxDivisionAns);
            this.Controls.Add(this.labelDivision);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textboxMultiplicationAns);
            this.Controls.Add(this.labelMultiplication);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textboxSubtractionAns);
            this.Controls.Add(this.labelSubtraction);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textboxAdditionAns);
            this.Controls.Add(this.labelAddition);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelTimeLeft);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(379, 414);
            this.MinimumSize = new System.Drawing.Size(304, 332);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Math Quiz";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDivision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMultiplication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSubtraction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer_Countdown;
        private System.Windows.Forms.Label labelTimeLeft;
        private System.Windows.Forms.Label labelTime;
        public System.Windows.Forms.Label labelAddition;
        public System.Windows.Forms.TextBox textboxAdditionAns;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label labelSubtraction;
        public System.Windows.Forms.TextBox textboxSubtractionAns;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label labelMultiplication;
        public System.Windows.Forms.TextBox textboxMultiplicationAns;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.Label labelDivision;
        public System.Windows.Forms.TextBox textboxDivisionAns;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.PictureBox pictureBoxAddition;
        private System.Windows.Forms.PictureBox pictureBoxSubtraction;
        private System.Windows.Forms.PictureBox pictureBoxMultiplication;
        private System.Windows.Forms.PictureBox pictureBoxDivision;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Timer timer_Playing_Duration;
        public System.Windows.Forms.Button button_Calculator;
        private System.Windows.Forms.Button button_Check;
        public System.Windows.Forms.Label labelAdditionResult;
        public System.Windows.Forms.Label labelSubtractionResult;
        public System.Windows.Forms.Label labelMultiplicationResult;
        public System.Windows.Forms.Label labelDivisionResult;
    }
}