const connection = new signalR.HubConnectionBuilder()
    .withUrl("/chathub")
    .configureLogging(signalR.LogLevel.Information)
    .build();

connection.on("ReceiveMessage", (user, message) => {
    const msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt").replace(/>/g, "&gt");
    const fecha = new Date().toLocaleTimeString();
    const mensajeAMostrar = fecha + "<strong>" + user + "</strong>" + msg;
    const li = document.createElement("li");
    li.innerHTML = mensajeAMostrar;
    document.getElementById("messagesList").appendChild(li);
   

      
});

connection.start().catch(err => console.error(err.toString()));

var el = document.getElementById("sendButton");
if (el) {
    el.addEventListener("click", () => {
        const user = document.getElementById("userInput").value;
        const message = document.getElementById("messageInput").value;
        connection.invoke("SendMessage", user, message).catch(err => console.error(err.toString()));
       
    });
}


/*document.getElementById("sendButton").addEventListener("click", () => {
    const user = document.getElementById("userInput").value;
    const message = document.getElementById("messageInput").value;
    connection.invoke("SendMessage", user, message).catch(err => console.error(err.toString()));

});
*/
