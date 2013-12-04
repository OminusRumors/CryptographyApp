using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptographyApp
{
    public partial class CryForm : Form
    {
        public CryForm()
        {
            InitializeComponent();
        }
        string skey;
        string stext;
        string btext;
        string bkey;

        private void CryForm_Load(object sender, EventArgs e)
        {

        }

        private void bt_encryption_Click(object sender, EventArgs e)
        {
            if (tb_key.Text.Length <= 1)
                MessageBox.Show("Enter a valid key.");
            //else if (tb_input.Text.Length < 1)
            //    MessageBox.Show("Enter a text for encryption.");
            else
            {
                skey = tb_key.Text;
                stext = tb_input.Text;

                //converts the key to binary
                foreach (char ch in skey)
                    bkey += Convert.ToString(ch, 2);

                //converts the text to binary
                foreach (char ch in stext)
                    btext += Convert.ToString(ch, 2);
            }
        }
    }
}