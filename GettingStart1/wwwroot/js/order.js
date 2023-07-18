var dataTable;
$(document).ready(function () {
    var url = window.location.search; 
    var statusString = ["inprocess", "pending", "completed", "approved", "all"];
    for (i = 0; i < statusString.length; i++) {
        if (url.includes(statusString[i])) {          
            loadDataTable(statusString[i]);
            break;
        }       
    } 
});

function loadDataTable(status) {
    //if ($.fn.datatable.isdatatable('#tbldata')) {
    //    // datatable has already been initialized, destroy it before reinitializing
    //    datatable.destroy();
    //}

    dataTable = $('#tblData').DataTable({
        "ajax": {url: '/admin/order/getall?status=' + status}, 
    "columns": [
        { data: 'id', "width": "10%" },
        { data: 'name', "width": "15%" },
        { data: 'phoneNumber', "width": "10%" },
        { data: 'applicationUser.email', "width": "20%" },
        { data: 'orderStatus', "width": "10%" },
        { data: 'orderTotal', "width": "10%" },

        {
            data: 'id',
            "render": function (data) { 
                return `<div class="w-75 btn-group" role="group">
                     <a href="/admin/order/details?orderId=${data}" class="btn btn-primary mx-2"><i class="bi bi-pencil-square"></i></a>
                </div>`
            },
          "width": "10%"}
        ]
    });
}




