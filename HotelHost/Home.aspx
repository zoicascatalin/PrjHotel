<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="HotelBase.Home" %>


<asp:Content ContentPlaceHolderID="MainContent" runat="server">

    <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel">
        <ol class="carousel-indicators">
            <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
            <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
            <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
        </ol>
        <div class="carousel-inner">
            <div class="carousel-item active">
                <img class="d-block w-100" src="/img/hot1.jpg" style="height:100%;">
                <asp:Button runat="server" ID="btnBooking1" OnClick="btnBooking_Click" class="btn btn-warning myBtn" />
                <div class="carousel-caption d-none d-md-block">
                    <h5>FIRST</h5>
                    <p>First</p>
                </div>
            </div>
            <div class="carousel-item">
                <img class="d-block w-100" src="/img/hot2.jpg" style="height:100%;">
                <asp:Button runat="server" ID="btnBooking2" OnClick="btnBooking_Click" class="btn btn-warning myBtn" />
                <div class="carousel-caption d-none d-md-block">
                    <h5>SECOND</h5>
                    <p>Second</p>
                </div>
            </div>
            <div class="carousel-item">
                <img class="d-block w-100" src="/img/hot3.jpg" style="height:100%;">
                <asp:Button runat="server" ID="btnBooking3" OnClick="btnBooking_Click" class="btn btn-warning myBtn" />
                <div class="carousel-caption d-none d-md-block">
                    <h5>THIRD</h5>
                    <p>Third</p>
                </div>
            </div>
        </div>
        <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
            <span class="sr-only">Previous</span>
        </a>
        <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
            <span class="carousel-control-next-icon" aria-hidden="true"></span>
            <span class="sr-only">Next</span>
        </a>
    </div>


</asp:Content>
