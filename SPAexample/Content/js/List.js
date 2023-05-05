$.getJSON("/Api/People", function (result) {

    $.each(result, function (key, val) {

        var item = "<tr Id='tr_" + val.ID + "'><td>" + val.ID + "</td><td>" + val.Name + "</td><td>" + val.Family + "</td><td>" + val.Age + "</td><td><a class='btn btn-warning btn-sm' OnClick='Edit(" + val.ID + ")'>ویرایش</a><a class='btn btn-danger btn-sm' OnClick='Delete(" + val.ID + ")'>حذف</a></td></tr>";

        $('#list').append(item);

    });

});
