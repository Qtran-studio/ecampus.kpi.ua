﻿<%@ Page Title="Підтримка" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Site.Modules.Support.Support" %>

<asp:Content ID="body_content" ContentPlaceHolderID="body" runat="server">

    <div class="page-header">
        <h1><%=Page.Title %></h1>
    </div>

    <div class="row">
        <div class="col-md-12">

            <!-- UserVoice JavaScript SDK (only needed once on a page) -->
            <script>(function () { var uv = document.createElement('script'); uv.type = 'text/javascript'; uv.async = true; uv.src = '//widget.uservoice.com/FHbJ9EbNqeoVrNWIEu32uA.js'; var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(uv, s) })()</script>

            <!-- The Classic Widget will be embeded wherever this div is placed -->
            <div data-uv-inline="classic_widget" data-uv-mode="full" data-uv-primary-color="#cb9b34" data-uv-link-color="#208843" data-uv-default-mode="support" data-uv-forum-id="254983" data-uv-width="100%" data-uv-height="550px"></div>

        </div>
    </div>

</asp:Content>
