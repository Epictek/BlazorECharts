window.invokeECharts = {
    charts: new Object(),
    init: function (id, theme, opts) {
        if (!!opts) {
            opts = JSON.parse(opts);
        }
        if (id in invokeECharts.charts) {
            return;
        }
        chart = echarts.init(document.getElementById(id), theme, opts);
        invokeECharts.charts[id] = chart;
    },
    setOption: function (id, option, notMerge, lazyUpdate) {
        option = JSON.parse(option);
        if (!(id in invokeECharts.charts)) {
            return;
        }
        invokeECharts.charts[id].setOption(option, notMerge, lazyUpdate);
    },
    remove: function (id) {
        if (id in invokeECharts.charts) {
            invokeECharts.charts[id].clear();
            if (!invokeECharts.charts[id].isDisposed) {
                invokeECharts.charts[id].dispose();
            }
            delete invokeECharts.charts[id];
        }
    },

};