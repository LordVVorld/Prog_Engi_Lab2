namespace Software_Evaluation
{
    partial class CalculateOperatingCosts
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
            this.developerSalaryTable = new System.Windows.Forms.DataGridView();
            this.PositionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalaryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DailySalaryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkingDaysColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OZPColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentTable = new System.Windows.Forms.DataGridView();
            this.EquipmentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarryingAmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountEquipmentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AverageDailyLoadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalOperatingColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.costsTable = new System.Windows.Forms.DataGridView();
            this.CostItemsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.developerSalaryTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // developerSalaryTable
            // 
            this.developerSalaryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.developerSalaryTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PositionColumn,
            this.SalaryColumn,
            this.DailySalaryColumn,
            this.WorkingDaysColumn,
            this.OZPColumn});
            this.developerSalaryTable.Location = new System.Drawing.Point(30, 35);
            this.developerSalaryTable.Name = "developerSalaryTable";
            this.developerSalaryTable.RowHeadersWidth = 51;
            this.developerSalaryTable.RowTemplate.Height = 24;
            this.developerSalaryTable.Size = new System.Drawing.Size(894, 150);
            this.developerSalaryTable.TabIndex = 1;
            // 
            // PositionColumn
            // 
            this.PositionColumn.HeaderText = "Должность";
            this.PositionColumn.MinimumWidth = 6;
            this.PositionColumn.Name = "PositionColumn";
            this.PositionColumn.Width = 125;
            // 
            // SalaryColumn
            // 
            this.SalaryColumn.HeaderText = "Должностной оклад";
            this.SalaryColumn.MinimumWidth = 6;
            this.SalaryColumn.Name = "SalaryColumn";
            this.SalaryColumn.Width = 125;
            // 
            // DailySalaryColumn
            // 
            this.DailySalaryColumn.HeaderText = "Дневная ставка";
            this.DailySalaryColumn.MinimumWidth = 6;
            this.DailySalaryColumn.Name = "DailySalaryColumn";
            this.DailySalaryColumn.Width = 125;
            // 
            // WorkingDaysColumn
            // 
            this.WorkingDaysColumn.HeaderText = "Затраты времени на разработку, человеко-дней";
            this.WorkingDaysColumn.MinimumWidth = 6;
            this.WorkingDaysColumn.Name = "WorkingDaysColumn";
            this.WorkingDaysColumn.Width = 125;
            // 
            // OZPColumn
            // 
            this.OZPColumn.HeaderText = "ОЗП, руб";
            this.OZPColumn.MinimumWidth = 6;
            this.OZPColumn.Name = "OZPColumn";
            this.OZPColumn.Width = 125;
            // 
            // equipmentTable
            // 
            this.equipmentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.equipmentTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EquipmentColumn,
            this.CarryingAmountColumn,
            this.AmountEquipmentColumn,
            this.AverageDailyLoadColumn,
            this.TotalOperatingColumn});
            this.equipmentTable.Location = new System.Drawing.Point(30, 222);
            this.equipmentTable.Name = "equipmentTable";
            this.equipmentTable.RowHeadersWidth = 51;
            this.equipmentTable.RowTemplate.Height = 24;
            this.equipmentTable.Size = new System.Drawing.Size(887, 150);
            this.equipmentTable.TabIndex = 2;
            // 
            // EquipmentColumn
            // 
            this.EquipmentColumn.HeaderText = "Обрудование";
            this.EquipmentColumn.MinimumWidth = 6;
            this.EquipmentColumn.Name = "EquipmentColumn";
            this.EquipmentColumn.Width = 125;
            // 
            // CarryingAmountColumn
            // 
            this.CarryingAmountColumn.HeaderText = "Балансовая стоимость";
            this.CarryingAmountColumn.MinimumWidth = 6;
            this.CarryingAmountColumn.Name = "CarryingAmountColumn";
            this.CarryingAmountColumn.Width = 125;
            // 
            // AmountEquipmentColumn
            // 
            this.AmountEquipmentColumn.HeaderText = "Количество оборудования";
            this.AmountEquipmentColumn.MinimumWidth = 6;
            this.AmountEquipmentColumn.Name = "AmountEquipmentColumn";
            this.AmountEquipmentColumn.Width = 125;
            // 
            // AverageDailyLoadColumn
            // 
            this.AverageDailyLoadColumn.HeaderText = "Среднее суточная загрузка";
            this.AverageDailyLoadColumn.MinimumWidth = 6;
            this.AverageDailyLoadColumn.Name = "AverageDailyLoadColumn";
            this.AverageDailyLoadColumn.Width = 125;
            // 
            // TotalOperatingColumn
            // 
            this.TotalOperatingColumn.HeaderText = "Общее время работы";
            this.TotalOperatingColumn.MinimumWidth = 6;
            this.TotalOperatingColumn.Name = "TotalOperatingColumn";
            this.TotalOperatingColumn.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1119, 614);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Далее";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(966, 614);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 35);
            this.button2.TabIndex = 4;
            this.button2.Text = "Рассчитать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // costsTable
            // 
            this.costsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.costsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CostItemsColumn,
            this.Costs});
            this.costsTable.Location = new System.Drawing.Point(30, 424);
            this.costsTable.Name = "costsTable";
            this.costsTable.RowHeadersWidth = 51;
            this.costsTable.RowTemplate.Height = 24;
            this.costsTable.Size = new System.Drawing.Size(383, 150);
            this.costsTable.TabIndex = 5;
            // 
            // CostItemsColumn
            // 
            this.CostItemsColumn.HeaderText = "Статьи затрат";
            this.CostItemsColumn.MinimumWidth = 6;
            this.CostItemsColumn.Name = "CostItemsColumn";
            this.CostItemsColumn.Width = 125;
            // 
            // Costs
            // 
            this.Costs.HeaderText = "Затраты";
            this.Costs.MinimumWidth = 6;
            this.Costs.Name = "Costs";
            this.Costs.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Основная заработная плата разработчиков";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // CalculateOperatingCosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 679);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.costsTable);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.equipmentTable);
            this.Controls.Add(this.developerSalaryTable);
            this.Name = "CalculateOperatingCosts";
            this.Text = "CalculateOperatingCosts";
            ((System.ComponentModel.ISupportInitialize)(this.developerSalaryTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView developerSalaryTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn PositionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalaryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DailySalaryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkingDaysColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OZPColumn;
        private System.Windows.Forms.DataGridView equipmentTable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView costsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostItemsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costs;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipmentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarryingAmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountEquipmentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AverageDailyLoadColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalOperatingColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}