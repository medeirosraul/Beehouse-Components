var OwlCharts = new Array();

window.OwlCreateChart = (chartObject) => {
    console.log(chartObject);
    let id = chartObject.id;
    let element = document.getElementById(id);
    console.log(element);
    let context = document.getElementById(id).getContext('2d');
    let chart = new Chart(context, chartObject)
}