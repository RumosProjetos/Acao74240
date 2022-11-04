/**Declaracao das Funcoes*/
function ObterValoresDestaque() {
    $("#boxVendas").html("65");
    $("#boxEntregasPendentes").html("12");
    $("#boxNovosClientes").html("18");
    $("#boxEstoqueBaixo").html("25");

}

function drawChartSales() {
    var data = google.visualization.arrayToDataTable([
        ['Dia da Semana', 'Vendas'],
        ['Segunda', 1000],
        ['Terça', 1170],
        ['Quarta', 660],
        ['Quinta', 1030],
        ['Sexta', 2000],
        ['Sábado', 700],
        ['Domingo', 500],
    ]);

    var options = {
        title: 'Vendas da Semana',
        curveType: 'function',
        legend: { position: 'bottom' }
    };

    var chart = new google.visualization.LineChart(document.getElementById('sales_chart'));

    chart.draw(data, options);
}

function drawChartCustomer() {
    var data = google.visualization.arrayToDataTable([
        ['Dia da Semana', 'Vendas'],
        ['Segunda', 900],
        ['Terça', 1070],
        ['Quarta', 560],
        ['Quinta', 930],
        ['Sexta', 1000],
        ['Sábado', 300],
        ['Domingo', 400]
    ]);

    var options = {
        chart: {
            title: 'Clientes da Semana',
            subtitle: 'Clientes novos na semana de 19/09/2022',
        },
        bars: 'horizontal' // Required for Material Bar Charts.
    };

    var chart = new google.charts.Bar(document.getElementById('customer_chart'));

    chart.draw(data, google.charts.Bar.convertOptions(options));
}


/**Funcoes utilizadas na página**/

google.charts.load('current', { 'packages': ['corechart', 'bar'] });
google.charts.setOnLoadCallback(drawChartSales);
google.charts.setOnLoadCallback(drawChartCustomer);
