{
     var num_stock = document.querySelector('input');
     cntBtn.addEventListener('click', function(){
        try{
            console.log(num_stock.value);
            const itog_cntItem = document.getElementById('itog_cnt');
            itog_cntItem.innerHTML = "";
            for(let x = 0; x < 11; x++){
                const tableItem = document.createElement('div');
                itog_cntItem.innerHTML = x*num_stock.value;
                itog_cntItem.appendChild(tableItem);
                console.log(x*num_stock.value);
            }
            itog_cntItem.innerHTML = `<p>Таблица умножения: ${num_stock.value}</p></br>`;
        } catch(error){
            console.error('Account error', error);
        }
     })

}