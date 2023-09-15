using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace progetto2
{
    public partial class shop : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int numeroCasuale = random.Next(1, Negozio.negozio.Count+1);
            Response.Redirect($"dettagli.aspx?id={numeroCasuale}");
        }
    }
}