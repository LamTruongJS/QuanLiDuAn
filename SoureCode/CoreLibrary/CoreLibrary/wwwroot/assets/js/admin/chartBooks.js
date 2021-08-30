
//getData
let bookPush = document.querySelectorAll(".bookPush")
let arrayBookPush =[]
bookPush.forEach(function(bookPushitem) {
  return arrayBookPush.push(bookPushitem)
})
// trả về 1 mảng chỉ lấy text
var arrayListBookPush = arrayBookPush.map(function(arrayBook) {
  return arrayBook.innerHTML
})

//getData
let bookDown = document.querySelectorAll(".bookDown")
let arraybookDown =[]
bookDown.forEach(function(bookDownitem) {
  return arraybookDown.push(bookDownitem)
})
// trả về 1 mảng chỉ lấy text
var arrayListbookDown = arraybookDown.map(function(arrayBook) {
  return arrayBook.innerHTML
})


// Chart bar
    var myChartBar = document.querySelector('#myChartBar').getContext('2d');
    // Global Options
    Chart.defaults.global.defaultFontFamily = 'Lato';
    Chart.defaults.global.defaultFontSize = 18;
    Chart.defaults.global.defaultFontColor = '#777';

    configBar= {
      type:'bar', // bar, horizontalBar, pie, line, HorizontalBar, radar, polarArea
      data:{
        labels:['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov','Dec'],
        datasets:[{
          label:'Book Upload',
          data:[
           `${arrayListBookPush[0]}`,
           `${arrayListBookPush[1]}`,
           `${arrayListBookPush[2]}`,
           `${arrayListBookPush[3]}`,
           `${arrayListBookPush[4]}`,
           `${arrayListBookPush[5]}`,
           `${arrayListBookPush[6]}`,
           `${arrayListBookPush[7]}`,
           `${arrayListBookPush[8]}`,
           `${arrayListBookPush[9]}`,
           `${arrayListBookPush[10]}`,
           `${arrayListBookPush[11]}`
          ],
          //backgroundColor:'green',
          backgroundColor:[
            'rgba(11, 232, 129,1.0)',
            'rgba(11, 232, 129,1.0)',
            'rgba(11, 232, 129,1.0)',
            'rgba(11, 232, 129,1.0)',
            'rgba(11, 232, 129,1.0)',
            'rgba(11, 232, 129,1.0)',
            'rgba(11, 232, 129,1.0)',
            'rgba(11, 232, 129,1.0)',
            'rgba(11, 232, 129,1.0)',
            'rgba(11, 232, 129,1.0)',
            'rgba(11, 232, 129,1.0)',
            'rgba(11, 232, 129,1.0)',
          ],
          borderWidth:1,
          borderColor:'#777',
        
          hoverBorderWidth:3,
          hoverBorderColor:[
            'rgba(11, 232, 129,1.0)',
            'rgba(11, 232, 129,1.0)',
            'rgba(11, 232, 129,1.0)',
            'rgba(11, 232, 129,1.0)',
            'rgba(11, 232, 129,1.0)',
            'rgba(11, 232, 129,1.0)',
            'rgba(11, 232, 129,1.0)',
            'rgba(11, 232, 129,1.0)',
            'rgba(11, 232, 129,1.0)',
            'rgba(11, 232, 129,1.0)',
            'rgba(11, 232, 129,1.0)',
            'rgba(11, 232, 129,1.0)',
          ],
        },
        {
          label:'Book Purcharsed',
          data:[
            `${arrayListbookDown[0]}`,
            `${arrayListbookDown[1]}`,
            `${arrayListbookDown[2]}`,
            `${arrayListbookDown[3]}`,
            `${arrayListbookDown[4]}`,
            `${arrayListbookDown[5]}`,
            `${arrayListbookDown[6]}`,
            `${arrayListbookDown[7]}`,
            `${arrayListbookDown[8]}`,
            `${arrayListbookDown[9]}`,
            `${arrayListbookDown[10]}`,
            `${arrayListbookDown[11]}`
          ],
          //backgroundColor:'green',
          backgroundColor:[
            'rgba(0, 216, 214,1.0)',
            'rgba(0, 216, 214,1.0)',
            'rgba(0, 216, 214,1.0)',
            'rgba(0, 216, 214,1.0)',
            'rgba(0, 216, 214,1.0)',
            'rgba(0, 216, 214,1.0)',
            'rgba(0, 216, 214,1.0)',
            'rgba(0, 216, 214,1.0)',
            'rgba(0, 216, 214,1.0)',
            'rgba(0, 216, 214,1.0)',
            'rgba(0, 216, 214,1.0)',
            'rgba(0, 216, 214,1.0)',
          ],
          borderWidth:1,
          borderColor:'#777',
          hoverBorderWidth:3,
          hoverBorderColor:[
            'rgba(0, 216, 214,1.0)',
            'rgba(0, 216, 214,1.0)',
            'rgba(0, 216, 214,1.0)',
            'rgba(0, 216, 214,1.0)',
            'rgba(0, 216, 214,1.0)',
            'rgba(0, 216, 214,1.0)',
            'rgba(0, 216, 214,1.0)',
            'rgba(0, 216, 214,1.0)',
            'rgba(0, 216, 214,1.0)',
            'rgba(0, 216, 214,1.0)',
            'rgba(0, 216, 214,1.0)',
            'rgba(0, 216, 214,1.0)',
          ],
        }
      ]
      },
      options:{
        
        legend:{
          display:true,
          position:'top',
          labels:{
            fontColor:'#000'
          }
        },
        scales: {
          yAxes: [{
              ticks: {
                  beginAtZero: true
              }
          }],
          
          
        },
        tooltips:{
          enabled:true
        },
        
    }
  }
    var myChartBar = new Chart(myChartBar, configBar)


