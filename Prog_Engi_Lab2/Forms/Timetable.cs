using System;
using System.Threading;
using System.Windows.Forms;

namespace Software_Evaluation
{
    public partial class Timetable : Form
    {
        public Timetable()
        {
            InitializeComponent();
        }

        public bool validate()
        {
            if (complexWorks.Rows.Count <= 1)
            {
                MessageBox.Show("Введите комплекс работ по разработке проекта");
                return false;
            }

            for(int i = 0; i < complexWorks.Rows.Count - 1; ++i)
            {
                foreach (DataGridViewCell cell in complexWorks.Rows[i].Cells)
                {
                    if (cell.Value == null || cell.Value.ToString() == "")
                    {
                        MessageBox.Show("Заполните все ячейки в комплексе работ");
                        return false;
                    }
                }

                bool isCorrectWorkDuring = double.TryParse(complexWorks.Rows[i].Cells["DuringPlaneColumn"].Value.ToString(),
                    out double workDuring); 
                   
                if (isCorrectWorkDuring && workDuring <= 0)
                {
                    MessageBox.Show("Длительность должна быть больше 0");
                }
            }

            foreach (DataGridViewRow row in complexWorks.Rows)
            {
                if(!row.IsNewRow)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
         
                        if (cell.Value == null || cell.Value.ToString() == "")
                        {
                            MessageBox.Show("Заполните все ячейки в комплексе работ");
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validate()) return;
                calendarSchedule.Rows.Clear();
                for (int i = 0; i < complexWorks.Rows.Count - 1; ++i)
                {
                    string startDate = i == 0 ?
                        monthCalendar1.SelectionStart.ToString("d")
                        :
                        calendarSchedule.Rows[i - 1].Cells["FinishWorkColumn"].Value.ToString();
                    string endDate = Convert.ToDateTime(startDate)
                        .AddDays(Convert.ToDouble(complexWorks.Rows[i].Cells["DuringPlaneColumn"].Value)).ToString("d");
                    calendarSchedule.Rows.Add(complexWorks.Rows[i].Cells["ContentWorkPlaneColumn"].Value,
                        complexWorks.Rows[i].Cells["ExecutorPlaneColumn"].Value,
                        complexWorks.Rows[i].Cells["DuringPlaneColumn"].Value,
                        startDate,
                        endDate);
                }
            } catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nextForm = new Thread(() => Application.Run(new СalculationProjectCosts()));
            nextForm.Start();
            this.Close();
        }
    }
}