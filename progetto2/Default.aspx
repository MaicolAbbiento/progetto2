<%@ Page Title="" Language="C#" MasterPageFile="~/shop.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="progetto2.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <asp:Repeater ID="Repeater1" runat="server" ItemType="progetto2.Carrello">
                   <ItemTemplate>
                       <div class="col-md-4 mt-5">
                           <div style="width:50%">
                               <img src="Content/img/<%# Item.foto %>"/>
                           </div>
                           <p><strong><%# Item.Name%></strong> <strong><%# Item.Name %></strong></p>
                         <a class="btn btn-success" href="dettagli.aspx?id=<%# Item.id %>">dettagli</a>
                       </div>
                   </ItemTemplate>
               </asp:Repeater>
</asp:Content>
