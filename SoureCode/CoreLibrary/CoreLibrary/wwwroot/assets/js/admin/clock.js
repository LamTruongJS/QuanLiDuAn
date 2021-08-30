setInterval(function() {
    let date = new Date();
    let hours = date.getHours();
    let minutes = date.getMinutes();
    let seconds = date.getSeconds();
    let am = "AM"
    if(hours > 12 )
    {
        hours = hours - 12;
        hours = "0"+hours.toString();
        am = "PM"
    }
    else {
        if (hours >= 10) {
            am = "AM";
            hours = hours.toString();
        }
        else {
            am = "AM";
            hours = "0" + hours.toString();
        }

    }
    if(minutes<10){
        minutes = "0"+minutes.toString();
    }
    if(seconds<10){
        seconds = "0"+seconds.toString();
    }
    
    var hour = document.querySelector(".hour");
    var minute = document.querySelector(".minute");
    var second = document.querySelector(".second");
    var ampm = document.querySelector(".ampm");
    hour.innerHTML = hours;
    minute.innerHTML= minutes;
    second.innerHTML = seconds;
    ampm.innerHTML= am;
    
},0)

setInterval(function(){


let date = new Date();
let day = date.getDay() +1;
var dayEnglish;
let month = date.getMonth() +1;
var monthEnglish;
switch (day) {
    case 1: 
        dayEnglish = "Sunday";
         break;
    case 2: 
        dayEnglish = "Monday";
        break;
    case 3: 
        dayEnglish = "Tuesday";
        break;
    case 4: dayEnglish = "Wednesday";
        break;
    case 5: dayEnglish = "Thursday";
        break;
    case 6: dayEnglish = "Friday"
        break;
    case 7: dayEnglish = "Saturday";
        break;   
}
switch (month) {
    case 1: monthEnglish = "January";
    break;
    case 2: monthEnglish = "February";
    break;
    case 3: monthEnglish = "March";
    break;
    case 4: monthEnglish = "April";
    break;
    case 5: monthEnglish = "May";
    break;
    case 6: monthEnglish = "June";
    break;
    case 7: monthEnglish = "July";
    break;
    case 8: monthEnglish = "August";
    break;
    case 9: monthEnglish = "September";
    break;
    case 10: monthEnglish = "October";
    break;
    case 11: monthEnglish = "November";
    break;
    case 12: monthEnglish = "December";
    break;
}
let today =document.querySelector(".today")
today.innerHTML=`${dayEnglish}, ${monthEnglish} ${date.getDate()}, ${date.getFullYear()}`;
},0)
