Ext.Loader.setConfig({ enabled: true });

Ext.application({
    name: 'Samurai',
    appFolder: 'desktop',
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