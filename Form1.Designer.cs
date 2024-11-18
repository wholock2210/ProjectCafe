namespace ProjectCafe
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
            panel1 = new Panel();
            label1 = new Label();
            btnSidebar = new PictureBox();
            sidebarContainer = new FlowLayoutPanel();
            menuContainer = new FlowLayoutPanel();
            panel6 = new Panel();
            menu = new Button();
            panel7 = new Panel();
            btnSubMenu1 = new Button();
            panel8 = new Panel();
            btnSubMenu2 = new Button();
            panel2 = new Panel();
            button1 = new Button();
            panel3 = new Panel();
            button2 = new Button();
            pnDashboard = new Panel();
            btnDashboard = new Button();
            pnLogout = new Panel();
            btnLogout = new Button();
            pnAbout = new Panel();
            btnAbout = new Button();
            pnSettings = new Panel();
            btnSettings = new Button();
            menuTransititon = new System.Windows.Forms.Timer(components);
            sidebarTransition = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnSidebar).BeginInit();
            sidebarContainer.SuspendLayout();
            menuContainer.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            pnDashboard.SuspendLayout();
            pnLogout.SuspendLayout();
            pnAbout.SuspendLayout();
            pnSettings.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnSidebar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(798, 42);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(47, 8);
            label1.Name = "label1";
            label1.Size = new Size(214, 25);
            label1.TabIndex = 1;
            label1.Text = "Project Cafe | By Wholock";
            // 
            // btnSidebar
            // 
            btnSidebar.Image = (Image)resources.GetObject("btnSidebar.Image");
            btnSidebar.Location = new Point(3, 2);
            btnSidebar.Name = "btnSidebar";
            btnSidebar.Size = new Size(38, 37);
            btnSidebar.SizeMode = PictureBoxSizeMode.CenterImage;
            btnSidebar.TabIndex = 1;
            btnSidebar.TabStop = false;
            btnSidebar.Click += btnSidebar_Click;
            // 
            // sidebarContainer
            // 
            sidebarContainer.BackColor = Color.FromArgb(23, 24, 29);
            sidebarContainer.Controls.Add(menuContainer);
            sidebarContainer.Controls.Add(pnDashboard);
            sidebarContainer.Controls.Add(pnLogout);
            sidebarContainer.Controls.Add(pnAbout);
            sidebarContainer.Controls.Add(pnSettings);
            sidebarContainer.Dock = DockStyle.Left;
            sidebarContainer.FlowDirection = FlowDirection.TopDown;
            sidebarContainer.Location = new Point(0, 42);
            sidebarContainer.Name = "sidebarContainer";
            sidebarContainer.Padding = new Padding(0, 30, 0, 0);
            sidebarContainer.Size = new Size(56, 406);
            sidebarContainer.TabIndex = 1;
            // 
            // menuContainer
            // 
            menuContainer.BackColor = Color.FromArgb(32, 33, 36);
            menuContainer.Controls.Add(panel6);
            menuContainer.Controls.Add(panel7);
            menuContainer.Controls.Add(panel8);
            menuContainer.Controls.Add(panel2);
            menuContainer.Controls.Add(panel3);
            menuContainer.Location = new Point(0, 30);
            menuContainer.Margin = new Padding(0);
            menuContainer.Name = "menuContainer";
            menuContainer.Size = new Size(250, 61);
            menuContainer.TabIndex = 7;
            // 
            // panel6
            // 
            panel6.Controls.Add(menu);
            panel6.Location = new Point(0, 0);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(247, 61);
            panel6.TabIndex = 8;
            // 
            // menu
            // 
            menu.BackColor = Color.FromArgb(23, 24, 29);
            menu.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menu.ForeColor = Color.White;
            menu.Image = (Image)resources.GetObject("menu.Image");
            menu.ImageAlign = ContentAlignment.MiddleLeft;
            menu.Location = new Point(-13, -8);
            menu.Name = "menu";
            menu.Padding = new Padding(25, 0, 0, 0);
            menu.Size = new Size(276, 78);
            menu.TabIndex = 2;
            menu.Text = "         Menu";
            menu.TextAlign = ContentAlignment.MiddleLeft;
            menu.UseVisualStyleBackColor = false;
            menu.Click += menu_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnSubMenu1);
            panel7.Location = new Point(0, 61);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Size = new Size(247, 61);
            panel7.TabIndex = 9;
            // 
            // btnSubMenu1
            // 
            btnSubMenu1.BackColor = Color.FromArgb(32, 33, 36);
            btnSubMenu1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubMenu1.ForeColor = Color.White;
            btnSubMenu1.Image = (Image)resources.GetObject("btnSubMenu1.Image");
            btnSubMenu1.ImageAlign = ContentAlignment.MiddleLeft;
            btnSubMenu1.Location = new Point(-16, -8);
            btnSubMenu1.Name = "btnSubMenu1";
            btnSubMenu1.Padding = new Padding(25, 0, 0, 0);
            btnSubMenu1.Size = new Size(276, 78);
            btnSubMenu1.TabIndex = 2;
            btnSubMenu1.Text = "              Đặt Món";
            btnSubMenu1.TextAlign = ContentAlignment.MiddleLeft;
            btnSubMenu1.UseVisualStyleBackColor = false;
            btnSubMenu1.Click += btnSubMenu1_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(btnSubMenu2);
            panel8.Location = new Point(0, 122);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Size = new Size(247, 61);
            panel8.TabIndex = 10;
            // 
            // btnSubMenu2
            // 
            btnSubMenu2.BackColor = Color.FromArgb(32, 33, 36);
            btnSubMenu2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubMenu2.ForeColor = Color.White;
            btnSubMenu2.Image = (Image)resources.GetObject("btnSubMenu2.Image");
            btnSubMenu2.ImageAlign = ContentAlignment.MiddleLeft;
            btnSubMenu2.Location = new Point(-16, -8);
            btnSubMenu2.Name = "btnSubMenu2";
            btnSubMenu2.Padding = new Padding(25, 0, 0, 0);
            btnSubMenu2.Size = new Size(276, 78);
            btnSubMenu2.TabIndex = 2;
            btnSubMenu2.Text = "              Khách Hàng";
            btnSubMenu2.TextAlign = ContentAlignment.MiddleLeft;
            btnSubMenu2.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Location = new Point(0, 183);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(247, 61);
            panel2.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(32, 33, 36);
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-16, -8);
            button1.Name = "button1";
            button1.Padding = new Padding(25, 0, 0, 0);
            button1.Size = new Size(276, 78);
            button1.TabIndex = 2;
            button1.Text = "              Bàn";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(button2);
            panel3.Location = new Point(0, 244);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(247, 61);
            panel3.TabIndex = 12;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(32, 33, 36);
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-16, -8);
            button2.Name = "button2";
            button2.Padding = new Padding(25, 0, 0, 0);
            button2.Size = new Size(276, 78);
            button2.TabIndex = 2;
            button2.Text = "              Công Thức";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // pnDashboard
            // 
            pnDashboard.Controls.Add(btnDashboard);
            pnDashboard.Location = new Point(3, 94);
            pnDashboard.Name = "pnDashboard";
            pnDashboard.Size = new Size(247, 61);
            pnDashboard.TabIndex = 3;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(23, 24, 29);
            btnDashboard.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(-16, -8);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(25, 0, 0, 0);
            btnDashboard.Size = new Size(276, 78);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "         Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += button1_Click;
            // 
            // pnLogout
            // 
            pnLogout.Controls.Add(btnLogout);
            pnLogout.Location = new Point(3, 161);
            pnLogout.Name = "pnLogout";
            pnLogout.Size = new Size(247, 61);
            pnLogout.TabIndex = 6;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(23, 24, 29);
            btnLogout.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(-16, -8);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(25, 0, 0, 0);
            btnLogout.Size = new Size(276, 78);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "         Đăng Xuất";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // pnAbout
            // 
            pnAbout.Controls.Add(btnAbout);
            pnAbout.Location = new Point(3, 228);
            pnAbout.Name = "pnAbout";
            pnAbout.Size = new Size(247, 61);
            pnAbout.TabIndex = 5;
            // 
            // btnAbout
            // 
            btnAbout.BackColor = Color.FromArgb(23, 24, 29);
            btnAbout.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAbout.ForeColor = Color.White;
            btnAbout.Image = (Image)resources.GetObject("btnAbout.Image");
            btnAbout.ImageAlign = ContentAlignment.MiddleLeft;
            btnAbout.Location = new Point(-16, -8);
            btnAbout.Name = "btnAbout";
            btnAbout.Padding = new Padding(25, 0, 0, 0);
            btnAbout.Size = new Size(276, 78);
            btnAbout.TabIndex = 2;
            btnAbout.Text = "         Thông Tin";
            btnAbout.TextAlign = ContentAlignment.MiddleLeft;
            btnAbout.UseVisualStyleBackColor = false;
            // 
            // pnSettings
            // 
            pnSettings.Controls.Add(btnSettings);
            pnSettings.Location = new Point(3, 295);
            pnSettings.Name = "pnSettings";
            pnSettings.Size = new Size(247, 61);
            pnSettings.TabIndex = 4;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.FromArgb(23, 24, 29);
            btnSettings.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSettings.ForeColor = Color.White;
            btnSettings.Image = (Image)resources.GetObject("btnSettings.Image");
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(-16, -11);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(25, 0, 0, 0);
            btnSettings.Size = new Size(276, 78);
            btnSettings.TabIndex = 2;
            btnSettings.Text = "         Cài Đặt";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.UseVisualStyleBackColor = false;
            // 
            // menuTransititon
            // 
            menuTransititon.Interval = 10;
            menuTransititon.Tick += menuTransititon_Tick;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Control;
            ClientSize = new Size(798, 448);
            Controls.Add(sidebarContainer);
            Controls.Add(panel1);
            IsMdiContainer = true;
            MaximumSize = new Size(1920, 1030);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += Form1_Load;
            Resize += Form1_Resize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnSidebar).EndInit();
            sidebarContainer.ResumeLayout(false);
            menuContainer.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            pnDashboard.ResumeLayout(false);
            pnLogout.ResumeLayout(false);
            pnAbout.ResumeLayout(false);
            pnSettings.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion


        private Panel panel1;
        private Label label1;
        private PictureBox btnSidebar;
        private FlowLayoutPanel sidebarContainer;
        private Button btnDashboard;
        private Panel pnDashboard;
        private Panel pnSettings;
        private Button btnSettings;
        private Panel pnAbout;
        private Button btnAbout;
        private Panel pnLogout;
        private Button btnLogout;
        private FlowLayoutPanel menuContainer;
        private Panel panel6;
        private Button menu;
        private Panel panel7;
        private Button btnSubMenu1;
        private Panel panel8;
        private Button btnSubMenu2;
        private System.Windows.Forms.Timer menuTransititon;
        private System.Windows.Forms.Timer sidebarTransition;
        private Panel panel2;
        private Button button1;
        private Panel panel3;
        private Button button2;
    }
}
