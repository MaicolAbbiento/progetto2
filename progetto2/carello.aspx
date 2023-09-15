<%@ Page EnableEventValidation="false" Title="" Language="C#" MasterPageFile="~/shop.Master" AutoEventWireup="true" CodeBehind="carello.aspx.cs" Inherits="progetto2.carello"  %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="row">
    <asp:Repeater ID="Repeater1" runat="server" ItemType="progetto2.Carrello">
        <ItemTemplate>
            <div class="col-md-4 mt-5">
    
                <div class="card" style="width: 18rem; height:660px">
                    <img src="Content/img/<%# Item.foto %>" class="card-img-top" alt="...">
                    <div class="card-body">
                        <h5 class="card-title"><strong><%# Item.Name%></strong></h5>
                        <p class="card-text"><%# Item.Description%></p>
                        <asp:Button ID="Button1" runat="server" Text="elimina elemento" CssClass="btn-danger btn"  OnClick ="Button1_Click" CommandArgument='<%# Item.id %> '/>
                    </div>
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>

    </div>
    <asp:Button ID="Button1" runat="server" Text="svuota carello" CssClass="btn-danger btn"  OnClick ="Button1_Click2"/>
    <p id="totale" runat="server" > </p>

</asp:Content>
