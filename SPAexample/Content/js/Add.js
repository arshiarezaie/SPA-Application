
$('#btnSave').click(function () {

    var person = {
        Name: $('#txtName').val(),
        Family: $('#txtFamily').val(),
        Age: $('#txtNumber').val(),
    }

    $.ajax({
        url: '/api/People',
        type: 'post',
        data: person
    }).done(function (result) {

        $('#view').load('/Home/List');
    });

});
