$(document).ready(function () {
    $('#data').dataTable({
        "sDom": '<"nav"lf>t<"nav"i>'
    });
    $('#data').addClass("tbl");
    $('#data thead th').addClass("header");
    $('#data tbody tr:even').addClass("silver");
});
