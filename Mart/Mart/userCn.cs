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
        UserDao uDao;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void userCn_Load(object sender, EventArgs e)
        {
            uDao = new UserDao();
            //List<User> list = uDao.GetUser();

            //foreach (User item in list)
            //{
            //    dgvUser.Rows.Add(item.Id,item.Name);
            //}

            uDao.FillDataGrid(dgvUser);

        }
    }
    
    //abcd "Changed by Thoura
}
