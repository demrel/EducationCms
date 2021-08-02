(function ($) {
    'use strict';
    $(function () {
        $('.file-upload-browse').on('click', function () {
            var file = $(this).parent().parent().parent().find('.file-upload-default');
            file.trigger('click');
        });
        $('.file-upload-default').on('change', function () {
            $(this).parent().find('.form-control').val($(this).val().replace(/C:\\fakepath\\/i, ''));
        });
    });
})(jQuery);

$('.glyphicon').click(function () {
    var id = $(this).attr("data-id")
    console.log(id)
    deleteitem(id)
    $(this.parentNode.parentNode).remove()

})

//delete image
function deleteitem(id) {
    console.log(id)
    fetch(`/admin/Image/DeleteImage/${id}`, {
        method: 'DELETE',
        headers: {
            'Content-Type': 'application/json'
        },
    })
}