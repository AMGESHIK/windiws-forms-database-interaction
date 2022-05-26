
namespace WindowsFormsApp1
{
    partial class Zadacha1v4
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zadacha1v4));
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFill = new System.Windows.Forms.Button();
            this.zadacha1DataGridView = new System.Windows.Forms.DataGridView();
            this.codeOfMaterialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfReceptionDocumentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfContractDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zadacha1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new WindowsFormsApp1.DataSet1();
            this.zadacha1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.zadacha1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.accountingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountingTableAdapter = new WindowsFormsApp1.DataSet1TableAdapters.accountingTableAdapter();
            this.deliveryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deliveryTableAdapter = new WindowsFormsApp1.DataSet1TableAdapters.deliveryTableAdapter();
            this.zadacha1TableAdapter = new WindowsFormsApp1.DataSet1TableAdapters.Zadacha1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.zadacha1DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zadacha1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zadacha1BindingNavigator)).BeginInit();
            this.zadacha1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1192, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Номер склада:";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(1333, 172);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(187, 26);
            this.txtNumber.TabIndex = 16;
            this.txtNumber.Text = "1";
            this.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1275, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 15;
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(1269, 215);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(141, 44);
            this.btnFill.TabIndex = 14;
            this.btnFill.Text = "Заполнить";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // zadacha1DataGridView
            // 
            this.zadacha1DataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.zadacha1DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.zadacha1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zadacha1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeOfMaterialDataGridViewTextBoxColumn,
            this.numberOfReceptionDocumentDataGridViewTextBoxColumn,
            this.receiptDateDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.numberOfContractDataGridViewTextBoxColumn,
            this.planDataGridViewTextBoxColumn,
            this.dateOfEndDataGridViewTextBoxColumn});
            this.zadacha1DataGridView.DataSource = this.zadacha1BindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.zadacha1DataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.zadacha1DataGridView.Location = new System.Drawing.Point(12, 49);
            this.zadacha1DataGridView.Name = "zadacha1DataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.zadacha1DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.zadacha1DataGridView.RowHeadersWidth = 62;
            this.zadacha1DataGridView.RowTemplate.Height = 28;
            this.zadacha1DataGridView.Size = new System.Drawing.Size(1118, 328);
            this.zadacha1DataGridView.TabIndex = 13;
            // 
            // codeOfMaterialDataGridViewTextBoxColumn
            // 
            this.codeOfMaterialDataGridViewTextBoxColumn.DataPropertyName = "code of material";
            this.codeOfMaterialDataGridViewTextBoxColumn.HeaderText = "code of material";
            this.codeOfMaterialDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.codeOfMaterialDataGridViewTextBoxColumn.Name = "codeOfMaterialDataGridViewTextBoxColumn";
            this.codeOfMaterialDataGridViewTextBoxColumn.Width = 150;
            // 
            // numberOfReceptionDocumentDataGridViewTextBoxColumn
            // 
            this.numberOfReceptionDocumentDataGridViewTextBoxColumn.DataPropertyName = "number of reception document";
            this.numberOfReceptionDocumentDataGridViewTextBoxColumn.HeaderText = "number of reception document";
            this.numberOfReceptionDocumentDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.numberOfReceptionDocumentDataGridViewTextBoxColumn.Name = "numberOfReceptionDocumentDataGridViewTextBoxColumn";
            this.numberOfReceptionDocumentDataGridViewTextBoxColumn.Width = 150;
            // 
            // receiptDateDataGridViewTextBoxColumn
            // 
            this.receiptDateDataGridViewTextBoxColumn.DataPropertyName = "receipt date";
            this.receiptDateDataGridViewTextBoxColumn.HeaderText = "receipt date";
            this.receiptDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.receiptDateDataGridViewTextBoxColumn.Name = "receiptDateDataGridViewTextBoxColumn";
            this.receiptDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "count";
            this.countDataGridViewTextBoxColumn.HeaderText = "count";
            this.countDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.Width = 150;
            // 
            // numberOfContractDataGridViewTextBoxColumn
            // 
            this.numberOfContractDataGridViewTextBoxColumn.DataPropertyName = "number of contract";
            this.numberOfContractDataGridViewTextBoxColumn.HeaderText = "number of contract";
            this.numberOfContractDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.numberOfContractDataGridViewTextBoxColumn.Name = "numberOfContractDataGridViewTextBoxColumn";
            this.numberOfContractDataGridViewTextBoxColumn.Width = 150;
            // 
            // planDataGridViewTextBoxColumn
            // 
            this.planDataGridViewTextBoxColumn.DataPropertyName = "plan";
            this.planDataGridViewTextBoxColumn.HeaderText = "plan";
            this.planDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.planDataGridViewTextBoxColumn.Name = "planDataGridViewTextBoxColumn";
            this.planDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateOfEndDataGridViewTextBoxColumn
            // 
            this.dateOfEndDataGridViewTextBoxColumn.DataPropertyName = "date of end";
            this.dateOfEndDataGridViewTextBoxColumn.HeaderText = "date of end";
            this.dateOfEndDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateOfEndDataGridViewTextBoxColumn.Name = "dateOfEndDataGridViewTextBoxColumn";
            this.dateOfEndDataGridViewTextBoxColumn.Width = 150;
            // 
            // zadacha1BindingSource
            // 
            this.zadacha1BindingSource.DataMember = "Zadacha1";
            this.zadacha1BindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zadacha1BindingNavigator
            // 
            this.zadacha1BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.zadacha1BindingNavigator.BindingSource = this.zadacha1BindingSource;
            this.zadacha1BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.zadacha1BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.zadacha1BindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.zadacha1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.zadacha1BindingNavigatorSaveItem});
            this.zadacha1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.zadacha1BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.zadacha1BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.zadacha1BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.zadacha1BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.zadacha1BindingNavigator.Name = "zadacha1BindingNavigator";
            this.zadacha1BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.zadacha1BindingNavigator.Size = new System.Drawing.Size(1550, 38);
            this.zadacha1BindingNavigator.TabIndex = 12;
            this.zadacha1BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(65, 33);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 38);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // zadacha1BindingNavigatorSaveItem
            // 
            this.zadacha1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zadacha1BindingNavigatorSaveItem.Enabled = false;
            this.zadacha1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("zadacha1BindingNavigatorSaveItem.Image")));
            this.zadacha1BindingNavigatorSaveItem.Name = "zadacha1BindingNavigatorSaveItem";
            this.zadacha1BindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 33);
            this.zadacha1BindingNavigatorSaveItem.Text = "Сохранить данные";
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
            // deliveryBindingSource
            // 
            this.deliveryBindingSource.DataMember = "delivery";
            this.deliveryBindingSource.DataSource = this.dataSet1;
            // 
            // deliveryTableAdapter
            // 
            this.deliveryTableAdapter.ClearBeforeFill = true;
            // 
            // zadacha1TableAdapter
            // 
            this.zadacha1TableAdapter.ClearBeforeFill = true;
            // 
            // Zadacha1v4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1550, 714);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.zadacha1DataGridView);
            this.Controls.Add(this.zadacha1BindingNavigator);
            this.Name = "Zadacha1v4";
            this.Text = "Zadacha1v4";
            this.Load += new System.EventHandler(this.Zadacha1v4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zadacha1DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zadacha1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zadacha1BindingNavigator)).EndInit();
            this.zadacha1BindingNavigator.ResumeLayout(false);
            this.zadacha1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.DataGridView zadacha1DataGridView;
        private System.Windows.Forms.BindingNavigator zadacha1BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton zadacha1BindingNavigatorSaveItem;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource accountingBindingSource;
        private DataSet1TableAdapters.accountingTableAdapter accountingTableAdapter;
        private System.Windows.Forms.BindingSource deliveryBindingSource;
        private DataSet1TableAdapters.deliveryTableAdapter deliveryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeOfMaterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfReceptionDocumentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiptDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfContractDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfEndDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource zadacha1BindingSource;
        private DataSet1TableAdapters.Zadacha1TableAdapter zadacha1TableAdapter;
    }
}