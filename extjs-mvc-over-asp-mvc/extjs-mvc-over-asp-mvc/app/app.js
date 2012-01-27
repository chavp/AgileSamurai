Ext.Loader.setConfig({ enabled: true });

Ext.application({
    name: 'Samurai',
    path: 'app',
    controllers: [
        'UserController'
    ],
    launch: function () {

        Ext.create('Ext.container.Viewport', {
            layout: 'fit',
            items: {
                xtype: 'userlist'
            }
        });
    }
});