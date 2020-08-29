"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/NotificationHub").build();


connection.on("RecieveMessage", function (text, url, senderName) {
    var asender = document.createElement("a");
    asender.setAttribute("class", "bold");
    asender.textContent = senderName;
    var atext = document.createElement("a");
    atext.setAttribute("class", "highlighted");
    atext.textContent = " " + text;
    atext.href = url;
    var userstatus = document.createElement("div");
    userstatus.classList.add("user-status", "notification");
    userstatus.appendChild(asender);
    userstatus.appendChild(atext);
    var wholediv = document.createElement("div");
    wholediv.classList.add("dropdown-box-list-item", "notreaden");
    wholediv.id = "notilist";
    wholediv.appendChild(userstatus);
    document.getElementById("wole").insertBefore(wholediv, document.getElementById("wole").firstChild);
});

connection.on("RecieveDownNotify", function (text, url, senderName) {
    var asender = document.createElement("a");
    asender.setAttribute("class", "bold");
    asender.textContent = senderName;
    var atext = document.createElement("a");
    atext.setAttribute("class", "highlighted");
    atext.textContent = " " + text;
    atext.href = url;
    var userstatus = document.createElement("div");
    userstatus.classList.add("user-status", "notification");
    userstatus.appendChild(asender);
    userstatus.appendChild(atext);
    var wholediv = document.createElement("div");
    wholediv.classList.add("dropdown-box-list-item", "notreaden");
    wholediv.id = "notilist";
    wholediv.appendChild(userstatus);
    document.getElementById("wole").insertBefore(wholediv, document.getElementById("wole").firstChild);
});
connection.on("RecieveUpvotec", function (text, url, senderName) {
    var asender = document.createElement("a");
    asender.setAttribute("class", "bold");
    asender.textContent = senderName;
    var atext = document.createElement("a");
    atext.setAttribute("class", "highlighted");
    atext.textContent = " " + text;
    atext.href = url;
    var userstatus = document.createElement("div");
    userstatus.classList.add("user-status", "notification");
    userstatus.appendChild(asender);
    userstatus.appendChild(atext);
    var wholediv = document.createElement("div");
    wholediv.classList.add("dropdown-box-list-item", "notreaden");
    wholediv.id = "notilist";
    wholediv.appendChild(userstatus);
    document.getElementById("wole").insertBefore(wholediv, document.getElementById("wole").firstChild);
});

connection.start().then(function () {
}).catch(function (err) {
    return console.error(err.toString());
});

const upvotes = document.querySelectorAll("#upvote");

upvotes.forEach(function (el) {
    el.addEventListener("click", function (event) {

        var url = el.parentNode.parentNode.parentNode.parentNode.firstElementChild.firstElementChild.firstElementChild.href;
        var text = " postunu yüksəltdi !";
        var connectionid = el.childNodes[3].innerHTML;
        var senderName = document.getElementById("sendername").innerHTML;
        

        if (el.parentNode.parentNode.children[2].firstElementChild.classList.contains("downvoted")) {
            $.ajax({
                url: '../../reaction/removedownvote/' + url.substr(35),
                type: 'GET',
                success: function () {
                    el.parentNode.parentNode.children[2].firstElementChild.classList.remove("downvoted");
                    var big = el.parentNode.parentNode.children[1].firstElementChild;
                    var scores = el.parentNode.parentNode.children[1].firstElementChild.innerHTML.split("-");
                    var down = parseInt(scores[1]) - 1;
                    big.innerHTML = scores[0] + "-" + down;
                }

            });
        }

        if (el.classList.contains("liked")) {
            $.ajax({
                url: '../../reaction/removeupvote/' + url.substr(35),
                type: 'GET',
                success: function () {
                    el.classList.remove("liked");
                    var big = el.parentNode.parentNode.children[1].firstElementChild;
                    var scores = el.parentNode.parentNode.children[1].firstElementChild.innerHTML.split("-");
                    big.innerHTML = parseInt(scores[0])-1 + "-" + scores[1];
                }

            });
        } else {
            connection.invoke("SendMessage", text, connectionid, url, senderName).catch(function (err) {
                return console.error(err.toString());
            });

            $.ajax({
                url: '../../reaction/upvotepost/' + url.substr(35),
                type: 'GET',
                success: function () {
                    el.classList.add("liked");

                    var big = el.parentNode.parentNode.children[1].firstElementChild;
                    var scores = el.parentNode.parentNode.children[1].firstElementChild.innerHTML.split("-");
                    big.innerHTML = parseInt(scores[0]) + 1 + "-" + scores[1];
                }

            });
        }

        event.preventDefault();
    });
});





