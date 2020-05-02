﻿"use strict";
let userCounter = 1;
//
let myconnectionID;
let enemies = new Array();
var enemyID;

//
let lobbySize = 4;
let thiscard;
let allcards = [1, 1, 1, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 7, 8];
let mycards = new Array();
var enemydeck;
var lobbyID = $('#lobbyID').text();
var didnotcheat;
var connection = new signalR.HubConnectionBuilder().withUrl("/hub").build();
console.log(connection);


connection.start().then(function () {
}).catch(function (err) {
    return console.error(err.toString());
});


connection.on("UserConnected", function (ConnectionId) {
    myconnectionID = ConnectionId;
    enemies.push(myconnectionID);
    connection.invoke("JoinLobby", lobbyID).catch(function (err) {
        return console.error(err.toString());
    });

});

connection.on("JoinedLobby", function (ConnectionId) {
    userCounter++;
    console.log(userCounter);
    //get all cards
    enemies.push(ConnectionId);
    $(".enemy-cards").append("<div class='card-container '> <h4 class='username-h4'>" + ConnectionId + "</h4>  <div class='enemy-deck' id=" + ConnectionId + " ondrop='drop(event)' ondragover='dragover(event)'></div></div >");
    if (userCounter == lobbySize) {
        //send them
        connection.invoke("SendEnemylist", lobbyID, enemies).catch(function (err) {
            return console.error(err.toString());
        });
    }

});

//recive list of opponets
connection.on("RecievEnemyList", function (enemieslist) {
    enemies = enemieslist;
    const index = enemies.indexOf(myconnectionID);
    if (index > -1) {
        enemies.splice(index, 1);
    }
    console.log(enemies);
    for (var i = 0; i < enemies.length; i++) {
        var c = i + 1;
        console.log(i);
        $(".enemy-cards").children('.card-container:nth-child(' + c + ')').children(".enemy-deck").attr('id', enemies[i]);
    }
});

connection.on("GameStart", function () {
    //if lobby is full
    if (userCounter === lobbySize) {
        console.log("game starting");
        allcards.sort(() => Math.random() - 0.5);
        allcards.pop();
        connection.invoke("GiveFirstCards", allcards, lobbyID).catch(function (err) {
            return console.error(err.toString());
        });
    }
});


connection.on("GiveCards", function (a) {
    allcards = a;
    if (userCounter == lobbySize) {
        getCard(allcards[0]);
        getCard(allcards[4]);//his turn
    }
    if (userCounter == lobbySize - 1) {
        getCard(allcards[1]);
    }
    if (userCounter == lobbySize - 2) {
        getCard(allcards[2]);
    }
    if (userCounter == lobbySize - 3) {
        getCard(allcards[3]);
    }
    for (let i = 0; i < lobbySize + 1; i++) {
        allcards.shift();
    }
    console.log(allcards);
    /*  $('.card').on("click", function () {
          if (userCounter == 4) {
              let thiscard = $(this).attr('id');
              if (mycards.includes(parseInt(thiscard))) {
                  userCounter = 1;
                  connection.invoke("PlayCard", thiscard, lobbyID).catch(function (err) {
                      return console.error(err.toString());
                  });
              }
  
          } else
              console.log("not your trun");
      });*/
});
//drag and drop
var draggedcard;
var draggedcardtype;

function dragStart(event) {
    if (userCounter == 4) {
        thiscard = $(event.target).attr('id');
        didnotcheat = mycards.includes(parseInt(thiscard));
        draggedcard = event.target;
        draggedcardtype = $(event.target).attr('class');
    }

}

function dragover(event) {
    event.preventDefault();;
}

function drop(event) {
    if (userCounter == 4 && didnotcheat) {
        event.preventDefault();
        enemyID = $(event.target).attr("id");
        //add if null
        console.log(enemyID)
        $(draggedcard).removeAttr('draggable');
        $(draggedcard).removeAttr('ondragstart');
        $(draggedcard).css('margin', '0');
        $(draggedcard).remove();
        // for enemy view
        //$(enemydeck).append($(draggedcard).clone());
        //your view
        $('.deck').append(draggedcard);
        connection.invoke("CardPlayed", lobbyID, thiscard, enemyID, myconnectionID).catch(function (err) {
            return console.error(err.tostring());
        });
        allcards.shift();
        userCounter = 1;
        console.log("usercounte reset");
    }

}

//others
connection.on("CardMoved", function (card, towhom, bywho) {
    userCounter++;
    //shift my card from others
    allcards.shift();
    console.log(card);
    console.log("counter after card move:" + userCounter);
    $('#' + bywho).append($("<div class='card princess' id=" + card + " >" + card + "</div>").clone());
    console.log(bywho)
    console.log(towhom);
    if (userCounter == 4) {
        getCard(allcards[0]);
    }
});


connection.on("UserDisconnected", function (ConnectionId) {
    $("#userlist").append($("<li>").text(ConnectionId + "has disconnected"))
});



//GAMEPLAY
function getCard(cardValue) {
    $('.pile-card').addClass('shift-card').delay(500).queue(function (next) {
        $(".my-cards").append("<div class='card princess' id=" + cardValue + " draggable='true' ondragstart='dragStart(event)'>" + cardValue + "</div>");
        $('.pile-card').removeClass('shift-card');
        mycards.push(cardValue);
        next();
    });
}




