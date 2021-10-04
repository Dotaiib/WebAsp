<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<!--Mobile Version Meta-->
<meta name="viewport" content="width=device-width" />

<link rel="stylesheet" href="Content/bootstrap.css">
<link rel="stylesheet" href="Content/bootstrap.min.css">

<script src="Scripts/bootstrap.js"></script>
<script src="Scripts/bootstrap.js"></script>
<script src="Scripts/jquery-3.3.1.js"></script>
<script src="Scripts/jquery-3.3.1.min.js"></script>



    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <div class="form-group">

            <label for="exampleInputEmail1">Full T</label>
            <asp:TextBox ID="TextBox1" runat="server" class="form-control" OnTextChanged="TextBox1_TextChanged" AutoPostBack="True"></asp:TextBox> </br>
            <label for="exampleInputEmail1">Article</label>
            <asp:TextBox ID="TextBox2" runat="server" class="form-control"></asp:TextBox> <br />
            <label for="exampleInputEmail1">Lot</label>
            <asp:TextBox ID="TextBox3" runat="server" class="form-control"></asp:TextBox> <br />
            <label for="exampleInputEmail1">N°P</label>
            <asp:TextBox ID="TextBox4" runat="server" class="form-control"></asp:TextBox> <br />
            <label for="exampleInputEmail1">Quantité</label>
            <asp:TextBox ID="TextBox5" runat="server" class="form-control"></asp:TextBox> <br />
            <label for="exampleInputEmail1">Allee</label>
            <asp:TextBox ID="TextBox6" runat="server" class="form-control"></asp:TextBox> <br />
            <label for="exampleInputEmail1">Travee</label>
            <asp:TextBox ID="TextBox7" runat="server" class="form-control"></asp:TextBox> <br />
            <label for="exampleInputEmail1">Niveau</label>
            <asp:TextBox ID="TextBox8" runat="server" class="form-control"></asp:TextBox> <br />

            <asp:Button class="btn btn-default" ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" /> &nbsp;&nbsp;
            <asp:Button class="btn btn-default" ID="Button2" runat="server" Text="Reset" OnClick="Button2_Click" /> <br /><br />


        </div>
    </form>

    <script type="text/javascript">
    $(document).bind("contextmenu",function(e) {
  e.preventDefault();
    });
    </script>
</body>
</html>
