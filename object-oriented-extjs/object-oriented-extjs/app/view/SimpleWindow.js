
Ext.define('app.view.SimpleWindow', {
    extend: 'Ext.Window',
    title: 'Welcome!',

    config: {
        note: 'Whatup!'
    },

    mixins: {
        console: 'app.mixins.Log'
    },

    initComponent: function () {
        this.items = [
            { xtype: 'textfield', name: 'tfName', fieldLabel: 'Enter your name' }
        ];

        this.callParent(arguments);
    }
});