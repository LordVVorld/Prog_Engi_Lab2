namespace Software_Evaluation
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
            this.tableKTY = new System.Windows.Forms.DataGridView();
            this.nextFormBtn = new System.Windows.Forms.Button();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.answerForAnalog = new System.Windows.Forms.Label();
            this.answerForProject = new System.Windows.Forms.Label();
            this.ktyAnswer = new System.Windows.Forms.Label();
            this.generateDataBtn = new System.Windows.Forms.Button();
            this.QualityCriteriaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeightingСoefficientColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpertEvalutionProjectColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectWeightFactorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpertEvaluationAnalogueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnalogueWeightCoefficientColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conclusion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableKTY)).BeginInit();
            this.SuspendLayout();
            // 
            // tableKTY
            // 
            this.tableKTY.AllowUserToAddRows = false;
            this.tableKTY.AllowUserToDeleteRows = false;
            this.tableKTY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableKTY.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QualityCriteriaColumn,
            this.WeightingСoefficientColumn,
            this.ExpertEvalutionProjectColumn,
            this.ProjectWeightFactorColumn,
            this.ExpertEvaluationAnalogueColumn,
            this.AnalogueWeightCoefficientColumn});
            this.tableKTY.Location = new System.Drawing.Point(12, 12);
            this.tableKTY.Name = "tableKTY";
            this.tableKTY.RowHeadersWidth = 51;
            this.tableKTY.RowTemplate.Height = 24;
            this.tableKTY.Size = new System.Drawing.Size(1115, 332);
            this.tableKTY.TabIndex = 0;
            // 
            // nextFormBtn
            // 
            this.nextFormBtn.Location = new System.Drawing.Point(993, 520);
            this.nextFormBtn.Name = "nextFormBtn";
            this.nextFormBtn.Size = new System.Drawing.Size(134, 39);
            this.nextFormBtn.TabIndex = 1;
            this.nextFormBtn.Text = "Далее";
            this.nextFormBtn.UseVisualStyleBackColor = true;
            this.nextFormBtn.Click += new System.EventHandler(this.nextFormBtn_Click);
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(812, 520);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(166, 39);
            this.calculateBtn.TabIndex = 2;
            this.calculateBtn.Text = "Рассчитать";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // answerForAnalog
            // 
            this.answerForAnalog.AutoSize = true;
            this.answerForAnalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answerForAnalog.Location = new System.Drawing.Point(12, 412);
            this.answerForAnalog.Name = "answerForAnalog";
            this.answerForAnalog.Size = new System.Drawing.Size(0, 22);
            this.answerForAnalog.TabIndex = 4;
            // 
            // answerForProject
            // 
            this.answerForProject.AutoSize = true;
            this.answerForProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answerForProject.Location = new System.Drawing.Point(12, 358);
            this.answerForProject.Name = "answerForProject";
            this.answerForProject.Size = new System.Drawing.Size(0, 22);
            this.answerForProject.TabIndex = 5;
            // 
            // ktyAnswer
            // 
            this.ktyAnswer.AutoSize = true;
            this.ktyAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ktyAnswer.Location = new System.Drawing.Point(12, 466);
            this.ktyAnswer.Name = "ktyAnswer";
            this.ktyAnswer.Size = new System.Drawing.Size(0, 22);
            this.ktyAnswer.TabIndex = 6;
            // 
            // generateDataBtn
            // 
            this.generateDataBtn.Location = new System.Drawing.Point(597, 520);
            this.generateDataBtn.Name = "generateDataBtn";
            this.generateDataBtn.Size = new System.Drawing.Size(209, 39);
            this.generateDataBtn.TabIndex = 7;
            this.generateDataBtn.Text = "Сгенерировать данные";
            this.generateDataBtn.UseVisualStyleBackColor = true;
            this.generateDataBtn.Click += new System.EventHandler(this.generateDataBtn_Click);
            // 
            // QualityCriteriaColumn
            // 
            this.QualityCriteriaColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.QualityCriteriaColumn.HeaderText = "Критерии качества";
            this.QualityCriteriaColumn.MinimumWidth = 6;
            this.QualityCriteriaColumn.Name = "QualityCriteriaColumn";
            this.QualityCriteriaColumn.Width = 280;
            // 
            // WeightingСoefficientColumn
            // 
            this.WeightingСoefficientColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.WeightingСoefficientColumn.HeaderText = "Коэффицент весомости";
            this.WeightingСoefficientColumn.MinimumWidth = 6;
            this.WeightingСoefficientColumn.Name = "WeightingСoefficientColumn";
            // 
            // ExpertEvalutionProjectColumn
            // 
            this.ExpertEvalutionProjectColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ExpertEvalutionProjectColumn.HeaderText = "Экспертная оценка проекта";
            this.ExpertEvalutionProjectColumn.MinimumWidth = 6;
            this.ExpertEvalutionProjectColumn.Name = "ExpertEvalutionProjectColumn";
            // 
            // ProjectWeightFactorColumn
            // 
            this.ProjectWeightFactorColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ProjectWeightFactorColumn.HeaderText = "Коэффицент весомости проекта";
            this.ProjectWeightFactorColumn.MinimumWidth = 6;
            this.ProjectWeightFactorColumn.Name = "ProjectWeightFactorColumn";
            this.ProjectWeightFactorColumn.ReadOnly = true;
            // 
            // ExpertEvaluationAnalogueColumn
            // 
            this.ExpertEvaluationAnalogueColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ExpertEvaluationAnalogueColumn.HeaderText = "Экспертная оценка аналога";
            this.ExpertEvaluationAnalogueColumn.MinimumWidth = 6;
            this.ExpertEvaluationAnalogueColumn.Name = "ExpertEvaluationAnalogueColumn";
            // 
            // AnalogueWeightCoefficientColumn
            // 
            this.AnalogueWeightCoefficientColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.AnalogueWeightCoefficientColumn.HeaderText = "Коэффицент весомости аналога";
            this.AnalogueWeightCoefficientColumn.MinimumWidth = 6;
            this.AnalogueWeightCoefficientColumn.Name = "AnalogueWeightCoefficientColumn";
            this.AnalogueWeightCoefficientColumn.ReadOnly = true;
            // 
            // conclusion
            // 
            this.conclusion.AutoSize = true;
            this.conclusion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.conclusion.Location = new System.Drawing.Point(12, 520);
            this.conclusion.Name = "conclusion";
            this.conclusion.Size = new System.Drawing.Size(0, 22);
            this.conclusion.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 596);
            this.Controls.Add(this.conclusion);
            this.Controls.Add(this.generateDataBtn);
            this.Controls.Add(this.ktyAnswer);
            this.Controls.Add(this.answerForProject);
            this.Controls.Add(this.answerForAnalog);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.nextFormBtn);
            this.Controls.Add(this.tableKTY);
            this.Name = "Form1";
            this.Text = "Расчет КТУ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableKTY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tableKTY;
        private System.Windows.Forms.Button nextFormBtn;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Label answerForAnalog;
        private System.Windows.Forms.Label answerForProject;
        private System.Windows.Forms.Label ktyAnswer;
        private System.Windows.Forms.Button generateDataBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QualityCriteriaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeightingСoefficientColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpertEvalutionProjectColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectWeightFactorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpertEvaluationAnalogueColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnalogueWeightCoefficientColumn;
        private System.Windows.Forms.Label conclusion;
    }
}

