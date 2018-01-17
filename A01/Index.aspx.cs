using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void submitbutton_Click(object sender, EventArgs e)
    {
        string[] input = new string[3];
        input[0] = lastName.Text.Replace(" ","");
        input[1] = birthYear.Text.Replace(" ", "");
        input[2] = favColor.Text.Replace(" ", "");

        string pass1, pass2, pass3, pass4;
        pass1 = input[0] + input[1] + input[2];
        pass2 = input[1] + input[2] + input[0];
        pass3 = input[2] + input[0] + input[1];
        pass4 = input[2] + input[1] + input[0];
        
        
        DropDownList1.Items.Add(pass1);
        DropDownList1.Items.Add(pass2);
        DropDownList1.Items.Add(pass3);
        DropDownList1.Items.Add(pass4);
    }
}