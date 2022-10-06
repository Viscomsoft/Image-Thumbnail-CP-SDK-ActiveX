namespace WindowsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.scrollTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.scrollUpButton = new System.Windows.Forms.Button();
            this.scrollDownButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.displayModeComboBox = new System.Windows.Forms.ComboBox();
            this.addFileButton = new System.Windows.Forms.Button();
            this.bgColorButton = new System.Windows.Forms.Button();
            this.clipColorButton = new System.Windows.Forms.Button();
            this.highColorButton = new System.Windows.Forms.Button();
            this.borderColorButton = new System.Windows.Forms.Button();
            this.shaddowColorButton = new System.Windows.Forms.Button();
            this.textColorButton = new System.Windows.Forms.Button();
            this.captionButton = new System.Windows.Forms.Button();
            this.acdcButton = new System.Windows.Forms.Button();
            this.normalStyleButton = new System.Windows.Forms.Button();
            this.deleteAllButton = new System.Windows.Forms.Button();
            this.deleteClipButton = new System.Windows.Forms.Button();
            this.displayFileNameButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.indexTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteTypeButton = new System.Windows.Forms.Button();
            this.addTypeButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.fileExtTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.topMargin = new System.Windows.Forms.NumericUpDown();
            this.topMarginButton = new System.Windows.Forms.Button();
            this.bottomMarginButton = new System.Windows.Forms.Button();
            this.bottomMargin = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.fontSizeButton = new System.Windows.Forms.Button();
            this.fontSize = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.fontTopButton = new System.Windows.Forms.Button();
            this.fontTop = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.clipWidthButton = new System.Windows.Forms.Button();
            this.clipWidth = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.clipHeightButton = new System.Windows.Forms.Button();
            this.clipHeight = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.boldCheckBox = new System.Windows.Forms.CheckBox();
            this.italicCheckBox = new System.Windows.Forms.CheckBox();
            this.underlineCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.cborotate = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.PageNoTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbofilter = new System.Windows.Forms.ComboBox();
            this.axImageThumbnailCP1 = new AxIMAGETHUMBNAILCPLib.AxImageThumbnailCP();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topMargin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomMargin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clipWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clipHeight)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axImageThumbnailCP1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "ScrollBar Type";
            // 
            // scrollTypeComboBox
            // 
            this.scrollTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.scrollTypeComboBox.FormattingEnabled = true;
            this.scrollTypeComboBox.Location = new System.Drawing.Point(94, 14);
            this.scrollTypeComboBox.Name = "scrollTypeComboBox";
            this.scrollTypeComboBox.Size = new System.Drawing.Size(121, 20);
            this.scrollTypeComboBox.TabIndex = 1;
            this.scrollTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.scrollTypeComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Programmatically Scrolling";
            // 
            // scrollUpButton
            // 
            this.scrollUpButton.Location = new System.Drawing.Point(15, 54);
            this.scrollUpButton.Name = "scrollUpButton";
            this.scrollUpButton.Size = new System.Drawing.Size(119, 21);
            this.scrollUpButton.TabIndex = 3;
            this.scrollUpButton.Text = "Scroll one line up";
            this.scrollUpButton.UseVisualStyleBackColor = true;
            this.scrollUpButton.Click += new System.EventHandler(this.scrollUpButton_Click);
            // 
            // scrollDownButton
            // 
            this.scrollDownButton.Location = new System.Drawing.Point(15, 81);
            this.scrollDownButton.Name = "scrollDownButton";
            this.scrollDownButton.Size = new System.Drawing.Size(119, 21);
            this.scrollDownButton.TabIndex = 4;
            this.scrollDownButton.Text = "Scroll one line down";
            this.scrollDownButton.UseVisualStyleBackColor = true;
            this.scrollDownButton.Click += new System.EventHandler(this.scrollDownButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Display Mode";
            // 
            // displayModeComboBox
            // 
            this.displayModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.displayModeComboBox.FormattingEnabled = true;
            this.displayModeComboBox.Location = new System.Drawing.Point(15, 120);
            this.displayModeComboBox.Name = "displayModeComboBox";
            this.displayModeComboBox.Size = new System.Drawing.Size(170, 20);
            this.displayModeComboBox.TabIndex = 6;
            this.displayModeComboBox.SelectedIndexChanged += new System.EventHandler(this.displayModeComboBox_SelectedIndexChanged);
            // 
            // addFileButton
            // 
            this.addFileButton.Location = new System.Drawing.Point(18, 206);
            this.addFileButton.Name = "addFileButton";
            this.addFileButton.Size = new System.Drawing.Size(170, 21);
            this.addFileButton.TabIndex = 7;
            this.addFileButton.Text = "Add File";
            this.addFileButton.UseVisualStyleBackColor = true;
            this.addFileButton.Click += new System.EventHandler(this.addFileButton_Click);
            // 
            // bgColorButton
            // 
            this.bgColorButton.Location = new System.Drawing.Point(17, 263);
            this.bgColorButton.Name = "bgColorButton";
            this.bgColorButton.Size = new System.Drawing.Size(170, 21);
            this.bgColorButton.TabIndex = 8;
            this.bgColorButton.Text = "Background Color";
            this.bgColorButton.UseVisualStyleBackColor = true;
            this.bgColorButton.Click += new System.EventHandler(this.bgColorButton_Click);
            // 
            // clipColorButton
            // 
            this.clipColorButton.Location = new System.Drawing.Point(17, 289);
            this.clipColorButton.Name = "clipColorButton";
            this.clipColorButton.Size = new System.Drawing.Size(170, 21);
            this.clipColorButton.TabIndex = 9;
            this.clipColorButton.Text = "Clip Color";
            this.clipColorButton.UseVisualStyleBackColor = true;
            this.clipColorButton.Click += new System.EventHandler(this.clipColorButton_Click);
            // 
            // highColorButton
            // 
            this.highColorButton.Location = new System.Drawing.Point(17, 316);
            this.highColorButton.Name = "highColorButton";
            this.highColorButton.Size = new System.Drawing.Size(170, 21);
            this.highColorButton.TabIndex = 10;
            this.highColorButton.Text = "Highlight color";
            this.highColorButton.UseVisualStyleBackColor = true;
            this.highColorButton.Click += new System.EventHandler(this.highColorButton_Click);
            // 
            // borderColorButton
            // 
            this.borderColorButton.Location = new System.Drawing.Point(17, 343);
            this.borderColorButton.Name = "borderColorButton";
            this.borderColorButton.Size = new System.Drawing.Size(170, 21);
            this.borderColorButton.TabIndex = 11;
            this.borderColorButton.Text = "Border color";
            this.borderColorButton.UseVisualStyleBackColor = true;
            this.borderColorButton.Click += new System.EventHandler(this.borderColorButton_Click);
            // 
            // shaddowColorButton
            // 
            this.shaddowColorButton.Location = new System.Drawing.Point(17, 370);
            this.shaddowColorButton.Name = "shaddowColorButton";
            this.shaddowColorButton.Size = new System.Drawing.Size(170, 21);
            this.shaddowColorButton.TabIndex = 12;
            this.shaddowColorButton.Text = "Shadow Color";
            this.shaddowColorButton.UseVisualStyleBackColor = true;
            this.shaddowColorButton.Click += new System.EventHandler(this.shaddowColorButton_Click);
            // 
            // textColorButton
            // 
            this.textColorButton.Location = new System.Drawing.Point(17, 396);
            this.textColorButton.Name = "textColorButton";
            this.textColorButton.Size = new System.Drawing.Size(170, 21);
            this.textColorButton.TabIndex = 13;
            this.textColorButton.Text = "Text Color";
            this.textColorButton.UseVisualStyleBackColor = true;
            this.textColorButton.Click += new System.EventHandler(this.textColorButton_Click);
            // 
            // captionButton
            // 
            this.captionButton.Location = new System.Drawing.Point(17, 423);
            this.captionButton.Name = "captionButton";
            this.captionButton.Size = new System.Drawing.Size(170, 21);
            this.captionButton.TabIndex = 14;
            this.captionButton.Text = "Update Caption Text";
            this.captionButton.UseVisualStyleBackColor = true;
            this.captionButton.Click += new System.EventHandler(this.captionButton_Click);
            // 
            // acdcButton
            // 
            this.acdcButton.Location = new System.Drawing.Point(17, 450);
            this.acdcButton.Name = "acdcButton";
            this.acdcButton.Size = new System.Drawing.Size(170, 21);
            this.acdcButton.TabIndex = 15;
            this.acdcButton.Text = "ACDSee Style";
            this.acdcButton.UseVisualStyleBackColor = true;
            this.acdcButton.Click += new System.EventHandler(this.acdcButton_Click);
            // 
            // normalStyleButton
            // 
            this.normalStyleButton.Location = new System.Drawing.Point(17, 477);
            this.normalStyleButton.Name = "normalStyleButton";
            this.normalStyleButton.Size = new System.Drawing.Size(170, 21);
            this.normalStyleButton.TabIndex = 16;
            this.normalStyleButton.Text = "Normal Style";
            this.normalStyleButton.UseVisualStyleBackColor = true;
            this.normalStyleButton.Click += new System.EventHandler(this.normalStyleButton_Click);
            // 
            // deleteAllButton
            // 
            this.deleteAllButton.Location = new System.Drawing.Point(17, 504);
            this.deleteAllButton.Name = "deleteAllButton";
            this.deleteAllButton.Size = new System.Drawing.Size(170, 21);
            this.deleteAllButton.TabIndex = 17;
            this.deleteAllButton.Text = "Delete All";
            this.deleteAllButton.UseVisualStyleBackColor = true;
            this.deleteAllButton.Click += new System.EventHandler(this.deleteAllButton_Click);
            // 
            // deleteClipButton
            // 
            this.deleteClipButton.Location = new System.Drawing.Point(17, 530);
            this.deleteClipButton.Name = "deleteClipButton";
            this.deleteClipButton.Size = new System.Drawing.Size(170, 21);
            this.deleteClipButton.TabIndex = 18;
            this.deleteClipButton.Text = "Delete Selected Clip";
            this.deleteClipButton.UseVisualStyleBackColor = true;
            this.deleteClipButton.Click += new System.EventHandler(this.deleteClipButton_Click);
            // 
            // displayFileNameButton
            // 
            this.displayFileNameButton.Location = new System.Drawing.Point(17, 557);
            this.displayFileNameButton.Name = "displayFileNameButton";
            this.displayFileNameButton.Size = new System.Drawing.Size(170, 21);
            this.displayFileNameButton.TabIndex = 19;
            this.displayFileNameButton.Text = "Display Selected FileName";
            this.displayFileNameButton.UseVisualStyleBackColor = true;
            this.displayFileNameButton.Click += new System.EventHandler(this.displayFileNameButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(221, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(495, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Accept Drop Files and you can drag the image to reorder the thumbnail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 22;
            this.label5.Text = "File Name";
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(281, 384);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(202, 21);
            this.fileNameTextBox.TabIndex = 23;
            // 
            // indexTextBox
            // 
            this.indexTextBox.Location = new System.Drawing.Point(581, 384);
            this.indexTextBox.Name = "indexTextBox";
            this.indexTextBox.Size = new System.Drawing.Size(93, 21);
            this.indexTextBox.TabIndex = 25;
            this.indexTextBox.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(489, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 24;
            this.label6.Text = "Current Index";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteTypeButton);
            this.groupBox1.Controls.Add(this.addTypeButton);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.fileExtTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(224, 434);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 165);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "You can display specific images for specific files";
            // 
            // deleteTypeButton
            // 
            this.deleteTypeButton.Location = new System.Drawing.Point(391, 74);
            this.deleteTypeButton.Name = "deleteTypeButton";
            this.deleteTypeButton.Size = new System.Drawing.Size(95, 21);
            this.deleteTypeButton.TabIndex = 4;
            this.deleteTypeButton.Text = "Delete file type";
            this.deleteTypeButton.UseVisualStyleBackColor = true;
            this.deleteTypeButton.Click += new System.EventHandler(this.deleteTypeButton_Click);
            // 
            // addTypeButton
            // 
            this.addTypeButton.Location = new System.Drawing.Point(391, 47);
            this.addTypeButton.Name = "addTypeButton";
            this.addTypeButton.Size = new System.Drawing.Size(95, 21);
            this.addTypeButton.TabIndex = 3;
            this.addTypeButton.Text = "Add file type";
            this.addTypeButton.UseVisualStyleBackColor = true;
            this.addTypeButton.Click += new System.EventHandler(this.addTypeButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(9, 47);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(376, 100);
            this.listBox1.TabIndex = 2;
            // 
            // fileExtTextBox
            // 
            this.fileExtTextBox.Location = new System.Drawing.Point(201, 18);
            this.fileExtTextBox.Name = "fileExtTextBox";
            this.fileExtTextBox.Size = new System.Drawing.Size(69, 21);
            this.fileExtTextBox.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "enter File extension e.g.(ppt)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(722, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 27;
            this.label8.Text = "Top Margin";
            // 
            // topMargin
            // 
            this.topMargin.Location = new System.Drawing.Point(802, 32);
            this.topMargin.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.topMargin.Name = "topMargin";
            this.topMargin.Size = new System.Drawing.Size(62, 21);
            this.topMargin.TabIndex = 28;
            // 
            // topMarginButton
            // 
            this.topMarginButton.Location = new System.Drawing.Point(870, 30);
            this.topMarginButton.Name = "topMarginButton";
            this.topMarginButton.Size = new System.Drawing.Size(33, 21);
            this.topMarginButton.TabIndex = 29;
            this.topMarginButton.Text = "Set";
            this.topMarginButton.UseVisualStyleBackColor = true;
            this.topMarginButton.Click += new System.EventHandler(this.topMarginButton_Click);
            // 
            // bottomMarginButton
            // 
            this.bottomMarginButton.Location = new System.Drawing.Point(870, 56);
            this.bottomMarginButton.Name = "bottomMarginButton";
            this.bottomMarginButton.Size = new System.Drawing.Size(33, 21);
            this.bottomMarginButton.TabIndex = 32;
            this.bottomMarginButton.Text = "Set";
            this.bottomMarginButton.UseVisualStyleBackColor = true;
            this.bottomMarginButton.Click += new System.EventHandler(this.bottomMarginButton_Click);
            // 
            // bottomMargin
            // 
            this.bottomMargin.Location = new System.Drawing.Point(802, 59);
            this.bottomMargin.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.bottomMargin.Name = "bottomMargin";
            this.bottomMargin.Size = new System.Drawing.Size(62, 21);
            this.bottomMargin.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(722, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 12);
            this.label9.TabIndex = 30;
            this.label9.Text = "Bottom Margin";
            // 
            // fontSizeButton
            // 
            this.fontSizeButton.Location = new System.Drawing.Point(870, 83);
            this.fontSizeButton.Name = "fontSizeButton";
            this.fontSizeButton.Size = new System.Drawing.Size(33, 21);
            this.fontSizeButton.TabIndex = 35;
            this.fontSizeButton.Text = "Set";
            this.fontSizeButton.UseVisualStyleBackColor = true;
            this.fontSizeButton.Click += new System.EventHandler(this.fontSizeButton_Click);
            // 
            // fontSize
            // 
            this.fontSize.Location = new System.Drawing.Point(802, 86);
            this.fontSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.fontSize.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.fontSize.Name = "fontSize";
            this.fontSize.Size = new System.Drawing.Size(62, 21);
            this.fontSize.TabIndex = 34;
            this.fontSize.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(722, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 33;
            this.label10.Text = "Font Size";
            // 
            // fontTopButton
            // 
            this.fontTopButton.Location = new System.Drawing.Point(870, 110);
            this.fontTopButton.Name = "fontTopButton";
            this.fontTopButton.Size = new System.Drawing.Size(33, 21);
            this.fontTopButton.TabIndex = 38;
            this.fontTopButton.Text = "Set";
            this.fontTopButton.UseVisualStyleBackColor = true;
            this.fontTopButton.Click += new System.EventHandler(this.fontTopButton_Click);
            // 
            // fontTop
            // 
            this.fontTop.Location = new System.Drawing.Point(802, 113);
            this.fontTop.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.fontTop.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.fontTop.Name = "fontTop";
            this.fontTop.Size = new System.Drawing.Size(62, 21);
            this.fontTop.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(722, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 36;
            this.label11.Text = "Font Top";
            // 
            // clipWidthButton
            // 
            this.clipWidthButton.Location = new System.Drawing.Point(870, 137);
            this.clipWidthButton.Name = "clipWidthButton";
            this.clipWidthButton.Size = new System.Drawing.Size(33, 21);
            this.clipWidthButton.TabIndex = 41;
            this.clipWidthButton.Text = "Set";
            this.clipWidthButton.UseVisualStyleBackColor = true;
            this.clipWidthButton.Click += new System.EventHandler(this.clipWidthButton_Click);
            // 
            // clipWidth
            // 
            this.clipWidth.Location = new System.Drawing.Point(802, 139);
            this.clipWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.clipWidth.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.clipWidth.Name = "clipWidth";
            this.clipWidth.Size = new System.Drawing.Size(62, 21);
            this.clipWidth.TabIndex = 40;
            this.clipWidth.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(722, 141);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 39;
            this.label12.Text = "Clip Width";
            // 
            // clipHeightButton
            // 
            this.clipHeightButton.Location = new System.Drawing.Point(870, 163);
            this.clipHeightButton.Name = "clipHeightButton";
            this.clipHeightButton.Size = new System.Drawing.Size(33, 21);
            this.clipHeightButton.TabIndex = 44;
            this.clipHeightButton.Text = "Set";
            this.clipHeightButton.UseVisualStyleBackColor = true;
            this.clipHeightButton.Click += new System.EventHandler(this.clipHeightButton_Click);
            // 
            // clipHeight
            // 
            this.clipHeight.Location = new System.Drawing.Point(802, 166);
            this.clipHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.clipHeight.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.clipHeight.Name = "clipHeight";
            this.clipHeight.Size = new System.Drawing.Size(62, 21);
            this.clipHeight.TabIndex = 43;
            this.clipHeight.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(722, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 12);
            this.label13.TabIndex = 42;
            this.label13.Text = "Clip Height";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(722, 190);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(181, 37);
            this.label14.TabIndex = 45;
            this.label14.Text = "If the clip size is big, you should use high Display Mode property";
            // 
            // boldCheckBox
            // 
            this.boldCheckBox.AutoSize = true;
            this.boldCheckBox.Location = new System.Drawing.Point(725, 225);
            this.boldCheckBox.Name = "boldCheckBox";
            this.boldCheckBox.Size = new System.Drawing.Size(108, 16);
            this.boldCheckBox.TabIndex = 46;
            this.boldCheckBox.Text = "Clip Font Bold";
            this.boldCheckBox.UseVisualStyleBackColor = true;
            this.boldCheckBox.CheckedChanged += new System.EventHandler(this.boldCheckBox_CheckedChanged);
            // 
            // italicCheckBox
            // 
            this.italicCheckBox.AutoSize = true;
            this.italicCheckBox.Location = new System.Drawing.Point(725, 246);
            this.italicCheckBox.Name = "italicCheckBox";
            this.italicCheckBox.Size = new System.Drawing.Size(120, 16);
            this.italicCheckBox.TabIndex = 47;
            this.italicCheckBox.Text = "Clip Font Italic";
            this.italicCheckBox.UseVisualStyleBackColor = true;
            this.italicCheckBox.CheckedChanged += new System.EventHandler(this.italicCheckBox_CheckedChanged);
            // 
            // underlineCheckBox
            // 
            this.underlineCheckBox.AutoSize = true;
            this.underlineCheckBox.Location = new System.Drawing.Point(725, 268);
            this.underlineCheckBox.Name = "underlineCheckBox";
            this.underlineCheckBox.Size = new System.Drawing.Size(138, 16);
            this.underlineCheckBox.TabIndex = 48;
            this.underlineCheckBox.Text = "Clip Font Underline";
            this.underlineCheckBox.UseVisualStyleBackColor = true;
            this.underlineCheckBox.CheckedChanged += new System.EventHandler(this.underlineCheckBox_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 21);
            this.button1.TabIndex = 49;
            this.button1.Text = "Add File from folder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(717, 302);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 12);
            this.label15.TabIndex = 50;
            this.label15.Text = "Rotate Type";
            // 
            // cborotate
            // 
            this.cborotate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cborotate.FormattingEnabled = true;
            this.cborotate.Location = new System.Drawing.Point(720, 322);
            this.cborotate.Name = "cborotate";
            this.cborotate.Size = new System.Drawing.Size(138, 20);
            this.cborotate.TabIndex = 51;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(720, 346);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 30);
            this.button2.TabIndex = 52;
            this.button2.Text = "Rotate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(720, 389);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 29);
            this.button3.TabIndex = 53;
            this.button3.Text = "Select one Clip";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(721, 428);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 28);
            this.button4.TabIndex = 54;
            this.button4.Text = "Select Multiple Clips";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(722, 465);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 34);
            this.button5.TabIndex = 55;
            this.button5.Text = "UnSelect Multiple Clips";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(725, 512);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(138, 34);
            this.button6.TabIndex = 56;
            this.button6.Text = "Visible clips";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(221, 417);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 12);
            this.label16.TabIndex = 57;
            this.label16.Text = "Page No";
            // 
            // PageNoTextBox
            // 
            this.PageNoTextBox.Location = new System.Drawing.Point(281, 412);
            this.PageNoTextBox.Name = "PageNoTextBox";
            this.PageNoTextBox.Size = new System.Drawing.Size(89, 21);
            this.PageNoTextBox.TabIndex = 58;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbofilter);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(15, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(203, 65);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Folder Filter";
            // 
            // cbofilter
            // 
            this.cbofilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbofilter.FormattingEnabled = true;
            this.cbofilter.Location = new System.Drawing.Point(6, 13);
            this.cbofilter.Name = "cbofilter";
            this.cbofilter.Size = new System.Drawing.Size(191, 20);
            this.cbofilter.TabIndex = 0;
            // 
            // axImageThumbnailCP1
            // 
            this.axImageThumbnailCP1.Enabled = true;
            this.axImageThumbnailCP1.Location = new System.Drawing.Point(224, 40);
            this.axImageThumbnailCP1.Name = "axImageThumbnailCP1";
            this.axImageThumbnailCP1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axImageThumbnailCP1.OcxState")));
            this.axImageThumbnailCP1.Size = new System.Drawing.Size(474, 367);
            this.axImageThumbnailCP1.TabIndex = 60;
            this.axImageThumbnailCP1.OnDropFiles += new AxIMAGETHUMBNAILCPLib._DImageThumbnailCPEvents_OnDropFilesEventHandler(this.axImageThumbnailCP1_OnDropFiles_1);
            this.axImageThumbnailCP1.ClickEvent += new AxIMAGETHUMBNAILCPLib._DImageThumbnailCPEvents_ClickEventHandler(this.axImageThumbnailCP1_ClickEvent);
            this.axImageThumbnailCP1.RightPress += new AxIMAGETHUMBNAILCPLib._DImageThumbnailCPEvents_RightPressEventHandler(this.axImageThumbnailCP1_RightPress);
            this.axImageThumbnailCP1.LeftPress += new AxIMAGETHUMBNAILCPLib._DImageThumbnailCPEvents_LeftPressEventHandler(this.axImageThumbnailCP1_LeftPress);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(18, 236);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(170, 21);
            this.button7.TabIndex = 61;
            this.button7.Text = "Get PDF Information";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 602);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.axImageThumbnailCP1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.PageNoTextBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cborotate);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.underlineCheckBox);
            this.Controls.Add(this.italicCheckBox);
            this.Controls.Add(this.boldCheckBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.clipHeightButton);
            this.Controls.Add(this.clipHeight);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.clipWidthButton);
            this.Controls.Add(this.clipWidth);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.fontTopButton);
            this.Controls.Add(this.fontTop);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.fontSizeButton);
            this.Controls.Add(this.fontSize);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bottomMarginButton);
            this.Controls.Add(this.bottomMargin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.topMarginButton);
            this.Controls.Add(this.topMargin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.indexTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fileNameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.displayFileNameButton);
            this.Controls.Add(this.deleteClipButton);
            this.Controls.Add(this.deleteAllButton);
            this.Controls.Add(this.normalStyleButton);
            this.Controls.Add(this.acdcButton);
            this.Controls.Add(this.captionButton);
            this.Controls.Add(this.textColorButton);
            this.Controls.Add(this.shaddowColorButton);
            this.Controls.Add(this.borderColorButton);
            this.Controls.Add(this.highColorButton);
            this.Controls.Add(this.clipColorButton);
            this.Controls.Add(this.bgColorButton);
            this.Controls.Add(this.addFileButton);
            this.Controls.Add(this.displayModeComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.scrollDownButton);
            this.Controls.Add(this.scrollUpButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scrollTypeComboBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Image Thumbnail CP ActiveX Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topMargin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomMargin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clipWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clipHeight)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axImageThumbnailCP1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox scrollTypeComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button scrollUpButton;
        private System.Windows.Forms.Button scrollDownButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox displayModeComboBox;
        private System.Windows.Forms.Button addFileButton;
        private System.Windows.Forms.Button bgColorButton;
        private System.Windows.Forms.Button clipColorButton;
        private System.Windows.Forms.Button highColorButton;
        private System.Windows.Forms.Button borderColorButton;
        private System.Windows.Forms.Button shaddowColorButton;
        private System.Windows.Forms.Button textColorButton;
        private System.Windows.Forms.Button captionButton;
        private System.Windows.Forms.Button acdcButton;
        private System.Windows.Forms.Button normalStyleButton;
        private System.Windows.Forms.Button deleteAllButton;
        private System.Windows.Forms.Button deleteClipButton;
        private System.Windows.Forms.Button displayFileNameButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.TextBox indexTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deleteTypeButton;
        private System.Windows.Forms.Button addTypeButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox fileExtTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown topMargin;
        private System.Windows.Forms.Button topMarginButton;
        private System.Windows.Forms.Button bottomMarginButton;
        private System.Windows.Forms.NumericUpDown bottomMargin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button fontSizeButton;
        private System.Windows.Forms.NumericUpDown fontSize;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button fontTopButton;
        private System.Windows.Forms.NumericUpDown fontTop;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button clipWidthButton;
        private System.Windows.Forms.NumericUpDown clipWidth;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button clipHeightButton;
        private System.Windows.Forms.NumericUpDown clipHeight;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox boldCheckBox;
        private System.Windows.Forms.CheckBox italicCheckBox;
        private System.Windows.Forms.CheckBox underlineCheckBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cborotate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox PageNoTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbofilter;
        private AxIMAGETHUMBNAILCPLib.AxImageThumbnailCP axImageThumbnailCP1;
        private System.Windows.Forms.Button button7;
    }
}

