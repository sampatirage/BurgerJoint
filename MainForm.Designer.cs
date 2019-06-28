namespace Ass3_11670527_Saman
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblMessage = new System.Windows.Forms.Label();
            this.debugBurgerDBDataSet = new Ass3_11670527_Saman.DebugBurgerDBDataSet();
            this.orderItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderItemTableAdapter = new Ass3_11670527_Saman.DebugBurgerDBDataSetTableAdapters.OrderItemTableAdapter();
            this.tableAdapterManager = new Ass3_11670527_Saman.DebugBurgerDBDataSetTableAdapters.TableAdapterManager();
            this.orderItemBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.orderItemBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.orderItemDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInitializeDatabase = new System.Windows.Forms.Button();
            this.btnAddRecordItem = new System.Windows.Forms.Button();
            this.burgerDBDataSet = new Ass3_11670527_Saman.BurgerDBDataSet();
            this.orderItemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.orderItemTableAdapter1 = new Ass3_11670527_Saman.BurgerDBDataSetTableAdapters.OrderItemTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.debugBurgerDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingNavigator)).BeginInit();
            this.orderItemBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.burgerDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(86, 341);
            this.lblMessage.MinimumSize = new System.Drawing.Size(600, 100);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(600, 100);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Message";
            // 
            // debugBurgerDBDataSet
            // 
            this.debugBurgerDBDataSet.DataSetName = "DebugBurgerDBDataSet";
            this.debugBurgerDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderItemBindingSource
            // 
            this.orderItemBindingSource.DataMember = "OrderItem";
            this.orderItemBindingSource.DataSource = this.debugBurgerDBDataSet;
            // 
            // orderItemTableAdapter
            // 
            this.orderItemTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OrderItemTableAdapter = this.orderItemTableAdapter;
            this.tableAdapterManager.UpdateOrder = Ass3_11670527_Saman.DebugBurgerDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // orderItemBindingNavigator
            // 
            this.orderItemBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.orderItemBindingNavigator.BindingSource = this.orderItemBindingSource;
            this.orderItemBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.orderItemBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.orderItemBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.orderItemBindingNavigatorSaveItem});
            this.orderItemBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.orderItemBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.orderItemBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.orderItemBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.orderItemBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.orderItemBindingNavigator.Name = "orderItemBindingNavigator";
            this.orderItemBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.orderItemBindingNavigator.Size = new System.Drawing.Size(825, 25);
            this.orderItemBindingNavigator.TabIndex = 1;
            this.orderItemBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // orderItemBindingNavigatorSaveItem
            // 
            this.orderItemBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.orderItemBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("orderItemBindingNavigatorSaveItem.Image")));
            this.orderItemBindingNavigatorSaveItem.Name = "orderItemBindingNavigatorSaveItem";
            this.orderItemBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.orderItemBindingNavigatorSaveItem.Text = "Save Data";
            this.orderItemBindingNavigatorSaveItem.Click += new System.EventHandler(this.orderItemBindingNavigatorSaveItem_Click);
            // 
            // orderItemDataGridView
            // 
            this.orderItemDataGridView.AllowUserToAddRows = false;
            this.orderItemDataGridView.AllowUserToDeleteRows = false;
            this.orderItemDataGridView.AutoGenerateColumns = false;
            this.orderItemDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.orderItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderItemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.orderItemDataGridView.DataSource = this.orderItemBindingSource1;
            this.orderItemDataGridView.Location = new System.Drawing.Point(123, 44);
            this.orderItemDataGridView.Name = "orderItemDataGridView";
            this.orderItemDataGridView.ReadOnly = true;
            this.orderItemDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderItemDataGridView.Size = new System.Drawing.Size(544, 220);
            this.orderItemDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Meal Item Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TypeName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Type";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ISize";
            this.dataGridViewTextBoxColumn3.HeaderText = "Size";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "BaseCost";
            this.dataGridViewTextBoxColumn4.HeaderText = "Base cost";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn5.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // btnInitializeDatabase
            // 
            this.btnInitializeDatabase.Location = new System.Drawing.Point(712, 100);
            this.btnInitializeDatabase.Name = "btnInitializeDatabase";
            this.btnInitializeDatabase.Size = new System.Drawing.Size(92, 43);
            this.btnInitializeDatabase.TabIndex = 3;
            this.btnInitializeDatabase.Text = "Initialize Database";
            this.btnInitializeDatabase.UseVisualStyleBackColor = true;
            this.btnInitializeDatabase.Click += new System.EventHandler(this.btnInitializeDatabase_Click);
            // 
            // btnAddRecordItem
            // 
            this.btnAddRecordItem.Location = new System.Drawing.Point(712, 178);
            this.btnAddRecordItem.Name = "btnAddRecordItem";
            this.btnAddRecordItem.Size = new System.Drawing.Size(92, 43);
            this.btnAddRecordItem.TabIndex = 4;
            this.btnAddRecordItem.Text = "Add Order Item";
            this.btnAddRecordItem.UseVisualStyleBackColor = true;
            this.btnAddRecordItem.Click += new System.EventHandler(this.btnAddRecordItem_Click);
            // 
            // burgerDBDataSet
            // 
            this.burgerDBDataSet.DataSetName = "BurgerDBDataSet";
            this.burgerDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderItemBindingSource1
            // 
            this.orderItemBindingSource1.DataMember = "OrderItem";
            this.orderItemBindingSource1.DataSource = this.burgerDBDataSet;
            // 
            // orderItemTableAdapter1
            // 
            this.orderItemTableAdapter1.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 461);
            this.Controls.Add(this.btnAddRecordItem);
            this.Controls.Add(this.btnInitializeDatabase);
            this.Controls.Add(this.orderItemDataGridView);
            this.Controls.Add(this.orderItemBindingNavigator);
            this.Controls.Add(this.lblMessage);
            this.Name = "MainForm";
            this.Text = "Food Item";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.debugBurgerDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingNavigator)).EndInit();
            this.orderItemBindingNavigator.ResumeLayout(false);
            this.orderItemBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.burgerDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private DebugBurgerDBDataSet debugBurgerDBDataSet;
        private System.Windows.Forms.BindingSource orderItemBindingSource;
        private DebugBurgerDBDataSetTableAdapters.OrderItemTableAdapter orderItemTableAdapter;
        private DebugBurgerDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator orderItemBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton orderItemBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView orderItemDataGridView;
        private System.Windows.Forms.Button btnInitializeDatabase;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnAddRecordItem;
        private BurgerDBDataSet burgerDBDataSet;
        private System.Windows.Forms.BindingSource orderItemBindingSource1;
        private BurgerDBDataSetTableAdapters.OrderItemTableAdapter orderItemTableAdapter1;
    }
}

