using DAL.Model;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NotificationHub
{
    public partial class EditSource : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(Request.QueryString["id"]);
            SourecDal sourerepo = new SourecDal();
            List<Source> l = sourerepo.GetSources();

            foreach (Source sou in l)
            {
                if (sou.Id == s)
                {
                    TextBox1.Text = sou.Name;
                }
            }
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(Request.QueryString["id"]);
            SourecDal sourerepo = new SourecDal();
            sourerepo.Edit(s,TextBox1.Text);
            Response.Redirect("SourceHome.aspx");
        }
    }
}