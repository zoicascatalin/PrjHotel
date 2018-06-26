<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Login.aspx.cs" Inherits="HotelHost.Login" %>


<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <style type="text/css" media="screen">
        .txtLogin {
            float: right;
            width: 70%;
            border: 1px solid #ccc;
            height: 40px;
        }

        .lblLogin {
            float: left;
            line-height: 40px;
            width: 30%;
        }
        .checked{
            background:url('~/img/checked.png') no-repeat;
            height: 16px;
            width: 16px;
            display:inline-block;
            padding: 0 0 0 0px;
        }

        .unchecked{
            background:url('~/img/unchecked.png') no-repeat;
            height: 16px;
            width: 16px;
            display:inline-block;
            padding: 0 0 0 0px;
        }
    </style>
    <script type="text/javascript">
        $('#checkRememberUsername').prop('checked', true);
        $('#checkStayLogged').prop('checked', true);
        var checkRU = $("#checkRememberUsername:checked").length;
        if (checkRU) {
            $("#checkRememberUsername").addClass("checked");
        } else {
            $("#checkRememberUsername").addClass("unchecked");
        }
        var checkLog = $("#checkStayLogged:checked").length;
        if (checkLog) {
            $("#checkStayLogged").addClass("checked");
        } else {
            $("#checkStayLogged").addClass("unchecked");
        }
    </script>
    <asp:Panel runat="server" ID="pnlBody" Style="text-align: center;">
        <div style="width: 30%; margin-left: 35%;">
            <div style="width: 100%; height: 40px; margin-bottom: 5px; float: left;">
                <asp:Label runat="server" ID="lblUsername" CssClass="lblLogin"></asp:Label>
                <asp:TextBox runat="server" ID="txtUsername" CssClass="txtLogin form-control"></asp:TextBox>
            </div>
            <div style="width: 100%; height: 40px; margin-bottom: 5px; float: left;">
                <asp:Label runat="server" ID="lblPassword" CssClass="lblLogin"></asp:Label>
                <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" CssClass="txtLogin form-control"></asp:TextBox>
            </div>
            <div>
                <asp:CheckBox runat="server" ID="checkRememberUsername" /><br />
                <asp:CheckBox runat="server" ID="checkStayLogged" />
            </div>
            <div>
                <asp:Button runat="server" ID="btnConfirm" OnClick="btnConfirm_Click" CssClass="btn btn-secondary" />
            </div>
            <asp:Label runat="server" ID="lblWrongData"></asp:Label>
        </div>
    </asp:Panel>

</asp:Content>

