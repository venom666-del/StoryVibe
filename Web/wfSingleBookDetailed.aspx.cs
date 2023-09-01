using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web.StoryService;

namespace Web
{
    public partial class wfSingleBookDetailed : System.Web.UI.Page
    {
        public string imageLink = "";
        public string lastUpdate = "";
        public string header = "";
        public string status = "";
        public int chapN = 0;
        public int views = 0;
        public string author = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["singleBookID"] == null)
            {
                Response.Redirect("wfHomePage.aspx");
            }
            Session["singleBookID"] = Request.Params["singleBookID"].ToString();
            if (!IsPostBack)
            {
                PopulateStoryData();
            }
        }

        public void PopulateStoryData()
        {
            StoryServiceClient storyService = new StoryServiceClient();
            ServedFullStory fullStories = storyService.SelectStories();
            int.TryParse(Session["singleBookID"].ToString(), out int singleBookID);
            Story story = fullStories.stories.Find(x => x.ID == singleBookID);
            header = story.header;

            foreach (categoryGroup category in fullStories.categoryGroup.FindAll(x => x.story.ID == singleBookID))
            {
                lblCategoryTags.Text += $"<span class=\"category-tag\">{category.category.name}</span>";
            }

            status = story.status.name;

            ChaptersList chapters = new ChaptersList();
            foreach (Chapter chapter in storyService.SelectChapters().FindAll(x => x.story.ID == story.ID).OrderBy(x => x.datePublished))
            {
                chapters.Add(chapter);
            }
            chapN = chapters.Count;
            views = story.views;
            author = story.user.name;
            imageLink = story.imageLink;
            lastUpdate = chapters.Max(x => x.datePublished);
        }
    }
}