using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NotificationHub
{
    public partial class SourceHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Table table = new Table();
            table.ID = "1";
            PlaceHolder1.Controls.Add(table);

            SourecDal sourecDal = new SourecDal();
            sourecDal.GetSources();

            for(int count = 0; count < sourecDal.Sourceslist.Count; count++)
            {
                TableRow tableRow = new TableRow();
                table.Rows.Add(tableRow);
                TableCell cell = new TableCell();
                tableRow.Cells.Add(cell);
                Label label = new Label();
                PlaceHolder1.Controls.Add(label);
                label.Text = sourecDal.Sourceslist[count].Name + " \t\t";                                                                                                  

                HyperLink Edit = new HyperLink();
                PlaceHolder1.Controls.Add(Edit);
                Edit.Text = "EDIT"+" \t";
                HyperLink Delete = new HyperLink();
                PlaceHolder1.Controls.Add(Delete);
                Delete.Text = "DELETE";




            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddSource.aspx");
        }
    }
}