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
        string lname = (string)Session["lastName"];
        lastName.Text = lname;
        
    }

    protected void submitbutton_Click(object sender, EventArgs e)
    {
        string[] input = new string[4];
        input[0] = lastName.Text.Replace(" ","");
        input[1] = birthYear.Text.Replace(" ", "");
        input[2] = favColor.Text.Replace(" ", "");
        input[3] = (string)Session["firstName"];

        string[] passwords = new string[5];
        passwords[4] = input[3] + input[0] + input[1];
        passwords[0] = input[0] + input[1] + input[2];
        passwords[1] = input[1] + input[2] + input[0];
        passwords[2] = input[2] + input[0] + input[1];
        passwords[3] = input[2] + input[1] + input[0];

        Random rng = new Random();
        for(int i = 0; i < passwords.Length-1; i++)
        {
            while(passwords[i].Length < 8)
            {
                passwords[i] = passwords[i] + input[rng.Next(0, 4)];
            }
            DropDownList1.Items.Add(passwords[i]);
        }
    }
}