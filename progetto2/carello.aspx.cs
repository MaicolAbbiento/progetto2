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
            foreach (var item in Negozio.carrello)
            {
                Tot += item.Price;
            }
            totale.InnerHtml = String.Format("{0:C}", Tot);
        }
    }
}