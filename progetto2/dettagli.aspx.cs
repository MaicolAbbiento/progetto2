﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace progetto2
{
    public partial class dettagli : System.Web.UI.Page
    {
        public Carrello prodotto { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            prodotto = Negozio.negozio.Find((p) => p.id == Convert.ToInt32(Request.QueryString["id"]));
            nomeProdotto.InnerHtml = prodotto.Name;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Negozio.carrello.Add(prodotto);
            Response.Redirect("carello.aspx");
        }
    }
}