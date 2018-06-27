<%@ Page Title="Guest Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"  CodeBehind="WebFormGuest.aspx.cs" Inherits="HotelBase.WebFormGuest"  %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">

    <style type="text/css" media="screen">
  
        .CenterRow{
            justify-content:center;
            text-align:center;
            
        }
    </style>

<div class="container" >
        <div class="row CenterRow" >
            <div class="col-lg-6 col-lg-offset-3 text-center">
                <div class="row">
                    <div class="col-md-6">
                        <h4>Piano : </h4>
                    </div>
                    <div class="col-md-6" id="pianoNumber" runat="server">
                        ****
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-6">
                        <h4>Camera : </h4>
                    </div>
                    <div class="col-md-6" id="cameraNumber" runat="server">
                        ****
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-6">
                        <h4>Temperatura : </h4>
                    </div>
                    <div class="col-md-6" id="setTemperatura">
                        <div class="input-group">
                       
                        <input type="text" class="form-control" placeholder="0.00°C" aria-describedby="basic-addon1" runat="server" id="tempControl">
                        </div>
                    </div>
                    
                </div>
                <br>
                <div class="row CenterRow">
                     <div class="col-md-6 col-md-offset-3" id="setPorta">
                        <div class="btn-group" role="group" >
                            <asp:Button runat="server" ID="btnOpen" class="btn btn-success" Text="Apri Porta" OnClick="btnOpen_Click"/>
                            <asp:Button runat="server" ID="btnClose" class="btn btn-danger" Text="Chiudi Porta" OnClick="btnClose_Click"/>
<%--                            
                        </div>
                    </div>
                </div>
            </div>
        </div>
    
</div>
<%--<form id="form1" runat="server">
<asp:Login ID = "Login1" runat = "server" OnAuthenticate= "ValidateUser"></asp:Login>
</form>--%>

</asp:Content>


