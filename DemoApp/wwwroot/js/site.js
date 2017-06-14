// Write your Javascript code.
(function () {



    var ele = $("#username");
    ele.text("sailaxman kumar");

    var main = $("#main");
    main.on("mouseenter", function () {
        main.style = "background-color: #888;";
    });

    main.onmouseleave = function () {
        main.style.backgroundColor = "";
    };


    var $sidebarAndWrapper = $("#sidebar,#wrapper");
    var $icon = $("#sidebarToggle i.fa")
    $("#sidebarToggle").on("click", function () {
        $sidebarAndWrapper.toggleClass("hide-sidebar");
        if ($sidebarAndWrapper.hasClass("hide-sidebar")) {
            $icon.removeClass("fa-angle-left");
            $icon.addClass("fa-angle-right");
        }
        else {
            $icon.removeClass("fa-angle-right");
            $icon.addClass("fa-angle-left");
        }
    });
})();