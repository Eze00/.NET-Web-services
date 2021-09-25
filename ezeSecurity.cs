using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//above are my imports

namespace Eze_s_Web_Browser
{
    // main class
    public partial class ezeSecurity : UserControl
    {
        //to initilize my components
        public ezeSecurity()
        {
            InitializeComponent();
        }

        // encrypting method. Takes an an input and spits a coded message
        private void encryption_Click(object sender, EventArgs e)
        {
            AsuService.ServiceClient asuService = new AsuService.ServiceClient();
            string encryption = asuService.Encrypt(enInput.Text);
            enOutput.Text = encryption.ToString();
        }

        // decrypting method. Takes an a coded message and spits out the original text
        private void decrypt_Click(object sender, EventArgs e)
        {
            AsuService.ServiceClient asuService = new AsuService.ServiceClient();
            string decryption = asuService.Decrypt(deInput.Text);
            deOutput.Text = decryption.ToString();
        }
    }
}
