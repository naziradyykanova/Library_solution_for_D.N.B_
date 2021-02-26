namespace Lib.Forms
{
    partial class AddReader
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
            System.Windows.Forms.Label номер_билетаLabel;
            System.Windows.Forms.Label фамилияLabel;
            System.Windows.Forms.Label имяLabel;
            System.Windows.Forms.Label отчествоLabel;
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label дата_рожденияLabel;
            System.Windows.Forms.Label код_задолжникаLabel;
            System.Windows.Forms.Label лимитLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.лимитNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.информация_о_читателеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.библиотекаDataSet = new Lib.БиблиотекаDataSet();
            this.дата_рожденияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.код_задолжникаTextBox = new System.Windows.Forms.TextBox();
            this.задолжникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.адресRichTextBox = new System.Windows.Forms.RichTextBox();
            this.отчествоTextBox = new System.Windows.Forms.TextBox();
            this.имяTextBox = new System.Windows.Forms.TextBox();
            this.фамилияTextBox = new System.Windows.Forms.TextBox();
            this.номер_билетаTextBox = new System.Windows.Forms.TextBox();
            this.информация_о_читателеTableAdapter = new Lib.БиблиотекаDataSetTableAdapters.Информация_о_читателеTableAdapter();
            this.tableAdapterManager = new Lib.БиблиотекаDataSetTableAdapters.TableAdapterManager();
            this.задолжникиTableAdapter = new Lib.БиблиотекаDataSetTableAdapters.ЗадолжникиTableAdapter();
            this.выдача_книгBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.выдача_книгTableAdapter = new Lib.БиблиотекаDataSetTableAdapters.Выдача_книгTableAdapter();
            номер_билетаLabel = new System.Windows.Forms.Label();
            фамилияLabel = new System.Windows.Forms.Label();
            имяLabel = new System.Windows.Forms.Label();
            отчествоLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            дата_рожденияLabel = new System.Windows.Forms.Label();
            код_задолжникаLabel = new System.Windows.Forms.Label();
            лимитLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.лимитNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.информация_о_читателеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.библиотекаDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.задолжникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.выдача_книгBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // номер_билетаLabel
            // 
            номер_билетаLabel.AutoSize = true;
            номер_билетаLabel.Location = new System.Drawing.Point(20, 33);
            номер_билетаLabel.Name = "номер_билетаLabel";
            номер_билетаLabel.Size = new System.Drawing.Size(82, 13);
            номер_билетаLabel.TabIndex = 0;
            номер_билетаLabel.Text = "Номер билета:";
            // 
            // фамилияLabel
            // 
            фамилияLabel.AutoSize = true;
            фамилияLabel.Location = new System.Drawing.Point(43, 72);
            фамилияLabel.Name = "фамилияLabel";
            фамилияLabel.Size = new System.Drawing.Size(59, 13);
            фамилияLabel.TabIndex = 2;
            фамилияLabel.Text = "Фамилия:";
            // 
            // имяLabel
            // 
            имяLabel.AutoSize = true;
            имяLabel.Location = new System.Drawing.Point(70, 106);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(32, 13);
            имяLabel.TabIndex = 4;
            имяLabel.Text = "Имя:";
            // 
            // отчествоLabel
            // 
            отчествоLabel.AutoSize = true;
            отчествоLabel.Location = new System.Drawing.Point(45, 139);
            отчествоLabel.Name = "отчествоLabel";
            отчествоLabel.Size = new System.Drawing.Size(57, 13);
            отчествоLabel.TabIndex = 6;
            отчествоLabel.Text = "Отчество:";
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Location = new System.Drawing.Point(330, 36);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(41, 13);
            адресLabel.TabIndex = 8;
            адресLabel.Text = "Адрес:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Location = new System.Drawing.Point(43, 218);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(55, 13);
            телефонLabel.TabIndex = 10;
            телефонLabel.Text = "Телефон:";
            // 
            // дата_рожденияLabel
            // 
            дата_рожденияLabel.AutoSize = true;
            дата_рожденияLabel.Location = new System.Drawing.Point(13, 178);
            дата_рожденияLabel.Name = "дата_рожденияLabel";
            дата_рожденияLabel.Size = new System.Drawing.Size(89, 13);
            дата_рожденияLabel.TabIndex = 15;
            дата_рожденияLabel.Text = "Дата рождения:";
            // 
            // код_задолжникаLabel
            // 
            код_задолжникаLabel.AutoSize = true;
            код_задолжникаLabel.Location = new System.Drawing.Point(6, 64);
            код_задолжникаLabel.Name = "код_задолжникаLabel";
            код_задолжникаLabel.Size = new System.Drawing.Size(94, 13);
            код_задолжникаLabel.TabIndex = 0;
            код_задолжникаLabel.Text = "Код задолжника:";
            // 
            // лимитLabel
            // 
            лимитLabel.AutoSize = true;
            лимитLabel.Location = new System.Drawing.Point(358, 132);
            лимитLabel.Name = "лимитLabel";
            лимитLabel.Size = new System.Drawing.Size(43, 13);
            лимитLabel.TabIndex = 17;
            лимитLabel.Text = "Лимит:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 312);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(лимитLabel);
            this.groupBox1.Controls.Add(this.лимитNumericUpDown);
            this.groupBox1.Controls.Add(дата_рожденияLabel);
            this.groupBox1.Controls.Add(this.дата_рожденияDateTimePicker);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(телефонLabel);
            this.groupBox1.Controls.Add(this.телефонTextBox);
            this.groupBox1.Controls.Add(адресLabel);
            this.groupBox1.Controls.Add(this.адресRichTextBox);
            this.groupBox1.Controls.Add(отчествоLabel);
            this.groupBox1.Controls.Add(this.отчествоTextBox);
            this.groupBox1.Controls.Add(имяLabel);
            this.groupBox1.Controls.Add(this.имяTextBox);
            this.groupBox1.Controls.Add(фамилияLabel);
            this.groupBox1.Controls.Add(this.фамилияTextBox);
            this.groupBox1.Controls.Add(номер_билетаLabel);
            this.groupBox1.Controls.Add(this.номер_билетаTextBox);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 305);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // лимитNumericUpDown
            // 
            this.лимитNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.информация_о_читателеBindingSource, "Лимит", true));
            this.лимитNumericUpDown.Location = new System.Drawing.Point(407, 132);
            this.лимитNumericUpDown.Name = "лимитNumericUpDown";
            this.лимитNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.лимитNumericUpDown.TabIndex = 18;
            // 
            // информация_о_читателеBindingSource
            // 
            this.информация_о_читателеBindingSource.DataMember = "Информация о читателе";
            this.информация_о_читателеBindingSource.DataSource = this.библиотекаDataSet;
            // 
            // библиотекаDataSet
            // 
            this.библиотекаDataSet.DataSetName = "БиблиотекаDataSet";
            this.библиотекаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // дата_рожденияDateTimePicker
            // 
            this.дата_рожденияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.информация_о_читателеBindingSource, "Дата рождения", true));
            this.дата_рожденияDateTimePicker.Location = new System.Drawing.Point(108, 174);
            this.дата_рожденияDateTimePicker.Name = "дата_рожденияDateTimePicker";
            this.дата_рожденияDateTimePicker.Size = new System.Drawing.Size(186, 20);
            this.дата_рожденияDateTimePicker.TabIndex = 16;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(465, 262);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Отмена";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(357, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(код_задолжникаLabel);
            this.groupBox2.Controls.Add(this.код_задолжникаTextBox);
            this.groupBox2.Location = new System.Drawing.Point(357, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 101);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сведения";
            // 
            // код_задолжникаTextBox
            // 
            this.код_задолжникаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.задолжникиBindingSource, "Код задолжника", true));
            this.код_задолжникаTextBox.Location = new System.Drawing.Point(106, 61);
            this.код_задолжникаTextBox.Name = "код_задолжникаTextBox";
            this.код_задолжникаTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_задолжникаTextBox.TabIndex = 1;
            // 
            // задолжникиBindingSource
            // 
            this.задолжникиBindingSource.DataMember = "Задолжники";
            this.задолжникиBindingSource.DataSource = this.библиотекаDataSet;
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.информация_о_читателеBindingSource, "Телефон", true));
            this.телефонTextBox.Location = new System.Drawing.Point(108, 215);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(186, 20);
            this.телефонTextBox.TabIndex = 11;
            // 
            // адресRichTextBox
            // 
            this.адресRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.информация_о_читателеBindingSource, "Адрес", true));
            this.адресRichTextBox.Location = new System.Drawing.Point(377, 33);
            this.адресRichTextBox.Name = "адресRichTextBox";
            this.адресRichTextBox.Size = new System.Drawing.Size(186, 72);
            this.адресRichTextBox.TabIndex = 9;
            this.адресRichTextBox.Text = "";
            // 
            // отчествоTextBox
            // 
            this.отчествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.информация_о_читателеBindingSource, "Отчество", true));
            this.отчествоTextBox.Location = new System.Drawing.Point(108, 136);
            this.отчествоTextBox.Name = "отчествоTextBox";
            this.отчествоTextBox.Size = new System.Drawing.Size(186, 20);
            this.отчествоTextBox.TabIndex = 7;
            // 
            // имяTextBox
            // 
            this.имяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.информация_о_читателеBindingSource, "Имя", true));
            this.имяTextBox.Location = new System.Drawing.Point(108, 103);
            this.имяTextBox.Name = "имяTextBox";
            this.имяTextBox.Size = new System.Drawing.Size(186, 20);
            this.имяTextBox.TabIndex = 5;
            // 
            // фамилияTextBox
            // 
            this.фамилияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.информация_о_читателеBindingSource, "Фамилия", true));
            this.фамилияTextBox.Location = new System.Drawing.Point(108, 69);
            this.фамилияTextBox.Name = "фамилияTextBox";
            this.фамилияTextBox.Size = new System.Drawing.Size(186, 20);
            this.фамилияTextBox.TabIndex = 3;
            // 
            // номер_билетаTextBox
            // 
            this.номер_билетаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.информация_о_читателеBindingSource, "Номер билета", true));
            this.номер_билетаTextBox.Location = new System.Drawing.Point(108, 30);
            this.номер_билетаTextBox.Name = "номер_билетаTextBox";
            this.номер_билетаTextBox.Size = new System.Drawing.Size(186, 20);
            this.номер_билетаTextBox.TabIndex = 1;
            // 
            // информация_о_читателеTableAdapter
            // 
            this.информация_о_читателеTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Информация_о_книгеTableAdapter = null;
            this.tableAdapterManager.Информация_о_читателеTableAdapter = this.информация_о_читателеTableAdapter;
            this.tableAdapterManager.ПользователиTableAdapter = null;
            this.tableAdapterManager.Разделы_библиотекиTableAdapter = null;
            // 
            // задолжникиTableAdapter
            // 
            this.задолжникиTableAdapter.ClearBeforeFill = true;
            // 
            // выдача_книгBindingSource
            // 
            this.выдача_книгBindingSource.DataMember = "FK_Выдача книг_Информация о читателе";
            this.выдача_книгBindingSource.DataSource = this.информация_о_читателеBindingSource;
            // 
            // выдача_книгTableAdapter
            // 
            this.выдача_книгTableAdapter.ClearBeforeFill = true;
            // 
            // AddReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 315);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddReader";
            this.Text = "Читатель";
            this.Load += new System.EventHandler(this.AddReader_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.лимитNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.информация_о_читателеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.библиотекаDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.задолжникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.выдача_книгBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private БиблиотекаDataSet библиотекаDataSet;
        private System.Windows.Forms.BindingSource информация_о_читателеBindingSource;
        private БиблиотекаDataSetTableAdapters.Информация_о_читателеTableAdapter информация_о_читателеTableAdapter;
        private БиблиотекаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox номер_билетаTextBox;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.RichTextBox адресRichTextBox;
        private System.Windows.Forms.TextBox отчествоTextBox;
        private System.Windows.Forms.TextBox имяTextBox;
        private System.Windows.Forms.TextBox фамилияTextBox;
        private System.Windows.Forms.DateTimePicker дата_рожденияDateTimePicker;
        private System.Windows.Forms.BindingSource задолжникиBindingSource;
        private БиблиотекаDataSetTableAdapters.ЗадолжникиTableAdapter задолжникиTableAdapter;
        private System.Windows.Forms.TextBox код_задолжникаTextBox;
        private System.Windows.Forms.BindingSource выдача_книгBindingSource;
        private БиблиотекаDataSetTableAdapters.Выдача_книгTableAdapter выдача_книгTableAdapter;
        private System.Windows.Forms.NumericUpDown лимитNumericUpDown;
    }
}