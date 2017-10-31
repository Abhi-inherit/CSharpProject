$(document).ready(function () {

    /* Only Alphabets*/
    $("#Name").keypress(function (e) {
        var inputVal = String.fromCharCode(e.keyCode)
        var characterReg = /["~!@#$%^*-+=`{}\[\]\|\\:;<>\/?"\t\r\n\0-9]+/g;
        if (characterReg.test(inputVal)) {
            return false;
        }
    });
    $("#Address").keypress(function (e) {
        var inputVal = String.fromCharCode(e.keyCode)
        var characterReg = /["~!@#$%^*-+=`{}\[\]\|\\:;<>\/?"\t\r\n\0-9]+/g;
        if (characterReg.test(inputVal)) {
            return false;
        }
    });
    $("#Place").keypress(function (e) {
        var inputVal = String.fromCharCode(e.keyCode)
        var characterReg = /["~!@#$%^*-+=`{}\[\]\|\\:;<>\/?"\t\r\n\0-9]+/g;
        if (characterReg.test(inputVal)) {
            return false;
        }
    });
    /* Only Numbers */
    $("#Number").keypress(function (e) {
        var inputVal = String.fromCharCode(e.keyCode)
        var characterReg = /["~!&()#$%^*=`{}\[\]\|\\:;<>\/?"\t\r\na-zA-Z." "]+/g;
        if (characterReg.test(inputVal)) {
            return false;
        }
    });
    BindPlaces();
    BindGrid();
    $("#jqxgrid").bind("pagechanged", function (event) {
        var args = event.args;
        var pagenumber = args.pagenum;
        var pagesize = args.pagesize;
        $("#jqxSubscription").val(pagenumber);

    });
});
function BindGrid() {

    var source =
          {
              datatype: "json",
              datafields: [
                  { name: 'Name', type: 'string' },
                  { name: 'Address', type: 'string' },
                  { name: 'Place', type: 'string' },
                  { name: 'Number', type: 'string' },
                  { name: 'Status', type: 'string' },
                  { name: 'Actions', type: 'string' },
                  { name: '', type: 'string' },
              ],
              id: 'Id',
              url: "/Sample/BindGrid",
          };
    var dataAdapter = new $.jqx.dataAdapter(source, {
        downloadComplete: function (data, status, xhr) { },
        loadComplete: function (data) { },
        loadError: function (xhr, status, error) { }
    });
    $("#jqxgrid").jqxGrid(
    {
        width: 980,
        source: dataAdapter,
        // theme: theme,
        pageable: true,
        autorowheight: true,
        autoheight: true,
        sortable: true,
        altrows: true,
        enabletooltips: true,
        //editable: true,Status
        enableanimations: true,
        selectionmode: 'multiplecellsadvanced',
        columns: [
          { text: 'Name', datafield: 'Name', width: 180 },
          { text: 'Address', datafield: 'Address', width: 180 },
          { text: 'Place', datafield: 'Place', width: 180 },
          { text: 'Phone NUmber', datafield: 'Number', width: 180 },
          { text: 'Status', datafield: 'Status', width: 120 },
          { text: 'Actions', datafield: 'Actions', width: 140, sortable: false, enabletooltips: false },
          { text: 'Id', datafield: 'Id', cellsalign: 'right', align: 'right', width: 10, hidden: true },
        ],
    });
}
function BindPlaces() {

    $.ajax({
        url: "/Sample/GetAllPlace",
        type: 'POST',
        dataType: 'json',
        success: function (result) {
            if (result.Result == "Error") {
                ShowMessage('Error');
            } else {
                console.log(result.Collection);
                $("#PlaceDDL").append("<option value='0'>--Select--</option>");
                for (var i = 0; i < result.Collection.length; i++) {
                    $("#PlaceDDL").append("<option value='" + result.Collection[i].Id + "'>" + result.Collection[i].Places + "</option>");
                } 
            }
        },
        error: function (result) {

        }
    });
}
function ShowInsert() {
    PopupShow('PopUpMeForMasters', 'Add New Details');

    $("#save").show();
    $("#edit").hide();
    $("#delete").hide();
    $("#lblId").attr("value", "-1");
    $("#Name").focus();
    ResetControls();
}
function ShowDelete(id) {

    $("#lblId").attr("value", id);
    PopupShow('PopUpDelete', 'Delete Details');
}
function ShowUpdate(cntrl) {
    PopupShow('PopUpMeForMasters', 'Edit ');

    var id = cntrl;
    $.ajax({
        url: "/Sample/GetById",
        type: 'POST',
        data: { "id": id },
        dataType: 'json',
        async: true,
        success: function (result) {
            if (result.Result == "Error") {
                ShowMessage('Error');
            } else {
               
                SetStatus(result.obj.Status);
                $("#Name").attr("value", result.obj.Name);
                $("#Address").attr("value", result.obj.Address);
                $("#PlaceDDL").attr("value", result.obj.PlaceID);
                $("#Number").attr("value", result.obj.Number);
            }
        },
        error: function (result) {

        }
    });
    $("#lblId").attr("value", id);
    $("#save").hide();
    $("#edit").show();
    $("#delete").hide();
    $("#Name").focus();
}
function ResetControls() {
    $("#Name").attr("value", "");
    $("#Address").attr("value", "");
    $("#PlaceDDL").attr("value", "0");
    $("#Number").attr("value", "");
    $("#ValName").fadeOut(500);
    $("#ValAddress").fadeOut(500);
    $("#ValPlace").fadeOut(500);
    $("#ValNumber").fadeOut(500);
    $("#PopMessage").fadeOut(500);
}
function Validate() {
    var eles = $("#PopUpMeForMasters input[type='text']");
    var selects = $("#PopUpMeForMasters select");
    var Error = true;
    for (var i = 0; i < eles.length; i++) {
        var id = $(eles[i]).attr("id");
        if ($("#Val" + id).length > 0) {
            if ($(eles[i]).attr("value") == "") {
                $("#Val" + id).text("* Required");
                $("#Val" + id).fadeIn(1000);

                Error = false;
            }
            else {
                $("#Val" + id).fadeOut(1000);
            }
        }
    }
    for (var i = 0; i < selects.length; i++) {
        var id = $(selects[i]).attr("id");
        if ($("#Val" + id).length > 0) {
            if ($(selects[i]).attr("value") == "0") {
                $("#Val" + id).fadeIn(1000);
                Error = false;
            }
            else {
                $("#Val" + id).fadeOut(1000);
            }
        }
    }
    return Error;
}
function SetStatus(value) {
    if (value == "A") {
        $("#IsActive").prop("checked", true);
    }
    else {
        $("#IsActive").prop("checked", false);
    }
}
function GetStatus() {
    var status = "Active";
    if ($("#IsActive").is(':checked')) {
        status = "A";
    }
    else {
        status = "B";
    }
    return status;
}
/* Insert */
function DoInsert() {
    if (Validate()) {

        var User = {};
        User["Name"] = $("#Name").val();
        User["Address"] = $("#Address").val();
        User["PlaceID"] = $("#PlaceDDL").val();      
        User["Number"] = $("#Number").val();
        User["Status"] = GetStatus();
      
        $.ajax({
            type: "POST",
            contentType: "application/json; charset=utf-8",
            url: "/Sample/DoInsert",
            data: JSON.stringify(User),
            dataType: "json",
            async: true,
            success: function (result) {

                if (result.Result == "Success") {

                    disablePopup('PopUpMeForMasters');
                    ResetControls();
                    BindGrid();

                    var n = $('#custom_container').noty({ text: 'Registration Details Inserted Successfully !' }); n.setType('success');
                    //var n = noty({ text: 'Subscription Details Inserted Successfully !' });
                    //var n = $('#custom_container').noty({text: 'Subscription Details Inserted Successfully !' });
                    //ShowMessage("Subscription Details Inserted Successfully")

                } else if (result.Result == "Error") {
                    ResetControls();
                    BindGrid();
                    disablePopup('PopUpMeForMasters');
                    var n = $('#custom_container').noty({ text: 'This Registration already exists !' }); n.setType('error');
                    // ShowMessage('Error');
                }
                else if (result.Result == "Already") {
                    ResetControls();
                    BindGrid();
                    disablePopup('PopUpMeForMasters');
                    var n = $('#custom_container').noty({ text: 'This Registration already exists !' }); n.setType('information');
                    // ShowError('PopMessage', 'This Subscription already exists');
                }
            },
            error: function (result) {

            }
        });
    }

}

