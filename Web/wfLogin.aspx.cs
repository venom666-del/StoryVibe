using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web.UserService;

namespace Web
{
    public partial class wfLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            lblErrMessage.Text = "";

            UserServiceClient userService = new UserServiceClient();
            UsersList users = userService.Select();
            User user = users.Find(x => (x.name == tbxUsername.Text && x.password == tbxPassword.Text));
            if (user == null)
            {
                lblErrMessage.Text = "The data does not exist in our system";
                return;
            }
            Session["userID"] = user.ID;
            Session["userName"] = user.name;
            Response.Redirect("wfHomePage.aspx");

        }
    }
}