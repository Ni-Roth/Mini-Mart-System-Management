using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mart
{
    public partial class Form1 : Form
    {
        List<Panel> listPanel = new List<Panel>();
        int index;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            if (!mainPanel.Controls.Contains(userCn.Instance))
            {
                mainPanel.Controls.Add(userCn.Instance);
                userCn.Instance.Dock = DockStyle.Fill;
                userCn.Instance.BringToFront();
            }
            else
            {
                userCn.Instance.BringToFront();
            }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            if (!mainPanel.Controls.Contains(settingCn.Instance))
            {
                mainPanel.Controls.Add(settingCn.Instance);
                settingCn.Instance.Dock = DockStyle.Fill;
                settingCn.Instance.BringToFront();
            }
            else
            {
                settingCn.Instance.BringToFront();
            }
        }

        private void btnBin_Click(object sender, EventArgs e)
        {
            if (!mainPanel.Controls.Contains(binCn.Instance))
            {
                mainPanel.Controls.Add(binCn.Instance);
                binCn.Instance.Dock = DockStyle.Fill;
                binCn.Instance.BringToFront();
            }
            else
            {
                binCn.Instance.BringToFront();
            }
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            if (!mainPanel.Controls.Contains(productCn.Instance))
            {
                mainPanel.Controls.Add(productCn.Instance);
                productCn.Instance.Dock = DockStyle.Fill;
                productCn.Instance.BringToFront();
            }
            else
            {
                stockCn.Instance.BringToFront();
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (!mainPanel.Controls.Contains(reportCn.Instance))
            {
                mainPanel.Controls.Add(reportCn.Instance);
                reportCn.Instance.Dock = DockStyle.Fill;
                reportCn.Instance.BringToFront();
            }
            else
            {
                reportCn.Instance.BringToFront();
            }
        }

        private void btnSold_Click(object sender, EventArgs e)
        {
            if (!mainPanel.Controls.Contains(soldCn.Instance))
            {
                mainPanel.Controls.Add(soldCn.Instance);
                soldCn.Instance.Dock = DockStyle.Fill;
                soldCn.Instance.BringToFront();
            }
            else
            {
                soldCn.Instance.BringToFront();
            }
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            if(!mainPanel.Controls.Contains(stockCn.Instance))
            {
                mainPanel.Controls.Add(stockCn.Instance);
                stockCn.Instance.Dock = DockStyle.Fill;
                stockCn.Instance.BringToFront();
            } else
            {
                stockCn.Instance.BringToFront();
            }
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            
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
