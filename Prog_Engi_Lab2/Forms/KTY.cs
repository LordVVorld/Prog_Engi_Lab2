using System;
using System.Threading;
using System.Windows.Forms;

namespace Software_Evaluation
{
    public partial class KTY : Form
    {
        public KTY()
        {
            InitializeComponent();
        }

        private void KTY_Load(object sender, EventArgs e)
        {
            string[] criteria = new string[] {
                "Удобство работы (пользовательский интерфейс)",
                "Новизна (соответствие современным требованиям)",
                "Соответствие профилю деятельности заказчика",
                "Ресурсная эффективность",
                "Надежность (защита данных)",
                "Скорость доступа к данным",
                "Гибкость настройки",
                "Обучаемость персонала",
                "Соотношение стоимость/возможности"
            };

            for (int i = 0; i < criteria.Length; i++)
            {
                tableKTY.Rows.Add(criteria[i]);
            }
        }

        private void generateDataBtn_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for(int i = 0; i < tableKTY.Rows.Count; i++)
            {
                tableKTY.Rows[i].Cells["ExpertEvalutionProjectColumn"].Value = random.Next(1, 6);
                tableKTY.Rows[i].Cells["ExpertEvaluationAnalogueColumn"].Value = random.Next(1, 6);
            }
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in tableKTY.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    //if (cell.Value == null || cell.Value.ToString() == "")
                    //{
                    //    MessageBox.Show("Заполните все критерии качества");
                    //    return;
                    //}

                    //if(!int.TryParse(cell.Value.ToString(), out int n))
                    //{
                    //    MessageBox.Show("Некорретные данные");
                    //    return;
                    //}
                }
            }

            try
            {
                double projectQualityIndicator = 0;
                double analogQualityIndicator = 0;
                for (int i = 0; i < tableKTY.Rows.Count; i++)
                {
                    double projectWeightFactor =
                        Convert.ToDouble(tableKTY.Rows[i].Cells["ExpertEvalutionProjectColumn"].Value)
                        *
                        Convert.ToDouble(tableKTY.Rows[i].Cells["WeightingСoefficientColumn"].Value);
                    double analogWeightFactor =
                        Convert.ToDouble(tableKTY.Rows[i].Cells["ExpertEvaluationAnalogueColumn"].Value)
                        *
                        Convert.ToDouble(tableKTY.Rows[i].Cells["WeightingСoefficientColumn"].Value);
                    projectQualityIndicator += projectWeightFactor;
                    analogQualityIndicator += analogWeightFactor;
                    tableKTY.Rows[i].Cells["ProjectWeightFactorColumn"].Value = projectWeightFactor;
                    tableKTY.Rows[i].Cells["AnalogueWeightCoefficientColumn"].Value = analogWeightFactor;
                }
                double kty = Math.Round(projectQualityIndicator / analogQualityIndicator, 2);
                answerForProject.Text = "Обобщенный показатель качества для проекта: " + projectQualityIndicator;
                answerForAnalog.Text = "Обобщенный показетель качества для аналога: " + analogQualityIndicator;
                ktyAnswer.Text = "КТУ: " + kty;

                if (kty > 1)
                {
                    conclusion.ForeColor = System.Drawing.Color.Green;
                    conclusion.Text = "Разработка проекта оправдана";
                }
                else
                {
                    conclusion.ForeColor = System.Drawing.Color.Red;
                    conclusion.Text = "Разработка проекта неоправдана";
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void nextFormBtn_Click(object sender, EventArgs e)
        {
            var nextForm = new Thread(() => Application.Run(new Timetable()));
            nextForm.Start();
            this.Close();
        }
    }
}
