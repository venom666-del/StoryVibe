<%@ Page Title="" Language="C#" MasterPageFile="~/StoryVibe.Master" AutoEventWireup="true" CodeBehind="wfSingleBookDetailed.aspx.cs" Inherits="Web.wfSingleBookDetailed" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="SP-hero-cont">
        <div class="SP-image">
            <img class="SP-book-cover" src="images/<%=imageLink %>" alt="Alternate Text" />
        </div>
        <div class="SP-info">

            <div class="SP-static-info">
                <div class="SP-header-cont">
                    <div class="story-header"><%=header %></div>
                    <div style="display: flex; align-items: center;"><span class="redSeparator">|</span><span class="story-description beside-story-header-secondary-story-info"><%=author %></span><span class="redSeparator">|</span></div>
                </div>

                <asp:Label ID="lblCategoryTags" runat="server" />

                <div class="story-info" style="margin: 10px 0;">

                    <span class="story-status"><i class="fa-sharp fa-solid fa-circle-dot <%=status %>"></i><%=status %>
                        <%if (status == "In-Progress")
                            { %>
                        <span style="margin-left: 5px;">last update: <%=lastUpdate%></span>
                        <%} %>li
                    </span>

                    <div class="sp-chapN" style="margin: 0 15px;"><i class="fa-solid fa-file"></i><%=chapN %> chapters</div>
                    <div class="views"><i class="icon fa-solid fa-eye"></i><%=views %> views</div>
                </div>

            </div>
            <div class="SP-interactive-btn-cont">
                <asp:Button Text="READ NOW" CssClass="primary-button" runat="server" />
                <button type="submit" class="add-to-readlist-link">TO READLIST</button>
            </div>
        </div>
    </div>
</asp:Content>