const downvotes = document.querySelectorAll("#downvote");

downvotes.forEach(function (el) {
    el.addEventListener("click", function (event) {
        var url = el.parentNode.parentNode.parentNode.parentNode.firstElementChild.firstElementChild.firstElementChild.href;
        var text = " postunun xalını azaltdı !";
        var connectionid = el.childNodes[3].innerHTML;
        var senderName = document.getElementById("sendername").innerHTML;

        if (el.parentNode.parentNode.firstElementChild.firstElementChild.classList.contains("liked")) {
            $.ajax({
                url: '../../reaction/removeupvote/' + url.substr(35),
                type: 'GET',
                success: function () {
                    el.parentNode.parentNode.firstElementChild.firstElementChild.classList.remove("liked");
                    var big = el.parentNode.parentNode.children[1].firstElementChild;
                    var scores = el.parentNode.parentNode.children[1].firstElementChild.innerHTML.split("-");
                    var down = scores[1];
                    big.innerHTML = parseInt(scores[0]) - 1 + "-" + down;
                }

            });
        }

        if (el.classList.contains("downvoted")) {
            $.ajax({
                url: '../../reaction/removedownvote/' + url.substr(35),
                type: 'GET',
                success: function () {
                    el.classList.remove("downvoted");
                    var big = el.parentNode.parentNode.children[1].firstElementChild;
                    var scores = el.parentNode.parentNode.children[1].firstElementChild.innerHTML.split("-");
                    var down = parseInt(scores[1]) - 1;
                    big.innerHTML = scores[0] + "-" + down;
                }

            });
        } else {
            connection.invoke("Downvote", text, connectionid, url, senderName).catch(function (err) {
                return console.error(err.toString());
            });

            $.ajax({
                url: '../../reaction/downvotepost/' + url.substr(35),
                type: 'GET',
                success: function () {
                    el.classList.add("downvoted");
                    var big = el.parentNode.parentNode.children[1].firstElementChild;
                    var scores = el.parentNode.parentNode.children[1].firstElementChild.innerHTML.split("-");
                    var down = parseInt(scores[1]) + 1;
                    big.innerHTML = scores[0] + "-" + down;
                }

            });
        }

        event.preventDefault();
    });
});


const upvotescomment = document.querySelectorAll("#upvotec");

