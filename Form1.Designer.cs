namespace WinFormsApp16
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            uiTabControlMenu1 = new Sunny.UI.UITabControlMenu();
            Login = new TabPage();
            UserAccount = new TabPage();
            Dashboard = new TabPage();
            Expense = new TabPage();
            Income = new TabPage();
            Goals = new TabPage();
            Reports = new TabPage();
            imageListReport = new ImageList(components);
            Report1 = new Sunny.UI.UILabel();
            Report2 = new Sunny.UI.UILabel();
            totalincome = new Sunny.UI.UILabel();
            uiLabel1 = new Sunny.UI.UILabel();
            uiLabel2 = new Sunny.UI.UILabel();
            Re3 = new Sunny.UI.UILabel();
            Reimg1 = new Sunny.UI.UILabel();
            reimg2 = new Sunny.UI.UILabel();
            reimg3 = new Sunny.UI.UILabel();
            report3 = new Sunny.UI.UILabel();
            report4 = new Sunny.UI.UILabel();
            spendingbreakdown = new Sunny.UI.UIGroupBox();
            report5 = new Sunny.UI.UILabel();
            report8 = new Sunny.UI.UILabel();
            report7 = new Sunny.UI.UILabel();
            report6 = new Sunny.UI.UILabel();
            img4 = new Sunny.UI.UILabel();
            img8 = new Sunny.UI.UILabel();
            img7 = new Sunny.UI.UILabel();
            img6 = new Sunny.UI.UILabel();
            progressBarfood = new ProgressBar();
            progressBartransport = new ProgressBar();
            progressBarshopping = new ProgressBar();
            progressBareducation = new ProgressBar();
            percentfood = new Sunny.UI.UILabel();
            percentshopping = new Sunny.UI.UILabel();
            percenttransport = new Sunny.UI.UILabel();
            percenteducation = new Sunny.UI.UILabel();
            moneyfood = new Sunny.UI.UILabel();
            moneyshopping = new Sunny.UI.UILabel();
            moneytransport = new Sunny.UI.UILabel();
            moneyeducation = new Sunny.UI.UILabel();
            btnexit = new Button();
            uiTabControlMenu1.SuspendLayout();
            Reports.SuspendLayout();
            spendingbreakdown.SuspendLayout();
            SuspendLayout();
            // 
            // uiTabControlMenu1
            // 
            uiTabControlMenu1.Alignment = TabAlignment.Left;
            uiTabControlMenu1.Controls.Add(Login);
            uiTabControlMenu1.Controls.Add(UserAccount);
            uiTabControlMenu1.Controls.Add(Dashboard);
            uiTabControlMenu1.Controls.Add(Income);
            uiTabControlMenu1.Controls.Add(Expense);
            uiTabControlMenu1.Controls.Add(Goals);
            uiTabControlMenu1.Controls.Add(Reports);
            uiTabControlMenu1.DrawMode = TabDrawMode.OwnerDrawFixed;
            uiTabControlMenu1.Font = new Font("Microsoft Sans Serif", 12F);
            uiTabControlMenu1.Location = new Point(-3, 1);
            uiTabControlMenu1.Multiline = true;
            uiTabControlMenu1.Name = "uiTabControlMenu1";
            uiTabControlMenu1.SelectedIndex = 0;
            uiTabControlMenu1.Size = new Size(1556, 767);
            uiTabControlMenu1.SizeMode = TabSizeMode.Fixed;
            uiTabControlMenu1.TabIndex = 0;
            // 
            // Login
            // 
            Login.Location = new Point(201, 0);
            Login.Name = "Login";
            Login.Size = new Size(1355, 767);
            Login.TabIndex = 0;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = true;
            // 
            // UserAccount
            // 
            UserAccount.Location = new Point(201, 0);
            UserAccount.Name = "UserAccount";
            UserAccount.Size = new Size(1355, 767);
            UserAccount.TabIndex = 1;
            UserAccount.Text = "UserAccount";
            UserAccount.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            Dashboard.Location = new Point(201, 0);
            Dashboard.Name = "Dashboard";
            Dashboard.Size = new Size(1355, 767);
            Dashboard.TabIndex = 2;
            Dashboard.Text = "Dashboard";
            Dashboard.UseVisualStyleBackColor = true;
            // 
            // Expense
            // 
            Expense.Location = new Point(201, 0);
            Expense.Name = "Expense";
            Expense.Size = new Size(1355, 767);
            Expense.TabIndex = 3;
            Expense.Text = "Expense";
            Expense.UseVisualStyleBackColor = true;
            // 
            // Income
            // 
            Income.Location = new Point(201, 0);
            Income.Name = "Income";
            Income.Size = new Size(1355, 767);
            Income.TabIndex = 4;
            Income.Text = "Income";
            Income.UseVisualStyleBackColor = true;
            // 
            // Goals
            // 
            Goals.Location = new Point(201, 0);
            Goals.Name = "Goals";
            Goals.Size = new Size(1355, 767);
            Goals.TabIndex = 5;
            Goals.Text = "Goals";
            Goals.UseVisualStyleBackColor = true;
            // 
            // Reports
            // 
            Reports.Controls.Add(btnexit);
            Reports.Controls.Add(spendingbreakdown);
            Reports.Controls.Add(report4);
            Reports.Controls.Add(report3);
            Reports.Controls.Add(reimg3);
            Reports.Controls.Add(reimg2);
            Reports.Controls.Add(Reimg1);
            Reports.Controls.Add(Re3);
            Reports.Controls.Add(uiLabel2);
            Reports.Controls.Add(uiLabel1);
            Reports.Controls.Add(totalincome);
            Reports.Controls.Add(Report1);
            Reports.Controls.Add(Report2);
            Reports.Location = new Point(201, 0);
            Reports.Name = "Reports";
            Reports.Size = new Size(1355, 767);
            Reports.TabIndex = 6;
            Reports.Text = "Reports";
            Reports.UseVisualStyleBackColor = true;
            // 
            // imageListReport
            // 
            imageListReport.ColorDepth = ColorDepth.Depth32Bit;
            imageListReport.ImageStream = (ImageListStreamer)resources.GetObject("imageListReport.ImageStream");
            imageListReport.TransparentColor = Color.Transparent;
            imageListReport.Images.SetKeyName(0, "a-education-icon-education-icon-11553430161bimwyohogu.png");
            imageListReport.Images.SetKeyName(1, "2331970.png");
            imageListReport.Images.SetKeyName(2, "190190.png");
            imageListReport.Images.SetKeyName(3, "food-icon-7.png");
            imageListReport.Images.SetKeyName(4, "4599210.png");
            imageListReport.Images.SetKeyName(5, "credit-card-bank-icon-png-26.png");
            imageListReport.Images.SetKeyName(6, "10149443.png");
            imageListReport.Images.SetKeyName(7, "340-3408958_results-icons-results-icon-hd-png-download.png");
            imageListReport.Images.SetKeyName(8, "306405.png");
            imageListReport.Images.SetKeyName(9, "12489840.png");
            imageListReport.Images.SetKeyName(10, "1571098.png");
            // 
            // Report1
            // 
            Report1.BackColor = SystemColors.MenuHighlight;
            Report1.Font = new Font("Microsoft Sans Serif", 12F);
            Report1.ForeColor = Color.FromArgb(48, 48, 48);
            Report1.ImageKey = "306405.png";
            Report1.ImageList = imageListReport;
            Report1.Location = new Point(3, 8);
            Report1.Name = "Report1";
            Report1.Size = new Size(80, 64);
            Report1.TabIndex = 0;
            // 
            // Report2
            // 
            Report2.BackColor = SystemColors.MenuHighlight;
            Report2.Font = new Font("Mongolian Baiti", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Report2.ForeColor = Color.White;
            Report2.Location = new Point(0, 0);
            Report2.Name = "Report2";
            Report2.Size = new Size(1355, 77);
            Report2.TabIndex = 1;
            Report2.Text = "REPORT";
            Report2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // totalincome
            // 
            totalincome.BackColor = Color.Aquamarine;
            totalincome.Font = new Font("Microsoft Sans Serif", 12F);
            totalincome.ForeColor = Color.FromArgb(48, 48, 48);
            totalincome.Location = new Point(82, 154);
            totalincome.Name = "totalincome";
            totalincome.Size = new Size(282, 115);
            totalincome.TabIndex = 2;
            // 
            // uiLabel1
            // 
            uiLabel1.BackColor = Color.LightPink;
            uiLabel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(535, 154);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(291, 115);
            uiLabel1.TabIndex = 3;
            // 
            // uiLabel2
            // 
            uiLabel2.BackColor = Color.LightSkyBlue;
            uiLabel2.Font = new Font("Microsoft Sans Serif", 12F);
            uiLabel2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel2.Location = new Point(1023, 154);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(282, 115);
            uiLabel2.TabIndex = 4;
            // 
            // Re3
            // 
            Re3.Font = new Font("Microsoft Sans Serif", 12F);
            Re3.ForeColor = Color.FromArgb(48, 48, 48);
            Re3.ImageList = imageListReport;
            Re3.Location = new Point(168, 100);
            Re3.Name = "Re3";
            Re3.Size = new Size(196, 40);
            Re3.TabIndex = 5;
            Re3.Text = "TOTAL INCOME";
            Re3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Reimg1
            // 
            Reimg1.Font = new Font("Microsoft Sans Serif", 12F);
            Reimg1.ForeColor = Color.FromArgb(48, 48, 48);
            Reimg1.ImageKey = "1571098.png";
            Reimg1.ImageList = imageListReport;
            Reimg1.Location = new Point(82, 77);
            Reimg1.Name = "Reimg1";
            Reimg1.Size = new Size(91, 74);
            Reimg1.TabIndex = 6;
            // 
            // reimg2
            // 
            reimg2.Font = new Font("Microsoft Sans Serif", 12F);
            reimg2.ForeColor = Color.FromArgb(48, 48, 48);
            reimg2.ImageKey = "10149443.png";
            reimg2.ImageList = imageListReport;
            reimg2.Location = new Point(523, 89);
            reimg2.Name = "reimg2";
            reimg2.Size = new Size(76, 62);
            reimg2.TabIndex = 7;
            // 
            // reimg3
            // 
            reimg3.Font = new Font("Microsoft Sans Serif", 12F);
            reimg3.ForeColor = Color.FromArgb(48, 48, 48);
            reimg3.ImageKey = "4599210.png";
            reimg3.ImageList = imageListReport;
            reimg3.Location = new Point(1023, 94);
            reimg3.Name = "reimg3";
            reimg3.Size = new Size(70, 57);
            reimg3.TabIndex = 8;
            // 
            // report3
            // 
            report3.Font = new Font("Microsoft Sans Serif", 12F);
            report3.ForeColor = Color.FromArgb(48, 48, 48);
            report3.Location = new Point(604, 100);
            report3.Name = "report3";
            report3.Size = new Size(222, 44);
            report3.TabIndex = 9;
            report3.Text = "TOTAL EXPENSE";
            report3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // report4
            // 
            report4.Font = new Font("Microsoft Sans Serif", 12F);
            report4.ForeColor = Color.FromArgb(48, 48, 48);
            report4.Location = new Point(1083, 107);
            report4.Name = "report4";
            report4.Size = new Size(222, 44);
            report4.TabIndex = 10;
            report4.Text = "NET SAVING";
            report4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // spendingbreakdown
            // 
            spendingbreakdown.BackColor = Color.White;
            spendingbreakdown.Controls.Add(moneyeducation);
            spendingbreakdown.Controls.Add(moneytransport);
            spendingbreakdown.Controls.Add(moneyshopping);
            spendingbreakdown.Controls.Add(moneyfood);
            spendingbreakdown.Controls.Add(percenteducation);
            spendingbreakdown.Controls.Add(percenttransport);
            spendingbreakdown.Controls.Add(percentshopping);
            spendingbreakdown.Controls.Add(percentfood);
            spendingbreakdown.Controls.Add(progressBareducation);
            spendingbreakdown.Controls.Add(progressBarshopping);
            spendingbreakdown.Controls.Add(progressBartransport);
            spendingbreakdown.Controls.Add(progressBarfood);
            spendingbreakdown.Controls.Add(img6);
            spendingbreakdown.Controls.Add(img7);
            spendingbreakdown.Controls.Add(img8);
            spendingbreakdown.Controls.Add(img4);
            spendingbreakdown.Controls.Add(report6);
            spendingbreakdown.Controls.Add(report7);
            spendingbreakdown.Controls.Add(report8);
            spendingbreakdown.Controls.Add(report5);
            spendingbreakdown.Cursor = Cursors.Cross;
            spendingbreakdown.FillColor = Color.White;
            spendingbreakdown.FillColor2 = Color.White;
            spendingbreakdown.Font = new Font("Mongolian Baiti", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            spendingbreakdown.Location = new Point(82, 291);
            spendingbreakdown.Margin = new Padding(4, 5, 4, 5);
            spendingbreakdown.MinimumSize = new Size(1, 1);
            spendingbreakdown.Name = "spendingbreakdown";
            spendingbreakdown.Padding = new Padding(0, 32, 0, 0);
            spendingbreakdown.Size = new Size(1233, 400);
            spendingbreakdown.TabIndex = 0;
            spendingbreakdown.Text = "Spending Breakdown";
            spendingbreakdown.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // report5
            // 
            report5.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold | FontStyle.Underline);
            report5.ForeColor = Color.Red;
            report5.Location = new Point(121, 71);
            report5.Name = "report5";
            report5.Size = new Size(150, 34);
            report5.TabIndex = 0;
            report5.Text = "food";
            // 
            // report8
            // 
            report8.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold | FontStyle.Underline);
            report8.ForeColor = Color.Lime;
            report8.Location = new Point(121, 316);
            report8.Name = "report8";
            report8.Size = new Size(150, 34);
            report8.TabIndex = 1;
            report8.Text = "Education";
            // 
            // report7
            // 
            report7.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold | FontStyle.Underline);
            report7.ForeColor = Color.FromArgb(255, 128, 0);
            report7.Location = new Point(121, 226);
            report7.Name = "report7";
            report7.Size = new Size(150, 34);
            report7.TabIndex = 2;
            report7.Text = "shopping";
            // 
            // report6
            // 
            report6.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold | FontStyle.Underline);
            report6.ForeColor = Color.FromArgb(0, 0, 192);
            report6.Location = new Point(121, 143);
            report6.Name = "report6";
            report6.Size = new Size(150, 34);
            report6.TabIndex = 3;
            report6.Text = "transport";
            // 
            // img4
            // 
            img4.BackColor = Color.White;
            img4.Font = new Font("Microsoft Sans Serif", 12F);
            img4.ForeColor = Color.FromArgb(48, 48, 48);
            img4.ImageKey = "food-icon-7.png";
            img4.ImageList = imageListReport;
            img4.Location = new Point(39, 55);
            img4.Name = "img4";
            img4.Size = new Size(76, 62);
            img4.TabIndex = 11;
            // 
            // img8
            // 
            img8.BackColor = Color.White;
            img8.Font = new Font("Microsoft Sans Serif", 12F);
            img8.ForeColor = Color.FromArgb(48, 48, 48);
            img8.ImageKey = "a-education-icon-education-icon-11553430161bimwyohogu.png";
            img8.ImageList = imageListReport;
            img8.Location = new Point(39, 301);
            img8.Name = "img8";
            img8.Size = new Size(76, 62);
            img8.TabIndex = 12;
            // 
            // img7
            // 
            img7.BackColor = Color.White;
            img7.Font = new Font("Microsoft Sans Serif", 12F);
            img7.ForeColor = Color.FromArgb(48, 48, 48);
            img7.ImageKey = "2331970.png";
            img7.ImageList = imageListReport;
            img7.Location = new Point(39, 214);
            img7.Name = "img7";
            img7.Size = new Size(76, 62);
            img7.TabIndex = 13;
            // 
            // img6
            // 
            img6.BackColor = Color.White;
            img6.Font = new Font("Microsoft Sans Serif", 12F);
            img6.ForeColor = Color.FromArgb(48, 48, 48);
            img6.ImageKey = "190190.png";
            img6.ImageList = imageListReport;
            img6.Location = new Point(39, 131);
            img6.Name = "img6";
            img6.Size = new Size(76, 62);
            img6.TabIndex = 14;
            // 
            // progressBarfood
            // 
            progressBarfood.Location = new Point(295, 88);
            progressBarfood.Name = "progressBarfood";
            progressBarfood.Size = new Size(630, 10);
            progressBarfood.TabIndex = 15;
            // 
            // progressBartransport
            // 
            progressBartransport.Location = new Point(295, 167);
            progressBartransport.Name = "progressBartransport";
            progressBartransport.Size = new Size(630, 10);
            progressBartransport.TabIndex = 16;
            // 
            // progressBarshopping
            // 
            progressBarshopping.Location = new Point(295, 250);
            progressBarshopping.Name = "progressBarshopping";
            progressBarshopping.Size = new Size(630, 10);
            progressBarshopping.TabIndex = 17;
            // 
            // progressBareducation
            // 
            progressBareducation.Location = new Point(295, 340);
            progressBareducation.Name = "progressBareducation";
            progressBareducation.Size = new Size(630, 10);
            progressBareducation.TabIndex = 18;
            // 
            // percentfood
            // 
            percentfood.Font = new Font("Microsoft Sans Serif", 12F);
            percentfood.ForeColor = Color.FromArgb(48, 48, 48);
            percentfood.Location = new Point(952, 66);
            percentfood.Name = "percentfood";
            percentfood.Size = new Size(107, 51);
            percentfood.TabIndex = 19;
            percentfood.Text = "%";
            percentfood.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // percentshopping
            // 
            percentshopping.Font = new Font("Microsoft Sans Serif", 12F);
            percentshopping.ForeColor = Color.FromArgb(48, 48, 48);
            percentshopping.Location = new Point(952, 226);
            percentshopping.Name = "percentshopping";
            percentshopping.Size = new Size(107, 51);
            percentshopping.TabIndex = 20;
            percentshopping.Text = "%";
            percentshopping.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // percenttransport
            // 
            percenttransport.Font = new Font("Microsoft Sans Serif", 12F);
            percenttransport.ForeColor = Color.FromArgb(48, 48, 48);
            percenttransport.Location = new Point(952, 143);
            percenttransport.Name = "percenttransport";
            percenttransport.Size = new Size(107, 51);
            percenttransport.TabIndex = 21;
            percenttransport.Text = "%";
            percenttransport.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // percenteducation
            // 
            percenteducation.Font = new Font("Microsoft Sans Serif", 12F);
            percenteducation.ForeColor = Color.FromArgb(48, 48, 48);
            percenteducation.Location = new Point(952, 316);
            percenteducation.Name = "percenteducation";
            percenteducation.Size = new Size(107, 51);
            percenteducation.TabIndex = 22;
            percenteducation.Text = "%";
            percenteducation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // moneyfood
            // 
            moneyfood.BackColor = Color.Lavender;
            moneyfood.Font = new Font("Microsoft Sans Serif", 12F);
            moneyfood.ForeColor = Color.FromArgb(48, 48, 48);
            moneyfood.Location = new Point(1073, 71);
            moneyfood.Name = "moneyfood";
            moneyfood.Size = new Size(150, 34);
            moneyfood.Style = Sunny.UI.UIStyle.Custom;
            moneyfood.TabIndex = 23;
            // 
            // moneyshopping
            // 
            moneyshopping.BackColor = Color.Lavender;
            moneyshopping.Font = new Font("Microsoft Sans Serif", 12F);
            moneyshopping.ForeColor = Color.FromArgb(48, 48, 48);
            moneyshopping.Location = new Point(1073, 237);
            moneyshopping.Name = "moneyshopping";
            moneyshopping.Size = new Size(150, 34);
            moneyshopping.Style = Sunny.UI.UIStyle.Custom;
            moneyshopping.TabIndex = 24;
            // 
            // moneytransport
            // 
            moneytransport.BackColor = Color.Lavender;
            moneytransport.Font = new Font("Microsoft Sans Serif", 12F);
            moneytransport.ForeColor = Color.FromArgb(48, 48, 48);
            moneytransport.Location = new Point(1073, 154);
            moneytransport.Name = "moneytransport";
            moneytransport.Size = new Size(150, 34);
            moneytransport.Style = Sunny.UI.UIStyle.Custom;
            moneytransport.TabIndex = 25;
            // 
            // moneyeducation
            // 
            moneyeducation.BackColor = Color.Lavender;
            moneyeducation.Font = new Font("Microsoft Sans Serif", 12F);
            moneyeducation.ForeColor = Color.FromArgb(48, 48, 48);
            moneyeducation.Location = new Point(1073, 327);
            moneyeducation.Name = "moneyeducation";
            moneyeducation.Size = new Size(150, 34);
            moneyeducation.Style = Sunny.UI.UIStyle.Custom;
            moneyeducation.TabIndex = 26;
            // 
            // btnexit
            // 
            btnexit.BackColor = Color.Indigo;
            btnexit.ForeColor = SystemColors.ControlLightLight;
            btnexit.Location = new Point(627, 699);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(153, 56);
            btnexit.TabIndex = 11;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1551, 768);
            Controls.Add(uiTabControlMenu1);
            Name = "Form1";
            Text = "Form1";
            uiTabControlMenu1.ResumeLayout(false);
            Reports.ResumeLayout(false);
            spendingbreakdown.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITabControlMenu uiTabControlMenu1;
        private TabPage Login;
        private TabPage UserAccount;
        private TabPage Dashboard;
        private TabPage Income;
        private TabPage Expense;
        private TabPage Goals;
        private TabPage Reports;
        private Sunny.UI.UILabel totalincome;
        private Sunny.UI.UILabel Report1;
        private ImageList imageListReport;
        private Sunny.UI.UILabel Report2;
        private Sunny.UI.UILabel Re3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIGroupBox spendingbreakdown;
        private Sunny.UI.UILabel report4;
        private Sunny.UI.UILabel report3;
        private Sunny.UI.UILabel reimg3;
        private Sunny.UI.UILabel reimg2;
        private Sunny.UI.UILabel Reimg1;
        private Sunny.UI.UILabel report6;
        private Sunny.UI.UILabel report7;
        private Sunny.UI.UILabel report8;
        private Sunny.UI.UILabel report5;
        private Sunny.UI.UILabel percenteducation;
        private Sunny.UI.UILabel percenttransport;
        private Sunny.UI.UILabel percentshopping;
        private Sunny.UI.UILabel percentfood;
        private ProgressBar progressBareducation;
        private ProgressBar progressBarshopping;
        private ProgressBar progressBartransport;
        private ProgressBar progressBarfood;
        private Sunny.UI.UILabel img6;
        private Sunny.UI.UILabel img7;
        private Sunny.UI.UILabel img8;
        private Sunny.UI.UILabel img4;
        private Button btnexit;
        private Sunny.UI.UILabel moneyeducation;
        private Sunny.UI.UILabel moneytransport;
        private Sunny.UI.UILabel moneyshopping;
        private Sunny.UI.UILabel moneyfood;
    }
}
