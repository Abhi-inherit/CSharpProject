function Register()
{

    if (Validate())
    {
        var Registration = {};
        Registration.Name = $("#Txt_Name").val();
        Registration.Email = $("#Txt_Email").val();
        Registration.PhoneNumber = $("#Txt_PhoneNo").val();
        Registration.Website = $("#Txt_Website").val();
        Registration.Password = $("#Txt_Password").val();
        Registration.ConfirmPassword = $("#Txt_Confirm_Password").val();

        var _data = { "userDetails": Registration };
        $.ajax
            ({
                type: "POST",
                url: 'UserRegistration.aspx/Register',
                data: JSON.stringify(_data),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: SetTabSessionValueSucceed,
                error: SetTabSessionValueFailed
            });
    }
    
}

function Login()
{
    if (Validate())
    {
        var varUserName = $("#Txt_Email").val();
        var varPassword = $("#Txt_Password").val();
       
        $.ajax
        ({
            type: "POST",
            url: "UserLogin.aspx/Login",
            data: "{'userName':'" + varUserName + "','password':'" + varPassword + "'}",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: SetTabLoginSucceed,
            error: SetTabSessionValueFailed
        });
    }
}

function SetTabSessionValueSucceed(result)
    {
    alert("LoginInformation : " + result.d.Name);
    alert("LoginInformation : " + result.d.Email);
    alert("LoginInformation : " + result.d.PhoneNumber);
    alert("LoginInformation : " + result.d.Website);
    alert("LoginInformation : " + result.d.Password);
    alert("LoginInformation : " + result.d.ConfirmPassword);
    }

function SetTabLoginSucceed(r)
    {
    alert(r.d);
    }

function SetTabSessionValueFailed()
    {
        alert('Login failed');
    }

function Validate() 
{
    var eles = $("#loginDiv input[type='text']");

    var eles = $("#RegisterPage input[type='text']");

    var Error = true;
 
    for (var i = 0; i < eles.length; i++) 
    {
        var id = $(eles[i]).attr("id");
        if ($("#Val" + id).length > 0) 
        {
            if ($(eles[i]).val() == "") 
            {
                document.getElementById("Val" + id).style.display = "block";
                $("#Val" + id).css("color", "Red");
                $("#" + id).focus();
                Error = false;
                return;
            }
        }
    }

    

    return Error;

}

/////
////
///
//

//WebService Call One Arragument
//function serviceCall() {
//    $.ajax({
//        type: "POST",
//        url: 'ServiceSample.asmx/TestMethod',
//        data: "{'data':'This is static data from the JavaScript file'}",
//        contentType: "application/json; charset=utf-8",
//        dataType: "json",
//        success: function (msg) {
//            $("#divResult").html(msg.d);
//        },
//        error: function (e) {
//            $("#divResult").html("WebSerivce unreachable");
//        }
//    });
//}

//function SampleLogin() {
//    if (Validate()) {
//        var varUserName = $("#txtName").val();
//        var varPassword = $("#Txtpassword").val();


//        $.ajax({
//            type: "POST",
//            url: 'ServiceSample.asmx/Login',
//            data: "{'Username':'" + varUserName + "','Password':'" + varPassword + "'}",
//            contentType: "application/json; charset=utf-8",
//            dataType: "json",
//            success: function (result) { alert(result) },
//            error: {}
//        });
//    }
//}