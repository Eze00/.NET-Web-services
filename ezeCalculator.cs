using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// my imports above ^^
namespace Eze_s_Web_Browser
{
    // my main calculations class
    public partial class ezeCalculator : UserControl
    {
        public ezeCalculator()
        {
            InitializeComponent();
        }

        // add function
        private void add_Click(object sender, EventArgs e)
        {
            float result = float.Parse(input1.Text) + float.Parse(input2.Text);
            output.Text = result.ToString();
        }
        //subtract function
        private void subtract_Click(object sender, EventArgs e)
        {
            float result = float.Parse(input1.Text) - float.Parse(input2.Text);
            output.Text = result.ToString();
        }
        //multiply function
        private void multiply_Click(object sender, EventArgs e)
        {
            float result = float.Parse(input1.Text) * float.Parse(input2.Text);
            output.Text = result.ToString();
        }
        // divide function
        private void divide_Click(object sender, EventArgs e)
        {
            float result = float.Parse(input1.Text) / float.Parse(input2.Text);
            output.Text = result.ToString();
        }
    }
}
