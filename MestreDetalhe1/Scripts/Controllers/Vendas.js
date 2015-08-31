(function ($, window, document) {
    "use strict";

    $(function () {

        $(document.body).on('click', '.addItem', function () {
            var data = $("Form").serializeArray();
            $("#Lista").load("/Venda/AddItem", data);
            return false;
        });

    });

}(window.jQuery, window, document));


