using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WcfBooksClient.ServiceReference1;

namespace WcfBooksClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnget_Click(object sender, EventArgs e)
        {
            string bcode = txtbcode.Text;
            BooksClient b = new BooksClient();
          var result=  b.findbycode(bcode);
            var list = new List<book> { result };
            GridView1.DataSource = list;
            GridView1.DataBind();
        }
    }
}