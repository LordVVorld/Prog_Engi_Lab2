namespace Software_Evaluation
{
    partial class Timetable
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
            this.calendarSchedule = new System.Windows.Forms.DataGridView();
            this.ContentWorkColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExecutorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DurationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartWorkColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinishWorkColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.complexWorks = new System.Windows.Forms.DataGridView();
            this.ContentWorkPlaneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExecutorPlaneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DuringPlaneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkingLoadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.calendarSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.complexWorks)).BeginInit();
            this.SuspendLayout();
            // 
            // calendarSchedule
            // 
            this.calendarSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calendarSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ContentWorkColumn,
            this.ExecutorColumn,
            this.DurationColumn,
            this.StartWorkColumn,
            this.FinishWorkColumn});
            this.calendarSchedule.Location = new System.Drawing.Point(12, 250);
            this.calendarSchedule.Name = "calendarSchedule";
            this.calendarSchedule.RowHeadersWidth = 51;
            this.calendarSchedule.RowTemplate.Height = 24;
            this.calendarSchedule.Size = new System.Drawing.Size(905, 412);
            this.calendarSchedule.TabIndex = 0;
            // 
            // ContentWorkColumn
            // 
            this.ContentWorkColumn.HeaderText = "Содержание работы";
            this.ContentWorkColumn.MinimumWidth = 6;
            this.ContentWorkColumn.Name = "ContentWorkColumn";
            this.ContentWorkColumn.Width = 125;
            // 
            // ExecutorColumn
            // 
            this.ExecutorColumn.HeaderText = "Исполнитель";
            this.ExecutorColumn.MinimumWidth = 6;
            this.ExecutorColumn.Name = "ExecutorColumn";
            this.ExecutorColumn.Width = 125;
            // 
            // DurationColumn
            // 
            this.DurationColumn.HeaderText = "Длительность";
            this.DurationColumn.MinimumWidth = 6;
            this.DurationColumn.Name = "DurationColumn";
            this.DurationColumn.Width = 125;
            // 
            // StartWorkColumn
            // 
            this.StartWorkColumn.HeaderText = "Начало работ";
            this.StartWorkColumn.MinimumWidth = 6;
            this.StartWorkColumn.Name = "StartWorkColumn";
            this.StartWorkColumn.Width = 125;
            // 
            // FinishWorkColumn
            // 
            this.FinishWorkColumn.HeaderText = "Конец работ";
            this.FinishWorkColumn.MinimumWidth = 6;
            this.FinishWorkColumn.Name = "FinishWorkColumn";
            this.FinishWorkColumn.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(986, 602);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "Далее";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(986, 539);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 57);
            this.button2.TabIndex = 2;
            this.button2.Text = "Рассчитать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // complexWorks
            // 
            this.complexWorks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.complexWorks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ContentWorkPlaneColumn,
            this.ExecutorPlaneColumn,
            this.DuringPlaneColumn,
            this.DayColumn,
            this.WorkingLoadColumn});
            this.complexWorks.Location = new System.Drawing.Point(12, 39);
            this.complexWorks.Name = "complexWorks";
            this.complexWorks.RowHeadersWidth = 51;
            this.complexWorks.RowTemplate.Height = 24;
            this.complexWorks.Size = new System.Drawing.Size(899, 160);
            this.complexWorks.TabIndex = 3;
            // 
            // ContentWorkPlaneColumn
            // 
            this.ContentWorkPlaneColumn.HeaderText = "Содержание работ";
            this.ContentWorkPlaneColumn.MinimumWidth = 6;
            this.ContentWorkPlaneColumn.Name = "ContentWorkPlaneColumn";
            this.ContentWorkPlaneColumn.Width = 125;
            // 
            // ExecutorPlaneColumn
            // 
            this.ExecutorPlaneColumn.HeaderText = "Исполнитель";
            this.ExecutorPlaneColumn.MinimumWidth = 6;
            this.ExecutorPlaneColumn.Name = "ExecutorPlaneColumn";
            this.ExecutorPlaneColumn.Width = 125;
            // 
            // DuringPlaneColumn
            // 
            this.DuringPlaneColumn.HeaderText = "Длительность";
            this.DuringPlaneColumn.MinimumWidth = 6;
            this.DuringPlaneColumn.Name = "DuringPlaneColumn";
            this.DuringPlaneColumn.Width = 125;
            // 
            // DayColumn
            // 
            this.DayColumn.HeaderText = "Загрузка (Дни)";
            this.DayColumn.MinimumWidth = 6;
            this.DayColumn.Name = "DayColumn";
            this.DayColumn.Width = 125;
            // 
            // WorkingLoadColumn
            // 
            this.WorkingLoadColumn.HeaderText = "Загрузка (%)";
            this.WorkingLoadColumn.MinimumWidth = 6;
            this.WorkingLoadColumn.Name = "WorkingLoadColumn";
            this.WorkingLoadColumn.Width = 125;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(949, 39);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(924, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выберите дату начала проекта:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(347, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Комплекс работ по разработке проекта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(354, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Календарный график выполнения работ";
            // 
            // Timetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 674);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.complexWorks);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.calendarSchedule);
            this.Name = "Timetable";
            this.Text = "Календарный график";
            ((System.ComponentModel.ISupportInitialize)(this.calendarSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.complexWorks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView calendarSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContentWorkColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExecutorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DurationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartWorkColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinishWorkColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView complexWorks;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContentWorkPlaneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExecutorPlaneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DuringPlaneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkingLoadColumn;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}