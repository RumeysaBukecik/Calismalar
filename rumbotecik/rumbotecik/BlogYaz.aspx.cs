using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace rumbotecik
{
    public partial class BlogYaz : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Oturum"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                int YazarID = Convert.ToInt32(Session["Oturum"].ToString());
            }
        }

        protected void btn_BlogYaz_Click(object sender, EventArgs e)
        {
            if (input_FotoUploadBlogYaz.PostedFile != null)
            {
                Blog b1 = new Blog();
                b1.BlogYazarID= Convert.ToByte(Session["Oturum"].ToString());
                b1.BlogBaslik = txt_Baslik.Text;
            b1.Blogİcerik = txt_İcerik.Text;

                if (input_FotoUploadBlogYaz.PostedFile != null || input_FotoUploadBlogYaz.PostedFile.FileName != null || input_FotoUploadBlogYaz.PostedFile.FileName != "")
            {
                b1.BlogGorselUrl = $"IMG/Blog-Resimleri/{DateTime.Today.ToString("dd-MM-yyyy")}_{Guid.NewGuid().ToString().Replace("-", "")}_{input_FotoUploadBlogYaz.FileName}";
                    input_FotoUploadBlogYaz.SaveAs(Server.MapPath("~/" + b1.BlogGorselUrl));
            }
            BLOGEntities ctx = new BLOGEntities();
            ctx.Blogs.Add(b1);
            ctx.SaveChanges();

        }
    }
    }
}