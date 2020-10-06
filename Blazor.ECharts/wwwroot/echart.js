var dotnetInstance;

window.invokeECharts = {
    charts: new Object(),
    init: function (id, theme, opts) {
        if (!!opts) {
            opts = eval('(' + opts + ')');

        }

        if (id in invokeECharts.charts) {
            return;
        }
        chart = echarts.init(document.getElementById(id), theme, opts);
        invokeECharts.charts[id] = chart;



        var dataZoom = invokeECharts.charts[id].on("dataZoom", function (params) {
            dotnetInstance.invokeMethod('OnDataZoom');
            console.log("callback");
        })

    },

    setOption: function (id, option, notMerge, lazyUpdate) {
        console.log(option);

        option = eval('(' + option + ')');
        if (!(id in invokeECharts.charts)) {
            return;
        }
        invokeECharts.charts[id].setOption(option, notMerge, lazyUpdate);
    },


    showLoading: function (id, type, opts) {
        if (!(id in invokeECharts.charts)) {
            return;
        }
        if (opts) {
            invokeECharts.charts[id].showLoading(type, opts);
        } else {
            invokeECharts.charts[id].showLoading(type);
        }
    },

    hideLoading: function (id, type, opts) {
        if (!(id in invokeECharts.charts)) {
            return;
        }
        invokeECharts.charts[id].hideLoading();
    },

    appendData: function (id, opts) {
        if (!(id in invokeECharts.charts)) {
            return;
        }

        opts = eval('(' + opts + ')');

        invokeECharts.charts[id].appendData(opts);
    },

    getOption: function (id) {

        if (!(id in invokeECharts.charts)) {
            return;
        }
        var option = invokeECharts.charts[id].getOption();
        //todo: implement type for GetOption
        return JSON.stringify(option);
    },

    getInsideDataZoomStart: function (id) {
        if (!(id in invokeECharts.charts)) {
            return;
        }

        var dataZoom = invokeECharts.charts[id].getOption().dataZoom[0].startValue;
        console.log(dataZoom);
        return dataZoom;
    },

    getInsideDataZoomEnd: function (id) {
        if (!(id in invokeECharts.charts)) {
            return;
        }

        var dataZoom = invokeECharts.charts[id].getOption().dataZoom[0].endValue;
        console.log(dataZoom);
        return dataZoom;
    },

    initCallback: function (id) {
        console.log("initCallback");

        if (!(id in invokeECharts.charts)) {
            return;
        }

        var dataZoom = invokeECharts.charts[id].on("dataZoom", function (params) {
            dotnetInstance.invokeMethod('OnDataZoom');
            console.log("callback");
        })

        return;
    },

    InitDotnetRef: function (instance) {
        dotnetInstance = instance;
        return true;
    },

    dispatchAction: function (id, action) {
        console.log(action)

        action = JSON.parse(action)

        if (!(id in invokeECharts.charts)) {
            return;
        }
        console.log(action);
        invokeECharts.charts[id].dispatchAction(action);
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

    resize: function (id) {
        if (!(id in invokeECharts.charts)) {
            return;
        }
        invokeECharts.charts[id].resize();
    },

    exist: function (id) {
        if (!!document.getElementById(id)) {
            return true;
        }
        else {
            return false;
        }
    }

};