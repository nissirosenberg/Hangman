namespace Hangman
{
    partial class frmHangman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHangman));
            pbxHangman = new PictureBox();
            tblMain = new TableLayoutPanel();
            lblStatus = new Label();
            tblKeyboardTop = new TableLayoutPanel();
            btnP = new Button();
            btnO = new Button();
            btnI = new Button();
            btnU = new Button();
            btnY = new Button();
            btnT = new Button();
            btnR = new Button();
            btnE = new Button();
            btnW = new Button();
            btnQ = new Button();
            tblKeyboardMiddle = new TableLayoutPanel();
            btnA = new Button();
            btnS = new Button();
            btnD = new Button();
            btnF = new Button();
            btnG = new Button();
            btnH = new Button();
            btnJ = new Button();
            btnK = new Button();
            btnL = new Button();
            tblKeyboardBottom = new TableLayoutPanel();
            btnPickAWord = new Button();
            btnZ = new Button();
            btnX = new Button();
            btnC = new Button();
            btnV = new Button();
            btnB = new Button();
            btnN = new Button();
            btnM = new Button();
            btnIGiveUp = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            lbl1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            lbl4 = new Label();
            lbl5 = new Label();
            lbl6 = new Label();
            lbl7 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pbxHangman).BeginInit();
            tblMain.SuspendLayout();
            tblKeyboardTop.SuspendLayout();
            tblKeyboardMiddle.SuspendLayout();
            tblKeyboardBottom.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // pbxHangman
            // 
            pbxHangman.Dock = DockStyle.Fill;
            pbxHangman.ImageLocation = "";
            pbxHangman.InitialImage = null;
            pbxHangman.Location = new Point(3, 3);
            pbxHangman.Name = "pbxHangman";
            tblMain.SetRowSpan(pbxHangman, 5);
            pbxHangman.Size = new Size(375, 444);
            pbxHangman.SizeMode = PictureBoxSizeMode.Zoom;
            pbxHangman.TabIndex = 5;
            pbxHangman.TabStop = false;
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.17073F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.82927F));
            tblMain.Controls.Add(lblStatus, 1, 0);
            tblMain.Controls.Add(tblKeyboardTop, 1, 4);
            tblMain.Controls.Add(tblKeyboardMiddle, 1, 5);
            tblMain.Controls.Add(tblKeyboardBottom, 0, 6);
            tblMain.Controls.Add(pbxHangman, 0, 0);
            tblMain.Controls.Add(tableLayoutPanel2, 1, 2);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 8;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tblMain.Size = new Size(1025, 645);
            tblMain.TabIndex = 0;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Right;
            lblStatus.BorderStyle = BorderStyle.Fixed3D;
            lblStatus.Font = new Font("PtilNarrow", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus.Location = new Point(555, 6);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(467, 52);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Click Pick a Word to start the game";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tblKeyboardTop
            // 
            tblKeyboardTop.ColumnCount = 11;
            tblKeyboardTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
            tblKeyboardTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
            tblKeyboardTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
            tblKeyboardTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
            tblKeyboardTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
            tblKeyboardTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
            tblKeyboardTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
            tblKeyboardTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
            tblKeyboardTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
            tblKeyboardTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
            tblKeyboardTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
            tblKeyboardTop.Controls.Add(btnP, 9, 0);
            tblKeyboardTop.Controls.Add(btnO, 8, 0);
            tblKeyboardTop.Controls.Add(btnI, 7, 0);
            tblKeyboardTop.Controls.Add(btnU, 6, 0);
            tblKeyboardTop.Controls.Add(btnY, 5, 0);
            tblKeyboardTop.Controls.Add(btnT, 4, 0);
            tblKeyboardTop.Controls.Add(btnR, 3, 0);
            tblKeyboardTop.Controls.Add(btnE, 2, 0);
            tblKeyboardTop.Controls.Add(btnW, 1, 0);
            tblKeyboardTop.Controls.Add(btnQ, 0, 0);
            tblKeyboardTop.Dock = DockStyle.Fill;
            tblKeyboardTop.Location = new Point(384, 389);
            tblKeyboardTop.Name = "tblKeyboardTop";
            tblKeyboardTop.RowCount = 1;
            tblKeyboardTop.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblKeyboardTop.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblKeyboardTop.Size = new Size(638, 58);
            tblKeyboardTop.TabIndex = 0;
            // 
            // btnP
            // 
            btnP.BackColor = Color.FromArgb(25, 150, 192);
            btnP.Dock = DockStyle.Fill;
            btnP.Enabled = false;
            btnP.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnP.ForeColor = SystemColors.ControlText;
            btnP.Location = new Point(516, 3);
            btnP.Name = "btnP";
            btnP.Size = new Size(51, 52);
            btnP.TabIndex = 9;
            btnP.Text = "P";
            btnP.UseVisualStyleBackColor = false;
            // 
            // btnO
            // 
            btnO.BackColor = Color.FromArgb(25, 150, 192);
            btnO.Dock = DockStyle.Fill;
            btnO.Enabled = false;
            btnO.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnO.ForeColor = SystemColors.ControlText;
            btnO.Location = new Point(459, 3);
            btnO.Name = "btnO";
            btnO.Size = new Size(51, 52);
            btnO.TabIndex = 8;
            btnO.Text = "O";
            btnO.UseVisualStyleBackColor = false;
            // 
            // btnI
            // 
            btnI.BackColor = Color.FromArgb(25, 150, 192);
            btnI.Dock = DockStyle.Fill;
            btnI.Enabled = false;
            btnI.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnI.ForeColor = SystemColors.ControlText;
            btnI.Location = new Point(402, 3);
            btnI.Name = "btnI";
            btnI.Size = new Size(51, 52);
            btnI.TabIndex = 7;
            btnI.Text = "I";
            btnI.UseVisualStyleBackColor = false;
            // 
            // btnU
            // 
            btnU.BackColor = Color.FromArgb(25, 150, 192);
            btnU.Dock = DockStyle.Fill;
            btnU.Enabled = false;
            btnU.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnU.ForeColor = SystemColors.ControlText;
            btnU.Location = new Point(345, 3);
            btnU.Name = "btnU";
            btnU.Size = new Size(51, 52);
            btnU.TabIndex = 6;
            btnU.Text = "U";
            btnU.UseVisualStyleBackColor = false;
            // 
            // btnY
            // 
            btnY.BackColor = Color.FromArgb(25, 150, 192);
            btnY.Dock = DockStyle.Fill;
            btnY.Enabled = false;
            btnY.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnY.ForeColor = SystemColors.ControlText;
            btnY.Location = new Point(288, 3);
            btnY.Name = "btnY";
            btnY.Size = new Size(51, 52);
            btnY.TabIndex = 5;
            btnY.Text = "Y";
            btnY.UseVisualStyleBackColor = false;
            // 
            // btnT
            // 
            btnT.BackColor = Color.FromArgb(25, 150, 192);
            btnT.Dock = DockStyle.Fill;
            btnT.Enabled = false;
            btnT.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnT.ForeColor = SystemColors.ControlText;
            btnT.Location = new Point(231, 3);
            btnT.Name = "btnT";
            btnT.Size = new Size(51, 52);
            btnT.TabIndex = 4;
            btnT.Text = "T";
            btnT.UseVisualStyleBackColor = false;
            // 
            // btnR
            // 
            btnR.BackColor = Color.FromArgb(25, 150, 192);
            btnR.Dock = DockStyle.Fill;
            btnR.Enabled = false;
            btnR.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnR.ForeColor = SystemColors.ControlText;
            btnR.Location = new Point(174, 3);
            btnR.Name = "btnR";
            btnR.Size = new Size(51, 52);
            btnR.TabIndex = 3;
            btnR.Text = "R";
            btnR.UseVisualStyleBackColor = false;
            // 
            // btnE
            // 
            btnE.BackColor = Color.FromArgb(25, 150, 192);
            btnE.Dock = DockStyle.Fill;
            btnE.Enabled = false;
            btnE.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnE.ForeColor = SystemColors.ControlText;
            btnE.Location = new Point(117, 3);
            btnE.Name = "btnE";
            btnE.Size = new Size(51, 52);
            btnE.TabIndex = 2;
            btnE.Text = "E";
            btnE.UseVisualStyleBackColor = false;
            // 
            // btnW
            // 
            btnW.BackColor = Color.FromArgb(25, 150, 192);
            btnW.Dock = DockStyle.Fill;
            btnW.Enabled = false;
            btnW.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnW.ForeColor = SystemColors.ControlText;
            btnW.Location = new Point(60, 3);
            btnW.Name = "btnW";
            btnW.Size = new Size(51, 52);
            btnW.TabIndex = 1;
            btnW.Text = "W";
            btnW.UseVisualStyleBackColor = false;
            // 
            // btnQ
            // 
            btnQ.BackColor = Color.FromArgb(25, 150, 192);
            btnQ.Dock = DockStyle.Fill;
            btnQ.Enabled = false;
            btnQ.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnQ.ForeColor = SystemColors.ControlText;
            btnQ.Location = new Point(3, 3);
            btnQ.Name = "btnQ";
            btnQ.Size = new Size(51, 52);
            btnQ.TabIndex = 0;
            btnQ.Text = "Q";
            btnQ.UseVisualStyleBackColor = false;
            // 
            // tblKeyboardMiddle
            // 
            tblKeyboardMiddle.ColumnCount = 12;
            tblKeyboardMiddle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.55F));
            tblKeyboardMiddle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.09F));
            tblKeyboardMiddle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.09F));
            tblKeyboardMiddle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.09F));
            tblKeyboardMiddle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.09F));
            tblKeyboardMiddle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.09F));
            tblKeyboardMiddle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.09F));
            tblKeyboardMiddle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.09F));
            tblKeyboardMiddle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.09F));
            tblKeyboardMiddle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.09F));
            tblKeyboardMiddle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.55F));
            tblKeyboardMiddle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.09F));
            tblKeyboardMiddle.Controls.Add(btnA, 1, 0);
            tblKeyboardMiddle.Controls.Add(btnS, 2, 0);
            tblKeyboardMiddle.Controls.Add(btnD, 3, 0);
            tblKeyboardMiddle.Controls.Add(btnF, 4, 0);
            tblKeyboardMiddle.Controls.Add(btnG, 5, 0);
            tblKeyboardMiddle.Controls.Add(btnH, 6, 0);
            tblKeyboardMiddle.Controls.Add(btnJ, 7, 0);
            tblKeyboardMiddle.Controls.Add(btnK, 8, 0);
            tblKeyboardMiddle.Controls.Add(btnL, 9, 0);
            tblKeyboardMiddle.Dock = DockStyle.Fill;
            tblKeyboardMiddle.Location = new Point(384, 453);
            tblKeyboardMiddle.Name = "tblKeyboardMiddle";
            tblKeyboardMiddle.RowCount = 1;
            tblKeyboardMiddle.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblKeyboardMiddle.Size = new Size(638, 58);
            tblKeyboardMiddle.TabIndex = 1;
            // 
            // btnA
            // 
            btnA.BackColor = Color.FromArgb(25, 150, 192);
            btnA.Dock = DockStyle.Fill;
            btnA.Enabled = false;
            btnA.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnA.ForeColor = SystemColors.ControlText;
            btnA.Location = new Point(32, 3);
            btnA.Name = "btnA";
            btnA.Size = new Size(51, 52);
            btnA.TabIndex = 1;
            btnA.Text = "A";
            btnA.UseVisualStyleBackColor = false;
            // 
            // btnS
            // 
            btnS.BackColor = Color.FromArgb(25, 150, 192);
            btnS.Dock = DockStyle.Fill;
            btnS.Enabled = false;
            btnS.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnS.ForeColor = SystemColors.ControlText;
            btnS.Location = new Point(89, 3);
            btnS.Name = "btnS";
            btnS.Size = new Size(51, 52);
            btnS.TabIndex = 2;
            btnS.Text = "S";
            btnS.UseVisualStyleBackColor = false;
            // 
            // btnD
            // 
            btnD.BackColor = Color.FromArgb(25, 150, 192);
            btnD.Dock = DockStyle.Fill;
            btnD.Enabled = false;
            btnD.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnD.ForeColor = SystemColors.ControlText;
            btnD.Location = new Point(146, 3);
            btnD.Name = "btnD";
            btnD.Size = new Size(51, 52);
            btnD.TabIndex = 3;
            btnD.Text = "D";
            btnD.UseVisualStyleBackColor = false;
            // 
            // btnF
            // 
            btnF.BackColor = Color.FromArgb(25, 150, 192);
            btnF.Dock = DockStyle.Fill;
            btnF.Enabled = false;
            btnF.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnF.ForeColor = SystemColors.ControlText;
            btnF.Location = new Point(203, 3);
            btnF.Name = "btnF";
            btnF.Size = new Size(51, 52);
            btnF.TabIndex = 4;
            btnF.Text = "F";
            btnF.UseVisualStyleBackColor = false;
            // 
            // btnG
            // 
            btnG.BackColor = Color.FromArgb(25, 150, 192);
            btnG.Dock = DockStyle.Fill;
            btnG.Enabled = false;
            btnG.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnG.ForeColor = SystemColors.ControlText;
            btnG.Location = new Point(260, 3);
            btnG.Name = "btnG";
            btnG.Size = new Size(51, 52);
            btnG.TabIndex = 5;
            btnG.Text = "G";
            btnG.UseVisualStyleBackColor = false;
            // 
            // btnH
            // 
            btnH.BackColor = Color.FromArgb(25, 150, 192);
            btnH.Dock = DockStyle.Fill;
            btnH.Enabled = false;
            btnH.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnH.ForeColor = SystemColors.ControlText;
            btnH.Location = new Point(317, 3);
            btnH.Name = "btnH";
            btnH.Size = new Size(51, 52);
            btnH.TabIndex = 6;
            btnH.Text = "H";
            btnH.UseVisualStyleBackColor = false;
            // 
            // btnJ
            // 
            btnJ.BackColor = Color.FromArgb(25, 150, 192);
            btnJ.Dock = DockStyle.Fill;
            btnJ.Enabled = false;
            btnJ.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnJ.ForeColor = SystemColors.ControlText;
            btnJ.Location = new Point(374, 3);
            btnJ.Name = "btnJ";
            btnJ.Size = new Size(51, 52);
            btnJ.TabIndex = 7;
            btnJ.Text = "J";
            btnJ.UseVisualStyleBackColor = false;
            // 
            // btnK
            // 
            btnK.BackColor = Color.FromArgb(25, 150, 192);
            btnK.Dock = DockStyle.Fill;
            btnK.Enabled = false;
            btnK.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnK.ForeColor = SystemColors.ControlText;
            btnK.Location = new Point(431, 3);
            btnK.Name = "btnK";
            btnK.Size = new Size(51, 52);
            btnK.TabIndex = 8;
            btnK.Text = "K";
            btnK.UseVisualStyleBackColor = false;
            // 
            // btnL
            // 
            btnL.BackColor = Color.FromArgb(25, 150, 192);
            btnL.Dock = DockStyle.Fill;
            btnL.Enabled = false;
            btnL.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnL.ForeColor = SystemColors.ControlText;
            btnL.Location = new Point(488, 3);
            btnL.Name = "btnL";
            btnL.Size = new Size(51, 52);
            btnL.TabIndex = 9;
            btnL.Text = "L";
            btnL.UseVisualStyleBackColor = false;
            // 
            // tblKeyboardBottom
            // 
            tblKeyboardBottom.ColumnCount = 11;
            tblMain.SetColumnSpan(tblKeyboardBottom, 2);
            tblKeyboardBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.1227F));
            tblKeyboardBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.1566219F));
            tblKeyboardBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.050796F));
            tblKeyboardBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.050796F));
            tblKeyboardBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.050796F));
            tblKeyboardBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.050796F));
            tblKeyboardBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.050796F));
            tblKeyboardBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.050796F));
            tblKeyboardBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.050796F));
            tblKeyboardBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.3466625F));
            tblKeyboardBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.01845026F));
            tblKeyboardBottom.Controls.Add(btnPickAWord, 1, 0);
            tblKeyboardBottom.Controls.Add(btnZ, 2, 0);
            tblKeyboardBottom.Controls.Add(btnX, 3, 0);
            tblKeyboardBottom.Controls.Add(btnC, 4, 0);
            tblKeyboardBottom.Controls.Add(btnV, 5, 0);
            tblKeyboardBottom.Controls.Add(btnB, 6, 0);
            tblKeyboardBottom.Controls.Add(btnN, 7, 0);
            tblKeyboardBottom.Controls.Add(btnM, 8, 0);
            tblKeyboardBottom.Controls.Add(btnIGiveUp, 9, 0);
            tblKeyboardBottom.Dock = DockStyle.Fill;
            tblKeyboardBottom.Location = new Point(3, 517);
            tblKeyboardBottom.Name = "tblKeyboardBottom";
            tblKeyboardBottom.RowCount = 1;
            tblKeyboardBottom.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblKeyboardBottom.Size = new Size(1019, 58);
            tblKeyboardBottom.TabIndex = 2;
            // 
            // btnPickAWord
            // 
            btnPickAWord.BackColor = Color.Orange;
            btnPickAWord.Dock = DockStyle.Fill;
            btnPickAWord.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPickAWord.ForeColor = SystemColors.ControlText;
            btnPickAWord.Location = new Point(177, 3);
            btnPickAWord.Name = "btnPickAWord";
            btnPickAWord.Size = new Size(219, 52);
            btnPickAWord.TabIndex = 0;
            btnPickAWord.Text = "Pick a Word";
            btnPickAWord.UseVisualStyleBackColor = false;
            // 
            // btnZ
            // 
            btnZ.BackColor = Color.FromArgb(25, 150, 192);
            btnZ.Dock = DockStyle.Fill;
            btnZ.Enabled = false;
            btnZ.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnZ.ForeColor = SystemColors.ControlText;
            btnZ.Location = new Point(402, 3);
            btnZ.Name = "btnZ";
            btnZ.Size = new Size(55, 52);
            btnZ.TabIndex = 2;
            btnZ.Text = "Z";
            btnZ.UseVisualStyleBackColor = false;
            // 
            // btnX
            // 
            btnX.BackColor = Color.FromArgb(25, 150, 192);
            btnX.Dock = DockStyle.Fill;
            btnX.Enabled = false;
            btnX.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnX.ForeColor = SystemColors.ControlText;
            btnX.Location = new Point(463, 3);
            btnX.Name = "btnX";
            btnX.Size = new Size(55, 52);
            btnX.TabIndex = 3;
            btnX.Text = "X";
            btnX.UseVisualStyleBackColor = false;
            // 
            // btnC
            // 
            btnC.BackColor = Color.FromArgb(25, 150, 192);
            btnC.Dock = DockStyle.Fill;
            btnC.Enabled = false;
            btnC.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnC.ForeColor = SystemColors.ControlText;
            btnC.Location = new Point(524, 3);
            btnC.Name = "btnC";
            btnC.Size = new Size(55, 52);
            btnC.TabIndex = 4;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = false;
            // 
            // btnV
            // 
            btnV.BackColor = Color.FromArgb(25, 150, 192);
            btnV.Dock = DockStyle.Fill;
            btnV.Enabled = false;
            btnV.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnV.ForeColor = SystemColors.ControlText;
            btnV.Location = new Point(585, 3);
            btnV.Name = "btnV";
            btnV.Size = new Size(55, 52);
            btnV.TabIndex = 5;
            btnV.Text = "V";
            btnV.UseVisualStyleBackColor = false;
            // 
            // btnB
            // 
            btnB.BackColor = Color.FromArgb(25, 150, 192);
            btnB.Dock = DockStyle.Fill;
            btnB.Enabled = false;
            btnB.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnB.ForeColor = SystemColors.ControlText;
            btnB.Location = new Point(646, 3);
            btnB.Name = "btnB";
            btnB.Size = new Size(55, 52);
            btnB.TabIndex = 6;
            btnB.Text = "B";
            btnB.UseVisualStyleBackColor = false;
            // 
            // btnN
            // 
            btnN.BackColor = Color.FromArgb(25, 150, 192);
            btnN.Dock = DockStyle.Fill;
            btnN.Enabled = false;
            btnN.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnN.ForeColor = SystemColors.ControlText;
            btnN.Location = new Point(707, 3);
            btnN.Name = "btnN";
            btnN.Size = new Size(55, 52);
            btnN.TabIndex = 7;
            btnN.Text = "N";
            btnN.UseVisualStyleBackColor = false;
            // 
            // btnM
            // 
            btnM.BackColor = Color.FromArgb(25, 150, 192);
            btnM.Dock = DockStyle.Fill;
            btnM.Enabled = false;
            btnM.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnM.ForeColor = SystemColors.ControlText;
            btnM.Location = new Point(768, 3);
            btnM.Name = "btnM";
            btnM.Size = new Size(55, 52);
            btnM.TabIndex = 8;
            btnM.Text = "M";
            btnM.UseVisualStyleBackColor = false;
            // 
            // btnIGiveUp
            // 
            btnIGiveUp.BackColor = Color.Orange;
            btnIGiveUp.Dock = DockStyle.Fill;
            btnIGiveUp.Enabled = false;
            btnIGiveUp.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnIGiveUp.ForeColor = SystemColors.ControlText;
            btnIGiveUp.Location = new Point(829, 3);
            btnIGiveUp.Name = "btnIGiveUp";
            btnIGiveUp.Size = new Size(160, 52);
            btnIGiveUp.TabIndex = 9;
            btnIGiveUp.Text = "I Give Up";
            btnIGiveUp.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 9;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.Controls.Add(lbl1, 1, 0);
            tableLayoutPanel2.Controls.Add(lbl2, 2, 0);
            tableLayoutPanel2.Controls.Add(lbl3, 3, 0);
            tableLayoutPanel2.Controls.Add(lbl4, 4, 0);
            tableLayoutPanel2.Controls.Add(lbl5, 5, 0);
            tableLayoutPanel2.Controls.Add(lbl6, 6, 0);
            tableLayoutPanel2.Controls.Add(lbl7, 7, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(384, 183);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(638, 84);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // lbl1
            // 
            lbl1.BackColor = Color.FromArgb(25, 150, 192);
            lbl1.BorderStyle = BorderStyle.Fixed3D;
            lbl1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lbl1.Location = new Point(73, 0);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(64, 84);
            lbl1.TabIndex = 7;
            lbl1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl2
            // 
            lbl2.BackColor = Color.FromArgb(25, 150, 192);
            lbl2.BorderStyle = BorderStyle.Fixed3D;
            lbl2.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lbl2.Location = new Point(143, 0);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(64, 84);
            lbl2.TabIndex = 8;
            lbl2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl3
            // 
            lbl3.BackColor = Color.FromArgb(25, 150, 192);
            lbl3.BorderStyle = BorderStyle.Fixed3D;
            lbl3.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lbl3.Location = new Point(213, 0);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(64, 84);
            lbl3.TabIndex = 9;
            lbl3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl4
            // 
            lbl4.BackColor = Color.FromArgb(25, 150, 192);
            lbl4.BorderStyle = BorderStyle.Fixed3D;
            lbl4.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lbl4.Location = new Point(283, 0);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(64, 84);
            lbl4.TabIndex = 10;
            lbl4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl5
            // 
            lbl5.BackColor = Color.FromArgb(25, 150, 192);
            lbl5.BorderStyle = BorderStyle.Fixed3D;
            lbl5.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lbl5.Location = new Point(353, 0);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(64, 84);
            lbl5.TabIndex = 11;
            lbl5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl6
            // 
            lbl6.BackColor = Color.FromArgb(25, 150, 192);
            lbl6.BorderStyle = BorderStyle.Fixed3D;
            lbl6.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lbl6.Location = new Point(423, 0);
            lbl6.Name = "lbl6";
            lbl6.Size = new Size(64, 84);
            lbl6.TabIndex = 12;
            lbl6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl7
            // 
            lbl7.BackColor = Color.FromArgb(25, 150, 192);
            lbl7.BorderStyle = BorderStyle.Fixed3D;
            lbl7.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lbl7.Location = new Point(493, 0);
            lbl7.Name = "lbl7";
            lbl7.Size = new Size(64, 84);
            lbl7.TabIndex = 13;
            lbl7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 11;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // frmHangman
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1025, 645);
            Controls.Add(tblMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmHangman";
            Text = "Hangman";
            ((System.ComponentModel.ISupportInitialize)pbxHangman).EndInit();
            tblMain.ResumeLayout(false);
            tblKeyboardTop.ResumeLayout(false);
            tblKeyboardMiddle.ResumeLayout(false);
            tblKeyboardBottom.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblStatus;
        private TableLayoutPanel tblKeyboardTop;
        private TableLayoutPanel tblKeyboardMiddle;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tblKeyboardBottom;
        private Button btnQ;
        private Button btnP;
        private Button btnO;
        private Button btnI;
        private Button btnU;
        private Button btnY;
        private Button btnT;
        private Button btnR;
        private Button btnE;
        private Button btnW;
        private Button btnA;
        private Button btnS;
        private Button btnD;
        private Button btnF;
        private Button btnG;
        private Button btnH;
        private Button btnJ;
        private Button btnK;
        private Button btnL;
        private Button btnPickAWord;
        private Button btnZ;
        private Button btnX;
        private Button btnC;
        private Button btnV;
        private Button btnB;
        private Button btnN;
        private Button btnM;
        private Button btnIGiveUp;
        private PictureBox pbxHangman;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private Label lbl4;
        private Label lbl5;
        private Label lbl6;
        private Label lbl7;
    }
}