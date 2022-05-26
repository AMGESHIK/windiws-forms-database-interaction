
namespace WindowsFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dataSet1 = new WindowsFormsApp1.DataSet1();
            this.availabilityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.availabilityTableAdapter = new WindowsFormsApp1.DataSet1TableAdapters.availabilityTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.DataSet1TableAdapters.TableAdapterManager();
            this.accountingTableAdapter = new WindowsFormsApp1.DataSet1TableAdapters.accountingTableAdapter();
            this.deliveryTableAdapter = new WindowsFormsApp1.DataSet1TableAdapters.deliveryTableAdapter();
            this.availabilityBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.availabilityBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.numberOfContractDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeOfMaterialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTableName = new System.Windows.Forms.ToolStripLabel();
            this.btnAvailability = new System.Windows.Forms.Button();
            this.btnDelivery = new System.Windows.Forms.Button();
            this.btnAccounting = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.availabilityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.availabilityBindingNavigator)).BeginInit();
            this.availabilityBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // availabilityBindingSource
            // 
            this.availabilityBindingSource.DataMember = "availability";
            this.availabilityBindingSource.DataSource = this.dataSet1;
            // 
            // availabilityTableAdapter
            // 
            this.availabilityTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.accountingTableAdapter = this.accountingTableAdapter;
            this.tableAdapterManager.availabilityTableAdapter = this.availabilityTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.deliveryTableAdapter = this.deliveryTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // accountingTableAdapter
            // 
            this.accountingTableAdapter.ClearBeforeFill = true;
            // 
            // deliveryTableAdapter
            // 
            this.deliveryTableAdapter.ClearBeforeFill = true;
            // 
            // availabilityBindingNavigator
            // 
            this.availabilityBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.availabilityBindingNavigator.BindingSource = this.availabilityBindingSource;
            this.availabilityBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.availabilityBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.availabilityBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.availabilityBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.availabilityBindingNavigatorSaveItem,
            this.lblTableName});
            this.availabilityBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.availabilityBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.availabilityBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.availabilityBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.availabilityBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.availabilityBindingNavigator.Name = "availabilityBindingNavigator";
            this.availabilityBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.availabilityBindingNavigator.Size = new System.Drawing.Size(1064, 33);
            this.availabilityBindingNavigator.TabIndex = 0;
            this.availabilityBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(65, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // availabilityBindingNavigatorSaveItem
            // 
            this.availabilityBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.availabilityBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("availabilityBindingNavigatorSaveItem.Image")));
            this.availabilityBindingNavigatorSaveItem.Name = "availabilityBindingNavigatorSaveItem";
            this.availabilityBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.availabilityBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.availabilityBindingNavigatorSaveItem.Click += new System.EventHandler(this.availabilityBindingNavigatorSaveItem_Click_1);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberOfContractDataGridViewTextBoxColumn,
            this.codeOfMaterialDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.dateOfStartDataGridViewTextBoxColumn,
            this.dateOfEndDataGridViewTextBoxColumn,
            this.planDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.deliveryBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 127);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(756, 220);
            this.dataGridView.TabIndex = 1;
            // 
            // numberOfContractDataGridViewTextBoxColumn
            // 
            this.numberOfContractDataGridViewTextBoxColumn.DataPropertyName = "number of contract";
            this.numberOfContractDataGridViewTextBoxColumn.HeaderText = "number of contract";
            this.numberOfContractDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.numberOfContractDataGridViewTextBoxColumn.Name = "numberOfContractDataGridViewTextBoxColumn";
            this.numberOfContractDataGridViewTextBoxColumn.Width = 150;
            // 
            // codeOfMaterialDataGridViewTextBoxColumn
            // 
            this.codeOfMaterialDataGridViewTextBoxColumn.DataPropertyName = "code of material";
            this.codeOfMaterialDataGridViewTextBoxColumn.HeaderText = "code of material";
            this.codeOfMaterialDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.codeOfMaterialDataGridViewTextBoxColumn.Name = "codeOfMaterialDataGridViewTextBoxColumn";
            this.codeOfMaterialDataGridViewTextBoxColumn.Width = 150;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "unit";
            this.unitDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateOfStartDataGridViewTextBoxColumn
            // 
            this.dateOfStartDataGridViewTextBoxColumn.DataPropertyName = "date of start";
            this.dateOfStartDataGridViewTextBoxColumn.HeaderText = "date of start";
            this.dateOfStartDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateOfStartDataGridViewTextBoxColumn.Name = "dateOfStartDataGridViewTextBoxColumn";
            this.dateOfStartDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateOfEndDataGridViewTextBoxColumn
            // 
            this.dateOfEndDataGridViewTextBoxColumn.DataPropertyName = "date of end";
            this.dateOfEndDataGridViewTextBoxColumn.HeaderText = "date of end";
            this.dateOfEndDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateOfEndDataGridViewTextBoxColumn.Name = "dateOfEndDataGridViewTextBoxColumn";
            this.dateOfEndDataGridViewTextBoxColumn.Width = 150;
            // 
            // planDataGridViewTextBoxColumn
            // 
            this.planDataGridViewTextBoxColumn.DataPropertyName = "plan";
            this.planDataGridViewTextBoxColumn.HeaderText = "plan";
            this.planDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.planDataGridViewTextBoxColumn.Name = "planDataGridViewTextBoxColumn";
            this.planDataGridViewTextBoxColumn.Width = 150;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 150;
            // 
            // deliveryBindingSource
            // 
            this.deliveryBindingSource.DataMember = "delivery";
            this.deliveryBindingSource.DataSource = this.dataSet1;
            // 
            // accountingBindingSource
            // 
            this.accountingBindingSource.DataMember = "accounting";
            this.accountingBindingSource.DataSource = this.dataSet1;
            // 
            // lblTableName
            // 
            this.lblTableName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(90, 28);
            this.lblTableName.Text = "Наличие";
            // 
            // btnAvailability
            // 
            this.btnAvailability.Location = new System.Drawing.Point(12, 59);
            this.btnAvailability.Name = "btnAvailability";
            this.btnAvailability.Size = new System.Drawing.Size(118, 44);
            this.btnAvailability.TabIndex = 2;
            this.btnAvailability.Text = "Наличие";
            this.btnAvailability.UseVisualStyleBackColor = true;
            this.btnAvailability.Click += new System.EventHandler(this.btnAvailability_Click);
            // 
            // btnDelivery
            // 
            this.btnDelivery.Location = new System.Drawing.Point(157, 59);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Size = new System.Drawing.Size(110, 44);
            this.btnDelivery.TabIndex = 3;
            this.btnDelivery.Text = "Доставка";
            this.btnDelivery.UseVisualStyleBackColor = true;
            this.btnDelivery.Click += new System.EventHandler(this.btnDelivery_Click);
            // 
            // btnAccounting
            // 
            this.btnAccounting.Location = new System.Drawing.Point(301, 59);
            this.btnAccounting.Name = "btnAccounting";
            this.btnAccounting.Size = new System.Drawing.Size(127, 44);
            this.btnAccounting.TabIndex = 4;
            this.btnAccounting.Text = "Учет";
            this.btnAccounting.UseVisualStyleBackColor = true;
            this.btnAccounting.Click += new System.EventHandler(this.btnAccounting_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(458, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(608, 59);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 43);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 602);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAccounting);
            this.Controls.Add(this.btnDelivery);
            this.Controls.Add(this.btnAvailability);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.availabilityBindingNavigator);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.availabilityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.availabilityBindingNavigator)).EndInit();
            this.availabilityBindingNavigator.ResumeLayout(false);
            this.availabilityBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource availabilityBindingSource;
        private DataSet1TableAdapters.availabilityTableAdapter availabilityTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator availabilityBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton availabilityBindingNavigatorSaveItem;
        private DataSet1TableAdapters.deliveryTableAdapter deliveryTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource deliveryBindingSource;
        private DataSet1TableAdapters.accountingTableAdapter accountingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfContractDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeOfMaterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfEndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource accountingBindingSource;
        private System.Windows.Forms.ToolStripLabel lblTableName;
        private System.Windows.Forms.Button btnAvailability;
        private System.Windows.Forms.Button btnDelivery;
        private System.Windows.Forms.Button btnAccounting;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSave;
    }
}