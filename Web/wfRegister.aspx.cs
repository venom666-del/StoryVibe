using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web.LeafService;
using Web.UserService;

namespace Web
{
    public partial class wfRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            UserServiceClient userService = new UserServiceClient();
            LeafServiceClient leafService = new LeafServiceClient();
            DateTime dateTime = DateTime.Now;
            UserService.Auth auth = new UserService.Auth();
            auth.ID = 7;
            User user = new User() {
                name = tbxUsername.Text,
                email = tbxEmail.Text,
                password = tbxPassword.Text,
                birthDate = tbxBirthDate.Text,
                auth = auth,
                creationDate = dateTime.ToString("d")
            };
            int rows = userService.Insert(user);
            User RegisteredUser = userService.Select().Find(x => x.email == tbxEmail.Text && x.password == tbxPassword.Text);
            if(rows == 1)
            {
                Session["userID"] = RegisteredUser.ID;
                Session["userName"] = RegisteredUser.name;
                Response.Redirect("wfHomePage.aspx");
            }
        }
    }
}