using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Marts.UserControls;

namespace Marts
{
    public partial class frmMain : Form
    {
        List<Panel> listPanel = new List<Panel>();
        int mouseX;
        int mouseY;
        bool mouseDown;
        readonly int MINIMUM_WIDTH = 1000;
        readonly int MINIMUM_HEIGHT = 700;
        readonly int WIDTH_NO_TASKBAR = Screen.PrimaryScreen.WorkingArea.Width;
        readonly int HEIGHT_NO_TASKBAR = Screen.PrimaryScreen.WorkingArea.Height;

        public frmMain()
        {
            InitializeComponent();
            RegisterEventControll();
        }

        private void RegisterEventControll()
        {
            panel1.MouseDown += pBanner_MouseDown;
            panel1.MouseUp += pBanner_MouseUp;
            panel1.MouseMove += pBanner_MouseMove;
            pbExit.Click +=DoClick;
            pbMinimize.Click += DoClick;
            pbResize.Click += DoClick;
        }

        private void RegisterEventMove()
        {
            panel1.MouseDown += pBanner_MouseDown;
            panel1.MouseUp += pBanner_MouseUp;
            panel1.MouseMove += pBanner_MouseMove;
        }

        void pBanner_MouseMove(object sender, MouseEventArgs e)
        {            
            if (mouseDown)
            {
                /* IF main Form is match the whole screen => we set it to Minimum size */
                if (Top == 0 && Left == 0 && Width == WIDTH_NO_TASKBAR && Height == HEIGHT_NO_TASKBAR)
                {
                    Width = MINIMUM_WIDTH;
                    Height = MINIMUM_HEIGHT;
                    this.CenterToScreen();          
                }                
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 20;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        void pBanner_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        void pBanner_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }


        private void DoClick(object sender, EventArgs e)
        {
            if (sender == pbMinimize)
            {
                WindowState = FormWindowState.Minimized;
            }else if(sender == pbResize){
                if(Width == MINIMUM_WIDTH && Height == MINIMUM_HEIGHT){
                    Left = Top = 0;
                    Width = WIDTH_NO_TASKBAR;
                    Height = HEIGHT_NO_TASKBAR;                   
                }
                else
                {                       
                    Width = MINIMUM_WIDTH;
                    Height = MINIMUM_HEIGHT;
                    this.CenterToScreen();
                }                
            }
            else if(sender == pbExit)
            {
                this.Close();
            }                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Left = Top = 0;
            //Width = WidthNoTaskBar;
            //Height = HeightNoTaskBar;            

            Width = MINIMUM_WIDTH;
            Height = MINIMUM_HEIGHT;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            if (!mainPanel.Controls.Contains(UUser.Instance))
            {
                mainPanel.Controls.Add(UUser.Instance);
                UUser.Instance.Dock = DockStyle.Fill;
                UUser.Instance.BringToFront();
            }
            else
            {
                UUser.Instance.BringToFront();
            }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            if (!mainPanel.Controls.Contains(USetting.Instance))
            {
                mainPanel.Controls.Add(USetting.Instance);
                USetting.Instance.Dock = DockStyle.Fill;
                USetting.Instance.BringToFront();
            }
            else
            {
                USetting.Instance.BringToFront();
            }
        }

        private void btnBin_Click(object sender, EventArgs e)
        {
            if (!mainPanel.Controls.Contains(UBin.Instance))
            {
                mainPanel.Controls.Add(UBin.Instance);
                UBin.Instance.Dock = DockStyle.Fill;
                UBin.Instance.BringToFront();
            }
            else
            {
                UBin.Instance.BringToFront();
            }
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            if (!mainPanel.Controls.Contains(UProduct.Instance))
            {
                mainPanel.Controls.Add(UProduct.Instance);
                UProduct.Instance.Dock = DockStyle.Fill;
                UProduct.Instance.BringToFront();
            }
            else
            {
                UProduct.Instance.BringToFront();
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (!mainPanel.Controls.Contains(UReport.Instance))
            {
                mainPanel.Controls.Add(UReport.Instance);
                UReport.Instance.Dock = DockStyle.Fill;
                UReport.Instance.BringToFront();
            }
            else
            {
                UReport.Instance.BringToFront();
            }
        }

        private void btnSold_Click(object sender, EventArgs e)
        {
            if (!mainPanel.Controls.Contains(USold.Instance))
            {
                mainPanel.Controls.Add(USold.Instance);
                USold.Instance.Dock = DockStyle.Fill;
                USold.Instance.BringToFront();
            }
            else
            {
                USold.Instance.BringToFront();
            }
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            if (!mainPanel.Controls.Contains(UImportStock.Instance))
            {
                mainPanel.Controls.Add(UImportStock.Instance);
                UImportStock.Instance.Dock = DockStyle.Fill;
                UImportStock.Instance.BringToFront();
            }
            else
            {
                UImportStock.Instance.BringToFront();
            }
        }

        private void showFormInPanel(Form form)
        {
            mainPanel.Controls.Clear();
            form.TopLevel = false;
            form.AutoScroll = true;
            mainPanel.Controls.Add(form);

            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

    }
}
