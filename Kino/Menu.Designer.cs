
namespace Kino
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.new_schemaDataSet1 = new Kino.new_schemaDataSet1();
            this.testBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testTableAdapter = new Kino.new_schemaDataSet1TableAdapters.testTableAdapter();
            this.idtestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.new_schemaDataSet2 = new Kino.new_schemaDataSet2();
            this.test2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.test2TableAdapter = new Kino.new_schemaDataSet2TableAdapters.test2TableAdapter();
            this.idtest2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button7 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.new_schemaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.new_schemaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtestDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.testBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(90, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(502, 133);
            this.dataGridView1.TabIndex = 0;
            // 
            // new_schemaDataSet1
            // 
            this.new_schemaDataSet1.DataSetName = "new_schemaDataSet1";
            this.new_schemaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testBindingSource
            // 
            this.testBindingSource.DataMember = "test";
            this.testBindingSource.DataSource = this.new_schemaDataSet1;
            // 
            // testTableAdapter
            // 
            this.testTableAdapter.ClearBeforeFill = true;
            // 
            // idtestDataGridViewTextBoxColumn
            // 
            this.idtestDataGridViewTextBoxColumn.DataPropertyName = "idtest";
            this.idtestDataGridViewTextBoxColumn.HeaderText = "idtest";
            this.idtestDataGridViewTextBoxColumn.Name = "idtestDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(612, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавление";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(612, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(612, 121);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 34);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(612, 305);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(66, 34);
            this.button4.TabIndex = 7;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(612, 255);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(66, 34);
            this.button5.TabIndex = 6;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(612, 206);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(66, 34);
            this.button6.TabIndex = 5;
            this.button6.Text = "Добавление";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtest2DataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.test2BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(90, 206);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(502, 133);
            this.dataGridView2.TabIndex = 4;
            // 
            // new_schemaDataSet2
            // 
            this.new_schemaDataSet2.DataSetName = "new_schemaDataSet2";
            this.new_schemaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // test2BindingSource
            // 
            this.test2BindingSource.DataMember = "test2";
            this.test2BindingSource.DataSource = this.new_schemaDataSet2;
            // 
            // test2TableAdapter
            // 
            this.test2TableAdapter.ClearBeforeFill = true;
            // 
            // idtest2DataGridViewTextBoxColumn
            // 
            this.idtest2DataGridViewTextBoxColumn.DataPropertyName = "idtest2";
            this.idtest2DataGridViewTextBoxColumn.HeaderText = "idtest2";
            this.idtest2DataGridViewTextBoxColumn.Name = "idtest2DataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(207, 244);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(173, 47);
            this.button7.TabIndex = 0;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.new_schemaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.new_schemaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private new_schemaDataSet1 new_schemaDataSet1;
        private System.Windows.Forms.BindingSource testBindingSource;
        private new_schemaDataSet1TableAdapters.testTableAdapter testTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private new_schemaDataSet2 new_schemaDataSet2;
        private System.Windows.Forms.BindingSource test2BindingSource;
        private new_schemaDataSet2TableAdapters.test2TableAdapter test2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtest2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button7;
    }
}

