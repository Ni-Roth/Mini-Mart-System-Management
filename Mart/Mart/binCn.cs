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
    public partial class binCn : UserControl
    {
        private static binCn _instance;

        public static binCn Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new binCn();
                return _instance;
            }
        }
        public binCn()
        {
            InitializeComponent();
        }
    }
}
