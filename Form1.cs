using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// imports above ^^
namespace Eze_s_Web_Browser
{
    //main class which is my form
    public partial class Form1 : Form
    {
        //to initialize my components
        public Form1()
        {
            InitializeComponent();
        }

        // no code inside the function. Not necessary 
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
        // in case you want to go back to a page
        private void back_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }
        // button to go forward to a page
        private void forward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }
        //to go to home page. Which is google
        private void home_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com");
        }
        //once you type a URL, you click this button and it'll take you there
        private void search_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(input.Text))
            {
                webBrowser1.Navigate(input.Text);
            }            
        }
        // this function does not need code inside of it
        private void ezeSecurity1_Load(object sender, EventArgs e)
        {

        }
    }
}
