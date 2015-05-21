var locationData = "";
var noJQdata = "";

$(document).ready(function () {
    GetRegions(); 
});


function GetRegions() {
    $.when(AJAX("RegionsPage.aspx/GetRegions", "{}")).done(function (data) {
        $.when(renderRegions(data)).done(function() {
            GetLocations();
        });
    })
};

function GetLocations() {
    $.when(AJAX("LocationsPage.aspx/GetLocations", '{regionValue: "' + document.getElementById('MainContent_Regions').value + '"}')).done(function (data) {
        $.when(renderLocations(data)).done(function () {
            Description(document.getElementById('MainContent_Locations').value);
        });
    });
};

function renderRegions(data) {
    $('#MainContent_Regions').children().remove();
    $.each(data, function (key, item) {
        for (i in item) {
            $('#MainContent_Regions').append('<option Value="' + item[i].regionValue + '">' + item[i].regionName + '</option>')
        }
    });
    $('#MainContent_Regions').change(function () {
        GetLocations();
    });
};

function renderLocations(data) {
    $('#MainContent_Locations').children().remove();
    $.each(data, function (key, item) {
        locationData = item;
        for (i in item) {
            $('#MainContent_Locations').append('<option Value="' + item[i].Value + '">' + item[i].Name + '</option>')
        }
    });
    $('#MainContent_Locations').change(function () {
        Description(document.getElementById('MainContent_Locations').value);
    });

};

function Description(locationValue) {
    for (i in locationData) {
        if (locationData[i].Value === locationValue) {
            $('#description').html(locationData[i].Description);
            break;
        }
    };
};

function AJAX(urlMethod, dataTransfer) {
    return $.ajax({
        type: "POST",
        url: urlMethod,
        data: dataTransfer,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        failure: function (response) {
            alert(response.d);
        }
    });
};

function noJQajax(urlMethod, dataTransfer) {
    var request = new XMLHttpRequest();
    request.onreadystatechange = function () {
        if (request.readyState == XMLHttpRequest.DONE) {
            return request.responseText;
        }
    }
    request.open('POST', urlMethod, true);
    request.setRequestHeader('Content-Type', 'application/json; charset=UTF-8');
    request.send(dataTransfer);
};