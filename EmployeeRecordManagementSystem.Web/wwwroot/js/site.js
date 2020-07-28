$(document).ready(function () {
    $('#joinedOn').datepicker({
        dateFormat: "yy-mm-dd"
    });

    $(document).on('click', '.addCommentBtn', function (e) {
        e.preventDefault();
        e.stopPropagation();
        let nextIndex = +$(this).parent().parent().parent().data('nextindex');
        $(this).removeClass('addCommentBtn').unbind('click').addClass('removeCommentBtn').val('Remove Comment');
        $('.commentContainer').last().after(
            '<div class="commentContainer" data-nextindex="' + (nextIndex+1) + '" > ' +
                '<div class="form-group green-border-focus">' +
                    '<label>Comment:</label>' +
                    '<textarea class="form-control" name="Comments[' + (nextIndex + 1) + '].Note" rows="3" style= "float:right; margin-top:10px;margin-left:10px"></textarea>' +
                    '<div class="form-group">'+
                        '<input class="btn btn-info addCommentBtn" style="float:right; margin-top:5px; margin-left:10px;" type="button" value="Add Comment" />' +
                        '<input class="form-control-sm" name="Comments[' + (nextIndex + 1) + '].Author" style= "float:right; margin-top:10px;margin-left:10px" type="text" value="">'+
                        '<label style="float: right; margin-top: 10px;">Author:</label>'+
                    '</div>'+
                '</div >' +
            '</div>');
    });

    $(document).on('click', '.removeCommentBtn', function (e) {
        e.preventDefault();
        e.stopPropagation();
        $(this).parent().parent().remove();
    });

    $('#deleteEmployeeSubmit').click(function (e) {
        e.preventDefault();
        e.stopImmediatePropagation();
        let employeeId = +$('#employeeId').data('id');
        $.ajax({
            method: 'POST',
            url: '/Employee/Delete',
            data: JSON.stringify(employeeId),
            dataType: 'json',
            contentType: 'application/json',
            success: function (data) {
                location.href = '/Home/Index';
            },
            error: function (jqXhr, textStatus, errorThrown) {
                console.log(errorThrown);
            }
        });

    });

    $('#searchBtn').click(function (e) {
        e.preventDefault;
        e.stopImmediatePropagation();
        let searchText = $('#searchText').val();
        $.ajax({
            method: 'POST',
            url: '/Home/Search',
            data: JSON.stringify(searchText),
            contentType: 'application/json',
            success: function (data) {
                $('#resultContainer').empty();
                $('#resultContainer').html(data);
            },
            error: function (jqXhr, textStatus, errorThrown) {
                console.log(errorThrown);
            }
        });
    });

});
