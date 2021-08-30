// window.onload = function() {
    
//     document.querySelector(".list_1").classList.add('border-bottom-0');
    
//     document.querySelector(".list_2").classList.add('border-bottom-0');
    
// }
var list_1= document.querySelector(".list_1")
list_1.addEventListener("click", function(){
var item_1= document.querySelector(".item_1")
list_1.classList.add("bg-success")
list_1.classList.remove("text-muted")
list_1.classList.add("text-white")

list_1.classList.add("fw-bold")
list_1.classList.remove("bg-white")
if(document.querySelector('.list_2').classList.contains("bg-success"))
{
    document.querySelector('.list_2').classList.remove("bg-success")
    document.querySelector('.list_2').classList.add("text-muted")
    document.querySelector('.list_2').classList.remove("text-white")
    document.querySelector('.list_2').classList.remove("fw-bold")
    document.querySelector('.list_2').classList.add("bg-white")
}
if(document.querySelector('.list_3').classList.contains("bg-success"))
{
    document.querySelector('.list_3').classList.remove("bg-success")
    document.querySelector('.list_3').classList.add("text-muted")
    document.querySelector('.list_3').classList.remove("text-white")
    document.querySelector('.list_3').classList.remove("fw-bold")
    document.querySelector('.list_3').classList.add("bg-white")
}

var items = item_1.querySelectorAll("a")
    items.forEach(function(item) {
        item.addEventListener('click', function(){
            
            list_1.classList.add("bg-success")
            list_1.classList.add("text-white")
            list_1.classList.remove("text-muted")
            list_1.classList.add("fw-bold")
            list_1.classList.remove("bg-white")
         
        })
    })
})

var list_2= document.querySelector(".list_2")
list_2.addEventListener("click", function(){
var item_2= document.querySelector(".item_2")
list_2.classList.remove('border-bottom-0');
list_2.classList.add("bg-success")
list_2.classList.add("text-white")
list_2.classList.remove("text-muted")
list_2.classList.add("fw-bold")
list_2.classList.remove("bg-white")
if(document.querySelector('.list_1').classList.contains("bg-success"))
{
    document.querySelector('.list_1').classList.remove("bg-success")
    document.querySelector('.list_1').classList.add("text-muted")
    document.querySelector('.list_1').classList.remove("text-white")
    document.querySelector('.list_1').classList.remove("fw-bold")
    document.querySelector('.list_1').classList.add("bg-white")
}
if(document.querySelector('.list_3').classList.contains("bg-success"))
{
    document.querySelector('.list_3').classList.remove("bg-success")
    document.querySelector('.list_3').classList.add("text-muted")
    document.querySelector('.list_3').classList.remove("text-white")
    document.querySelector('.list_3').classList.remove("fw-bold")
    document.querySelector('.list_3').classList.add("bg-white")
}

var items = item_2.querySelectorAll("a")
    items.forEach(function(item) {
        item.addEventListener('click', function(){
        
            list_2.classList.add("bg-success")
            
            list_2.classList.add("text-white")
            list_2.classList.remove("text-muted")
            list_2.classList.add("fw-bold")
            list_2.classList.remove("bg-white")
          
        })
    })
})

var list_3= document.querySelector(".list_3")
list_3.addEventListener("click", function(){
var item_3= document.querySelector(".item_3")

list_3.classList.add("bg-success")
list_3.classList.add("text-white")
list_3.classList.remove("text-muted")
list_3.classList.add("fw-bold")
list_3.classList.remove("bg-white")
if(document.querySelector('.list_1').classList.contains("bg-success"))
{
    document.querySelector('.list_1').classList.remove("bg-success")
    document.querySelector('.list_1').classList.add("text-muted")
    document.querySelector('.list_1').classList.remove("text-white")
    document.querySelector('.list_1').classList.remove("fw-bold")
    document.querySelector('.list_1').classList.add("bg-white")
}
if(document.querySelector('.list_2').classList.contains("bg-success"))
{
    document.querySelector('.list_2').classList.remove("bg-success")
    document.querySelector('.list_2').classList.add("text-muted")
    document.querySelector('.list_2').classList.remove("text-white")
    document.querySelector('.list_2').classList.remove("fw-bold")
    document.querySelector('.list_2').classList.add("bg-white")
}

var items = item_3.querySelectorAll("a")
    items.forEach(function(item) {
        item.addEventListener('click', function(){
           
            
            list_3.classList.add("bg-success")
            list_3.classList.add("text-white")
            list_3.classList.remove("text-muted")
            list_3.classList.add("fw-bold")
            list_3.classList.remove("bg-white")
           
        })
    })
})

var list3 = document.querySelector(".list_item_3")
list3.addEventListener("click",function(){
   
    var item_3 = document.querySelector(".item_3")
    item_3.classList.add("item")
    if(document.querySelector(".item_2").classList.contains("item")){
        document.querySelector(".item_2").classList.remove("item")
        document.querySelector(".item_2").classList.add("item_2")
    }
    if(document.querySelector(".item_1").classList.contains("item")){
        document.querySelector(".item_1").classList.remove("item")
        document.querySelector(".item_1").classList.add("item_1")
    }
})
var list2 = document.querySelector(".list_item_2")
list2.addEventListener("click",function(){
    var item_2 = document.querySelector(".item_2")
    item_2.classList.add("item")
    if(document.querySelector(".item_3").classList.contains("item")){
        document.querySelector(".item_3").classList.remove("item")
        document.querySelector(".item_3").classList.add("item_3")
    }
    if(document.querySelector(".item_1").classList.contains("item")){
        document.querySelector(".item_1").classList.remove("item")
        document.querySelector(".item_1").classList.add("item_1")
    }
})
var list1 = document.querySelector(".list_item_1")
list1.addEventListener("click",function(){
    var item_1 = document.querySelector(".item_1")
    item_1.classList.add("item")
    if(document.querySelector(".item_3").classList.contains("item")){
        document.querySelector(".item_3").classList.remove("item")
        document.querySelector(".item_3").classList.add("item_3")
    }
    if(document.querySelector(".item_2").classList.contains("item")){
        document.querySelector(".item_2").classList.remove("item")
        document.querySelector(".item_2").classList.add("item_2")
    }
})

