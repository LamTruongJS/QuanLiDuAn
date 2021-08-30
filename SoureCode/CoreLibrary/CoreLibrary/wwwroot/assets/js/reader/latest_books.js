$(document).ready(function () {
    var menu_item = $('.menu-item');
    var target = menu_item.eq(3);
    menu_item.removeClass('active');
    target.addClass('active');
});