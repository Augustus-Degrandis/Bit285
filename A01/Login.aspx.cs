using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void loginSubmit_Click(object sender, EventArgs e)
    {
        if(userName.Text == "Ian" && pass.Text == "password")
        {
            Server.Transfer("/Welcome.aspx");
        }
      
        string passInput = pass.Text.Replace(" ", "");
        if (passInput == "")
        {
            Server.Transfer("/NewAccount.aspx");
        }
        else
            Error.Visible = true;
    }
}