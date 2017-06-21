using System;
using System.Web;
using System.Web.UI;

namespace Development_Flow_Demo
{

    public partial class Default : System.Web.UI.Page
    {
        public void button1Clicked(object sender, EventArgs args)
        {
            button1.Text = "You clicked me";
        }
    }
}
