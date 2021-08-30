$(document).ready(function () {
    var menu_item = $('.menu-item');
    var target = menu_item.eq(0);
    menu_item.removeClass('active');
    target.addClass('active');
});