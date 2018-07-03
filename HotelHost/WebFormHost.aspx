<%@ Page Title="Host Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormHost.aspx.cs" Inherits="HotelBase.WebFormHost" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <script type="text/javascript">
        function btnOpenClick(x) {
            console.log(x)
        }
    </script>
    <asp:Panel runat="server" ID="pnlBody">

        <div>
            <asp:DropDownList runat="server" ID="ddlFloors" AppendDataBoundItems="true" CssClass="form-control" Style="margin: 0 auto;" AutoPostBack="True" OnSelectedIndexChanged="ddlFloors_SelectedIndexChanged">
                <asp:ListItem Text="-Scegliere Piano-" />
            </asp:DropDownList>
        </div>

        <asp:Repeater runat="server" ID="rpt" OnItemDataBound="rpt_ItemDataBound">
            <HeaderTemplate>
                <br />
            </HeaderTemplate>
            <ItemTemplate>
                <div class="row">
                    <div>
                        <asp:Label runat="server" ID="lblRoom" Text='<%# "Camera " + Eval("ID") %>'></asp:Label>
                    </div>
                    <div>
                        <asp:Label runat="server" ID="lblTemp">Temperatura</asp:Label>
                        <asp:TextBox runat="server" ID="txtTemp" Text='<%# Eval("Temperatura") %>'></asp:TextBox>
                        <asp:Button runat="server" ID="btnSetTemp" CssClass="btn" OnClick="btnSetTemp_Click" Text="Setta" />
                    </div>
                    <div>
                        <asp:Button runat="server" ID="btnOpen" CssClass="btn" OnClick="btnOpen_Click" Text='<%# (bool.Parse(Eval("Porta").ToString()) == true) ? "Chiudi porta" : "Apri Porta" %>' />
                    </div>
                </div>
            </ItemTemplate>
            <SeparatorTemplate>
                <br />
            </SeparatorTemplate>
        </asp:Repeater>
    </asp:Panel>
</asp:Content>
