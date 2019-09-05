using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _02_List_control
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
            ListItem li1 = new ListItem("Pune","pune");
            ListItem li2 = new ListItem("Mumbai","mumbai");
            ListItem li3 = new ListItem("Delhi","delhi");

            RadioButton1.Text = "Male";
            DropDownList1.Items.Add(li1);
            DropDownList1.Items.Add(li2);
            DropDownList1.Items.Add(li3);
            }
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            TextBox1.Text = RadioButton1.Text;
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //d
        }
    }
}