<%@ Page EnableEventValidation="false" Title="" Language="C#" MasterPageFile="~/shop.Master" AutoEventWireup="true" CodeBehind="carello.aspx.cs" Inherits="progetto2.carello"  %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Repeater ID="Repeater1" runat="server" ItemType="progetto2.Carrello">
        <ItemTemplate>


            <div class="d-flex justify-content-evenly bg-white align-items-center">
                <img src="Content/img/<%# Item.foto %>" class="img-elimina" alt="...">
                <h5 class="card-title"><strong><%# Item.Name%></strong></h5>


                <asp:Button ID="Button1" runat="server" Text="elimina elemento" CssClass="btn-danger btn" OnClick="Button1_Click" CommandArgument='<%# Item.id %> ' />

            </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>


    <asp:Button ID="Button1" runat="server" Text="svuota carello" CssClass="btn-danger btn mt-2"  OnClick ="Button1_Click2"/>
    <p id="totale" runat="server" > </p>

</asp:Content>
