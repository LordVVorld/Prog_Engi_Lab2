using System;
using System.Threading;
using System.Windows.Forms;

namespace Software_Evaluation
{
    public partial class EconomicEffect : Form
    {
        public EconomicEffect()
        {
            InitializeComponent();
        }

        private void EconomicEffect_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Себестоимость (текущие эксплуатационные затраты), руб.");
            dataGridView1.Rows.Add("Суммарные затраты, связанные с внедрением проекта, руб.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                const double A = 1.6;
                const double E = 0.33;
                const int N = 1;
                double cAnalog = Convert.ToDouble(dataGridView1.Rows[0].Cells["AnalogProductColumn"].Value);
                double kAnalog = Convert.ToDouble(dataGridView1.Rows[1].Cells["AnalogProductColumn"].Value);
                double cProduct = Convert.ToDouble(dataGridView1.Rows[0].Cells["DevelopingProductColumn"].Value);
                double kProduct = Convert.ToDouble(dataGridView1.Rows[1].Cells["DevelopingProductColumn"].Value);
                double zAnalog = cAnalog + E * kAnalog;
                double zProduct = cProduct + E * kProduct;
                double economicEffect = (zAnalog * A - zProduct) * N;
                dataGridView1.Rows.Add("Приведенные затраты на единицу работ, руб.", zAnalog, zProduct);
                dataGridView1.Rows.Add("Экономический эффект от использования разрабатываемой системы, руб.", economicEffect);
            }catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var nextForm = new Thread(() => Application.Run(new COCOMO()));
            nextForm.Start();
            this.Close();
        }
    }
}