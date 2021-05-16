
namespace App1._2
{
    partial class Form1
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
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textKodChange = new System.Windows.Forms.TextBox();
            this.textKodDelete = new System.Windows.Forms.TextBox();
            this.textPositionChange = new System.Windows.Forms.TextBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firmBDDataSet = new App1._2.FirmBDDataSet();
            this.sTOREBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myBDDataSet = new App1._2.MyBDDataSet();
            this.sTORETableAdapter = new App1._2.MyBDDataSetTableAdapters.STORETableAdapter();
            this.tableAdapterManager = new App1._2.MyBDDataSetTableAdapters.TableAdapterManager();
            this.заказыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказыTableAdapter = new App1._2.FirmBDDataSetTableAdapters.ЗаказыTableAdapter();
            this.сотрудникиTableAdapter = new App1._2.FirmBDDataSetTableAdapters.СотрудникиTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textPositionAdd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textNameAdd = new System.Windows.Forms.TextBox();
            this.textSurnameAdd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textKodAdd = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.myBDDataSet1 = new App1._2.MyBDDataSet1();
            this.заказыBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.заказыTableAdapter1 = new App1._2.MyBDDataSet1TableAdapters.ЗаказыTableAdapter();
            this.myBDDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клиентыTableAdapter = new App1._2.MyBDDataSet1TableAdapters.КлиентыTableAdapter();
            this.сотрудникиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникиTableAdapter1 = new App1._2.MyBDDataSet1TableAdapters.СотрудникиTableAdapter();
            this.кодСотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOREBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myBDDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myBDDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(28, 350);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(140, 40);
            this.buttonDelete.TabIndex = 15;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(15, 144);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(312, 53);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(184, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Код сотрудника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(184, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Должность";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(184, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Код сотрудника";
            // 
            // textKodChange
            // 
            this.textKodChange.Location = new System.Drawing.Point(187, 234);
            this.textKodChange.Name = "textKodChange";
            this.textKodChange.Size = new System.Drawing.Size(140, 20);
            this.textKodChange.TabIndex = 19;
            // 
            // textKodDelete
            // 
            this.textKodDelete.Location = new System.Drawing.Point(187, 370);
            this.textKodDelete.Name = "textKodDelete";
            this.textKodDelete.Size = new System.Drawing.Size(140, 20);
            this.textKodDelete.TabIndex = 16;
            // 
            // textPositionChange
            // 
            this.textPositionChange.Location = new System.Drawing.Point(187, 296);
            this.textPositionChange.Name = "textPositionChange";
            this.textPositionChange.Size = new System.Drawing.Size(140, 20);
            this.textPositionChange.TabIndex = 18;
            // 
            // buttonChange
            // 
            this.buttonChange.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChange.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChange.ForeColor = System.Drawing.Color.White;
            this.buttonChange.Location = new System.Drawing.Point(28, 255);
            this.buttonChange.Margin = new System.Windows.Forms.Padding(4);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(140, 40);
            this.buttonChange.TabIndex = 17;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.firmBDDataSet;
            // 
            // firmBDDataSet
            // 
            this.firmBDDataSet.DataSetName = "FirmBDDataSet";
            this.firmBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTOREBindingSource
            // 
            this.sTOREBindingSource.DataMember = "STORE";
            this.sTOREBindingSource.DataSource = this.myBDDataSet;
            // 
            // myBDDataSet
            // 
            this.myBDDataSet.DataSetName = "MyBDDataSet";
            this.myBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTORETableAdapter
            // 
            this.sTORETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.STORETableAdapter = this.sTORETableAdapter;
            this.tableAdapterManager.UpdateOrder = App1._2.MyBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // заказыBindingSource
            // 
            this.заказыBindingSource.DataMember = "Заказы";
            this.заказыBindingSource.DataSource = this.firmBDDataSet;
            // 
            // заказыTableAdapter
            // 
            this.заказыTableAdapter.ClearBeforeFill = true;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textKodDelete);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textPositionAdd);
            this.panel1.Controls.Add(this.textKodChange);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textPositionChange);
            this.panel1.Controls.Add(this.buttonChange);
            this.panel1.Controls.Add(this.textNameAdd);
            this.panel1.Controls.Add(this.textSurnameAdd);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textKodAdd);
            this.panel1.Location = new System.Drawing.Point(561, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 532);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(184, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Должность";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Gray;
            this.buttonUpdate.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonUpdate.FlatAppearance.BorderSize = 3;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(14, 407);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(312, 111);
            this.buttonUpdate.TabIndex = 16;
            this.buttonUpdate.Text = "Обновить базу данных";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textPositionAdd
            // 
            this.textPositionAdd.Location = new System.Drawing.Point(187, 104);
            this.textPositionAdd.Name = "textPositionAdd";
            this.textPositionAdd.Size = new System.Drawing.Size(140, 20);
            this.textPositionAdd.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "Фамилия";
            // 
            // textNameAdd
            // 
            this.textNameAdd.Location = new System.Drawing.Point(187, 25);
            this.textNameAdd.Name = "textNameAdd";
            this.textNameAdd.Size = new System.Drawing.Size(140, 20);
            this.textNameAdd.TabIndex = 34;
            // 
            // textSurnameAdd
            // 
            this.textSurnameAdd.Location = new System.Drawing.Point(14, 104);
            this.textSurnameAdd.Name = "textSurnameAdd";
            this.textSurnameAdd.Size = new System.Drawing.Size(140, 20);
            this.textSurnameAdd.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "Код сотрудника";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(184, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Имя";
            // 
            // textKodAdd
            // 
            this.textKodAdd.Location = new System.Drawing.Point(14, 25);
            this.textKodAdd.Name = "textKodAdd";
            this.textKodAdd.Size = new System.Drawing.Size(140, 20);
            this.textKodAdd.TabIndex = 32;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодСотрудникаDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.должностьDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.сотрудникиBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(6, 63);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(548, 532);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // myBDDataSet1
            // 
            this.myBDDataSet1.DataSetName = "MyBDDataSet1";
            this.myBDDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заказыBindingSource1
            // 
            this.заказыBindingSource1.DataMember = "Заказы";
            this.заказыBindingSource1.DataSource = this.myBDDataSet1;
            // 
            // заказыTableAdapter1
            // 
            this.заказыTableAdapter1.ClearBeforeFill = true;
            // 
            // myBDDataSet1BindingSource
            // 
            this.myBDDataSet1BindingSource.DataSource = this.myBDDataSet1;
            this.myBDDataSet1BindingSource.Position = 0;
            // 
            // клиентыBindingSource
            // 
            this.клиентыBindingSource.DataMember = "Клиенты";
            this.клиентыBindingSource.DataSource = this.myBDDataSet1BindingSource;
            // 
            // клиентыTableAdapter
            // 
            this.клиентыTableAdapter.ClearBeforeFill = true;
            // 
            // сотрудникиBindingSource1
            // 
            this.сотрудникиBindingSource1.DataMember = "Сотрудники";
            this.сотрудникиBindingSource1.DataSource = this.myBDDataSet1BindingSource;
            // 
            // сотрудникиTableAdapter1
            // 
            this.сотрудникиTableAdapter1.ClearBeforeFill = true;
            // 
            // кодСотрудникаDataGridViewTextBoxColumn
            // 
            this.кодСотрудникаDataGridViewTextBoxColumn.DataPropertyName = "Код сотрудника";
            this.кодСотрудникаDataGridViewTextBoxColumn.HeaderText = "Код сотрудника";
            this.кодСотрудникаDataGridViewTextBoxColumn.Name = "кодСотрудникаDataGridViewTextBoxColumn";
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            // 
            // должностьDataGridViewTextBoxColumn
            // 
            this.должностьDataGridViewTextBoxColumn.DataPropertyName = "Должность";
            this.должностьDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.должностьDataGridViewTextBoxColumn.Name = "должностьDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 603);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Database Editor";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOREBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myBDDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myBDDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private MyBDDataSet myBDDataSet;
        private System.Windows.Forms.BindingSource sTOREBindingSource;
        private MyBDDataSetTableAdapters.STORETableAdapter sTORETableAdapter;
        private MyBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private FirmBDDataSet firmBDDataSet;
        private System.Windows.Forms.BindingSource заказыBindingSource;
        private FirmBDDataSetTableAdapters.ЗаказыTableAdapter заказыTableAdapter;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private FirmBDDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textKodChange;
        private System.Windows.Forms.TextBox textKodDelete;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textPositionChange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textPositionAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textNameAdd;
        private System.Windows.Forms.TextBox textSurnameAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textKodAdd;
        private MyBDDataSet1 myBDDataSet1;
        private System.Windows.Forms.BindingSource заказыBindingSource1;
        private MyBDDataSet1TableAdapters.ЗаказыTableAdapter заказыTableAdapter1;
        private System.Windows.Forms.BindingSource myBDDataSet1BindingSource;
        private System.Windows.Forms.BindingSource клиентыBindingSource;
        private MyBDDataSet1TableAdapters.КлиентыTableAdapter клиентыTableAdapter;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource1;
        private MyBDDataSet1TableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСотрудникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
    }
}

