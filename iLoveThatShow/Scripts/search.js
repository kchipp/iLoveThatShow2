var settings = {
    "async": true,
    "crossDomain": true,
    "url": "https://api.themoviedb.org/3/search/tv?query=the%20walking%20dead&language=en-US&api_key=d467e0b9558a2959e74098c93160e1be",
    "method": "GET",
    "headers": {
        "content-type": "application/json"
    },
    "processData": false,
    "data": "{}"
}

$.ajax(settings).done(function (response) {
    console.log(response);
});

var data = JSON.stringify({});

var xhr = new XMLHttpRequest();
xhr.withCredentials = true;

xhr.addEventListener("readystatechange", function () {
    if (this.readyState === this.DONE) {
        console.log(this.responseText);
    }
});

xhr.open("GET", "https://api.themoviedb.org/3/search/tv?query=the%20walking%20dead&language=en-US&api_key=d467e0b9558a2959e74098c93160e1be");
xhr.setRequestHeader("content-type", "application/json");

xhr.send(data);