<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentInput.aspx.cs" Inherits="WebApplication1.StudentInput" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Student input information</title>
</head>
    <style type="text/css">
        label {
            margin-right: 30px;
            width: 25%;
        }
        .main{
            width: 50%;
        }
        .infor {
            display: flex;            
            
        }
        .infor label {
            float: left;
        }
    </style>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <div class="main">
            <h2>Student infor</h2>
            <div class="infor">
                <label>Name</label>                
                    <input type="text" name="name" />                              
            </div>
            <div class="infor">
                <label class="infor">Age</label>
                    <input type="text" name="age" />         
            </div>
            <div class="infor">
                <label>Gender</label>
                <div class="infor-input">
                    <div><input type="radio" name="gender" value="male"/>Male</div>
                    <div><input type="radio" name="gender" value="female"/>Female</div>
                </div>
                
            </div>
            <div class="infor">
                <label>Favourite</label>
                <div class="infor-input">
                    <div>
                        <input type="checkbox" name="football" />Football
                    </div>
                    <div>
                        <input type="checkbox" name="swim" />Swim
                    </div>
                    <div>
                        <input type="checkbox" name="basketball" />Basket ball
                    </div>
                </div>                              
            </div>
        </div>
    </form>
</body>
</html>
