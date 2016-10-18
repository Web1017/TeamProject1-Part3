<%@ Page Title="Counter Strike" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="counterStrikePage.aspx.cs" Inherits="TeamProject1.counterStrikePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!--
    Mudrak Patel and Javid Niftaliyeve
    COMP229 Project
     -->
    <div class="counterStrikeImageDiv"></div>

    <div class="counterStrikeTextDivNew">Counter Strike Go</div>

    <div class="counterStrikeContentDiv">
        <asp:GridView ID="CounterStrikeGridView" runat="server" AutoGenerateColumns="false"
            CssClass="CounterStrikeGridView" DataKeyNames=""
            Visible="true"
            HeaderStyle-CssClass="CS_GRID_HEADER">
            <Columns>
                <asp:BoundField DataField="WEEK_NUMBER" HeaderText="WEEK" Visible="true" ItemStyle-CssClass="CS_WEEK_NUMBER" />
                <asp:BoundField DataField="TEAM_1_ID" HeaderText="TEAM 1" Visible="true" ItemStyle-CssClass="CS_TEAM_1_ID" />
                <asp:BoundField DataField="TEAM_1_Score" HeaderText="TEAM 1 SCORE" Visible="true" ItemStyle-CssClass="CS_TEAM_1_Score" />
                <asp:BoundField DataField="TEAM_2_Score" HeaderText="TEAM 2 SCORE" Visible="true" ItemStyle-CssClass="CS_TEAM_2_Score" />
                <asp:BoundField DataField="TEAM_2_ID" HeaderText="TEAM 2" Visible="true" ItemStyle-CssClass="TEAM_2_ID" />
            </Columns>
        </asp:GridView>

    </div>

    <div class="counterStrikeTextDiv">Counter Strike Go</div>

</asp:Content>
