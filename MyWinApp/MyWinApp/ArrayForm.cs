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
    public partial class ArrayForm : Form
    {
        public ArrayForm()
        {
            InitializeComponent();

            const int size = 10;
            int [] firstArray = new int[size];
            firstArray[0] =10;
            firstArray[1] = 1;
            firstArray[5] = 9;

            string message = "";

            for (int index = 0; index < firstArray.Length; index ++)
            {
                if(firstArray[index]!= 0)
                    message = message + "Element at [index : " + index +"] is = "+ firstArray[index] + "\n";
            }

            showRichTextBox.Text = message;
        }
    }
}
