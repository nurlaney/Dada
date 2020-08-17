$(document).ready(function () {

    $(".eemailinfo").click(function () {
        $(".emailinfo").addClass("d-none")
    });



    // search engine
        $("#search-main").autocomplete({
            source: function (request, response) {


                $.ajax({
                    url: '/Search/Search',
                    type: 'GET',
                    cache: false,
                    data: request,
                    dataType: 'json',
                    success: function (data) {


                        var alldata = data.nicks.concat(data.clubs).concat(data.titles);



                        response($.map(alldata, function (item) {


                            return {

                                value: item,
                                label: data

                            }


                        }))
                    }
                });
            },
            minLength: 1,
        }).data("ui-autocomplete")._renderItem = function (ul, item) {


            if (item.label.nicks.includes(item.value)) {
                return $("<li>")
                    .append($("<a>").attr("href", "profile?username=" + item.value).append(item.value))
                    .appendTo(ul);
            } else if (item.label.clubs.includes(item.value)) {

                return $("<li>")

                    .append($("<a>").attr("href", "group/index/" + item.value.slice(0, item.value.indexOf("*"))).append(item.value.slice(item.value.indexOf("*") + 1)))

                    .appendTo(ul);

            }

            return $("<li>")
                .append($("<a>").attr("href", "post/index/" + item.value.slice(0, item.value.indexOf("*"))).append(item.value.slice(item.value.indexOf("*") + 1)))
                .appendTo(ul);
        }
 });