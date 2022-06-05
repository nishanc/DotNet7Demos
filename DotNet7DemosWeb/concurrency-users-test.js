import http from 'k6/http';

export let options = {
    insecureSkipTLSVerify: true,
    maxRedirects: 0,
    vus: 10,
    duration: '5s',
    noConnectionReuse: false
};

export default function () {

    let response = http.get('https://localhost:7055/WeatherForecast');
    check(response, {
        'is status 200': (res) => res.status === 200
    });
};