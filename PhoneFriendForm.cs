using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppGameMillioner
{
    
    public partial class PhoneFriendForm : Form
    {
        public PhoneFriendForm(string friendResponse)
        {
            InitializeComponent();
            labelResponse.Text = friendResponse;
        }

        private void labelResponse_Click(object sender, EventArgs e)
        {

        }

    }
}
