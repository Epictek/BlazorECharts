window.invokeECharts = {
    init: function (id, opts = null, theme = 'light') {
        chart = echarts.init(document.getElementById(id), theme)
        if (opts) {
            option = JSON.parse(opts);
            chart.setOption(option);
        }
        window.charts[id] = chart;
    },

    remove: function (id) {
        if (id in window.charts) {
            var chart = window.charts[id];
            chart.clear();
            delete window.charts[id];
        }
    },

    setup: function (id, opts, notMerge, lazyUpdate) {
        if (!(id in window.charts)) {
            invokeECharts.init(id);
        }
        option = JSON.parse(opts);
        window.charts[id].hideLoading();
        window.charts[id].setOption(option, notMerge, lazyUpdate);
    }
};

window.charts = {};