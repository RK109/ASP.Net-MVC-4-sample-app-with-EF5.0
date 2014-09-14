// script file for Titles page

$(document).ready(function () {
    //    buttonclick event
//    $("#btnSearch").click(function () {

//        // var optionSelectedText = $('#ddlSearchOption option:selected').Text();
//        var optionSelectedValue = $('#ddlSearchOption :selected').val();
//        var searchText = $("#txtSearchText").val();
//       
//        if (searchText != null) {
//            $.ajax({
//                dataType: 'json',
//                url: '/Titles/Search',
//                contentType: 'application/json; charset=utf-8',
//                data: { searchOption: optionSelectedValue, searchText: searchText },
//                success: function () { }
//            });
//        }
//        else { 
//            alert(optionSelectedText + " is required.");
//        }
    });

    // dropdown lostfocus event
    $("#ddlSearchOption").change(function () {
        $("#divSearch").show();

        var selectedOption = $(this).val();

        if (selectedOption == 0)
            $("#lblSearchTextLabel").text('Enter Title Name');
        else if (selectedOption == 1)
            $("#lblSearchTextLabel").text('Enter Genre');
        else if (selectedOption == 2)
            $("#lblSearchTextLabel").text('Enter Language');
        else if (selectedOption == 3)
            $("#lblSearchTextLabel").text('Enter Participant');
        else
            $("#divSearch").hide();
    });

});
