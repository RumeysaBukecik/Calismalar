using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace rumbotecik
{
    public partial class YaziListele : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BLOGEntities db = new BLOGEntities();
            Repeater1.DataSource = db.Blogs.ToList();
            Repeater1.DataBind();
        }
    }
}