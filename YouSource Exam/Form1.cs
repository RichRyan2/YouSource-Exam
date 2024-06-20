using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sorting_Algorithms;

namespace YouSource_Exam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SortingAlgo.SelectedIndex = 0;
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            if (SortingAlgo.SelectedIndex == 0)
            {
                SortedString.Text = SortingAlgorithms.BubbleSort(StringToSort.Text);
            }
            else
            {
                SortedString.Text = new string(SortingAlgorithms.QuickSort(StringToSort.Text.ToCharArray(), 0, StringToSort.Text.Length - 1));
            }
        } 
    }
}
