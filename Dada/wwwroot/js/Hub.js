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

connection.start().then(function () {
}).catch(function (err) {
    return console.error(err.toString());
});

const upvotes = document.querySelectorAll("#upvote");

upvotes.forEach(function (el) {
    el.addEventListener("click", function (event) {

        var url = el.parentNode.parentNode.parentNode.parentNode.firstElementChild.firstElementChild.firstElementChild.href;
        var text = "postunu yüksəltdi !";
        var connectionid = el.childNodes[3].innerHTML;
        var senderName = document.getElementById("sendername").innerHTML;

        if (el.classList.contains("liked")) {
            $.ajax({
                url: '../../reaction/removeupvote/' + url.substr(35),
                type: 'GET',
                success: function () {
                    el.classList.remove("liked");
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
                }

            });
        }

        event.preventDefault();
    });
});





const downvotes = document.querySelectorAll("#downvote");

downvotes.forEach(function (el) {
    el.addEventListener("click", function (event) {
        console.log("clicked");
        var url = el.parentNode.parentNode.parentNode.parentNode.firstElementChild.firstElementChild.firstElementChild.href;
        var text = "postunun xalını azaltdı !";
        var connectionid = el.childNodes[3].innerHTML;
        var senderName = document.getElementById("sendername").innerHTML;

        if (el.classList.contains("downvoted")) {
            $.ajax({
                url: '../../reaction/removeupvote/' + url.substr(35),
                type: 'GET',
                success: function () {
                    el.classList.remove("downvoted");
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
                }

            });
        }

        event.preventDefault();
    });
});