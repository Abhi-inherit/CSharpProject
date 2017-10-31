$(document).ready
(
    function ()
    {
        Header();
    }
)

function Header()
{
    var adddiv = $("#headerdiv");
    $.ajax
    ({
        type: "GET",
        url: "/Admin/Slider/",
        success: function (data)
        {
            adddiv.append(data);
            Home();
        },
        error: function (data)
        {
            console.log(data);
        }
    });
}

function Home()
{
    var adddiv = $("#topdiv");
    $.ajax
        ({
            type: "GET",
            url: "/Admin/Home/",
            success: function (data)
            {
                adddiv.html('');
                adddiv.html(data);
            },
            error: function (data) {
                alert(data);
                console.log(data);
            }
        });
}

