<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyWorkspaces.aspx.cs" Inherits="Recipe03.WebForms.Members.MyWorkspaces" MasterPageFile="~/Site.Master" %>
<asp:Content ID="Content4" 
    ContentPlaceHolderID="MainContent" 
    runat="server">
    <h1>My Song Workspaces</h1>
    <div class="tab-content" id="flowtabsPanes">
        <div class="tab-pane active" id="MyWorkspaces">
            <asp:PlaceHolder 
              Text="You have not created any song workspaces." 
              runat="server" 
              Visible="false" 
              ID="noWorkspaces" />
            <asp:Repeater ID="ProjectsRepeater" runat="server">
                <HeaderTemplate>
                    <table class="table table-striped">
                        <thead>
                            <tr>
                                <th>
                                    <asp:Label ID="ProjectNameHdrLabel" 
                                       runat="server" 
                                       Text="Project Name">
                                    </asp:Label>
                                </th>
                                <th>
                                    <asp:Label ID="ProjectDetailsHdrLabel" 
                                         runat="server" 
                                         Text="Status">
                                    </asp:Label>
                                </th>
                                <th>
                                    <asp:Label ID="ProjectStatusHdrLabel" 
                                         runat="server" 
                                         Text="Created">
                                    </asp:Label>
                                </th>
                                <th>
                                    <asp:Label ID="ProjectDateModHdrLabel" 
                                         runat="server" 
                                         Text="Modified">
                                    </asp:Label>
                                </th>
                            </tr>
                        </thead>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td>
                            <asp:Label ID="ProjectNameLabel" 
                                 runat="server">
                             <a title="Go to the project workspace." href="#">
                                <%# Eval("Title") %></a></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="ProjectDetailsLabel" 
                                 runat="server"><%# Eval("Status") %>
                            </asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="ProjectStatusLabel" 
                               runat="server">
                               <%# Eval("CreateDate")%>
                            </asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="ProjectDateModLabel" 
                                 runat="server"><%# Eval("ModifiedDate")%>
                            </asp:Label>
                        </td>
                    </tr>
                </ItemTemplate>

                <FooterTemplate></table></FooterTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>

