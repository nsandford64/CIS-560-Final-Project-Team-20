using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectView
{
    public class ViewController
    {
        private ClientView c;
        private AdminView a;
        private bool clientOn = true;
        
        public ViewController()
        {

        }

        public void SetViews(ClientView client, AdminView admin)
        {
            a = admin;
            c = client;
        }

        public void ChangeViewsClient()
        {
            c.Hide();
            a.Show();
        }

        public void ChangeViewsAdmin()
        {
            a.Hide();
            c.Show();
        }
    }
}
