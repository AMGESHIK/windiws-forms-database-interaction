
namespace WindowsFormsApp1
{
    partial class Zadacha3v2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zadacha3v2));
            this.btnFill = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlan = new System.Windows.Forms.TextBox();
            this.Zadacha3bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.Zadacha3DataGridView = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new WindowsFormsApp1.DataSet1();
            this.zadacha3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zadacha3TableAdapter = new WindowsFormsApp1.DataSet1TableAdapters.Zadacha3TableAdapter();
            this.accountingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountingTableAdapter = new WindowsFormsApp1.DataSet1TableAdapters.accountingTableAdapter();
            this.availabilityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.availabilityTableAdapter = new WindowsFormsApp1.DataSet1TableAdapters.availabilityTableAdapter();
            this.deliveryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deliveryTableAdapter = new WindowsFormsApp1.DataSet1TableAdapters.deliveryTableAdapter();
            this.codeOfMaterialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Zadacha3bindingNavigator1)).BeginInit();
            this.Zadacha3bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Zadacha3DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zadacha3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.availabilityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(866, 204);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(141, 44);
            this.btnFill.TabIndex = 33;
            this.btnFill.Text = "Заполнить";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(716, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Поступление в количестве:";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(985, 127);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(187, 26);
            this.txtCount.TabIndex = 31;
            this.txtCount.Text = "20";
            this.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(716, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "План поставки:";
            // 
            // txtPlan
            // 
            this.txtPlan.Location = new System.Drawing.Point(985, 84);
            this.txtPlan.Name = "txtPlan";
            this.txtPlan.Size = new System.Drawing.Size(187, 26);
            this.txtPlan.TabIndex = 29;
            this.txtPlan.Text = "100";
            this.txtPlan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Zadacha3bindingNavigator1
            // 
            this.Zadacha3bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.Zadacha3bindingNavigator1.BindingSource = this.zadacha3BindingSource;
            this.Zadacha3bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.Zadacha3bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.Zadacha3bindingNavigator1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Zadacha3bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem});
            this.Zadacha3bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.Zadacha3bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.Zadacha3bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.Zadacha3bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.Zadacha3bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.Zadacha3bindingNavigator1.Name = "Zadacha3bindingNavigator1";
            this.Zadacha3bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.Zadacha3bindingNavigator1.Size = new System.Drawing.Size(1713, 33);
            this.Zadacha3bindingNavigator1.TabIndex = 28;
            this.Zadacha3bindingNavigator1.Text = "bindingNavigator1";
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
            // Zadacha3DataGridView
            // 
            this.Zadacha3DataGridView.AutoGenerateColumns = false;
            this.Zadacha3DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Zadacha3DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeOfMaterialDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.Zadacha3DataGridView.DataSource = this.zadacha3BindingSource;
            this.Zadacha3DataGridView.Location = new System.Drawing.Point(31, 81);
            this.Zadacha3DataGridView.Name = "Zadacha3DataGridView";
            this.Zadacha3DataGridView.RowHeadersWidth = 62;
            this.Zadacha3DataGridView.RowTemplate.Height = 28;
            this.Zadacha3DataGridView.Size = new System.Drawing.Size(633, 634);
            this.Zadacha3DataGridView.TabIndex = 27;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zadacha3BindingSource
            // 
            this.zadacha3BindingSource.DataMember = "Zadacha3";
            this.zadacha3BindingSource.DataSource = this.dataSet1;
            // 
            // zadacha3TableAdapter
            // 
            this.zadacha3TableAdapter.ClearBeforeFill = true;
            // 
            // accountingBindingSource
            // 
            this.accountingBindingSource.DataMember = "accounting";
            this.accountingBindingSource.DataSource = this.dataSet1;
            // 
            // accountingTableAdapter
            // 
            this.accountingTableAdapter.ClearBeforeFill = true;
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
            // deliveryBindingSource
            // 
            this.deliveryBindingSource.DataMember = "delivery";
            this.deliveryBindingSource.DataSource = this.dataSet1;
            // 
            // deliveryTableAdapter
            // 
            this.deliveryTableAdapter.ClearBeforeFill = true;
            // 
            // codeOfMaterialDataGridViewTextBoxColumn
            // 
            this.codeOfMaterialDataGridViewTextBoxColumn.DataPropertyName = "code of material";
            this.codeOfMaterialDataGridViewTextBoxColumn.HeaderText = "code of material";
            this.codeOfMaterialDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.codeOfMaterialDataGridViewTextBoxColumn.Name = "codeOfMaterialDataGridViewTextBoxColumn";
            this.codeOfMaterialDataGridViewTextBoxColumn.Width = 150;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 150;
            // 
            // Zadacha3v2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1713, 733);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPlan);
            this.Controls.Add(this.Zadacha3bindingNavigator1);
            this.Controls.Add(this.Zadacha3DataGridView);
            this.Name = "Zadacha3v2";
            this.Text = "Zadacha3v2";
            this.Load += new System.EventHandler(this.Zadacha3v2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Zadacha3bindingNavigator1)).EndInit();
            this.Zadacha3bindingNavigator1.ResumeLayout(false);
            this.Zadacha3bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Zadacha3DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zadacha3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.availabilityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlan;
        private System.Windows.Forms.BindingNavigator Zadacha3bindingNavigator1;
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
        private System.Windows.Forms.DataGridView Zadacha3DataGridView;
        private System.Windows.Forms.BindingSource zadacha3BindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.Zadacha3TableAdapter zadacha3TableAdapter;
        private System.Windows.Forms.BindingSource accountingBindingSource;
        private DataSet1TableAdapters.accountingTableAdapter accountingTableAdapter;
        private System.Windows.Forms.BindingSource availabilityBindingSource;
        private DataSet1TableAdapters.availabilityTableAdapter availabilityTableAdapter;
        private System.Windows.Forms.BindingSource deliveryBindingSource;
        private DataSet1TableAdapters.deliveryTableAdapter deliveryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeOfMaterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    }
}