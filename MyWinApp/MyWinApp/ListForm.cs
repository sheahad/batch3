using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinApp
{
    public partial class ListForm : Form
    {
        List<int>  numbers =  new List<int>();
        public ListForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(numberTextBox.Text);
            numbers. Add(number);
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string message = "";

            foreach (var num in numbers)
            {
                message = message + "List element is " + num + "\n";
            }

            showRichTextBox.Text = message;
        }

        private void ReverseButton_Click(object sender, EventArgs e)
        {
            string message = "";

            for (int i = numbers.Count-1; i >= 0; i--)
            {
                message = message + "List element is " + numbers[i]+ "\n";
            }

            showRichTextBox.Text = message;
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            List<int> cloneNumbers = new List<int>();

            foreach (var num in numbers)
            {
                cloneNumbers.Add(num);
            }

            string message = "";

            foreach (var num in cloneNumbers)
            {
                message = message + "List element is " + num + "\n";
            }

            showRichTextBox.Text = message;
        }

        private void DuplicateButton_Click(object sender, EventArgs e)
        {
            List<int> cloneNumbers = new List<int>();
            List<int> duplicateNumbers = new List<int>();


            cloneNumbers = numbers;

            bool flag = false;
            foreach (var num in numbers)
            {
                foreach (var cnum in cloneNumbers)
                {
                    if (num==cnum && flag == false)
                    {
                        duplicateNumbers.Add(num);
                        flag =   true;
                    }
                }
                flag = false;
            }
            string message = "";

            foreach (var num in duplicateNumbers)
            {
                message = message + "List element is " + num + "\n";
            }

            showRichTextBox.Text = message;
        }

    }
}
