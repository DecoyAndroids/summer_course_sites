document.addEventListener("DOMContentLoaded", function() {
    const getWeatherBtn = document.getElementById('getWeatherBtn');
    getWeatherBtn.addEventListener('click', async function(){
            try{
                const response = await axios.get('http://localhost:5197/weatherforecast');
                console.log(response.data);
                const forecastDiv = document.getElementById('forecast');
                forecastDiv.innerHTML = '';
                response.data.forEach(forecast => {
                    const forecastItem = document.createElement('div');
                    forecastItem.innerHTML = `
                        <p>Date: ${forecast.date}</p>
                        <p>Temperature (C): ${forecast.temperatureC}</p>
                        <p>Temperature (F): ${forecast.temperatureF}</p>
                        <p>Summary: ${forecast.summary}</p>
                    `;
                    forecastDiv.appendChild(forecastItem);
                });
            }   catch( error ) {
                console.error('Axios error:', error);
            }      
    });

    const postButton = document.getElementById('postBtn');
    postButton.addEventListener('click', async function(){
        try{
            const response = await fetch('http://localhost:5197/submitdata',{
                method:'POST',
                headers:{
                    'Content-Type':'application/json'
                },
                body: JSON.stringify({name:'Dio', age:124})    
            });
            if (!response.ok){
                throw new Error('Network response not ok');
            }
            const data = await response.json();
            console.log(data);
            const postResultContainer = document.getElementById('postResult');
            postResultContainer.innerHTML = '';
            postResultContainer.innerHTML = JSON.stringify(data);
            } catch(error){
                console.error('fetch error: ', error);
            }
            })
            }
)