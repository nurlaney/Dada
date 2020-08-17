"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/NotificationHub?userId=" + userId).build();     
connection.on("sendToUser", (articleContent) => {
    var p = document.createElement("p");
    p.innerText = articleContent;
    var div = document.createElement("div");
    div.appendChild(heading);
    div.appendChild(p);

    document.getElementById("usercontent").appendChild(div);
});
connection.start().catch(function (err) {
    return console.error(err.toString());
}).then(function () {
    connection.invoke('GetConnectionId').then(function (connectionId) {
        document.getElementById('signalRConnectionId').innerHTML = connectionId;
    })
});