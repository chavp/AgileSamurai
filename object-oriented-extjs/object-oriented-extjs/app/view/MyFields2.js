Ext.define('MyApp.view.MyFields2', {
    extend: 'MyApp.view.MyFields',
    alias: 'widget.myfields2',

    initComponent: function () {
        this.items = [{ xtype: 'textfield', fieldLabel: 'MyFields2'}];
        //Ext.apply(this);
        //MyApp.view.MyFields2.supperclass.initComponent.call(this);
    },

    buildItems: function () {
        return [{ xtype: 'textfield', fieldLabel: 'MyFields2'}];
    }

});