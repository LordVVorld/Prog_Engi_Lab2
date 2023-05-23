

using System.Windows.Forms;

namespace Software_Evaluation
{
    partial class СalculationProjectCosts
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
            this.materialTable = new System.Windows.Forms.DataGridView();
            this.MaterialsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitMeasurementColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricePerUnitColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumMaterialsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.developmentCostsTable = new System.Windows.Forms.DataGridView();
            this.CostItemsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.additionalSalaryCoeff = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.overheadСoeff = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.socialСoeff = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.developerSalaryTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.developmentCostsTable)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.developerSalaryTable.Location = new System.Drawing.Point(57, 46);
            this.developerSalaryTable.Name = "developerSalaryTable";
            this.developerSalaryTable.RowHeadersWidth = 51;
            this.developerSalaryTable.RowTemplate.Height = 24;
            this.developerSalaryTable.Size = new System.Drawing.Size(894, 150);
            this.developerSalaryTable.TabIndex = 0;
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
            // materialTable
            // 
            this.materialTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaterialsColumn,
            this.UnitMeasurementColumn,
            this.AmountColumn,
            this.PricePerUnitColumn,
            this.SumMaterialsColumn});
            this.materialTable.Location = new System.Drawing.Point(57, 250);
            this.materialTable.Name = "materialTable";
            this.materialTable.RowHeadersWidth = 51;
            this.materialTable.RowTemplate.Height = 24;
            this.materialTable.Size = new System.Drawing.Size(894, 150);
            this.materialTable.TabIndex = 1;
            // 
            // MaterialsColumn
            // 
            this.MaterialsColumn.HeaderText = "Материалы";
            this.MaterialsColumn.MinimumWidth = 6;
            this.MaterialsColumn.Name = "MaterialsColumn";
            this.MaterialsColumn.Width = 125;
            // 
            // UnitMeasurementColumn
            // 
            this.UnitMeasurementColumn.HeaderText = "Единица измерения";
            this.UnitMeasurementColumn.MinimumWidth = 6;
            this.UnitMeasurementColumn.Name = "UnitMeasurementColumn";
            this.UnitMeasurementColumn.Width = 125;
            // 
            // AmountColumn
            // 
            this.AmountColumn.HeaderText = "Количество";
            this.AmountColumn.MinimumWidth = 6;
            this.AmountColumn.Name = "AmountColumn";
            this.AmountColumn.Width = 125;
            // 
            // PricePerUnitColumn
            // 
            this.PricePerUnitColumn.HeaderText = "Цена за единицу, руб";
            this.PricePerUnitColumn.MinimumWidth = 6;
            this.PricePerUnitColumn.Name = "PricePerUnitColumn";
            this.PricePerUnitColumn.Width = 125;
            // 
            // SumMaterialsColumn
            // 
            this.SumMaterialsColumn.HeaderText = "Сумма, руб";
            this.SumMaterialsColumn.MinimumWidth = 6;
            this.SumMaterialsColumn.Name = "SumMaterialsColumn";
            this.SumMaterialsColumn.Width = 125;
            // 
            // developmentCostsTable
            // 
            this.developmentCostsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.developmentCostsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CostItemsColumn,
            this.SumItems});
            this.developmentCostsTable.Location = new System.Drawing.Point(57, 451);
            this.developmentCostsTable.Name = "developmentCostsTable";
            this.developmentCostsTable.RowHeadersWidth = 51;
            this.developmentCostsTable.RowTemplate.Height = 24;
            this.developmentCostsTable.Size = new System.Drawing.Size(400, 150);
            this.developmentCostsTable.TabIndex = 2;
            // 
            // CostItemsColumn
            // 
            this.CostItemsColumn.HeaderText = "Статьи затрат";
            this.CostItemsColumn.MinimumWidth = 6;
            this.CostItemsColumn.Name = "CostItemsColumn";
            this.CostItemsColumn.Width = 125;
            // 
            // SumItems
            // 
            this.SumItems.HeaderText = "Сумма";
            this.SumItems.MinimumWidth = 6;
            this.SumItems.Name = "SumItems";
            this.SumItems.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1081, 606);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Далее";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1038, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 59);
            this.button2.TabIndex = 4;
            this.button2.Text = "Рассчитать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(62, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Основная заработная плата разработчиков";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(62, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Затраты на материалы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(62, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Затраты на разработку";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.additionalSalaryCoeff);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.overheadСoeff);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.socialСoeff);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(972, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 209);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Коэффициенты";
            // 
            // additionalSalaryCoeff
            // 
            this.additionalSalaryCoeff.Location = new System.Drawing.Point(10, 156);
            this.additionalSalaryCoeff.Name = "additionalSalaryCoeff";
            this.additionalSalaryCoeff.Size = new System.Drawing.Size(134, 22);
            this.additionalSalaryCoeff.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Коэффициент дополнительной зп:";
            // 
            // overheadСoeff
            // 
            this.overheadСoeff.Location = new System.Drawing.Point(10, 103);
            this.overheadСoeff.Name = "overheadСoeff";
            this.overheadСoeff.Size = new System.Drawing.Size(134, 22);
            this.overheadСoeff.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Коэффициент накладных расходов:";
            // 
            // socialСoeff
            // 
            this.socialСoeff.Location = new System.Drawing.Point(10, 46);
            this.socialСoeff.Name = "socialСoeff";
            this.socialСoeff.Size = new System.Drawing.Size(134, 22);
            this.socialСoeff.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Коэффициент социальных нужд:";
            // 
            // СalculationProjectCosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 660);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.developmentCostsTable);
            this.Controls.Add(this.materialTable);
            this.Controls.Add(this.developerSalaryTable);
            this.Name = "СalculationProjectCosts";
            this.Text = "Расчет затрат на разработку проекта";
            ((System.ComponentModel.ISupportInitialize)(this.developerSalaryTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.developmentCostsTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.DataGridView materialTable;
        private System.Windows.Forms.DataGridView developmentCostsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostItemsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitMeasurementColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PricePerUnitColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumMaterialsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumItems;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox overheadСoeff;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox socialСoeff;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox additionalSalaryCoeff;
        private System.Windows.Forms.Label label6;
    }
}