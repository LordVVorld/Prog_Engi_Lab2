using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Evaluation
{
    public partial class COCOMO : Form
    {
        public COCOMO()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (numberCodeTextBox.Text.Length == 0)
            {
                MessageBox.Show("Введите количество строк");
                return;
            }

            if (!int.TryParse(numberCodeTextBox.Text, out int n))
            {
                MessageBox.Show("Введите число в количество строк");
                return;
            }

            if (commonTypeProject.Checked && semiIndependentTypeProject.Checked
                || commonTypeProject.Checked && builtInTypeProject.Checked 
                || semiIndependentTypeProject.Checked && builtInTypeProject.Checked)
            {
                MessageBox.Show("Выберите только один тип проекта");
                return;
            }

            List<CheckedListBox> checkedListBoxes = new List<CheckedListBox>
            {
                vlowList,
                lowList,
                nominalList,
                highList,
                vhighList,
                extrahighList
            };
            double EAF = 1;
            foreach(CheckedListBox checkedListBox in checkedListBoxes)
            {
                for(int i = 0; i < checkedListBox.Items.Count; i++)
                {
                    if (checkedListBox.GetItemChecked(i))
                    {
                        EAF *= double.Parse(lowList.Items[i].ToString());
                    }
                }
            }
            double a = 0 ;
            double b = 0;
            if(commonTypeProject.Checked)
            {
                a = 3.2;
                b = 1.05;
            }else if (semiIndependentTypeProject.Checked)
            {
                a = 3;
                b = 1.12;
            }else
            {
                a = 2.8;
                b = 1.2;
            }
            int size = int.Parse(numberCodeTextBox.Text);
            double result = EAF * a * Math.Pow(size, b);
            laborIntensityTextBox.Text = Math.Round(result, 2).ToString();
        } 

        private void vlowList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = vlowList.SelectedIndex;

            if (index != -1 && vlowList.GetItemChecked(index) && (lowList.GetItemChecked(index)
                || highList.GetItemChecked(index) || vhighList.GetItemChecked(index)
                || extrahighList.GetItemChecked(index) || nominalList.GetItemChecked(index)))
            {
                MessageBox.Show("Пожалуйста, выберите только один пункт!");
                vlowList.SetItemChecked(index, false);
                vlowList.SelectedIndex = -1;

            }
        }

        private void lowList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lowList.SelectedIndex;

            if (index != -1 && lowList.GetItemChecked(index) && (vlowList.GetItemChecked(index)
                || highList.GetItemChecked(index) || vhighList.GetItemChecked(index)
                || extrahighList.GetItemChecked(index) || nominalList.GetItemChecked(index)))
            {
                MessageBox.Show("Пожалуйста, выберите только один пункт!");
                lowList.SetItemChecked(index, false);
                lowList.SelectedIndex = -1;

            }
        }

        private void nominalList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = nominalList.SelectedIndex;

            if (index != -1 && nominalList.GetItemChecked(index) && (vlowList.GetItemChecked(index)
                || highList.GetItemChecked(index) || vhighList.GetItemChecked(index)
                || extrahighList.GetItemChecked(index) || lowList.GetItemChecked(index)))
            {
                MessageBox.Show("Пожалуйста, выберите только один пункт!");
                nominalList.SetItemChecked(index, false);
                nominalList.SelectedIndex = -1;

            }
        }

        private void highList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = highList.SelectedIndex;

            if (index != -1 && highList.GetItemChecked(index) && (vlowList.GetItemChecked(index)
                || nominalList.GetItemChecked(index) || vhighList.GetItemChecked(index)
                || extrahighList.GetItemChecked(index) || lowList.GetItemChecked(index)))
            {
                MessageBox.Show("Пожалуйста, выберите только один пункт!");
                highList.SetItemChecked(index, false);
                highList.SelectedIndex = -1;

            }
        }

        private void vhighList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = vhighList.SelectedIndex;

            if (index != -1 && vhighList.GetItemChecked(index) && (vlowList.GetItemChecked(index)
                || nominalList.GetItemChecked(index) || highList.GetItemChecked(index)
                || extrahighList.GetItemChecked(index) || lowList.GetItemChecked(index)))
            {
                MessageBox.Show("Пожалуйста, выберите только один пункт!");
                vhighList.SetItemChecked(index, false);
                vhighList.SelectedIndex = -1;

            }
        }

        private void extrahighList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = extrahighList.SelectedIndex;
            if (index != -1 && extrahighList.GetItemChecked(index) && (vlowList.GetItemChecked(index)
                || nominalList.GetItemChecked(index) || vhighList.GetItemChecked(index)
                || highList.GetItemChecked(index) || lowList.GetItemChecked(index)))
            {
                MessageBox.Show("Пожалуйста, выберите только один пункт!");
                extrahighList.SetItemChecked(index, false);
                extrahighList.SelectedIndex = -1;
            }
        }
    }
}