/* Update */
function DoUpdate() {

    if (Validate()) {

        $("#lblId").attr("value", id);
        var User = {};
        User["Id"] = $("#lblId").val();
        User["Name"] = $("#Name").val();
        User["Address"] = $("#Address").val();
        User["PlaceID"] = $("#PlaceDDL").val();
        User["Number"] = $("#Number").val();
        User["Status"] = GetStatus();

        $.ajax({
            type: "POST",
            contentType: "application/json; charset=utf-8",
            url: "/Sample/DoUpdate",
            data: JSON.stringify(User),
            dataType: "json",
            success: function (result) {

                if (result.Result == "Success") {
                    $("#lblId").attr("value", "-1");
                    disablePopup('PopUpMeForMasters');
                    ResetControls();
                    BindGrid();
                    $("#jqxgrid").jqxGrid('gotopage', $("#jqxSample").val());

                    var n = $('#custom_container').noty({ text: 'Details Updated Successfully !' }); n.setType('success');
                   // ShowMessage("Details Updated Successfully !");
                } else if (result.Result == "Error") {
                    disablePopup('PopUpMeForMasters');
                    ResetControls();
                    BindGrid();
                    var n = $('#custom_container').noty({ text: 'This Details already exists !' }); n.setType('error');
                    //ShowMessage('Error');
                }
                else if (result.Result == "Already") {
                    disablePopup('PopUpMeForMasters');
                    ResetControls();
                    BindGrid();
                    var n = $('#custom_container').noty({ text: 'This Details already exists !' }); n.setType('information');
                    //ShowError('PopMessage', 'This Subscription ' + $("#Name").val() + '  already exists');
                }
            },
            error: function (result) {

            }
        });
    }
    else {
        ResetControls();
    }
}

/* Delete */
function DoDelete() {

    var id = parseInt($("#lblId").val());

    var User = {};
    User["Id"] = $("#lblId").val();
    User["Name"] = $("#Name").val();
    User["Address"] = $("#Address").val();
    User["Place"] = $("#Place").val();
    User["Number"] = $("#Number").val();
    User["Status"] = GetStatus();

    $.ajax({
        type: "POST",
        contentType: "application/json; charset=utf-8",
        url: "/Sample/DoDelete",
        data: JSON.stringify(User),
        dataType: "json",
        success: function (result) {
            if (result.Result == "Success") {
                $("#lblId").attr("value", "-1");
                disablePopup('PopUpDelete');

                ResetControls();
                BindGrid();
                $("#jqxgrid").jqxGrid('gotopage', $("#jqxSample").val());

                var n = $('#custom_container').noty({ text: 'Details Deleted Successfully !' }); n.setType('success');
                //ShowMessage("Subscription Deleted Successfully");
            } else if (result.Result == "Error") {
                var n = $('#custom_container').noty({ text: 'This Details already exists !' }); n.setType('error');
                //ShowMessage('Error');
            }
        },
        error: function (result) {

        }
    });

}
