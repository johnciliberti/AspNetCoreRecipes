$(function () {
    //check to see if URL contains a hash and if so try and navigate to the correct tab
    var tab = $(location).attr('href');
    var re = new RegExp('#+[a-z]+', 'i');
    var m = re.exec(tab);
    if (m) {
        $("#tabMenu a[href='" + m + "']").tab('show');
    }
});