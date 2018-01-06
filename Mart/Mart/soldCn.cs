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
    public partial class soldCn : UserControl
    {
        private static soldCn _instance;

        public static soldCn Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new soldCn();
                return _instance;
            }
        }
        public soldCn()
        {
            InitializeComponent();
        }
    }
}
