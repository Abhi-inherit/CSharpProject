
function PopupShow(cntrl, Caption) {
    currentDiv = cntrl;
    //alert('Popup  function: ' + Caption);
    $("#" + cntrl).fadeIn(0500); // fadein popup div
    $("#backgroundPopup").css("opacity", "0.7"); // css opacity, supports IE7, IE8
    $("#backgroundPopup").fadeIn(0001);
   // $("#content").show();
    $("#" + cntrl).show();
    ///$("#content").show();
    $("#wrapper").show();
    $("#popup_content").show();
    $("#PopupCaption").text(Caption);
    //$("#CurrentDiv").text("2");
    // GetUploaderandWebSites();
    // SlideClick();


}
function PopupShowAlert(cntrl, Caption) {
    currentDiv = cntrl;
    //alert('Popup  function: ' + Caption);
    $("#" + cntrl).fadeIn(0500); // fadein popup div
    $("#backgroundPopup").css("opacity", "0.7"); // css opacity, supports IE7, IE8
    $("#backgroundPopup").fadeIn(0001);
    // $("#content").show();
    $("#" + cntrl).show();
    ///$("#content").show();
    $("#wrapper").show();
    $("#popup_content").show();
    $("#divHeaderContent").text(Caption);
    //$("#CurrentDiv").text("2");
    // GetUploaderandWebSites();
    // SlideClick();


}
function disablePopup(cntrl) {
    {
        $("#" + cntrl).fadeOut("normal");
        $("#backgroundPopup").fadeOut("normal");

        // $("#popup_content").hide();
        $("#container").show();
    }
}

function ShowMessage(Message) {
    //alert(Message);
    var childs = $("#MessageContainer div").length;
    //alert(childs);
    var id = childs + 1;
    var ele = "div" + id;
    var Msg = "";
    Msg += "<div class='Message' id='" + ele + "' style='display:none;'>";
    Msg += Message + "</div>";
    //alert(Msg);
    $("#MessageContainer").append(Msg);
    $("#" + ele).fadeIn(1500);

    // $("#" + ele).animate({ width: "100%" });

    setTimeout(function () {
        // alert('fired');
        HideMessage(ele);
    }, 5000);
}
function HideMessage(cntrl) {

    // $("#" + cntrl).animate({ width: "0%" });
    $("#" + cntrl).fadeOut(1500);
    setTimeout(function () {
        $("#" + cntrl).remove();
    }, 1550);

}

function ShowError(cntrl, error) {
    $("#" + cntrl).text(error);
    $("#" + cntrl).fadeIn(0800);
    setTimeout(function () {
        // alert('fired');
        $("#" + cntrl).fadeOut(0800);
    }, 5000);
}

function ClosePopUp() {
    disablePopup('PopUp');

    //$("#lblId").attr("value", "-1");
}
function ClosePopUpDiv(cntrl) {
    disablePopup(cntrl);

    //$("#lblId").attr("value", "-1");
}

function getUrlVars() {

    var vars = [], hash;
    var hashes = window.location.href.slice(window.location.href.indexOf('?') + 1).split('&');
    for (var i = 0; i < hashes.length; i++) {
        hash = hashes[i].split('=');
        vars.push(hash[0]);
        vars[hash[0]] = hash[1];
    }
    return vars;

    //var returl = getUrlVars()["RetUrl"];
}