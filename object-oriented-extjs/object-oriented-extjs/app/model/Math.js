Ext.define('app.model.Math', {
    statics: {
        count: 0,
        appName: 'Math',

        sum: function (n1, n2) {
            return n1 + n2;
        }
    },

    constructor: function () {
        this.statics().count++;

    }
});

Ext.define('app.model.MoreMath', {
    extend: 'app.model.Math',

    statics: {
        appName: 'MoreMath',
        multiply: function (n1, n2) {
            return n1 * n2;
        }
    },

    constructor: function () {
        this.callParent();
    }
});