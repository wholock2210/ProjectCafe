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
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            label1 = new Label();
            btnSidebar = new PictureBox();
            sidebarContainer = new FlowLayoutPanel();
            pnDashboard = new Panel();
            btnDashboard = new Button();
            menuContainer = new FlowLayoutPanel();
            panel6 = new Panel();
            menu = new Button();
            panel7 = new Panel();
            btnSubMenu1 = new Button();
            panel8 = new Panel();
            btnSubMenu2 = new Button();
            pnSettings = new Panel();
            btnSettings = new Button();
            pnAbout = new Panel();
            btnAbout = new Button();
            pnLogout = new Panel();
            btnLogout = new Button();
            menuTransititon = new System.Windows.Forms.Timer(components);
            sidebarTransition = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnSidebar).BeginInit();
            sidebarContainer.SuspendLayout();
            pnDashboard.SuspendLayout();
            menuContainer.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            pnSettings.SuspendLayout();
            pnAbout.SuspendLayout();
            pnLogout.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(nightControlBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnSidebar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(965, 42);
            panel1.TabIndex = 0;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(826, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 2;
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
            sidebarContainer.Controls.Add(pnDashboard);
            sidebarContainer.Controls.Add(menuContainer);
            sidebarContainer.Controls.Add(pnSettings);
            sidebarContainer.Controls.Add(pnAbout);
            sidebarContainer.Controls.Add(pnLogout);
            sidebarContainer.Dock = DockStyle.Left;
            sidebarContainer.FlowDirection = FlowDirection.TopDown;
            sidebarContainer.Location = new Point(0, 42);
            sidebarContainer.Name = "sidebarContainer";
            sidebarContainer.Padding = new Padding(0, 30, 0, 0);
            sidebarContainer.Size = new Size(58, 548);
            sidebarContainer.TabIndex = 1;
            // 
            // pnDashboard
            // 
            pnDashboard.Controls.Add(btnDashboard);
            pnDashboard.Location = new Point(3, 33);
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
            // menuContainer
            // 
            menuContainer.BackColor = Color.FromArgb(32, 33, 36);
            menuContainer.Controls.Add(panel6);
            menuContainer.Controls.Add(panel7);
            menuContainer.Controls.Add(panel8);
            menuContainer.Location = new Point(0, 97);
            menuContainer.Margin = new Padding(0);
            menuContainer.Name = "menuContainer";
            menuContainer.Size = new Size(247, 61);
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
            menu.Location = new Point(-16, -8);
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
            btnSubMenu1.Text = "         Sub Menu 1";
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
            btnSubMenu2.Text = "         Sub Menu 2";
            btnSubMenu2.TextAlign = ContentAlignment.MiddleLeft;
            btnSubMenu2.UseVisualStyleBackColor = false;
            // 
            // pnSettings
            // 
            pnSettings.Controls.Add(btnSettings);
            pnSettings.Location = new Point(3, 161);
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
            btnSettings.Location = new Point(-16, -8);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(25, 0, 0, 0);
            btnSettings.Size = new Size(276, 78);
            btnSettings.TabIndex = 2;
            btnSettings.Text = "         Settings";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.UseVisualStyleBackColor = false;
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
            btnAbout.Text = "         About";
            btnAbout.TextAlign = ContentAlignment.MiddleLeft;
            btnAbout.UseVisualStyleBackColor = false;
            // 
            // pnLogout
            // 
            pnLogout.Controls.Add(btnLogout);
            pnLogout.Location = new Point(3, 295);
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
            btnLogout.Text = "         Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
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
            ClientSize = new Size(965, 590);
            Controls.Add(sidebarContainer);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            MaximumSize = new Size(1920, 1030);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnSidebar).EndInit();
            sidebarContainer.ResumeLayout(false);
            pnDashboard.ResumeLayout(false);
            menuContainer.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            pnSettings.ResumeLayout(false);
            pnAbout.ResumeLayout(false);
            pnLogout.ResumeLayout(false);
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
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.Timer sidebarTransition;
    }
}
