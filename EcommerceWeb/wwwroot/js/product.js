﻿$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url: '/product/getall' },
        "columns": [
            { data: 'title', "width": "15%" },
            { data: 'madeIn', "width": "10%" },
            { data: 'brand', "width": "15%" },
            { data: 'listPrice', "width": "10%" },
            { data: 'category.name', "width": "15%" },
            {
                data: 'id',
                "render": function (data) {
                    return `<div class="w-75 btn-group" role="group">
                    <a href="/product/edit?id=${data}" class="btn btn-primary mx-2"><i class="bi bi-pencil-square"></i>Edit</a>
                    <a href="/product/delete?id=${data}" class="btn btn-danger mx-2"><i class="bi bi-trash-fill"></i>Delete</a>
                    </div>`
                },
                "width":"15%"
            }
        ]
    });
}