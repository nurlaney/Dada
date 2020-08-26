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
        var text = "postunu yüksəltdi";
        var connectionid = el.childNodes[3].innerHTML;
        var url = el.parentNode.parentNode.parentNode.parentNode.firstElementChild.firstElementChild.firstElementChild.href;
        var senderName = document.getElementById("sendername").innerHTML;
        connection.invoke("SendMessage", text, connectionid, url, senderName).catch(function (err) {
            return console.error(err.toString());
        });

        event.preventDefault();
    });
});