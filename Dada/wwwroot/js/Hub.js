"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/NotificationHub").build();


connection.on("ReceiveMessage", function (user, message) {
    var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    var encodedMsg = user + " says " + msg;
    var li = document.createElement("li");
    li.textContent = encodedMsg;
    document.getElementById("messagesList").appendChild(li);
});

connection.start().then(function () {
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("joining").addEventListener("click", function (event) {
    var user = "d/stendhal";
    var message = "groupa uzv oldu";
    connection.invoke("GroupNotify", user, message).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});