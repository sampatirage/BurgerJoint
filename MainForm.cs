using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ass3_11670527_Saman
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            lblMessage.Text = " Database folder =" + Model.Database.dbFolder;
        }

        private void orderItemBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orderItemBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.debugBurgerDBDataSet);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'burgerDBDataSet.OrderItem' table. You can move, or remove it, as needed.
            this.orderItemTableAdapter1.Fill(this.burgerDBDataSet.OrderItem);
            // TODO: This line of code loads data into the 'debugBurgerDBDataSet.OrderItem' table. You can move, or remove it, as needed.
            this.orderItemTableAdapter.Fill(this.debugBurgerDBDataSet.OrderItem);           
        }

        private void btnInitializeDatabase_Click(object sender, EventArgs e)
        {
            // crete database to store FootItems data
            Model.Database.ConstructDatabase(); 
        }

        private void btnAddRecordItem_Click(object sender, EventArgs e)
        {
            var form = new View.OrderItemForm();
            form.ShowDialog();
        }
    }
}
