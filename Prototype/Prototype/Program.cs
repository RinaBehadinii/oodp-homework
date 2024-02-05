using Prototype;

var dashboard = new Dashboard();

var dataWidget = new DataWidget("Sales Data");
var chartWidget = new ChartWidget("Pie Chart");

dashboard.AddWidget(dataWidget);
dashboard.AddWidget(chartWidget);

dashboard.DuplicateWidget(0);

dashboard.DisplayWidgets();