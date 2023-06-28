using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web.StoryService;

namespace Web
{
    public partial class wfHomePage : System.Web.UI.Page
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
            lblLongHeroPageStories.Text = "";
            StoryService.StoryServiceClient storyService = new StoryService.StoryServiceClient();
            ServedFullStory stories = storyService.SelectStories();
            lblLongHeroPageStories.Text += $"<div class=\"Long-Hero-Page-Stories-cont\">";
            foreach (Story story in stories.stories)
            {
                lblLongHeroPageStories.Text += $"<div class=\"whole-story-wrapper\">";
                lblLongHeroPageStories.Text += $"<div style=\"position: relative;\"><div><img class=\"book-cover\" src=\"images/{story.imageLink}\" /></div><div><input style=\"width: 125px!important\" class=\"primary-button\" type=\"submit\" value=\"READ NOW\" /></div></div>";
                lblLongHeroPageStories.Text += $"<div>";
                lblLongHeroPageStories.Text += $"<div class=\"Long-Hero-Page-Story\">";
                lblLongHeroPageStories.Text += $"<div style=\"display: flex; align-items: center;\"><div class=\"story-header\">{story.header}</div><span class=\"header-span\" style=\"color: #f13737; font-size: 30px; padding: 0 5px;\">|</span><div class=\"story-description beside-story-header-secondary-story-info\">{story.user.name}</div><span class=\"header-span\" style=\"color: #f13737; font-size: 30px; padding: 0 5px;\">|</span><div class=\"story-description beside-story-header-secondary-story-info\">{story.datePublished}</div></div>";
                lblLongHeroPageStories.Text += $"<div class=\"story-description\">{story.description}</div>";
                lblLongHeroPageStories.Text += $"<div style=\"margin: 10px 0;\">";
                foreach(categoryGroup category in stories.categoryGroup.FindAll(x => x.story.ID == story.ID))
                {
                    lblLongHeroPageStories.Text += $"<span class=\"category-tag\"> {category.category.name}</span>";
                }
                lblLongHeroPageStories.Text += "</div>";

                lblLongHeroPageStories.Text += $"<div class=\"story-info\">";
                lblLongHeroPageStories.Text += $"<div class=\"nav-item\">number of chapters: 19.</div>";
                lblLongHeroPageStories.Text += $"<div class=\"nav-item story-status\"><i class=\"fa-sharp fa-solid fa-circle-dot {story.status.name}\"></i><span>{story.status.name}</span></div>";
                lblLongHeroPageStories.Text += "</div>";
                lblLongHeroPageStories.Text += $"<div class=\"above-readnow-button-cont\"><div class=\"story-description above-readnow-button-secondary-story-info\">{story.user.name}</div><span class=\"above-button-span\" style=\"color: #f13737; font-size: 30px; padding: 0 5px;\">|</span><div class=\"story-description above-readnow-button-secondary-story-info\">{story.datePublished}</div></div></div>";
                if(story.price != 0)
                {
                    lblLongHeroPageStories.Text += $"<div>{story.price}</div>";
                }
                lblLongHeroPageStories.Text += $"</div>";
                lblLongHeroPageStories.Text += $"</div>";
                lblLongHeroPageStories.Text += $"</div>";
            }
            lblLongHeroPageStories.Text += $"</div>";
        }
    }
}