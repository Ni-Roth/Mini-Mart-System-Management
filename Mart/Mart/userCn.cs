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
    public partial class userCn : UserControl
    {
        private static userCn _instance;

        public static userCn Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new userCn();
                return _instance;
            }
        }
        public userCn()
        {
            InitializeComponent();
        }
    }
}
