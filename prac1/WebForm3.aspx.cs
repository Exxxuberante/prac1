using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prac1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String str = "Textbox:" + TextBox1.Text;

            if (Sugar.Checked)
            {
                str += "<br/> RadioButton:" + Sugar.Text;
            }
            if (Eggs.Checked)
            {
                str += "<br/> RadioButton:" + Eggs.Text;
            }
            if (Grechka.Checked)
            {
                str += "<br/> RadioButton:" + Grechka.Text;
            }

            str += "<br/> Listbox:" + ListBox1.SelectedValue;

            str += "<br/> DropDownList:" + DropDownList1.SelectedValue;

            

            Label1.Text = str;
        }
    }
}