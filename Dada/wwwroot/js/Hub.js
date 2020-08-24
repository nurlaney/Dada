"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/NotificationHub").build();


connection.on("RecieveMessage", function (message) {
    var msg = message;
    var encodedMsg = " says " + msg;
    var li = document.createElement("li");
    li.textContent = encodedMsg;
    document.getElementById("messagelist").appendChild(li);
});

connection.start().then(function () {
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("upvote").addEventListener("click", function (event) {
    var message = "groupa uzv oldu";
    var connectionid = document.getElementById("conn").innerText;
    console.log(connectionid);
    connection.invoke("SendMessage", message, connectionid).catch(function (err) {
        return console.error(err.toString());
    });

    event.preventDefault();
});