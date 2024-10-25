using ProjectCafe.Script;

namespace ProjectCafe
{
    public partial class Form1 : Form
    {
        FormDashboard dashboard;
        FormSub1 sub1;
        FormSub2 sub2;
        FormSettings settings;
        FormAbout about;
        public Form1()
        {
            InitializeComponent();
            mdiProp();
        }

        bool menuExpand = false;

        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232,234,237);
        }
        private void menuTransititon_Tick(object sender, EventArgs e)
        {
            if (!menuExpand)
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 192)
                {
                    menuTransititon.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 10;
                if (menuContainer.Height <= 61)
                {
                    menuTransititon.Stop();
                    menuExpand = false;
                }
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            menuTransititon.Start();
        }

        bool sidebarExpand = false;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (!sidebarExpand)
            {
                sidebarContainer.Width += 5;
                if (sidebarContainer.Width >= 250)
                {
                    sidebarTransition.Stop();
                    sidebarExpand = true;

                    pnDashboard.Width = sidebarContainer.Width;
                    pnSettings.Width = sidebarContainer.Width;
                    pnAbout.Width = sidebarContainer.Width;
                    pnLogout.Width = sidebarContainer.Width;
                    menuContainer.Width = sidebarContainer.Width;
                }
            }
            else
            {
                sidebarContainer.Width -= 5;
                if (sidebarContainer.Width <= 56)
                {
                    sidebarTransition.Stop();
                    sidebarExpand = false;

                    pnDashboard.Width = sidebarContainer.Width;
                    pnSettings.Width = sidebarContainer.Width;
                    pnAbout.Width = sidebarContainer.Width;
                    pnLogout.Width = sidebarContainer.Width;
                    menuContainer.Width = sidebarContainer.Width;
                }
            }
        }

        private void btnSidebar_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dashboard == null)
            {
                dashboard = new FormDashboard();
                dashboard.FormClosed += Dashboard_FormClosed;
                dashboard.MdiParent = this;
                dashboard.Dock = DockStyle.Fill;
                dashboard.Show();
            }
            else
            {
                dashboard.Activate();
            }
        }

        private void Dashboard_FormClosed(object? sender, FormClosedEventArgs e)
        {
            dashboard = null;
        }

        private void btnSubMenu1_Click(object sender, EventArgs e)
        {
            if(sub1 == null)
            {
                sub1 = new FormSub1();
                sub1.FormClosed += Sub1_FormClosed;
                sub1.MdiParent = this;
                sub1.Dock = DockStyle.Fill;
                sub1.Show();
            }
            else
            {
                sub1.Activate();
            }
        }

        private void Sub1_FormClosed(object? sender, FormClosedEventArgs e)
        {
            sub1 = null;
        }
    }
}