// Chart Line
    let myChartLine = document.querySelector('#myChartLine').getContext('2d');
    // Global Options
    Chart.defaults.global.defaultFontFamily = 'Lato';
    Chart.defaults.global.defaultFontSize = 18;
    Chart.defaults.global.defaultFontColor = '#777';

  var configLine= {
      type:'line', // bar, horizontalBar, pie, line, HorizontalBar, radar, polarArea
      data:{
        labels:['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov','Dec'],
        datasets:[{
          label:'Book Up',
          data:[
            `${arrayListBookPush[0]}`,
            `${arrayListBookPush[1]}`,
            `${arrayListBookPush[2]}`,
            `${arrayListBookPush[3]}`,
            `${arrayListBookPush[4]}`,
            `${arrayListBookPush[5]}`,
            `${arrayListBookPush[6]}`,
            `${arrayListBookPush[7]}`,
            `${arrayListBookPush[8]}`,
            `${arrayListBookPush[9]}`,
            `${arrayListBookPush[10]}`,
            `${arrayListBookPush[11]}`
          ],
          borderWidth:1,
          pointHoverBackgroundColor: "red",
          pointBorderColor:"blue",
          pointBackgroundColor:"blue",
          borderColor:"blue",
          tension: 0,
          fill: false,
        },
        {
          label:'Book Down',
          data:[
            `${arrayListbookDown[0]}`,
            `${arrayListbookDown[1]}`,
            `${arrayListbookDown[2]}`,
            `${arrayListbookDown[3]}`,
            `${arrayListbookDown[4]}`,
            `${arrayListbookDown[5]}`,
            `${arrayListbookDown[6]}`,
            `${arrayListbookDown[7]}`,
            `${arrayListbookDown[8]}`,
            `${arrayListbookDown[9]}`,
            `${arrayListbookDown[10]}`,
            `${arrayListbookDown[11]}`
          ],
          //backgroundColor:'green',
          borderWidth:1,
          pointHoverBackgroundColor: "red",
          pointBorderColor:"green",
          pointBackgroundColor:"green",
          borderColor:"green",
          tension: 0,
          fill: false,
        }]
      },
      options: {
        responsive: true,
        plugins: {
          legend: {
            position: 'top',
          },
        },
        tooltips:{
          enabled: true
        }, 
      },
    }

// chart HorizontalBar


let myChartHorizontalBar = document.querySelector('#myChartHorizontalBar').getContext('2d');
// Global Options
Chart.defaults.global.defaultFontFamily = 'Lato';
Chart.defaults.global.defaultFontSize = 18;
Chart.defaults.global.defaultFontColor = '#777';

