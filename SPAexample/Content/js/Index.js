
$(function () {
    $('#view').load('/Home/list');
});

$('#btnAdd').click(function () {
    $('#view').load('/Home/Add');
});

function Edit(Id) {
    $('#view').load('/Home/Edit/' + Id);
}

$('#info').click(function () {
    $('#view').load('/Home/Information');
});

$('#about').click(function () {
    $('#view').load('/Home/AboutMe');
});

$('#home').click(function () {
    $('#view').load('/Home/list');
});

$('#Connect').click(function () {
    $('#view').load('/Home/ConnectMe');
});

function Delete(Id) {

    Swal.fire({
        title: 'ایا از حذف اطمینان دارید ?',
        text: "مورد حذف شده دیگر قابل بازیابی نخواهد بود !",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'بله, حذف شود !',
        cancelButtonText: 'لغو'
    }).then((result) => {
        if (result.isConfirmed) {


            $.ajax({

                url: '/api/People/' + Id,
                type: 'Delete',
                data: Id

            }).done(function () {
                $('#tr_' + Id).addClass('danger');
                $('#tr_' + Id).hide('slow');
            });

        }
    })

}
