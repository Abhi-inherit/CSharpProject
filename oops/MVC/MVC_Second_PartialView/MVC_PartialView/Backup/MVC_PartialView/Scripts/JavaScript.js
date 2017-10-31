$(document).ready(function ()
    {
        ListView()
        AddView()
    });

function ListView()
    {
        var Search = $("#Search").val();
        var divResult = $("#ListView");
        var url = "/Admin/_ListView";

        $.ajax
            ({
                cache: false,
                type: "GET",
                url: url,
                data: { "Search": Search },
                success: function (data)
                {
                    divResult.html('');
                    divResult.html(data);
                },
                error: function (data)
                {
                    alert("Failed to retrieve data !")
                }
            });
}

function AddView()
    {
    var divResult = $("#AddDetails")
    var url = "/Admin/_ManageView";
    $.ajax
        ({
            type: "GET",
            url: url,
            success: function (data)
                {
                    divResult.html('');
                    divResult.html(data);
                },
            error: function (data)
                {
                    alert("Failed to retrieve data !")
                }
        });
}

function DetailsAdd()
{

    var Id = $("#CurrentID").val();
    
    if (Id <= 0) {
        Save();
    }
    else {
        Update();
    }
}

function Save()
{

    var items = $('#fileupload').prop("files");
    for (var i = 0; i < items.length; i++)
    {
        var file = items[i];
        var fileName = file.name;
        var isEdit = $("#HdnIsEdit").val("0");
        var Registration = {}
        Registration["Name"] = $("#Name").val();
        Registration["DateOfBirth"] = $("#DateOfBirth").val();
        Registration["Address"] = $("#Address").val();
        Registration["Phone"] = $("#Phone").val();
        Registration["Image"] = fileName;
        Registration["Place"] = $("#Place").val();
        Registration["Status"] = $("#Status").val();

        $.ajax
        ({
            type: "POST",
            contentType: "application/json;charset=ut-f-8",
            url: "/Admin/Manage/",
            data: "{'Obj':" + JSON.stringify(Registration) + ",'Status':'" + isEdit + "' }",
            datatype: "json",
            async: true,
            success: function (data)
            {
                UploadFile();
                alert("Success.")
                ListView();
            },
            error: function (data)
            {
                alert("Failed to retrieve data !")
            }
        });
    }
}

function UploadFile() {
    var items = $('#fileupload').prop("files");
    for (var i = 0; i < items.length; i++) {
        var file = items[i];
        if (file == null) { return; }
        var fileName = file.name;
        var fd = new FormData();
        fd.append("fileData", file);
        var xhr = new XMLHttpRequest();
        xhr.open("POST", "/Admin/UploadFile", false);
        xhr.send(fd);
    }
}

function Update()
{
    alert('Update try');

    var items = $('#fileupload').prop("files");
    for (var i = 0; i < items.length; i++) {
        var file = items[i];
        var fileName = file.name;
    }
    var isEdit = $("#HdnIsEdit").val();
    var Registration = {}
    Registration["Id"] = $("#CurrentID").val();;
    Registration["Name"] = $("#Name").val();
    Registration["DateOfBirth"] = $("#DateOfBirth").val();
    Registration["Address"] = $("#Address").val();
    Registration["Phone"] = $("#Phone").val();
    Registration["Image"] = fileName;
    Registration["Place"] = $("#Place").val();
    Registration["Status"] = $("#Status").val();

    $.ajax
        ({
            type: "POST",
            contentType: "application/json;charset=ut-f-8",
            url: "/Admin/Manage/",
            data: "{'Obj':" + JSON.stringify(Registration) + ",'Status':'" + isEdit + "' }",
            datatype: "json",
            async: true,
            success: function (data) {
                UploadFile();
                alert("Success.")
                ListView();
                $("#HdnIsEdit").val(0);
                $("#CurrentID").val(0);
            },
            error: function (data) {
                alert("Failed to retrieve data !")
            }
        });
}

function Edit(id)
{
    alert(id);

    var divResult = $("#AddDetails")
    var url = "/Admin/_ManageView";
    $.ajax
        ({
            type: "GET",
            url: url,
            data: { Id: id },
            success: function (data)
            {
                divResult.html('');
                divResult.html(data);
                $("#HdnIsEdit").val(1);
                $("#CurrentID").val(id);
            },
            error: function (data)
            {
                alert("Failed to retrieve data !")
            }
        });
}

function Delete(id)
{
    var divResult = $("#AddDetails")
    var url = "/Admin/Delete";
    $.ajax
        ({
            type: "GET",
            url: url,
            data: { Id: id },
            success: function (data)
            {
                ListView();
            },
            error: function (data)
            {
                alert("Failed to retrieve data !")
            }
        });
}

function View(id)
{
    var divResult = $("#AddDetails")
    var url = "/Admin/_DetailView";
    $.ajax
        ({
            type: "GET",
            url: url,
            data: { Id: id },
            success: function (data)
            {
                divResult.html('');
                divResult.html(data);
            },
            error: function (data)
            {
                alert("Failed to retrieve data !")
            }
        });

}





