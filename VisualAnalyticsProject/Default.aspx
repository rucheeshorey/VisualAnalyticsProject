<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" MasterPageFile="~/MasterPage.Master" Inherits="_Default" %>

<asp:Content runat="server" ContentPlaceHolderID="head">
    <link rel="stylesheet" href="Stylesheets/main.css" />
    <script type="text/javascript" src="Scripts/main.js"></script>
    <script src="Scripts/jquery.modal.min.js" type="text/javascript" charset="utf-8"></script>
    <link rel="stylesheet" href="Stylesheets/jquery.modal.min.css" type="text/css" media="screen" />
</asp:Content>

<asp:Content runat="server" ContentPlaceHolderID="PageContent">
    <div id="content">
        <div class="section" id="burgersection">
            <div class="subsectionheading" id="burgersubsectionheading">Burgers</div>
            <div runat="server" class="subsection" id="burgersubsection"></div>
        </div>
        <div class="section" id="drinksection">
            <div class="subsectionheading" id="drinksubsectionheading">Drinks</div>
            <div runat="server" class="subsection" id="drinksubsection"></div>
        </div>
        <div class="section" id="sidesection">
            <div class="subsectionheading" id="sidesubsectionheading">Sides</div>
            <div runat="server" class="subsection" id="sidesubsection"></div>
        </div>
         <div class="section" id="dessertsection">
            <div class="subsectionheading" id="dessertsubsectionheading">Desserts</div>
            <div runat="server" class="subsection" id="dessertsubsection"></div>
        </div>
        <div class="section" id="breakfastsection">
            <div class="subsectionheading" id="breakfastsubsectionheading">Breakfast</div>
            <div runat="server" class="subsection" id="breakfastsubsection"></div>
        </div>
         <div class="section" id="saladsection">
            <div class="subsectionheading" id="saladsubsectionheading">Salads</div>
            <div runat="server" class="subsection" id="saladsubsection"></div>
        </div>
    </div>
</asp:Content>