using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace prac1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Dictionary<String, String> users = new Dictionary<string, string>();

            users.Add("john", "12346");
            users.Add("nail", "login123");
            users.Add("scott", "qwerty");



            if (users.ContainsKey(TextBoxLogin.Text.ToLower()))
            {
                if (users[TextBoxLogin.Text.ToLower()] == TextBoxPassword.Text)
                {
                    Response.Redirect("WebForm2.aspx");
                }
                else if (users[TextBoxLogin.Text.ToLower()] != TextBoxPassword.Text) 
                {
                    Label1.Text = "Пароль или логин неверный ";
                }
            }
        }

        protected void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}