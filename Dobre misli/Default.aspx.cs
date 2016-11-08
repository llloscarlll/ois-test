using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Dobre_misli
{
    
    public partial class Default : System.Web.UI.Page
    {
        private static List<string> data = new List<string>();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
        }

        protected void dodajMisel_Click(object sender, EventArgs e)
        {
            
            data.Add(misel.Text);
            misel.Text = "";
            foreach (string m in data)
            {
                Label tb = new Label();
                tb.Text = m + "<br />";
                misli.Controls.Add(tb);
            }
        }
    }
    
}