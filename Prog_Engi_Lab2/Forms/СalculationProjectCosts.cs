using System;
using System.Threading;
using System.Windows.Forms;

namespace Software_Evaluation
{
    public partial class СalculationProjectCosts : Form
    {
        public СalculationProjectCosts()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (socialСoeff.Text == "" || overheadСoeff.Text == "" || additionalSalaryCoeff.Text == "")
                {
                    MessageBox.Show("Введите коэффициенты");
                    return;
                }

                if (!double.TryParse(socialСoeff.Text, out double coeffSocialContributions) ||
                    !double.TryParse(overheadСoeff.Text, out double coeffOverhead) ||
                    !double.TryParse(additionalSalaryCoeff.Text, out double coeffAdditionalSalary))
                {
                    MessageBox.Show("Неверный формат коэффициентов");
                    return;
                }

                if (coeffSocialContributions <= 0 || coeffOverhead <= 0 || coeffAdditionalSalary <= 0)
                {
                    MessageBox.Show("Коэффициенты не могут быть меньше или равны нулю");
                    return;
                }

                if(!(developerSalaryTable.Rows.Count > 0))
                {
                    MessageBox.Show("Введите зарплаты");
                }

                const int workingDaysPerMonth = 21;
                double baseSalary = 0;
                for (int i = 0; i < developerSalaryTable.Rows.Count - 1; i++)
                {
                    double workingDays = Convert.ToDouble(developerSalaryTable.Rows[i].Cells["WorkingDaysColumn"].Value);
                    double dailySalary = Convert.ToDouble(developerSalaryTable.Rows[i].Cells["DailySalaryColumn"].Value);
                    developerSalaryTable.Rows[i].Cells["OZPColumn"].Value = workingDays * Math.Abs(dailySalary);
                    developerSalaryTable.Rows[i].Cells["SalaryColumn"].Value = Math.Round(workingDaysPerMonth * dailySalary);
                    baseSalary += Convert.ToDouble(developerSalaryTable.Rows[i].Cells["OZPColumn"].Value);
                }

                double materialCosts = 0;
                for (int i = 0; i < materialTable.Rows.Count - 1; i++)
                {
                    int amountMaterial = Math.Abs(Convert.ToInt16(materialTable.Rows[i].Cells["AmountColumn"].Value));
                    double price = Convert.ToDouble(materialTable.Rows[i].Cells["PricePerUnitColumn"].Value);
                    double sum = price * amountMaterial;
                    materialCosts += sum;
                    materialTable.Rows[i].Cells["SumMaterialsColumn"].Value = sum;
                }

                double computerTime = 460;
                double costOneHourComputer = 20;
                int multiprogramRate = 1;

                double costsUsageComputer = computerTime * costOneHourComputer * multiprogramRate;
                double additionalPay = coeffAdditionalSalary * baseSalary;
                double socialContributions = (baseSalary + additionalPay) * coeffSocialContributions;
                double expensesOrganization = baseSalary * coeffOverhead;
                double result = baseSalary + additionalPay + socialContributions + materialCosts
                     + expensesOrganization;
                developmentCostsTable.Rows.Clear();
                developmentCostsTable.Rows.Add("Основная заработная плата", baseSalary);
                developmentCostsTable.Rows.Add("Дополнительная зарплата", additionalPay);
                developmentCostsTable.Rows.Add("Отчисления на социальные нужды", socialContributions);
                developmentCostsTable.Rows.Add("Затраты на материал", materialCosts);
                // developmentCostsTable.Rows.Add("Затраты на машинное время", costsUsageComputer);
                developmentCostsTable.Rows.Add("Накладные расходы организации", expensesOrganization);
                developmentCostsTable.Rows.Add("ИТОГО", result);
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nextForm = new Thread(() => Application.Run(new CalculateOperatingCosts()));
            nextForm.Start();
            this.Close();
        }
    }
}