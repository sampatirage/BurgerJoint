using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ass3_11670527_Saman.View
{
    public partial class OrderItemForm : Form
    {
        public OrderItemForm()
        {
            InitializeComponent();
        }

        private void btnAddOrderItem_Click(object sender, EventArgs e)
        {
            Model.Database.InsertOrderItem("Umami Burgers","Burger", 2.90, 1);
        }
    }
}
