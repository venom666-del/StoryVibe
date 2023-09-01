using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web.StoryService;
using Web.UserService;

namespace Web
{
    public partial class wfHomePage : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PopulateGeneralStories();
            }
            WhatButtonPressed();
        }

        public void PopulateHeroSection()
        {
            lblHeroPageInformative.Text = "";
            UserServiceClient userService = new UserServiceClient();
            StoryServiceClient storyService = new StoryServiceClient();

            ServedFullStory fullStories = storyService.SelectStories();
            StoriesList stories = fullStories.stories;

            foreach (Story story in stories.OrderBy(x => x.views))
            {
                lblHeroPageInformative.Text += "<div class=\"leaderboard-story\">";
                lblHeroPageInformative.Text += $"<div class=\"story-description\">{story.header}</div>";
                lblHeroPageInformative.Text += $"<div>{story.user.name}</div>";

                lblHeroPageInformative.Text += "</div>";
            }
        }

        public void PopulateGeneralStories()
        {
            PopulateHeroSection();
            lblLongGeneralStories.Text = "";
            StoryService.StoryServiceClient storyService = new StoryService.StoryServiceClient();
            ServedFullStory stories = storyService.SelectStories();
            lblLongGeneralStories.Text += $"<div class=\"Long-Hero-Page-Stories-cont\">";
            foreach (Story story in stories.stories)
            {
                lblLongGeneralStories.Text += $"<a class=\"go-to-details-link\" href=\"wfSingleBookDetailed.aspx?singleBookID={story.ID}\"><div class=\"whole-story-wrapper\">";
                lblLongGeneralStories.Text += $"<div style=\"position: relative; margin-right: 20px;\">" +$"<div><img class=\"book-cover-homepage\" src=\"images/{story.imageLink}\" /></div>" +$"<div><input class=\"primary-button\" name=\"bookID{story.ID}\" type=\"submit\" value=\"READ NOW\" /></div>" +$"</div>";
                lblLongGeneralStories.Text += $"<div>";
                lblLongGeneralStories.Text += $"<div class=\"Long-Hero-Page-Story\">";
                lblLongGeneralStories.Text += $"<div style=\"display: flex; align-items: center;\">" +$"<div class=\"story-header\">{story.header}</div><span class=\"header-span\" style=\"color: #f13737; font-size: 30px; padding: 0 5px;\">|</span><div class=\"story-description beside-story-header-secondary-story-info\">{story.user.name}</div><span class=\"header-span\" style=\"color: #f13737; font-size: 30px; padding: 0 5px;\">|</span><div class=\"story-description beside-story-header-secondary-story-info\">{story.datePublished}</div></div>";
                lblLongGeneralStories.Text += $"<div class=\"story-description\">{story.description}</div>";
                lblLongGeneralStories.Text += $"<div style=\"margin: 10px 0;\">";
                foreach(categoryGroup category in stories.categoryGroup.FindAll(x => x.story.ID == story.ID))
                {
                    lblLongGeneralStories.Text += $"<span class=\"category-tag\"> {category.category.name}</span>";
                }
                lblLongGeneralStories.Text += "</div>";

                lblLongGeneralStories.Text += $"<div class=\"story-info\">";
                ChaptersList chapters = new ChaptersList();
                foreach (Chapter chapter in storyService.SelectChapters().FindAll(x => x.story.ID == story.ID).OrderBy(x => x.datePublished))
                {
                    chapters.Add(chapter);
                }
                lblLongGeneralStories.Text += $"<div class=\"nav-item\">{chapters.Count} chapters.</div>";
                lblLongGeneralStories.Text += $"<div class=\"nav-item story-status\"><i class=\"fa-sharp fa-solid fa-circle-dot {story.status.name}\"></i>{story.status.name}";
                if (story.status.name == "In-Progress")
                {
                    lblLongGeneralStories.Text += $"<span style=\"margin-left: 5px;\">last update: {chapters.Max(x => x.datePublished)}</span>";
                }
                lblLongGeneralStories.Text += "</div>";
                if(story.price != 0)
                {
                    lblLongGeneralStories.Text += $"<div>{story.price}</div>";
                }
                lblLongGeneralStories.Text += "</div>";
                lblLongGeneralStories.Text += $"<div class=\"above-readnow-button-cont\"><div class=\"story-description above-readnow-button-secondary-story-info\">{story.user.name}</div><span class=\"above-button-span\" style=\"color: #f13737; font-size: 30px; padding: 0 5px;\">|</span><div class=\"story-description above-readnow-button-secondary-story-info\">{story.datePublished}</div></div></div>";
                lblLongGeneralStories.Text += $"</div>";
                lblLongGeneralStories.Text += $"</div></a>";
            }
            lblLongGeneralStories.Text += $"</div>";
        }

        public void WhatButtonPressed()
        {
            foreach (string key in Request.Form.AllKeys)
            {
                if (key.StartsWith("bookID"))
                {
                    string bookID = key.Substring(6);
                    string URL = $"wfReadBook.aspx?bookID={bookID}";
                    Response.Redirect(URL);
                }
            }
        }
    }
}