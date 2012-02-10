Ext.Loader.setConfig({ enabled: true });

Ext.application({
    name: 'MyApp',
    appFolder: 'app',
    controllers: [
        'MyAppController'
    ],
    launch: function () {

        Ext.create('Ext.container.Viewport', {
            
            layout: 'fit',
            items: [{
                xtype: 'panel',
                title: 'Hello',
                items: [{ xtype: 'myfields'}]
            }]
        });
    }
});