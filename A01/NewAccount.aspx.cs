//Augustus DeGrandis
//Bit 285 Assignment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NewAccount : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            dropdownlist.Items.Add("Web Developer Degree"); //adds these 3 items to the webpage
            dropdownlist.Items.Add("ETSP Degree");
            dropdownlist.Items.Add("Network Technology Degree");
        }
    }

    protected void createAccount_Click(object sender, EventArgs e)
    {
        if (CheckBox1.Checked == true) // no need to save session data unless the user wants emails
            Session["email"] = email.Text;
        Session["firstName"] = fName.Text;
        Session["lastName"] = lName.Text;
        Session["selectedProgram"] = dropdownlist.SelectedValue;
        Server.Transfer("/index.aspx");
    }



    protected void reset_Click(object sender, EventArgs e) 
    {
        Response.Redirect("NewAccount.aspx"); //refreshes the page clearing input
    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        emailValidation.Enabled = CheckBox1.Checked; //enables Validation for email when the box is checked
    }
}