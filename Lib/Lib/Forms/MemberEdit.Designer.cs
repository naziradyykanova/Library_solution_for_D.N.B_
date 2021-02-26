namespace Lib.Forms
{
    partial class MemberEdit
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
            this.button1 = new System.Windows.Forms.Button();
            this.кодВыдачиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.шифрКнигиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодЧитательскогоБилетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаВыдачиКнигиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.выдача_книгTableAdapter = new Lib.БиблиотекаDataSetTableAdapters.Выдача_книгTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.датаВозвратаКнигиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.выдачаКнигBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.библиотекаDataSet = new Lib.БиблиотекаDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.выдачаКнигBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.библиотекаDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Вернуть";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // кодВыдачиDataGridViewTextBoxColumn
            // 
            this.кодВыдачиDataGridViewTextBoxColumn.DataPropertyName = "Код выдачи";
            this.кодВыдачиDataGridViewTextBoxColumn.HeaderText = "Код выдачи";
            this.кодВыдачиDataGridViewTextBoxColumn.Name = "кодВыдачиDataGridViewTextBoxColumn";
            // 
            // шифрКнигиDataGridViewTextBoxColumn
            // 
            this.шифрКнигиDataGridViewTextBoxColumn.DataPropertyName = "Шифр книги";
            this.шифрКнигиDataGridViewTextBoxColumn.HeaderText = "Шифр книги";
            this.шифрКнигиDataGridViewTextBoxColumn.Name = "шифрКнигиDataGridViewTextBoxColumn";
            // 
            // кодЧитательскогоБилетаDataGridViewTextBoxColumn
            // 
            this.кодЧитательскогоБилетаDataGridViewTextBoxColumn.DataPropertyName = "Код читательского билета";
            this.кодЧитательскогоБилетаDataGridViewTextBoxColumn.HeaderText = "Код читательского билета";
            this.кодЧитательскогоБилетаDataGridViewTextBoxColumn.Name = "кодЧитательскогоБилетаDataGridViewTextBoxColumn";
            // 
            // датаВыдачиКнигиDataGridViewTextBoxColumn
            // 
            this.датаВыдачиКнигиDataGridViewTextBoxColumn.DataPropertyName = "Дата выдачи книги";
            this.датаВыдачиКнигиDataGridViewTextBoxColumn.HeaderText = "Дата выдачи книги";
            this.датаВыдачиКнигиDataGridViewTextBoxColumn.Name = "датаВыдачиКнигиDataGridViewTextBoxColumn";
            // 
            // выдача_книгTableAdapter
            // 
            this.выдача_книгTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодВыдачиDataGridViewTextBoxColumn,
            this.шифрКнигиDataGridViewTextBoxColumn,
            this.кодЧитательскогоБилетаDataGridViewTextBoxColumn,
            this.датаВыдачиКнигиDataGridViewTextBoxColumn,
            this.датаВозвратаКнигиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.выдачаКнигBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 214);
            this.dataGridView1.TabIndex = 13;
            // 
            // датаВозвратаКнигиDataGridViewTextBoxColumn
            // 
            this.датаВозвратаКнигиDataGridViewTextBoxColumn.DataPropertyName = "Дата возврата книги";
            this.датаВозвратаКнигиDataGridViewTextBoxColumn.HeaderText = "Дата возврата книги";
            this.датаВозвратаКнигиDataGridViewTextBoxColumn.Name = "датаВозвратаКнигиDataGridViewTextBoxColumn";
            // 
            // выдачаКнигBindingSource
            // 
            this.выдачаКнигBindingSource.DataMember = "Выдача книг";
            this.выдачаКнигBindingSource.DataSource = this.библиотекаDataSet;
            // 
            // библиотекаDataSet
            // 
            this.библиотекаDataSet.DataSetName = "БиблиотекаDataSet";
            this.библиотекаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 41);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Книга";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(481, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MemberEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 321);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MemberEdit";
            this.Text = "MemberEdit";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.выдачаКнигBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.библиотекаDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодВыдачиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn шифрКнигиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодЧитательскогоБилетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаВыдачиКнигиDataGridViewTextBoxColumn;
        private БиблиотекаDataSetTableAdapters.Выдача_книгTableAdapter выдача_книгTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаВозвратаКнигиDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource выдачаКнигBindingSource;
        private БиблиотекаDataSet библиотекаDataSet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
    }
}