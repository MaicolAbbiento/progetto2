<%@ Page Title="" Language="C#" MasterPageFile="~/shop.Master" AutoEventWireup="true" CodeBehind="dettagli.aspx.cs" Inherits="progetto2.dettagli" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p id="nomeProdotto" runat="server"> </p>
    <asp:Button ID="Button1" CssClass="btn btn-dark" runat="server" Text="aggiungi al carello" OnClick="Button1_Click" />
    
</asp:Content>
