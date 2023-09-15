<%@ Page Title="" Language="C#" MasterPageFile="~/shop.Master" AutoEventWireup="true" CodeBehind="dettagli.aspx.cs" Inherits="progetto2.dettagli" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="text-center">
    <asp:Image ID="Image1" runat="server"  CssClass="img-dettaglio" />

    </div>
 <div>
    <h2 id="nomeProdotto" runat="server" class=" m-0 text-center  fs-1 "></h2>
    <p id="descrizione" class="  ms-2  text-center" runat="server"> </p>
     <div class="text-center">
         <asp:Button ID="Button1" CssClass="btn btn-dark " runat="server" Text="aggiungi al carello" OnClick="Button1_Click" />
     </div>

 </div>
</asp:Content>
