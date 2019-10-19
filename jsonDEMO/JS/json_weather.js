// Timothy Clubine
// WDD229-O
// Assignment 6: JSON Practice
// 10-19-2019

/**********   PRACTICE EXERCISES   *******************/
//1. Create a JSON object in the blank json_weather.js file using the provided weatherData.txt file.
// Use the following line if code to test your new file: console.log(data.results.forecast[2].day);
var data =
    {"results": {
            "forecast": [
                {
                    "date": "17 OCT 2014",
                    "day": "Friday",
                    "high": 80,
                    "low": 62,
                    "text": "Sunny"
                },
                {
                    "date": "18 OCT 2014",
                    "day": "Saturday",
                    "high": 82,
                    "low": 63,
                    "text": "Partly Cloudy"
                },
                {
                    "date": "19 OCT 2014",
                    "day": "Sun",
                    "high": 85,
                    "low": 65,
                    "text": "Partly Cloudy"
                }
            ]
        }
    };

//test
console.log(data.results.forecast[2].day);

// 2. Console.log the forecast for the next 3 days in sentence (String) format
// example: Today is Saturday. The high is 82. The low is 65. It will be partly cloudy.

for(i = 0; i < data.results.forecast.length; i++){
    console.log('On ' + data.results.forecast[i].day +
        ', the high is ' + data.results.forecast[i].high +
        ', the low is ' + data.results.forecast[i].low +
        ', and it will be ' + data.results.forecast[i].text + '.');

};


// 3. Console.log each of the employees showing their full names (from the object "employees"
// and jobs (from the object "people").