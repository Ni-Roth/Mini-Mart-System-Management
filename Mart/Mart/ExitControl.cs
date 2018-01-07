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
    public partial class ExitControl : UserControl
    {
        private ExitControl _instance;
        public ExitControl Instance
        {
            get
            {
                if(_instance ==  null)              
                _instance = new ExitControl();
                return _instance;              
            }
        }
        public ExitControl()
        {
            InitializeComponent();
        }
    }
}
