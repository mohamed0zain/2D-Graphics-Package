namespace Graphics
{
    partial class form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            xStartPoint = new TextBox();
            yStartPoint = new TextBox();
            xEndPoint = new TextBox();
            yEndPoint = new TextBox();
            DDA_Button = new Button();
            BersenhamButton = new Button();
            picture = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            xCenter = new TextBox();
            yCenter = new TextBox();
            RadiusTextBox = new TextBox();
            CircleButton = new Button();
            label7 = new Label();
            yCenterElipse = new TextBox();
            xCenterElipse = new TextBox();
            label8 = new Label();
            label9 = new Label();
            radiusX = new TextBox();
            radiusY = new TextBox();
            ElipseButton = new Button();
            button1 = new Button();
            label10 = new Label();
            label11 = new Label();
            yPoint1 = new TextBox();
            xPoint1 = new TextBox();
            label12 = new Label();
            yPoint2 = new TextBox();
            xPoint2 = new TextBox();
            label13 = new Label();
            yPoint3 = new TextBox();
            xPoint3 = new TextBox();
            label14 = new Label();
            yPoint4 = new TextBox();
            xPoint4 = new TextBox();
            label15 = new Label();
            addPolygon = new Button();
            yMatrix = new TextBox();
            xMatrix = new TextBox();
            Scalling2DBtn = new Button();
            Translation2DBtn = new Button();
            ShearX = new TextBox();
            ShearY = new TextBox();
            ShearXBtn = new Button();
            ShearYBtn = new Button();
            label22 = new Label();
            angle = new TextBox();
            xReflectBtn = new Button();
            yReflectBtn = new Button();
            originReflectBtn = new Button();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            button2 = new Button();
            label16 = new Label();
            ((System.ComponentModel.ISupportInitialize)picture).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightSalmon;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(27, 9);
            label1.Name = "label1";
            label1.Size = new Size(216, 37);
            label1.TabIndex = 1;
            label1.Text = "Drawing Line";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightSalmon;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 2;
            label2.Text = "Start Point";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightSalmon;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(12, 90);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 3;
            label3.Text = "End Point";
            label3.Click += label3_Click;
            // 
            // xStartPoint
            // 
            xStartPoint.BackColor = SystemColors.GradientActiveCaption;
            xStartPoint.BorderStyle = BorderStyle.FixedSingle;
            xStartPoint.Font = new Font("Microsoft Sans Serif", 8.249999F, FontStyle.Regular, GraphicsUnit.Point);
            xStartPoint.ForeColor = Color.Black;
            xStartPoint.Location = new Point(115, 61);
            xStartPoint.Margin = new Padding(3, 2, 3, 2);
            xStartPoint.Name = "xStartPoint";
            xStartPoint.PlaceholderText = " X";
            xStartPoint.Size = new Size(54, 20);
            xStartPoint.TabIndex = 4;
            xStartPoint.TextChanged += xStartPoint_TextChanged;
            // 
            // yStartPoint
            // 
            yStartPoint.BackColor = SystemColors.GradientActiveCaption;
            yStartPoint.BorderStyle = BorderStyle.FixedSingle;
            yStartPoint.Font = new Font("Microsoft Sans Serif", 8.249999F, FontStyle.Regular, GraphicsUnit.Point);
            yStartPoint.ForeColor = Color.Black;
            yStartPoint.Location = new Point(189, 60);
            yStartPoint.Margin = new Padding(3, 2, 3, 2);
            yStartPoint.Name = "yStartPoint";
            yStartPoint.PlaceholderText = " Y";
            yStartPoint.Size = new Size(54, 20);
            yStartPoint.TabIndex = 5;
            yStartPoint.TextChanged += yStartPoint_TextChanged;
            // 
            // xEndPoint
            // 
            xEndPoint.BackColor = SystemColors.GradientActiveCaption;
            xEndPoint.BorderStyle = BorderStyle.FixedSingle;
            xEndPoint.Font = new Font("Microsoft Sans Serif", 8.249999F, FontStyle.Regular, GraphicsUnit.Point);
            xEndPoint.ForeColor = Color.Black;
            xEndPoint.Location = new Point(115, 89);
            xEndPoint.Margin = new Padding(3, 2, 3, 2);
            xEndPoint.Name = "xEndPoint";
            xEndPoint.PlaceholderText = " X";
            xEndPoint.Size = new Size(54, 20);
            xEndPoint.TabIndex = 6;
            xEndPoint.TextChanged += xEndPoint_TextChanged;
            // 
            // yEndPoint
            // 
            yEndPoint.BackColor = SystemColors.GradientActiveCaption;
            yEndPoint.BorderStyle = BorderStyle.FixedSingle;
            yEndPoint.Font = new Font("Microsoft Sans Serif", 8.249999F, FontStyle.Regular, GraphicsUnit.Point);
            yEndPoint.ForeColor = Color.Black;
            yEndPoint.Location = new Point(189, 90);
            yEndPoint.Margin = new Padding(3, 2, 3, 2);
            yEndPoint.Name = "yEndPoint";
            yEndPoint.PlaceholderText = " Y";
            yEndPoint.Size = new Size(54, 20);
            yEndPoint.TabIndex = 7;
            yEndPoint.TextChanged += yEndPoint_TextChanged;
            // 
            // DDA_Button
            // 
            DDA_Button.BackColor = Color.FromArgb(64, 64, 64);
            DDA_Button.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            DDA_Button.ForeColor = Color.White;
            DDA_Button.Location = new Point(12, 129);
            DDA_Button.Margin = new Padding(3, 2, 3, 2);
            DDA_Button.Name = "DDA_Button";
            DDA_Button.Size = new Size(124, 37);
            DDA_Button.TabIndex = 0;
            DDA_Button.Text = "DDA";
            DDA_Button.UseVisualStyleBackColor = false;
            DDA_Button.Click += button1_Click;
            // 
            // BersenhamButton
            // 
            BersenhamButton.BackColor = Color.FromArgb(64, 64, 64);
            BersenhamButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            BersenhamButton.ForeColor = Color.White;
            BersenhamButton.Location = new Point(142, 129);
            BersenhamButton.Margin = new Padding(3, 2, 3, 2);
            BersenhamButton.Name = "BersenhamButton";
            BersenhamButton.Size = new Size(124, 37);
            BersenhamButton.TabIndex = 8;
            BersenhamButton.Text = "Bersenham";
            BersenhamButton.UseVisualStyleBackColor = false;
            BersenhamButton.Click += button2_Click;
            // 
            // picture
            // 
            picture.BackColor = SystemColors.ActiveBorder;
            picture.Location = new Point(270, 9);
            picture.Margin = new Padding(3, 2, 3, 2);
            picture.Name = "picture";
            picture.Size = new Size(600, 600);
            picture.TabIndex = 9;
            picture.TabStop = false;
            picture.Click += picture_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightSalmon;
            label4.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(12, 197);
            label4.Name = "label4";
            label4.Size = new Size(239, 37);
            label4.TabIndex = 10;
            label4.Text = "Drawing Circle";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LightSalmon;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(12, 248);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 11;
            label5.Text = "Center Point";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LightSalmon;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(12, 294);
            label6.Name = "label6";
            label6.Size = new Size(59, 20);
            label6.TabIndex = 12;
            label6.Text = "Radius";
            label6.Click += label6_Click;
            // 
            // xCenter
            // 
            xCenter.BackColor = SystemColors.GradientActiveCaption;
            xCenter.BorderStyle = BorderStyle.FixedSingle;
            xCenter.Font = new Font("Microsoft Sans Serif", 8.249999F, FontStyle.Regular, GraphicsUnit.Point);
            xCenter.ForeColor = Color.Black;
            xCenter.Location = new Point(115, 248);
            xCenter.Margin = new Padding(3, 2, 3, 2);
            xCenter.Name = "xCenter";
            xCenter.PlaceholderText = " X";
            xCenter.Size = new Size(54, 20);
            xCenter.TabIndex = 13;
            xCenter.TextChanged += xCenter_TextChanged;
            // 
            // yCenter
            // 
            yCenter.BackColor = SystemColors.GradientActiveCaption;
            yCenter.BorderStyle = BorderStyle.FixedSingle;
            yCenter.Font = new Font("Microsoft Sans Serif", 8.249999F, FontStyle.Regular, GraphicsUnit.Point);
            yCenter.ForeColor = Color.Black;
            yCenter.Location = new Point(189, 248);
            yCenter.Margin = new Padding(3, 2, 3, 2);
            yCenter.Name = "yCenter";
            yCenter.PlaceholderText = " Y";
            yCenter.Size = new Size(54, 20);
            yCenter.TabIndex = 14;
            yCenter.TextChanged += yCenter_TextChanged;
            // 
            // RadiusTextBox
            // 
            RadiusTextBox.BackColor = SystemColors.GradientActiveCaption;
            RadiusTextBox.BorderStyle = BorderStyle.FixedSingle;
            RadiusTextBox.Font = new Font("Microsoft Sans Serif", 8.249999F, FontStyle.Regular, GraphicsUnit.Point);
            RadiusTextBox.ForeColor = Color.Black;
            RadiusTextBox.Location = new Point(115, 294);
            RadiusTextBox.Margin = new Padding(3, 2, 3, 2);
            RadiusTextBox.Name = "RadiusTextBox";
            RadiusTextBox.PlaceholderText = " r";
            RadiusTextBox.Size = new Size(54, 20);
            RadiusTextBox.TabIndex = 15;
            RadiusTextBox.TextChanged += RadiusTextBox_TextChanged;
            // 
            // CircleButton
            // 
            CircleButton.BackColor = Color.FromArgb(64, 64, 64);
            CircleButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            CircleButton.ForeColor = Color.White;
            CircleButton.Location = new Point(75, 332);
            CircleButton.Margin = new Padding(3, 2, 3, 2);
            CircleButton.Name = "CircleButton";
            CircleButton.Size = new Size(124, 37);
            CircleButton.TabIndex = 16;
            CircleButton.Text = "Circle";
            CircleButton.UseVisualStyleBackColor = false;
            CircleButton.Click += CircleButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.LightSalmon;
            label7.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(12, 398);
            label7.Name = "label7";
            label7.Size = new Size(244, 37);
            label7.TabIndex = 17;
            label7.Text = "Drawing Elipse";
            label7.Click += label7_Click;
            // 
            // yCenterElipse
            // 
            yCenterElipse.BackColor = SystemColors.GradientActiveCaption;
            yCenterElipse.BorderStyle = BorderStyle.FixedSingle;
            yCenterElipse.Font = new Font("Microsoft Sans Serif", 8.249999F, FontStyle.Regular, GraphicsUnit.Point);
            yCenterElipse.ForeColor = Color.Black;
            yCenterElipse.Location = new Point(189, 469);
            yCenterElipse.Margin = new Padding(3, 2, 3, 2);
            yCenterElipse.Name = "yCenterElipse";
            yCenterElipse.PlaceholderText = " Y";
            yCenterElipse.Size = new Size(54, 20);
            yCenterElipse.TabIndex = 20;
            yCenterElipse.TextChanged += textBox1_TextChanged;
            // 
            // xCenterElipse
            // 
            xCenterElipse.BackColor = SystemColors.GradientActiveCaption;
            xCenterElipse.BorderStyle = BorderStyle.FixedSingle;
            xCenterElipse.Font = new Font("Microsoft Sans Serif", 8.249999F, FontStyle.Regular, GraphicsUnit.Point);
            xCenterElipse.ForeColor = Color.Black;
            xCenterElipse.Location = new Point(115, 469);
            xCenterElipse.Margin = new Padding(3, 2, 3, 2);
            xCenterElipse.Name = "xCenterElipse";
            xCenterElipse.PlaceholderText = " X";
            xCenterElipse.Size = new Size(54, 20);
            xCenterElipse.TabIndex = 19;
            xCenterElipse.TextChanged += textBox2_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.LightSalmon;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(12, 469);
            label8.Name = "label8";
            label8.Size = new Size(97, 20);
            label8.TabIndex = 18;
            label8.Text = "Center Point";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.LightSalmon;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(12, 512);
            label9.Name = "label9";
            label9.Size = new Size(59, 20);
            label9.TabIndex = 21;
            label9.Text = "Radius";
            label9.Click += label9_Click;
            // 
            // radiusX
            // 
            radiusX.BackColor = SystemColors.GradientActiveCaption;
            radiusX.BorderStyle = BorderStyle.FixedSingle;
            radiusX.Font = new Font("Microsoft Sans Serif", 8.249999F, FontStyle.Regular, GraphicsUnit.Point);
            radiusX.ForeColor = Color.Black;
            radiusX.Location = new Point(115, 512);
            radiusX.Margin = new Padding(3, 2, 3, 2);
            radiusX.Name = "radiusX";
            radiusX.PlaceholderText = " rX";
            radiusX.Size = new Size(54, 20);
            radiusX.TabIndex = 22;
            radiusX.TextChanged += textBox3_TextChanged;
            // 
            // radiusY
            // 
            radiusY.BackColor = SystemColors.GradientActiveCaption;
            radiusY.BorderStyle = BorderStyle.FixedSingle;
            radiusY.Font = new Font("Microsoft Sans Serif", 8.249999F, FontStyle.Regular, GraphicsUnit.Point);
            radiusY.ForeColor = Color.Black;
            radiusY.Location = new Point(189, 512);
            radiusY.Margin = new Padding(3, 2, 3, 2);
            radiusY.Name = "radiusY";
            radiusY.PlaceholderText = " rY";
            radiusY.Size = new Size(54, 20);
            radiusY.TabIndex = 24;
            radiusY.TextChanged += textBox4_TextChanged;
            // 
            // ElipseButton
            // 
            ElipseButton.BackColor = Color.FromArgb(64, 64, 64);
            ElipseButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ElipseButton.ForeColor = Color.White;
            ElipseButton.Location = new Point(75, 560);
            ElipseButton.Margin = new Padding(3, 2, 3, 2);
            ElipseButton.Name = "ElipseButton";
            ElipseButton.Size = new Size(124, 37);
            ElipseButton.TabIndex = 25;
            ElipseButton.Text = "Elipse";
            ElipseButton.UseVisualStyleBackColor = false;
            ElipseButton.Click += ElipseButton_Click;
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = Color.LightSalmon;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Microsoft Sans Serif", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(270, 614);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(600, 46);
            button1.TabIndex = 26;
            button1.Text = "clear";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.LightSalmon;
            label10.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(937, 170);
            label10.Name = "label10";
            label10.Size = new Size(255, 37);
            label10.TabIndex = 27;
            label10.Text = "transformations";
            label10.Click += label10_Click_1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Georgia", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label11.Location = new Point(2270, 19);
            label11.Name = "label11";
            label11.Size = new Size(221, 29);
            label11.TabIndex = 31;
            label11.Text = "transformations";
            // 
            // yPoint1
            // 
            yPoint1.BackColor = SystemColors.GradientActiveCaption;
            yPoint1.BorderStyle = BorderStyle.FixedSingle;
            yPoint1.Font = new Font("Microsoft Sans Serif", 8.249999F, FontStyle.Regular, GraphicsUnit.Point);
            yPoint1.ForeColor = Color.Black;
            yPoint1.Location = new Point(997, 60);
            yPoint1.Margin = new Padding(3, 2, 3, 2);
            yPoint1.Name = "yPoint1";
            yPoint1.PlaceholderText = " Y";
            yPoint1.Size = new Size(54, 20);
            yPoint1.TabIndex = 30;
            // 
            // xPoint1
            // 
            xPoint1.BackColor = SystemColors.GradientActiveCaption;
            xPoint1.BorderStyle = BorderStyle.FixedSingle;
            xPoint1.Font = new Font("Microsoft Sans Serif", 8.249999F, FontStyle.Regular, GraphicsUnit.Point);
            xPoint1.ForeColor = Color.Black;
            xPoint1.Location = new Point(937, 60);
            xPoint1.Margin = new Padding(3, 2, 3, 2);
            xPoint1.Name = "xPoint1";
            xPoint1.PlaceholderText = " X";
            xPoint1.Size = new Size(54, 20);
            xPoint1.TabIndex = 29;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.LightSalmon;
            label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(876, 61);
            label12.Name = "label12";
            label12.Size = new Size(53, 20);
            label12.TabIndex = 28;
            label12.Text = "point1";
            // 
            // yPoint2
            // 
            yPoint2.BackColor = SystemColors.GradientActiveCaption;
            yPoint2.BorderStyle = BorderStyle.FixedSingle;
            yPoint2.Font = new Font("Microsoft Sans Serif", 8.249999F, FontStyle.Regular, GraphicsUnit.Point);
            yPoint2.ForeColor = Color.Black;
            yPoint2.Location = new Point(997, 89);
            yPoint2.Margin = new Padding(3, 2, 3, 2);
            yPoint2.Name = "yPoint2";
            yPoint2.PlaceholderText = " Y";
            yPoint2.Size = new Size(54, 20);
            yPoint2.TabIndex = 35;
            // 
            // xPoint2
            // 
            xPoint2.BackColor = SystemColors.GradientActiveCaption;
            xPoint2.BorderStyle = BorderStyle.FixedSingle;
            xPoint2.Font = new Font("Microsoft Sans Serif", 8.249999F, FontStyle.Regular, GraphicsUnit.Point);
            xPoint2.ForeColor = Color.Black;
            xPoint2.Location = new Point(937, 89);
            xPoint2.Margin = new Padding(3, 2, 3, 2);
            xPoint2.Name = "xPoint2";
            xPoint2.PlaceholderText = " X";
            xPoint2.Size = new Size(54, 20);
            xPoint2.TabIndex = 34;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.LightSalmon;
            label13.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ButtonHighlight;
            label13.Location = new Point(876, 90);
            label13.Name = "label13";
            label13.Size = new Size(53, 20);
            label13.TabIndex = 33;
            label13.Text = "point2";
            // 
            // yPoint3
            // 
            yPoint3.BackColor = SystemColors.GradientActiveCaption;
            yPoint3.BorderStyle = BorderStyle.FixedSingle;
            yPoint3.Font = new Font("Microsoft Sans Serif", 8.249999F, FontStyle.Regular, GraphicsUnit.Point);
            yPoint3.ForeColor = Color.Black;
            yPoint3.Location = new Point(1186, 61);
            yPoint3.Margin = new Padding(3, 2, 3, 2);
            yPoint3.Name = "yPoint3";
            yPoint3.PlaceholderText = " Y";
            yPoint3.Size = new Size(54, 20);
            yPoint3.TabIndex = 39;
            // 
            // xPoint3
            // 
            xPoint3.BackColor = SystemColors.GradientActiveCaption;
            xPoint3.BorderStyle = BorderStyle.FixedSingle;
            xPoint3.Font = new Font("Microsoft Sans Serif", 8.249999F, FontStyle.Regular, GraphicsUnit.Point);
            xPoint3.ForeColor = Color.Black;
            xPoint3.Location = new Point(1126, 62);
            xPoint3.Margin = new Padding(3, 2, 3, 2);
            xPoint3.Name = "xPoint3";
            xPoint3.PlaceholderText = " X";
            xPoint3.Size = new Size(54, 20);
            xPoint3.TabIndex = 38;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.LightSalmon;
            label14.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.ButtonHighlight;
            label14.Location = new Point(1069, 62);
            label14.Name = "label14";
            label14.Size = new Size(53, 20);
            label14.TabIndex = 37;
            label14.Text = "point3";
            // 
            // yPoint4
            // 
            yPoint4.BackColor = SystemColors.GradientActiveCaption;
            yPoint4.BorderStyle = BorderStyle.FixedSingle;
            yPoint4.Font = new Font("Microsoft Sans Serif", 8.249999F, FontStyle.Regular, GraphicsUnit.Point);
            yPoint4.ForeColor = Color.Black;
            yPoint4.Location = new Point(1186, 89);
            yPoint4.Margin = new Padding(3, 2, 3, 2);
            yPoint4.Name = "yPoint4";
            yPoint4.PlaceholderText = " Y";
            yPoint4.Size = new Size(54, 20);
            yPoint4.TabIndex = 43;
            // 
            // xPoint4
            // 
            xPoint4.BackColor = SystemColors.GradientActiveCaption;
            xPoint4.BorderStyle = BorderStyle.FixedSingle;
            xPoint4.Font = new Font("Microsoft Sans Serif", 8.249999F, FontStyle.Regular, GraphicsUnit.Point);
            xPoint4.ForeColor = Color.Black;
            xPoint4.Location = new Point(1126, 89);
            xPoint4.Margin = new Padding(3, 2, 3, 2);
            xPoint4.Name = "xPoint4";
            xPoint4.PlaceholderText = "X";
            xPoint4.Size = new Size(54, 20);
            xPoint4.TabIndex = 42;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.LightSalmon;
            label15.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = SystemColors.ButtonHighlight;
            label15.Location = new Point(1069, 90);
            label15.Name = "label15";
            label15.Size = new Size(53, 20);
            label15.TabIndex = 41;
            label15.Text = "point4";
            // 
            // addPolygon
            // 
            addPolygon.BackColor = Color.FromArgb(64, 64, 64);
            addPolygon.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            addPolygon.ForeColor = Color.White;
            addPolygon.Location = new Point(937, 126);
            addPolygon.Margin = new Padding(3, 2, 3, 2);
            addPolygon.Name = "addPolygon";
            addPolygon.Size = new Size(269, 40);
            addPolygon.TabIndex = 63;
            addPolygon.Text = "Enter";
            addPolygon.UseVisualStyleBackColor = false;
            addPolygon.Click += addPolygon_Click;
            // 
            // yMatrix
            // 
            yMatrix.BackColor = SystemColors.GradientActiveCaption;
            yMatrix.BorderStyle = BorderStyle.FixedSingle;
            yMatrix.Font = new Font("Microsoft Sans Serif", 8.249999F, FontStyle.Regular, GraphicsUnit.Point);
            yMatrix.ForeColor = Color.Black;
            yMatrix.Location = new Point(1115, 267);
            yMatrix.Margin = new Padding(3, 2, 3, 2);
            yMatrix.Name = "yMatrix";
            yMatrix.PlaceholderText = " Y";
            yMatrix.Size = new Size(54, 20);
            yMatrix.TabIndex = 66;
            // 
            // xMatrix
            // 
            xMatrix.BackColor = SystemColors.GradientActiveCaption;
            xMatrix.BorderStyle = BorderStyle.FixedSingle;
            xMatrix.Font = new Font("Microsoft Sans Serif", 8.249999F, FontStyle.Regular, GraphicsUnit.Point);
            xMatrix.ForeColor = Color.Black;
            xMatrix.Location = new Point(986, 267);
            xMatrix.Margin = new Padding(3, 2, 3, 2);
            xMatrix.Name = "xMatrix";
            xMatrix.PlaceholderText = " X";
            xMatrix.Size = new Size(54, 20);
            xMatrix.TabIndex = 65;
            // 
            // Scalling2DBtn
            // 
            Scalling2DBtn.BackColor = Color.FromArgb(64, 64, 64);
            Scalling2DBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Scalling2DBtn.ForeColor = Color.White;
            Scalling2DBtn.Location = new Point(913, 304);
            Scalling2DBtn.Margin = new Padding(3, 2, 3, 2);
            Scalling2DBtn.Name = "Scalling2DBtn";
            Scalling2DBtn.Size = new Size(146, 35);
            Scalling2DBtn.TabIndex = 68;
            Scalling2DBtn.Text = "2D scalling";
            Scalling2DBtn.UseVisualStyleBackColor = false;
            Scalling2DBtn.Click += Scalling2DBtn_Click;
            // 
            // Translation2DBtn
            // 
            Translation2DBtn.BackColor = Color.FromArgb(64, 64, 64);
            Translation2DBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Translation2DBtn.ForeColor = Color.White;
            Translation2DBtn.Location = new Point(1094, 304);
            Translation2DBtn.Margin = new Padding(3, 2, 3, 2);
            Translation2DBtn.Name = "Translation2DBtn";
            Translation2DBtn.Size = new Size(146, 35);
            Translation2DBtn.TabIndex = 70;
            Translation2DBtn.Text = "2D Translation";
            Translation2DBtn.UseVisualStyleBackColor = false;
            Translation2DBtn.Click += Translation2DBtn_Click;
            // 
            // ShearX
            // 
            ShearX.BackColor = SystemColors.GradientActiveCaption;
            ShearX.BorderStyle = BorderStyle.FixedSingle;
            ShearX.Font = new Font("Microsoft Sans Serif", 8.249999F, FontStyle.Regular, GraphicsUnit.Point);
            ShearX.ForeColor = Color.Black;
            ShearX.Location = new Point(1087, 395);
            ShearX.Margin = new Padding(3, 2, 3, 2);
            ShearX.Name = "ShearX";
            ShearX.PlaceholderText = " ShX";
            ShearX.Size = new Size(54, 20);
            ShearX.TabIndex = 75;
            // 
            // ShearY
            // 
            ShearY.BackColor = SystemColors.GradientActiveCaption;
            ShearY.BorderStyle = BorderStyle.FixedSingle;
            ShearY.Font = new Font("Microsoft Sans Serif", 8.249999F, FontStyle.Regular, GraphicsUnit.Point);
            ShearY.ForeColor = Color.Black;
            ShearY.Location = new Point(1167, 395);
            ShearY.Margin = new Padding(3, 2, 3, 2);
            ShearY.Name = "ShearY";
            ShearY.PlaceholderText = " ShY";
            ShearY.Size = new Size(54, 20);
            ShearY.TabIndex = 76;
            ShearY.TextChanged += ShearY_TextChanged;
            // 
            // ShearXBtn
            // 
            ShearXBtn.BackColor = Color.FromArgb(64, 64, 64);
            ShearXBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ShearXBtn.ForeColor = Color.White;
            ShearXBtn.Location = new Point(1070, 428);
            ShearXBtn.Margin = new Padding(3, 2, 3, 2);
            ShearXBtn.Name = "ShearXBtn";
            ShearXBtn.Size = new Size(84, 37);
            ShearXBtn.TabIndex = 78;
            ShearXBtn.Text = "Shear X";
            ShearXBtn.UseVisualStyleBackColor = false;
            ShearXBtn.Click += ShearXBtn_Click;
            // 
            // ShearYBtn
            // 
            ShearYBtn.BackColor = Color.FromArgb(64, 64, 64);
            ShearYBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ShearYBtn.ForeColor = Color.White;
            ShearYBtn.Location = new Point(1156, 428);
            ShearYBtn.Margin = new Padding(3, 2, 3, 2);
            ShearYBtn.Name = "ShearYBtn";
            ShearYBtn.Size = new Size(84, 37);
            ShearYBtn.TabIndex = 79;
            ShearYBtn.Text = "Shear Y";
            ShearYBtn.UseVisualStyleBackColor = false;
            ShearYBtn.Click += ShearYBtn_Click;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.LightSalmon;
            label22.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label22.ForeColor = SystemColors.ButtonHighlight;
            label22.Location = new Point(931, 398);
            label22.Name = "label22";
            label22.Size = new Size(50, 20);
            label22.TabIndex = 81;
            label22.Text = "Angle";
            // 
            // angle
            // 
            angle.BackColor = SystemColors.GradientActiveCaption;
            angle.BorderStyle = BorderStyle.FixedSingle;
            angle.Font = new Font("Microsoft Sans Serif", 8.249999F, FontStyle.Regular, GraphicsUnit.Point);
            angle.ForeColor = Color.Black;
            angle.Location = new Point(992, 397);
            angle.Margin = new Padding(3, 2, 3, 2);
            angle.Name = "angle";
            angle.Size = new Size(54, 20);
            angle.TabIndex = 82;
            // 
            // xReflectBtn
            // 
            xReflectBtn.BackColor = Color.FromArgb(64, 64, 64);
            xReflectBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            xReflectBtn.ForeColor = Color.White;
            xReflectBtn.Location = new Point(896, 512);
            xReflectBtn.Margin = new Padding(3, 2, 3, 2);
            xReflectBtn.Name = "xReflectBtn";
            xReflectBtn.Size = new Size(135, 42);
            xReflectBtn.TabIndex = 86;
            xReflectBtn.Text = "over X";
            xReflectBtn.UseVisualStyleBackColor = false;
            xReflectBtn.Click += xReflectBtn_Click;
            // 
            // yReflectBtn
            // 
            yReflectBtn.BackColor = Color.FromArgb(64, 64, 64);
            yReflectBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            yReflectBtn.ForeColor = Color.White;
            yReflectBtn.Location = new Point(1085, 512);
            yReflectBtn.Margin = new Padding(3, 2, 3, 2);
            yReflectBtn.Name = "yReflectBtn";
            yReflectBtn.Size = new Size(135, 42);
            yReflectBtn.TabIndex = 87;
            yReflectBtn.Text = "over Y";
            yReflectBtn.UseVisualStyleBackColor = false;
            yReflectBtn.Click += yReflectBtn_Click;
            // 
            // originReflectBtn
            // 
            originReflectBtn.BackColor = Color.FromArgb(64, 64, 64);
            originReflectBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            originReflectBtn.ForeColor = Color.White;
            originReflectBtn.Location = new Point(1005, 560);
            originReflectBtn.Margin = new Padding(3, 2, 3, 2);
            originReflectBtn.Name = "originReflectBtn";
            originReflectBtn.Size = new Size(135, 42);
            originReflectBtn.TabIndex = 88;
            originReflectBtn.Text = "over origin";
            originReflectBtn.UseVisualStyleBackColor = false;
            originReflectBtn.Click += originReflectBtn_Click;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.LightSalmon;
            label23.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label23.ForeColor = SystemColors.ButtonHighlight;
            label23.Location = new Point(876, 207);
            label23.Name = "label23";
            label23.Size = new Size(385, 37);
            label23.TabIndex = 92;
            label23.Text = "Scalling and Translation";
            label23.Click += label23_Click;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BackColor = Color.LightSalmon;
            label24.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label24.ForeColor = SystemColors.ButtonHighlight;
            label24.Location = new Point(1100, 345);
            label24.Name = "label24";
            label24.Size = new Size(153, 37);
            label24.TabIndex = 93;
            label24.Text = "Shearing";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.BackColor = Color.LightSalmon;
            label25.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label25.ForeColor = SystemColors.ButtonHighlight;
            label25.Location = new Point(928, 346);
            label25.Name = "label25";
            label25.Size = new Size(144, 37);
            label25.TabIndex = 94;
            label25.Text = "Rotation";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.BackColor = Color.LightSalmon;
            label26.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label26.ForeColor = SystemColors.ButtonHighlight;
            label26.Location = new Point(998, 469);
            label26.Name = "label26";
            label26.Size = new Size(167, 37);
            label26.TabIndex = 95;
            label26.Text = "Reflection";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(64, 64, 64);
            button2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(930, 425);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(118, 42);
            button2.TabIndex = 96;
            button2.Text = "2D Rotation";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.LightSalmon;
            label16.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = SystemColors.ButtonHighlight;
            label16.Location = new Point(970, 9);
            label16.Name = "label16";
            label16.Size = new Size(241, 37);
            label16.TabIndex = 97;
            label16.Text = "polygon Points";
            label16.Click += label16_Click;
            // 
            // form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1270, 662);
            Controls.Add(label16);
            Controls.Add(button2);
            Controls.Add(label26);
            Controls.Add(label25);
            Controls.Add(label24);
            Controls.Add(label23);
            Controls.Add(originReflectBtn);
            Controls.Add(yReflectBtn);
            Controls.Add(xReflectBtn);
            Controls.Add(angle);
            Controls.Add(label22);
            Controls.Add(ShearYBtn);
            Controls.Add(ShearXBtn);
            Controls.Add(ShearY);
            Controls.Add(ShearX);
            Controls.Add(Translation2DBtn);
            Controls.Add(Scalling2DBtn);
            Controls.Add(yMatrix);
            Controls.Add(xMatrix);
            Controls.Add(addPolygon);
            Controls.Add(yPoint4);
            Controls.Add(xPoint4);
            Controls.Add(label15);
            Controls.Add(yPoint3);
            Controls.Add(xPoint3);
            Controls.Add(label14);
            Controls.Add(yPoint2);
            Controls.Add(xPoint2);
            Controls.Add(label13);
            Controls.Add(label11);
            Controls.Add(yPoint1);
            Controls.Add(xPoint1);
            Controls.Add(label12);
            Controls.Add(label10);
            Controls.Add(button1);
            Controls.Add(ElipseButton);
            Controls.Add(radiusY);
            Controls.Add(radiusX);
            Controls.Add(label9);
            Controls.Add(yCenterElipse);
            Controls.Add(xCenterElipse);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(CircleButton);
            Controls.Add(RadiusTextBox);
            Controls.Add(yCenter);
            Controls.Add(xCenter);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(picture);
            Controls.Add(BersenhamButton);
            Controls.Add(DDA_Button);
            Controls.Add(yEndPoint);
            Controls.Add(xEndPoint);
            Controls.Add(yStartPoint);
            Controls.Add(xStartPoint);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "form";
            Text = "Graphics Package";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox xStartPoint;
        private TextBox yStartPoint;
        private TextBox xEndPoint;
        private TextBox yEndPoint;
        private Button DDA_Button;
        private Button BersenhamButton;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox xCenter;
        private TextBox yCenter;
        private TextBox RadiusTextBox;
        private Button CircleButton;
        private Label label7;
        private TextBox yCenterElipse;
        private TextBox xCenterElipse;
        private Label label8;
        private Label label9;
        private TextBox radiusX;
        private TextBox radiusY;
        private Button ElipseButton;
        private Button button1;
        private Label label10;
        private Label label11;
        private TextBox yPoint1;
        private TextBox xPoint1;
        private Label label12;
        private TextBox yPoint2;
        private TextBox xPoint2;
        private Label label13;
        private TextBox yPoint3;
        private TextBox xPoint3;
        private Label label14;
        private TextBox yPoint4;
        private TextBox xPoint4;
        private Label label15;
        private Button addPolygon;
        private TextBox yMatrix;
        private TextBox xMatrix;
        private Button Scalling2DBtn;
        private Button Translation2DBtn;
        private TextBox ShearX;
        private TextBox ShearY;
        private Button ShearXBtn;
        private Button ShearYBtn;
        private Label label22;
        private TextBox angle;
        private Button xReflectBtn;
        private Button yReflectBtn;
        private Button originReflectBtn;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private Button button2;
        private Label label16;
        private PictureBox picture;
    }
}