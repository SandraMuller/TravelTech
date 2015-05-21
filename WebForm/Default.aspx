<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebForm._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Title %>.</h1>
            </hgroup>
            <p>

            </p>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3>Region</h3>
            <asp:DropDownList runat="server" ID="Regions">
            </asp:DropDownList>
    <h3>Location</h3>
           <asp:DropDownList runat="server" ID="Locations">
            </asp:DropDownList>
    <h3>Description</h3>
            <p ID="description" ></p>
</asp:Content>
