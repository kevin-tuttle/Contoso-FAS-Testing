<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Contoso_FAS_Web._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <div class="col-md-8">
        <form action="Default.aspx" method="GET">
            <fieldset>

                <!-- Form Name -->
                <legend>Contoso Finance Approval System</legend>

                <!-- Text input-->
                <div class="form-group">
                    <div class="col-md-4">
                        <label class="control-label" for="firstName">First Name</label>
                    </div>
                    <div class="col-md-4">
                        <input id="firstName" name="firstName" type="text" value="Kevin" class="form-control input-md">
                    </div>
                </div>
                <br/><br/>

                <!-- Text input-->
                <div class="form-group">
                    <div class="col-md-4">
                        <label class="control-label" for="lastName">Last Name</label>
                    </div>
                    <div class="col-md-4">
                        <input id="lastName" name="lastName" type="text" value="Tuttle" class="form-control input-md">
                    </div>
                </div>
                <br/><br/>

                <!-- Text input-->
                <div class="form-group">
                    <div class="col-md-4">
                        <label class="control-label" for="email">Email</label>
                    </div>
                    <div class="col-md-4">
                        <input id="email" name="email" type="text" value="ktuttle@ivision.com" class="form-control input-md">
                    </div>
                </div>
                <br/><br/>

                <!-- Button (Double) -->
                <div class="form-group">
                    <div class="col-md-8">
                        <button id="submit" name="submit" class="btn btn-success">Submit</button>
                        <button id="Cancel" name="Cancel" class="btn btn-danger">Cancel</button>
                    </div>
                </div>
                
                <div id="postResult" runat="server"></div>
            </fieldset>
        </form>
    </div>

</asp:Content>
