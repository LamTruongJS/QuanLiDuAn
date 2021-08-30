
//getData
let listturnovers = document.querySelectorAll(".turnover")
let arrayturnover =[]
listturnovers.forEach(function(listturnover) {
  return arrayturnover.push(listturnover)
})
var arraryListturnover = arrayturnover.map(function(listturnover) {
  return listturnover.innerHTML
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
          label:'Turnover',
          data:[
           `${arraryListturnover[0]}`,
           `${arraryListturnover[1]}`,
           `${arraryListturnover[2]}`,
           `${arraryListturnover[3]}`,
           `${arraryListturnover[4]}`,
           `${arraryListturnover[5]}`,
           `${arraryListturnover[6]}`,
           `${arraryListturnover[7]}`,
           `${arraryListturnover[8]}`,
           `${arraryListturnover[9]}`,
           `${arraryListturnover[10]}`,
           `${arraryListturnover[10]}`
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
          }]
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
          label:'Turnover',
          data:[
           `${arraryListturnover[0]}`,
           `${arraryListturnover[1]}`,
           `${arraryListturnover[2]}`,
           `${arraryListturnover[3]}`,
           `${arraryListturnover[4]}`,
           `${arraryListturnover[5]}`,
           `${arraryListturnover[6]}`,
           `${arraryListturnover[7]}`,
           `${arraryListturnover[8]}`,
           `${arraryListturnover[9]}`,
           `${arraryListturnover[10]}`,
           `${arraryListturnover[11]}`
          ],
          //backgroundColor:'green',
          borderWidth:1,
          pointHoverBackgroundColor: "red",
          pointBorderColor:"green",
          pointBackgroundColor:"green",
          strokeColor:"green",
          borderColor:"green",
          tension: 0,
          fill: false,
        },]
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
      label:'Turnover',
      data:[
       `${arraryListturnover[0]}`,
       `${arraryListturnover[1]}`,
       `${arraryListturnover[2]}`,
       `${arraryListturnover[3]}`,
       `${arraryListturnover[4]}`,
       `${arraryListturnover[5]}`,
       `${arraryListturnover[6]}`,
       `${arraryListturnover[7]}`,
       `${arraryListturnover[8]}`,
       `${arraryListturnover[9]}`,
       `${arraryListturnover[10]}`,
       `${arraryListturnover[10]}`
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
