<%@ Page Title="" Language="C#" MasterPageFile="~/StoryVibe.Master" AutoEventWireup="true" CodeBehind="wfHomePage.aspx.cs" Inherits="Web.wfHomePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="hero-page-section">
        <div class="hero-page-inner-wrapper">
            <div class="five-top-stories">
            </div>
            <div class="top-writers">
                <div class="partial-writers-leaderboard">
                    <asp:Label ID="lblHeroPageInformative" runat="server" />
                </div>
                <div class="view-full-writers-leaderboard">
                    <a class="writers-leaderboard-link" href="#">
                        <div class="view-full-writers-leaderboard-inner-wrapper">
                            <span style="margin-right: 5px;">TO LEADERBOARD</span><i class="fa-solid fa-arrow-right"></i>
                        </div>
                    </a>
                </div>
            </div>
        </div>
            <div  class="ScFoMo">
                <p>Scroll For More</p>
                <i class="fa-solid fa-arrow-down"></i>  
            </div>

    </div>
    <div class="long-general-stroies-outer-container">
        <asp:Label ID="lblLongGeneralStories" runat="server" />
    </div>
</asp:Content>
