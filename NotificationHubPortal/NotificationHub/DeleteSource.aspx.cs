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
    public partial class DeleteSource : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            int s = Convert.ToInt32(Request.QueryString["id"]);
            SourecDal sourerepo = new SourecDal();
            List<Source> l=sourerepo.GetSources();
            ////Source so = new Source();
            foreach(Source sou in l)
            {
                if(sou.Id == s)
                {
                    Label1.Text = sou.Name;
                }
            }
            
            



            //PlaceHolder placeHolder = new PlaceHolder();
            //Label label = new Label();
            //label.Text = "Are you Sure You Want To delete " + sourerepo.Sourceslist[s].Name;
            //placeHolder.Controls.Add(label);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            int s = Convert.ToInt32(Request.QueryString["id"]);
           
            SourecDal sourerepo = new SourecDal();
            //Label1.Text = sourerepo.Sourceslist[s].Name;
            sourerepo.Delete(s);

          
            //Label1.Text = sourerepo.Sourceslist[s].Name;
           

            Response.Redirect("SourceHome.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("SourceHome.aspx");
        }
    }
}