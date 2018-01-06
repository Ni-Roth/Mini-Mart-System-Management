using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mart
{
    public partial class settingCn : UserControl
    {
        private static settingCn _instance;

        public static settingCn Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new settingCn();
                return _instance;
            }
        }
        public settingCn()
        {
            InitializeComponent();
        }
    }
}
