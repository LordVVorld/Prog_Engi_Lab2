using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Evaluation
{
    public partial class CalculateOperatingCosts : Form
    {
        public CalculateOperatingCosts()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < developerSalaryTable.Rows.Count - 1; i++)
            //{
            //    if (Double.TryParse(developerSalaryTable.Rows[i].Cells["WorkingDaysColumn"].Value.ToString(), out double d)
            //        || Double.TryParse(developerSalaryTable.Rows[i].Cells["DailySalaryColumn"].Value.ToString(), out double s)
            //        || s < 0)
            //    {
            //        MessageBox.Show("Введены некорретные данные");
            //    }
            //}

            const int workingDaysPerMonth = 21;
            double baseSalary = 0;
            for (int i = 0; i < developerSalaryTable.Rows.Count - 1; i++)
            {
                double workingDays = Convert.ToDouble(developerSalaryTable.Rows[i].Cells["WorkingDaysColumn"].Value);
                double dailySalary = Convert.ToDouble(developerSalaryTable.Rows[i].Cells["DailySalaryColumn"].Value);
                developerSalaryTable.Rows[i].Cells["OZPColumn"].Value = workingDays * dailySalary * 1.4 * 1.302;
                developerSalaryTable.Rows[i].Cells["SalaryColumn"].Value = Math.Round(workingDaysPerMonth * dailySalary);
                baseSalary += Convert.ToDouble(developerSalaryTable.Rows[i].Cells["OZPColumn"].Value);
            }

            double depreciationCharge = 0;
            double costsRepair = 0;
            double electricityCosts = 0;
            double costsMaterials = 0;
            double overheadCosts = 0;
            const int workingDaysYear = 247;
            const double a = 0.2;
            const double standardRepairCosts = 0.05;
            const double electricityTariff = 2.6;
            const double equipmentPower = 0.4;
            
            for (int i = 0; i < equipmentTable.Rows.Count - 1; ++i)
            {
                double h = Convert.ToDouble(equipmentTable.Rows[i].Cells["AverageDailyLoadColumn"].Value);
                double c = Convert.ToDouble(equipmentTable.Rows[i].Cells["CarryingAmountColumn"].Value);
                int g = Convert.ToInt16(equipmentTable.Rows[i].Cells["AmountEquipmentColumn"].Value);
                double f = workingDaysYear * h;
                double t = Convert.ToDouble(equipmentTable.Rows[i].Cells["TotalOperatingColumn"].Value);
                depreciationCharge += (c * a * g * t) / f;
                costsRepair += (standardRepairCosts * c * t) / f;
                costsMaterials += c * 0.01;
                electricityCosts += equipmentPower * g * t * electricityTariff;
            }

            costsTable.Rows.Clear();
            overheadCosts = (baseSalary + depreciationCharge + electricityCosts + costsRepair + costsMaterials) * 0.2;
            double result = baseSalary + depreciationCharge + electricityCosts + costsRepair + costsMaterials + overheadCosts;
            costsTable.Rows.Add("Основная и дополнительная зарплата с отчислениями", Math.Round(baseSalary, 3, MidpointRounding.ToEven));
            costsTable.Rows.Add("Амортизационные отчисления", Math.Round(depreciationCharge, 3, MidpointRounding.ToEven));
            costsTable.Rows.Add("Затраты на электроэнергию", Math.Round(electricityCosts, 3, MidpointRounding.ToEven));
            costsTable.Rows.Add("Затраты на текущий ремонт", Math.Round(costsRepair, 3, MidpointRounding.ToEven));
            costsTable.Rows.Add("Затраты на материалы", Math.Round(costsMaterials, 3, MidpointRounding.ToEven));
            costsTable.Rows.Add("Накладные расходы", Math.Round(overheadCosts, 3, MidpointRounding.ToEven));
            costsTable.Rows.Add("Итого", Math.Round(result, 3, MidpointRounding.ToEven));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nextForm = new Thread(() => Application.Run(new EconomicEffect()));
            nextForm.Start();
            this.Close();
        }
    }
}