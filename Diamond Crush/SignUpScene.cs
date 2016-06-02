using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Diamond_Crush
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        private void username_enter_Press(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar== (char)Keys.Enter)
            {

            }
        }
        private void password_enter_Press(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

            }
        }
        private void confirm_enter_Press(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

            }
        }
        private void exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void sign_up_Click(object sender, EventArgs e)
        {

        }
    }
}
