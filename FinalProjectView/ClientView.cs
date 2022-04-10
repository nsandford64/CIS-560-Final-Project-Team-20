using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectView
{
    public partial class ClientView : Form
    {
        private ViewController c;

        public ClientView(ViewController controller)
        {
            c = controller;
            InitializeComponent();
        }

        private void uxAdminButton_Click(object sender, EventArgs e)
        {
            c.ChangeViewsClient();
        }
    }
}
