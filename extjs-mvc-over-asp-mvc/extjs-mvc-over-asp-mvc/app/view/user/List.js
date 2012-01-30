Ext.define('Samurai.view.user.List', {
    extend: 'Ext.grid.Panel',
    alias: 'widget.userlist',

    title: 'All Users',

    store: 'UserStore',

    initComponent: function () {
        this.columns = [
            { text: 'Name', dataIndex: 'Name', flex: 1 },
            { text: 'Email', dataIndex: 'Email', flex: 1 }
        ];

        this.callParent(arguments);
    }
});