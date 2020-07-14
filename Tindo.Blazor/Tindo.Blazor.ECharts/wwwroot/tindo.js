window.invokeECharts = {
    charts: {},
    init: function (id, theme = 'light', showLoading = true, opts = null) {
        chart = echarts.init(document.getElementById(id), theme, opts)
        if (showLoading) {
            chart.showLoading();
        }
        charts[id] = chart;
    },

    showLoading: function (id) {
        if (id in this.charts) {
            this.charts[id].showLoading();
        } else {
            invokeECharts.initChart(id);
        }
    },

    get: function (id) {
        return this.charts[id];
    },

    set: function (id, chart) {
        this.charts[id] = chart;
    },

    remove: function (id) {
        if (id in this.charts) {
            delete this.charts[id];
        }
    },

    setup: function (id, option, notMerge, lazyUpdate) {
        if (!(id in this.charts)) {
            invokeECharts.init(id);
        }
        this.charts[id].hideLoading();
        this.charts[id].setOption(option, notMerge, lazyUpdate);
    }
}