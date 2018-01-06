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
    public partial class productCn : UserControl
    {
        private static productCn _instance;

        public static productCn Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new productCn();
                return _instance;
            }
        }
        public productCn()
        {
            InitializeComponent();
        }
    }
}
