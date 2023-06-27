

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="demo.aspx.cs" Inherits="WebApplication2.CPANEL.demo" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Timetable Generator</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Timetable Generator</h1>
            <asp:Button ID="btnGenerate" runat="server" Text="Generate Timetable" OnClick="btnGenerate_Click"
                />
            <hr />
            <asp:GridView ID="gvTimetable" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="TimeSlot" HeaderText="Time Slot" />
                    <asp:BoundField DataField="Subject" HeaderText="Subject" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
