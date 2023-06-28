using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web.LeafService;

namespace Web
{
    public partial class StoryVibe : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                populate();
            }
        }

        public void populate()
        {
            lblCategoriesFoNavbar.Text = "";
            LeafServiceClient leafService = new LeafServiceClient();
            LeavesList leaves = leafService.selectLeaves(Enumsleaves.category);
            foreach (Leaf leaf in leaves)
            {
                lblCategoriesFoNavbar.Text += $"<li><span><a style=\"color: #fff; text-decoration: none\" href=\"wfSingleCategory.aspx?categoryID={leaf.ID}\">{leaf.name}</a></span></li>";
            }
        }
    }
}