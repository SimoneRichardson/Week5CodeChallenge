//Load the dom into a jQuery object
//after its fully loaded (.ready()))
$(document).ready(function () {
    //after the DOM loaded, then execute this code

    //when we click on homeLink, run some code
    $('.about li').on('click', function () {
        //use a .get request to update the data
        // data-url attribute
        var url = $(this).data('url');
        //use a Ajax .get request to update our content
        $.get(url, function (data) {
            //update the content div with the
            //data returned from our GET request
            $('#tabContent').html(data);
        });
    });
    //remove the current active tab
    $('.aboutli').removeClass();
});