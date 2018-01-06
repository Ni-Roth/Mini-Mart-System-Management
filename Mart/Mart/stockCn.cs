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
    public partial class stockCn : UserControl
    {
        private static stockCn _instance;

        public static stockCn Instance
        {
            get
            {
                if(_instance == null)                
                    _instance = new stockCn();
                    return _instance;        
            }
        }

        public stockCn()
        {
            InitializeComponent();
        }
    }
}
