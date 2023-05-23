namespace Software_Evaluation
{
    partial class EconomicEffect
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CharacteristicsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnalogProductColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DevelopingProductColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CharacteristicsColumn,
            this.AnalogProductColumn,
            this.DevelopingProductColumn});
            this.dataGridView1.Location = new System.Drawing.Point(12, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(830, 236);
            this.dataGridView1.TabIndex = 0;
            // 
            // CharacteristicsColumn
            // 
            this.CharacteristicsColumn.HeaderText = "Характеристика";
            this.CharacteristicsColumn.MinimumWidth = 6;
            this.CharacteristicsColumn.Name = "CharacteristicsColumn";
            this.CharacteristicsColumn.Width = 200;
            // 
            // AnalogProductColumn
            // 
            this.AnalogProductColumn.HeaderText = "Продукт-аналог";
            this.AnalogProductColumn.MinimumWidth = 6;
            this.AnalogProductColumn.Name = "AnalogProductColumn";
            this.AnalogProductColumn.Width = 200;
            // 
            // DevelopingProductColumn
            // 
            this.DevelopingProductColumn.HeaderText = "Разрабатываемый-продукт";
            this.DevelopingProductColumn.MinimumWidth = 6;
            this.DevelopingProductColumn.Name = "DevelopingProductColumn";
            this.DevelopingProductColumn.Width = 200;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(561, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(711, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "Далее";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EconomicEffect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 401);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EconomicEffect";
            this.Text = "Экономическое обоснование продукта";
            this.Load += new System.EventHandler(this.EconomicEffect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CharacteristicsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnalogProductColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DevelopingProductColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}