upvotescomment.forEach(function (el) {
    el.addEventListener("click", function (event) {

        var url = el.parentNode.parentNode.parentNode.parentNode.parentNode.parentNode.parentNode.parentNode.parentNode.firstElementChild.firstElementChild.children[1].children[1].firstElementChild.firstElementChild.firstElementChild.firstElementChild.href;
        var text = " Şərhini yüksəltdi !";
        var connectionid = el.childNodes[3].innerHTML;
        var cmntid = el.children[2].innerHTML;
        var senderName = document.getElementById("sendername").innerHTML;


        if (el.parentNode.parentNode.children[2].firstElementChild.classList.contains("downvotedc")) {
            $.ajax({
                url: '../../reaction/removedownvote/' + cmntid,
                type: 'GET',
                success: function () {
                    el.parentNode.parentNode.children[2].firstElementChild.classList.remove("downvotedc");
                    var big = el.parentNode.parentNode.children[1].firstElementChild;
                    var scores = el.parentNode.parentNode.children[1].firstElementChild.innerHTML.split("-");
                    var down = parseInt(scores[1]) - 1;
                    big.innerHTML = scores[0] + "-" + down;
                }

            });
        }

        if (el.classList.contains("likedc")) {
            $.ajax({
                url: '../../reaction/removeupvotecomment/' + cmntid,
                type: 'GET',
                success: function () {
                    el.classList.remove("likedc");
                    var big = el.parentNode.parentNode.children[1].firstElementChild;
                    var scores = el.parentNode.parentNode.children[1].firstElementChild.innerHTML.split("-");
                    big.innerHTML = parseInt(scores[0]) - 1 + "-" + scores[1];
                }

            });
        } else {
            connection.invoke("Upvotec", text, connectionid, url, senderName).catch(function (err) {
                return console.error(err.toString());
            });

            $.ajax({
                url: '../../reaction/upvotecomment/' + cmntid,
                type: 'GET',
                success: function () {
                    el.classList.add("likedc");

                    var big = el.parentNode.parentNode.children[1].firstElementChild;
                    var scores = el.parentNode.parentNode.children[1].firstElementChild.innerHTML.split("-");
                    big.innerHTML = parseInt(scores[0]) + 1 + "-" + scores[1];
                }

            });
        }

        event.preventDefault();
    });
});

const downvotescomment = document.querySelectorAll("#downvotec");

downvotescomment.forEach(function (el) {
    el.addEventListener("click", function (event) {
        var url =  el.parentNode.parentNode.parentNode.parentNode.parentNode.parentNode.parentNode.parentNode.parentNode.firstElementChild.firstElementChild.children[1].children[1].firstElementChild.firstElementChild.firstElementChild.firstElementChild.href;
        var text = " Şərhinin xalını azaltdı !";
        var connectionid = el.childNodes[3].innerHTML;
        var cmntid = el.children[2].innerHTML;
        var senderName = document.getElementById("sendername").innerHTML;

        if (el.parentNode.parentNode.firstElementChild.firstElementChild.classList.contains("likedc")) {
            $.ajax({
                url: '../../reaction/removeupvotecomment/' + cmntid,
                type: 'GET',
                success: function () {
                    el.parentNode.parentNode.firstElementChild.firstElementChild.classList.remove("likedc");
                    var big = el.parentNode.parentNode.children[1].firstElementChild;
                    var scores = el.parentNode.parentNode.children[1].firstElementChild.innerHTML.split("-");
                    var down = scores[1];
                    big.innerHTML = parseInt(scores[0]) - 1 + "-" + down;
                }

            });
        }

        if (el.classList.contains("downvotedc")) {
            $.ajax({
                url: '../../reaction/removedownvotecomment/' + cmntid,
                type: 'GET',
                success: function () {
                    el.classList.remove("downvotedc");
                    var big = el.parentNode.parentNode.children[1].firstElementChild;
                    var scores = el.parentNode.parentNode.children[1].firstElementChild.innerHTML.split("-");
                    var down = parseInt(scores[1]) - 1;
                    big.innerHTML = scores[0] + "-" + down;
                }

            });
        } else {
            connection.invoke("Downvotec", text, connectionid, url, senderName).catch(function (err) {
                return console.error(err.toString());
            });

            $.ajax({
                url: '../../reaction/downvotecomment/' + cmntid,
                type: 'GET',
                success: function () {
                    el.classList.add("downvotedc");
                    var big = el.parentNode.parentNode.children[1].firstElementChild;
                    var scores = el.parentNode.parentNode.children[1].firstElementChild.innerHTML.split("-");
                    var down = parseInt(scores[1]) + 1;
                    big.innerHTML = scores[0] + "-" + down;
                }

            });
        }

        event.preventDefault();
    });
});