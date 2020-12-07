<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ebarker1730ex2h._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <div class="row">
        <div class="col-md-6">
            <h2>datetime methods</h2>
            <div class="form-group">
              <asp:Label ID="Label1" runat="server" Text="1) datetime.now:"></asp:Label>
              <asp:TextBox ID="TextBox1aResult" runat="server" Enabled="False"></asp:TextBox>
              <asp:TextBox ID="TextBox1bResult" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
              <asp:Label ID="Label2" runat="server" Text="2) datetime.today:"></asp:Label>
              <asp:TextBox ID="TextBox2aResult" runat="server" Enabled="False"></asp:TextBox>
              <asp:TextBox ID="TextBox2bResult" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
              <asp:Label ID="Label3" runat="server" Text="3) datetime.today:"></asp:Label>
              <asp:TextBox ID="TextBox3aResult" runat="server" Enabled="False" Width="40px"></asp:TextBox>
              <asp:TextBox ID="TextBox3bResult" runat="server" Enabled="False" Width="30px"></asp:TextBox>
              <asp:TextBox ID="TextBox3cResult" runat="server" Enabled="False" Width="30px"></asp:TextBox>
            </div>
            <div class="form-group">
              <asp:Label ID="Label4" runat="server" Text="4) datetime.adddays():"></asp:Label>
              <asp:TextBox ID="TextBox4Result" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
              <asp:Label ID="Label5" runat="server" Text="5) datetime.addmonths():"></asp:Label>
              <asp:TextBox ID="TextBox5Result" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
              <asp:Label ID="Label6" runat="server" Text="6) datetime(y, m, d):"></asp:Label>
              <asp:TextBox ID="TextBox6a" runat="server" Width="40px">2019</asp:TextBox>
              <asp:TextBox ID="TextBox6b" runat="server" Width="30px">4</asp:TextBox>
              <asp:TextBox ID="TextBox6c" runat="server" Width="30px">27</asp:TextBox>
              <asp:TextBox ID="TextBox6Result" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
              <asp:Label ID="Label7" runat="server" Text="7) datetime.parse():"></asp:Label>
              <asp:TextBox ID="TextBox7" runat="server">April 27, 2019</asp:TextBox>
              <asp:TextBox ID="TextBox7Result" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
              <asp:Label ID="Label8" runat="server" Text="8) datetime.tryparse():"></asp:Label>
              <asp:TextBox ID="TextBox8" runat="server">April 27, 2019</asp:TextBox>
              <asp:TextBox ID="TextBox8Result" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
              <asp:Label ID="Label9" runat="server" Text="9) dateA - dateB:"></asp:Label>
              <asp:TextBox ID="TextBox9a" runat="server" Width="80px">1/13/2013</asp:TextBox>
              <asp:TextBox ID="TextBox9b" runat="server" Width="80px">12/12/2012</asp:TextBox>
              <asp:TextBox ID="TextBox9Result" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
              <asp:Label ID="Label10" runat="server" Text="10) dateA &gt; dateB"></asp:Label>
              <asp:TextBox ID="TextBox10a" runat="server" Width="80px">1/13/2013</asp:TextBox>
              <asp:TextBox ID="TextBox10b" runat="server" Width="80px">12/12/2012</asp:TextBox>
              <asp:TextBox ID="TextBox10Result" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Button ID="datecalculationsButton" runat="server" Text="date calculations" OnClick="datecalculationsButton_Click" />
            </div>
        </div>
        <div class="col-md-6">
            <h2>string methods</h2>
            <div class="form-group">
              <asp:Label ID="Label11" runat="server" Text="1) remove/insert:"></asp:Label>
              <asp:TextBox ID="TextBox11" runat="server">late</asp:TextBox>
              <asp:TextBox ID="TextBox11Result" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
              <asp:Label ID="Label12" runat="server" Text="2) remove/insert:"></asp:Label>
              <asp:TextBox ID="TextBox12" runat="server">cater</asp:TextBox>
              <asp:TextBox ID="TextBox12Result" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
              <asp:Label ID="Label13" runat="server" Text="3) substring/to upper:"></asp:Label>
              <asp:TextBox ID="TextBox13" runat="server">ABBlue22</asp:TextBox>
              <asp:TextBox ID="TextBox13Result" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
              <asp:Label ID="Label14" runat="server" Text="4) padleft:"></asp:Label>
              <asp:TextBox ID="TextBox14" runat="server">123.45</asp:TextBox>
              <asp:TextBox ID="TextBox14Result" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
              <asp:Label ID="Label15" runat="server" Text="5) replace:"></asp:Label>
              <asp:TextBox ID="TextBox15" runat="server">(651) 385-6300</asp:TextBox>
              <asp:TextBox ID="TextBox15Result" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
              <asp:Label ID="Label16" runat="server" Text="6) replace/length/insert:"></asp:Label>
              <asp:TextBox ID="TextBox16" runat="server">(651) 385-6300</asp:TextBox>
              <asp:TextBox ID="TextBox16Result" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
              <asp:Label ID="Label17" runat="server" Text="7) to lower/contains:"></asp:Label>
              <asp:TextBox ID="TextBox17" runat="server">308 Pioneer Rd</asp:TextBox>
              <asp:TextBox ID="TextBox17Result" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
              <asp:Label ID="Label18" runat="server" Text="8) indexof/substring:"></asp:Label>
              <asp:TextBox ID="TextBox18" runat="server" Width="171px">1250 Homer Rd, Winona</asp:TextBox>
              <asp:TextBox ID="TextBox18Result" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
              <asp:Label ID="Label19" runat="server" Text="9) lastindexof/substring:"></asp:Label>
              <asp:TextBox ID="TextBox19" runat="server" Width="211px">111 1st St, Lake City, MN 55041</asp:TextBox>
              <asp:TextBox ID="TextBox19Result" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div class="form-group">
              <asp:Label ID="Label20" runat="server" Text="10) stringbuilder.append:"></asp:Label>
              <asp:Label ID="Label20Result" runat="server"></asp:Label>
            </div>
            <div class="form-group">
                <asp:Button ID="Button1" runat="server" OnClick="StringCalculationButton_Click" Text="string calculations" />
            </div>
        </div>
        </div>

</asp:Content>
