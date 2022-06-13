let items=document.querySelectorAll(`.cars-menu .menu-item`);
items.forEach(e=>{
    e.onclick=function(){
        document.querySelector(`.cars-menu .menu-item.active`).classList.remove('active');
        document.querySelector(`.menu-img1 .menu-img.active`).classList.remove('active');
        let tab=document.querySelector(this.getAttribute('data-target'));
        tab.classList.add('active')
    }
})