var configHorizontalBar= {
  type:'horizontalBar', // bar, horizontalBar, pie, line, HorizontalBar, radar, polarArea
  data:{
    labels:['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov','Dec'],
    datasets:[{
      label:'Book Up',
      data:[
        `${arrayListBookPush[0]}`,
        `${arrayListBookPush[1]}`,
        `${arrayListBookPush[2]}`,
        `${arrayListBookPush[3]}`,
        `${arrayListBookPush[4]}`,
        `${arrayListBookPush[5]}`,
        `${arrayListBookPush[6]}`,
        `${arrayListBookPush[7]}`,
        `${arrayListBookPush[8]}`,
        `${arrayListBookPush[9]}`,
        `${arrayListBookPush[10]}`,
        `${arrayListBookPush[11]}`
      ],
      //backgroundColor:'green',
      backgroundColor:[
        'rgba(11, 232, 129,1.0)',
        'rgba(11, 232, 129,1.0)',
        'rgba(11, 232, 129,1.0)',
        'rgba(11, 232, 129,1.0)',
        'rgba(11, 232, 129,1.0)',
        'rgba(11, 232, 129,1.0)',
        'rgba(11, 232, 129,1.0)',
        'rgba(11, 232, 129,1.0)',
        'rgba(11, 232, 129,1.0)',
        'rgba(11, 232, 129,1.0)',
        'rgba(11, 232, 129,1.0)',
        'rgba(11, 232, 129,1.0)',
      ],
      borderWidth:1,
      borderColor:'#777',
      hoverBorderWidth:3,
      hoverBorderColor:[
        'rgba(11, 232, 129,1.0)',
        'rgba(11, 232, 129,1.0)',
        'rgba(11, 232, 129,1.0)',
        'rgba(11, 232, 129,1.0)',
        'rgba(11, 232, 129,1.0)',
        'rgba(11, 232, 129,1.0)',
        'rgba(11, 232, 129,1.0)',
        'rgba(11, 232, 129,1.0)',
        'rgba(11, 232, 129,1.0)',
        'rgba(11, 232, 129,1.0)',
        'rgba(11, 232, 129,1.0)',
        'rgba(11, 232, 129,1.0)',
      ],
    },
    {
      label:'Book Down',
      data:[
        `${arrayListbookDown[0]}`,
        `${arrayListbookDown[1]}`,
        `${arrayListbookDown[2]}`,
        `${arrayListbookDown[3]}`,
        `${arrayListbookDown[4]}`,
        `${arrayListbookDown[5]}`,
        `${arrayListbookDown[6]}`,
        `${arrayListbookDown[7]}`,
        `${arrayListbookDown[8]}`,
        `${arrayListbookDown[9]}`,
        `${arrayListbookDown[10]}`,
        `${arrayListbookDown[11]}`
      ],
      //backgroundColor:'green',
      backgroundColor:[
        'rgba(0, 216, 214,1.0)',
        'rgba(0, 216, 214,1.0)',
        'rgba(0, 216, 214,1.0)',
        'rgba(0, 216, 214,1.0)',
        'rgba(0, 216, 214,1.0)',
        'rgba(0, 216, 214,1.0)',
        'rgba(0, 216, 214,1.0)',
        'rgba(0, 216, 214,1.0)',
        'rgba(0, 216, 214,1.0)',
        'rgba(0, 216, 214,1.0)',
        'rgba(0, 216, 214,1.0)',
        'rgba(0, 216, 214,1.0)',
      ],
      borderWidth:1,
      borderColor:'#777',
      hoverBorderWidth:3,
      hoverBorderColor:[
        'rgba(0, 216, 214,1.0)',
        'rgba(0, 216, 214,1.0)',
        'rgba(0, 216, 214,1.0)',
        'rgba(0, 216, 214,1.0)',
        'rgba(0, 216, 214,1.0)',
        'rgba(0, 216, 214,1.0)',
        'rgba(0, 216, 214,1.0)',
        'rgba(0, 216, 214,1.0)',
        'rgba(0, 216, 214,1.0)',
        'rgba(0, 216, 214,1.0)',
        'rgba(0, 216, 214,1.0)',
        'rgba(0, 216, 214,1.0)',
      ],
    }
  ]
  },
  options:{
    
    legend:{
      display:true,
      position:'top',
      labels:{
        fontColor:'#000'
      }
    },
    scales: {
      xAxes: [{
          ticks: {
              beginAtZero: true
          }
      }]
    },
    tooltips:{
      enabled:true
    },
    
}
}


    document.querySelector('.itemBar').onclick = function (){
      myChartBar = new Chart(myChartBar, configBar);
    }
    document.querySelector('.itemLine').onclick = function(){
      myChartLine = new Chart(myChartLine, configLine);
    }
    document.querySelector('.itemHorizontalBar').onclick = function(){
      myChartHorizontalBar = new Chart(myChartHorizontalBar, configHorizontalBar);
    }
