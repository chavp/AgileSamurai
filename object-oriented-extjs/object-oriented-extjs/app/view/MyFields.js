Ext.define('MyApp.view.MyFields', {
    extend: 'Ext.Panel',
    alias: 'widget.myfields',

    initComponent: function () {
        this.items = [{ xtype: 'textfield', fieldLabel: 'MyFields1' }];
        //Ext.apply(this);
        //MyApp.view.MyFields2.supperclass.initComponent.call(this);
    }
});