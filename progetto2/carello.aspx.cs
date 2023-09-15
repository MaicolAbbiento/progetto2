using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace progetto2
{
    public partial class carello : System.Web.UI.Page
    {
        public decimal Tot { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Negozio.carrello.Count==0)
            {
                Response.Redirect("default.aspx");
            }
            foreach (var item in Negozio.carrello)
            {
                Tot += item.Price;
            }
            totale.InnerHtml = String.Format("{0:C}", Tot);
            Repeater1.DataSource = Negozio.carrello;
            Repeater1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int itemIndex = Convert.ToInt32(btn.CommandArgument);
            Carrello prodottoDaRimuovere = Negozio.carrello.Find(p => p.id == itemIndex);
            Tot -= prodottoDaRimuovere.Price;
            Negozio.carrello.Remove(prodottoDaRimuovere);
            Repeater1.DataSource = Negozio.carrello;
            Response.Redirect("carello.aspx");
        }

     

        protected void Button1_Click2(object sender, EventArgs e)
        {
            Negozio.carrello.Clear();

            Response.Redirect("default.aspx");
        }
    }
}