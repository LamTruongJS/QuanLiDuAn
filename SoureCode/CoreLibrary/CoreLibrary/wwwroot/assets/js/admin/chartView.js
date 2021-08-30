
//getData
let listviews = document.querySelectorAll(".view")
let arrayView =[]
listviews.forEach(function(listview) {
  return arrayView.push(listview)
})
var arraryListView = arrayView.map(function(listview) {
  return listview.innerHTML
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
            label:'Purchased',
          data:[
           `${arraryListView[0]}`,
           `${arraryListView[1]}`,
           `${arraryListView[2]}`,
           `${arraryListView[3]}`,
           `${arraryListView[4]}`,
           `${arraryListView[5]}`,
           `${arraryListView[6]}`,
           `${arraryListView[7]}`,
           `${arraryListView[8]}`,
           `${arraryListView[9]}`,
           `${arraryListView[10]}`,
           `${arraryListView[10]}`
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
            label:'Purchased',
          data:[
           `${arraryListView[0]}`,
           `${arraryListView[1]}`,
           `${arraryListView[2]}`,
           `${arraryListView[3]}`,
           `${arraryListView[4]}`,
           `${arraryListView[5]}`,
           `${arraryListView[6]}`,
           `${arraryListView[7]}`,
           `${arraryListView[8]}`,
           `${arraryListView[9]}`,
           `${arraryListView[10]}`,
           `${arraryListView[11]}`
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
        label:'Purchased',
      data:[
       `${arraryListView[0]}`,
       `${arraryListView[1]}`,
       `${arraryListView[2]}`,
       `${arraryListView[3]}`,
       `${arraryListView[4]}`,
       `${arraryListView[5]}`,
       `${arraryListView[6]}`,
       `${arraryListView[7]}`,
       `${arraryListView[8]}`,
       `${arraryListView[9]}`,
       `${arraryListView[10]}`,
       `${arraryListView[10]}`
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
