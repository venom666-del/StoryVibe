using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web.StoryService;

namespace Web
{
    public partial class wfReadBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["bookID"] == null)
            {
                Response.Redirect("wfHomePage.aspx");
            }
            Session["bookID"] = Request.Params["bookID"];
            if (!IsPostBack)
            {
                Populate();
                AddSingleView();
            }
        }

        public void AddSingleView()
        {
            StoryServiceClient storyService = new StoryServiceClient();
            ServedFullStory fullStories = storyService.SelectStories();
            Story story = fullStories.stories.Find(x => x.ID == int.Parse(Session["bookID"].ToString()));
            story.views++;
            int rows = storyService.UpdateStory(story);
        }

        public void Populate()
        {
            StoryServiceClient storyService = new StoryServiceClient();
            ServedFullStory fullStories = storyService.SelectStories();
            Story story = fullStories.stories.Find(x => x.ID == int.Parse(Session["bookID"].ToString()));
            ChaptersList chapters = storyService.SelectChapters();
            Chapter chapter = chapters.Find(x => (x.chapterNumber == 1 && x.story.ID == story.ID));
            lblChapter.Text += "<div class=\"book-intro\">";
            lblChapter.Text += $"<img class=\"book-cover-reading-page\" src=\"images/{story.imageLink}\" />";
            lblChapter.Text += $"<div class=\"reading-page-book-header\">{story.header}</div>";
            lblChapter.Text += $"<div class=\"reading-page-author\">written by: <a class=\"secondary-link\" style=\"color: #f13737\" href=\"wfUserProfile.aspx?userID={story.user.ID}\">{story.user.name}</a></div>";
            lblChapter.Text += $"<br /><hr />";
            lblChapter.Text += "</div>";
            lblChapter.Text += $"<div class=\"story-header\">{chapter.topic}</div>";
            lblChapter.Text += $"<div class=\"reading-page-content\">{chapter.content}</div>";
        }
    }
}