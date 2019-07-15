function jQueryAjaxPost(form) {
    $.validator.unobtrusive.parse(form);
    if ($(form).valid())
    {
        var ajaxConfig = {
            type: 'POST',
            url: form.action,
            data: new FormData(form),
            success: function (response) {
                if (response.success) {


                    $("#firstTab").html(response.html);
                    refreshAddNewTab($(form).attr('data-resetUrl'), true);
                    $.notify(response.message, "success");
                }
                else {
                    $.notify(response.message, "error");
                }
            }
        } 
        if ($(form).attr('enctype') == "multipart/form-data") {
                ajaxConfig["contentType"] = false,
                ajaxConfig["processData"] = false;

                
        }
        $.ajax(ajaxConfig);
    }
    return false;
}
function refreshAddNewTab(resetUrl, showViewTab) {
    $.ajax({
        type: 'GET',
        url: resetUrl,
        success: function (response) {
            $("#secondTab").html(response);
            $('ul.nav.nav-tabs a:eq(1)').html('Add New');
            if (showViewTab)
                $('ul.nav.nav-tabs a:eq(1)').tab('show');
        }
    })
}
function Delete(url) {
    if (confirm('Are you sure you want to delete this record?') == true) {
        $.ajax({
            type: 'POST',
            url: url,
            success: function (response) {
                if (response.success) {
                    $("#firstTab").html(response.html);
                    $.notify(response.message, "warn");
                } else {
                    $.notify(response.message, "error");
                }
                
            }
        })

    }
}
function Delivered(url) {
    if (confirm('Is this Order already Delivered') == true) {
        $.ajax({
            type: 'POST',
            url: url,
            success: function (response) {
                if (response.success) {
                    $("#thirdTab").html(response.html);
                    $.notify(response.message, "warn");
                } else {
                    $.notify(response.message, "error");
                }

            }
        })

    }
}