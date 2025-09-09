<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ExpenseTracker.aspx.cs" MasterPageFile="~/TrackerMaster.master" Inherits="ExpenseTracker" %>

    <asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="container-fluid text-center">    
  <div class="row content">
    <div class="col-sm-2 sidenav">   
    </div>
    <div class="col-sm-8 text-left"> 
        <br/>
     <div class="panel panel-primary">
         <div class="panel-heading">LOGIN</div>
  <div class="panel-body">
      <div class="row">
          <div class="col-md-4">
              <div class="form-group">
                  <label>Username:</label>
                  <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
              </div>
          </div>
            <div class="col-md-4">
              <div class="form-group">
                  <label>Password:</label>
                  <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>              
              </div>
          </div>
      </div>
      <div class="row">
           <div class="col-md-4">
              <div class="form-group">
                  <asp:Button ID="btnlogin" CssClass="btn btn-success btn-lg" runat="server" Text="LOGIN" OnClick="btnlogin_Click" />
              </div>
               </div>
      </div>
  </div>
</div>
    </div>
    <div class="col-sm-2 sidenav">    
    </div>
  </div>
</div>
</asp:Content>
    
    
 
   

