namespace Lab2_BD
{
    partial class Form1
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
            this.bindingSource_Smartphones = new System.Windows.Forms.BindingSource(this.components);
            this.sMARTPHONESDataSet = new Lab2_BD.SMARTPHONESDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bestBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.benchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.benchTableAdapter = new Lab2_BD.SMARTPHONESDataSetTableAdapters.BenchTableAdapter();
            this.bestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bestTableAdapter = new Lab2_BD.SMARTPHONESDataSetTableAdapters.BestTableAdapter();
            this.likesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.likesTableAdapter = new Lab2_BD.SMARTPHONESDataSetTableAdapters.LikesTableAdapter();
            this.benchBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.geekBenchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.antutuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.benchBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.yandexmarketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fpdaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.likesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_Smartphones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMARTPHONESDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bestBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.likesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benchBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benchBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.likesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource_Smartphones
            // 
            this.bindingSource_Smartphones.DataSource = this.sMARTPHONESDataSet;
            this.bindingSource_Smartphones.Position = 0;
            // 
            // sMARTPHONESDataSet
            // 
            this.sMARTPHONESDataSet.DataSetName = "SMARTPHONESDataSet";
            this.sMARTPHONESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.brand,
            this.model,
            this.cpu,
            this.ram,
            this.rom});
            this.dataGridView1.DataSource = this.bestBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(1, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(653, 436);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.FillWeight = 60F;
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brand
            // 
            this.brand.DataPropertyName = "brand";
            this.brand.HeaderText = "brand";
            this.brand.Name = "brand";
            // 
            // model
            // 
            this.model.DataPropertyName = "model";
            this.model.HeaderText = "model";
            this.model.Name = "model";
            // 
            // cpu
            // 
            this.cpu.DataPropertyName = "cpu";
            this.cpu.HeaderText = "cpu";
            this.cpu.Name = "cpu";
            // 
            // ram
            // 
            this.ram.DataPropertyName = "ram";
            this.ram.HeaderText = "ram";
            this.ram.Name = "ram";
            // 
            // rom
            // 
            this.rom.DataPropertyName = "rom";
            this.rom.HeaderText = "rom";
            this.rom.Name = "rom";
            // 
            // bestBindingSource1
            // 
            this.bestBindingSource1.DataMember = "Best";
            this.bestBindingSource1.DataSource = this.bindingSource_Smartphones;
            // 
            // benchBindingSource
            // 
            this.benchBindingSource.DataMember = "Bench";
            this.benchBindingSource.DataSource = this.bindingSource_Smartphones;
            // 
            // benchTableAdapter
            // 
            this.benchTableAdapter.ClearBeforeFill = true;
            // 
            // bestBindingSource
            // 
            this.bestBindingSource.DataMember = "Best";
            this.bestBindingSource.DataSource = this.bindingSource_Smartphones;
            // 
            // bestTableAdapter
            // 
            this.bestTableAdapter.ClearBeforeFill = true;
            // 
            // likesBindingSource
            // 
            this.likesBindingSource.DataMember = "Likes";
            this.likesBindingSource.DataSource = this.bindingSource_Smartphones;
            // 
            // likesTableAdapter
            // 
            this.likesTableAdapter.ClearBeforeFill = true;
            // 
            // benchBindingSource1
            // 
            this.benchBindingSource1.DataMember = "Bench";
            this.benchBindingSource1.DataSource = this.bindingSource_Smartphones;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.geekBenchDataGridViewTextBoxColumn,
            this.antutuDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.benchBindingSource2;
            this.dataGridView2.Location = new System.Drawing.Point(660, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(339, 436);
            this.dataGridView2.TabIndex = 1;
            // 
            // geekBenchDataGridViewTextBoxColumn
            // 
            this.geekBenchDataGridViewTextBoxColumn.DataPropertyName = "geekBench";
            this.geekBenchDataGridViewTextBoxColumn.HeaderText = "geekBench";
            this.geekBenchDataGridViewTextBoxColumn.Name = "geekBenchDataGridViewTextBoxColumn";
            // 
            // antutuDataGridViewTextBoxColumn
            // 
            this.antutuDataGridViewTextBoxColumn.DataPropertyName = "antutu";
            this.antutuDataGridViewTextBoxColumn.HeaderText = "antutu";
            this.antutuDataGridViewTextBoxColumn.Name = "antutuDataGridViewTextBoxColumn";
            // 
            // benchBindingSource2
            // 
            this.benchBindingSource2.DataMember = "Bench";
            this.benchBindingSource2.DataSource = this.bindingSource_Smartphones;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yandexmarketDataGridViewTextBoxColumn,
            this.fpdaDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.likesBindingSource1;
            this.dataGridView3.Location = new System.Drawing.Point(1005, 2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(339, 436);
            this.dataGridView3.TabIndex = 2;
            // 
            // yandexmarketDataGridViewTextBoxColumn
            // 
            this.yandexmarketDataGridViewTextBoxColumn.DataPropertyName = "yandex_market";
            this.yandexmarketDataGridViewTextBoxColumn.HeaderText = "yandex_market";
            this.yandexmarketDataGridViewTextBoxColumn.Name = "yandexmarketDataGridViewTextBoxColumn";
            // 
            // fpdaDataGridViewTextBoxColumn
            // 
            this.fpdaDataGridViewTextBoxColumn.DataPropertyName = "Fpda";
            this.fpdaDataGridViewTextBoxColumn.HeaderText = "Fpda";
            this.fpdaDataGridViewTextBoxColumn.Name = "fpdaDataGridViewTextBoxColumn";
            // 
            // likesBindingSource1
            // 
            this.likesBindingSource1.DataMember = "Likes";
            this.likesBindingSource1.DataSource = this.bindingSource_Smartphones;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1369, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Внести изменения";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.FontChanged += new System.EventHandler(this.button1_FontChanged);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1369, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Лучшая тройка";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1369, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Лучшая пятёрка";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1369, 89);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(171, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Все смартфоны";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1369, 118);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(171, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Самый быстрый";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button5_MouseClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1461, 169);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(79, 20);
            this.textBox1.TabIndex = 8;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1369, 160);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 36);
            this.button6.TabIndex = 9;
            this.button6.Text = "Только номер";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1623, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_Smartphones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMARTPHONESDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bestBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.benchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.likesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.benchBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.benchBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.likesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource_Smartphones;
        private SMARTPHONESDataSet sMARTPHONESDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource benchBindingSource;
        private SMARTPHONESDataSetTableAdapters.BenchTableAdapter benchTableAdapter;
        private System.Windows.Forms.BindingSource bestBindingSource;
        private SMARTPHONESDataSetTableAdapters.BestTableAdapter bestTableAdapter;
        private System.Windows.Forms.BindingSource likesBindingSource;
        private SMARTPHONESDataSetTableAdapters.LikesTableAdapter likesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ram;
        private System.Windows.Forms.DataGridViewTextBoxColumn rom;
        private System.Windows.Forms.BindingSource bestBindingSource1;
        private System.Windows.Forms.BindingSource benchBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource benchBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource likesBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn geekBenchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn antutuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yandexmarketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fpdaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button6;
    }
}

