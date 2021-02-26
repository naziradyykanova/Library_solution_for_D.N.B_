namespace Lib.Forms
{
    partial class BookEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookEdit));
            System.Windows.Forms.Label шифр_книгиLabel;
            System.Windows.Forms.Label названиеLabel;
            System.Windows.Forms.Label код_издательстваLabel;
            System.Windows.Forms.Label год_изданияLabel;
            System.Windows.Forms.Label объем_книгиLabel;
            System.Windows.Forms.Label ценаLabel;
            System.Windows.Forms.Label количествоLabel;
            System.Windows.Forms.Label код_разделаLabel;
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.библиотекаDataSet = new Lib.БиблиотекаDataSet();
            this.информация_о_книгеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.информация_о_книгеTableAdapter = new Lib.БиблиотекаDataSetTableAdapters.Информация_о_книгеTableAdapter();
            this.tableAdapterManager = new Lib.БиблиотекаDataSetTableAdapters.TableAdapterManager();
            this.информация_о_книгеBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.информация_о_книгеBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.BookID = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtBookPublisher = new System.Windows.Forms.TextBox();
            this.DTPpublishing = new System.Windows.Forms.DateTimePicker();
            this.txtBookVolume = new System.Windows.Forms.TextBox();
            this.txtBookPrice = new System.Windows.Forms.TextBox();
            this.txtBookCategory = new System.Windows.Forms.TextBox();
            this.txtBookQuentity = new System.Windows.Forms.TextBox();
            шифр_книгиLabel = new System.Windows.Forms.Label();
            названиеLabel = new System.Windows.Forms.Label();
            код_издательстваLabel = new System.Windows.Forms.Label();
            год_изданияLabel = new System.Windows.Forms.Label();
            объем_книгиLabel = new System.Windows.Forms.Label();
            ценаLabel = new System.Windows.Forms.Label();
            количествоLabel = new System.Windows.Forms.Label();
            код_разделаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.библиотекаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.информация_о_книгеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.информация_о_книгеBindingNavigator)).BeginInit();
            this.информация_о_книгеBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(433, 276);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(337, 276);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button2_Click);
            // 
            // библиотекаDataSet
            // 
            this.библиотекаDataSet.DataSetName = "БиблиотекаDataSet";
            this.библиотекаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // информация_о_книгеBindingSource
            // 
            this.информация_о_книгеBindingSource.DataMember = "Информация о книге";
            this.информация_о_книгеBindingSource.DataSource = this.библиотекаDataSet;
            // 
            // информация_о_книгеTableAdapter
            // 
            this.информация_о_книгеTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Lib.БиблиотекаDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Авторы_книгTableAdapter = null;
            this.tableAdapterManager.АвторыTableAdapter = null;
            this.tableAdapterManager.Бронирование_книгTableAdapter = null;
            this.tableAdapterManager.Выдача_книгTableAdapter = null;
            this.tableAdapterManager.ГородаTableAdapter = null;
            this.tableAdapterManager.ЗадолжникиTableAdapter = null;
            this.tableAdapterManager.ИздательстваTableAdapter = null;
            this.tableAdapterManager.Информация_о_книгеTableAdapter = this.информация_о_книгеTableAdapter;
            this.tableAdapterManager.Информация_о_читателеTableAdapter = null;
            this.tableAdapterManager.ПользователиTableAdapter = null;
            this.tableAdapterManager.Разделы_библиотекиTableAdapter = null;
            // 
            // информация_о_книгеBindingNavigator
            // 
            this.информация_о_книгеBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.информация_о_книгеBindingNavigator.BindingSource = this.информация_о_книгеBindingSource;
            this.информация_о_книгеBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.информация_о_книгеBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.информация_о_книгеBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.информация_о_книгеBindingNavigatorSaveItem});
            this.информация_о_книгеBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.информация_о_книгеBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.информация_о_книгеBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.информация_о_книгеBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.информация_о_книгеBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.информация_о_книгеBindingNavigator.Name = "информация_о_книгеBindingNavigator";
            this.информация_о_книгеBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.информация_о_книгеBindingNavigator.Size = new System.Drawing.Size(594, 25);
            this.информация_о_книгеBindingNavigator.TabIndex = 2;
            this.информация_о_книгеBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // информация_о_книгеBindingNavigatorSaveItem
            // 
            this.информация_о_книгеBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.информация_о_книгеBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("информация_о_книгеBindingNavigatorSaveItem.Image")));
            this.информация_о_книгеBindingNavigatorSaveItem.Name = "информация_о_книгеBindingNavigatorSaveItem";
            this.информация_о_книгеBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.информация_о_книгеBindingNavigatorSaveItem.Text = "Save Data";
            this.информация_о_книгеBindingNavigatorSaveItem.Click += new System.EventHandler(this.информация_о_книгеBindingNavigatorSaveItem_Click);
            // 
            // шифр_книгиLabel
            // 
            шифр_книгиLabel.AutoSize = true;
            шифр_книгиLabel.Location = new System.Drawing.Point(12, 42);
            шифр_книгиLabel.Name = "шифр_книгиLabel";
            шифр_книгиLabel.Size = new System.Drawing.Size(71, 13);
            шифр_книгиLabel.TabIndex = 3;
            шифр_книгиLabel.Text = "Шифр книги:";
            // 
            // названиеLabel
            // 
            названиеLabel.AutoSize = true;
            названиеLabel.Location = new System.Drawing.Point(23, 78);
            названиеLabel.Name = "названиеLabel";
            названиеLabel.Size = new System.Drawing.Size(60, 13);
            названиеLabel.TabIndex = 5;
            названиеLabel.Text = "Название:";
            // 
            // код_издательстваLabel
            // 
            код_издательстваLabel.AutoSize = true;
            код_издательстваLabel.Location = new System.Drawing.Point(12, 114);
            код_издательстваLabel.Name = "код_издательстваLabel";
            код_издательстваLabel.Size = new System.Drawing.Size(102, 13);
            код_издательстваLabel.TabIndex = 7;
            код_издательстваLabel.Text = "Код издательства:";
            // 
            // год_изданияLabel
            // 
            год_изданияLabel.AutoSize = true;
            год_изданияLabel.Location = new System.Drawing.Point(10, 159);
            год_изданияLabel.Name = "год_изданияLabel";
            год_изданияLabel.Size = new System.Drawing.Size(73, 13);
            год_изданияLabel.TabIndex = 9;
            год_изданияLabel.Text = "Год издания:";
            // 
            // объем_книгиLabel
            // 
            объем_книгиLabel.AutoSize = true;
            объем_книгиLabel.Location = new System.Drawing.Point(37, 202);
            объем_книгиLabel.Name = "объем_книгиLabel";
            объем_книгиLabel.Size = new System.Drawing.Size(77, 13);
            объем_книгиLabel.TabIndex = 11;
            объем_книгиLabel.Text = "Объем книги:";
            // 
            // ценаLabel
            // 
            ценаLabel.AutoSize = true;
            ценаLabel.Location = new System.Drawing.Point(78, 239);
            ценаLabel.Name = "ценаLabel";
            ценаLabel.Size = new System.Drawing.Size(36, 13);
            ценаLabel.TabIndex = 13;
            ценаLabel.Text = "Цена:";
            // 
            // количествоLabel
            // 
            количествоLabel.AutoSize = true;
            количествоLabel.Location = new System.Drawing.Point(282, 45);
            количествоLabel.Name = "количествоLabel";
            количествоLabel.Size = new System.Drawing.Size(69, 13);
            количествоLabel.TabIndex = 15;
            количествоLabel.Text = "Количество:";
            // 
            // код_разделаLabel
            // 
            код_разделаLabel.AutoSize = true;
            код_разделаLabel.Location = new System.Drawing.Point(282, 92);
            код_разделаLabel.Name = "код_разделаLabel";
            код_разделаLabel.Size = new System.Drawing.Size(74, 13);
            код_разделаLabel.TabIndex = 17;
            код_разделаLabel.Text = "Код раздела:";
            // 
            // BookID
            // 
            this.BookID.Location = new System.Drawing.Point(120, 35);
            this.BookID.Name = "BookID";
            this.BookID.Size = new System.Drawing.Size(128, 20);
            this.BookID.TabIndex = 19;
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(120, 71);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(128, 20);
            this.txtBookName.TabIndex = 20;
            // 
            // txtBookPublisher
            // 
            this.txtBookPublisher.Location = new System.Drawing.Point(120, 114);
            this.txtBookPublisher.Name = "txtBookPublisher";
            this.txtBookPublisher.Size = new System.Drawing.Size(128, 20);
            this.txtBookPublisher.TabIndex = 21;
            // 
            // DTPpublishing
            // 
            this.DTPpublishing.Location = new System.Drawing.Point(120, 159);
            this.DTPpublishing.Name = "DTPpublishing";
            this.DTPpublishing.Size = new System.Drawing.Size(128, 20);
            this.DTPpublishing.TabIndex = 22;
            // 
            // txtBookVolume
            // 
            this.txtBookVolume.Location = new System.Drawing.Point(120, 199);
            this.txtBookVolume.Name = "txtBookVolume";
            this.txtBookVolume.Size = new System.Drawing.Size(128, 20);
            this.txtBookVolume.TabIndex = 23;
            // 
            // txtBookPrice
            // 
            this.txtBookPrice.Location = new System.Drawing.Point(120, 239);
            this.txtBookPrice.Name = "txtBookPrice";
            this.txtBookPrice.Size = new System.Drawing.Size(128, 20);
            this.txtBookPrice.TabIndex = 24;
            // 
            // txtBookCategory
            // 
            this.txtBookCategory.Location = new System.Drawing.Point(380, 92);
            this.txtBookCategory.Name = "txtBookCategory";
            this.txtBookCategory.Size = new System.Drawing.Size(128, 20);
            this.txtBookCategory.TabIndex = 25;
            this.txtBookCategory.WordWrap = false;
            // 
            // txtBookQuentity
            // 
            this.txtBookQuentity.Location = new System.Drawing.Point(380, 45);
            this.txtBookQuentity.Name = "txtBookQuentity";
            this.txtBookQuentity.Size = new System.Drawing.Size(128, 20);
            this.txtBookQuentity.TabIndex = 26;
            // 
            // BookEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 319);
            this.Controls.Add(this.txtBookQuentity);
            this.Controls.Add(this.txtBookCategory);
            this.Controls.Add(this.txtBookPrice);
            this.Controls.Add(this.txtBookVolume);
            this.Controls.Add(this.DTPpublishing);
            this.Controls.Add(this.txtBookPublisher);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.BookID);
            this.Controls.Add(код_разделаLabel);
            this.Controls.Add(количествоLabel);
            this.Controls.Add(ценаLabel);
            this.Controls.Add(объем_книгиLabel);
            this.Controls.Add(год_изданияLabel);
            this.Controls.Add(код_издательстваLabel);
            this.Controls.Add(названиеLabel);
            this.Controls.Add(шифр_книгиLabel);
            this.Controls.Add(this.информация_о_книгеBindingNavigator);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Name = "BookEdit";
            this.Text = "BookEdit";
            this.Load += new System.EventHandler(this.BookEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.библиотекаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.информация_о_книгеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.информация_о_книгеBindingNavigator)).EndInit();
            this.информация_о_книгеBindingNavigator.ResumeLayout(false);
            this.информация_о_книгеBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private БиблиотекаDataSet библиотекаDataSet;
        private System.Windows.Forms.BindingSource информация_о_книгеBindingSource;
        private БиблиотекаDataSetTableAdapters.Информация_о_книгеTableAdapter информация_о_книгеTableAdapter;
        private БиблиотекаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator информация_о_книгеBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton информация_о_книгеBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox BookID;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtBookPublisher;
        private System.Windows.Forms.DateTimePicker DTPpublishing;
        private System.Windows.Forms.TextBox txtBookVolume;
        private System.Windows.Forms.TextBox txtBookPrice;
        private System.Windows.Forms.TextBox txtBookCategory;
        private System.Windows.Forms.TextBox txtBookQuentity;
    }
}