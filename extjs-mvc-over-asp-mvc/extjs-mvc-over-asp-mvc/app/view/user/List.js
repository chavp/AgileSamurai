Ext.define('Samurai.view.user.List', {
    extend: 'Ext.grid.Panel',
    alias: 'widget.userlist',

    title: 'All Users',

    store: 'UserStore',

    initComponent: function () {
        this.columns = [
            { text: 'Name', dataIndex: 'name', flex: 1 },
            { text: 'Email', dataIndex: 'email', flex: 1 }
        ];

        this.callParent(arguments);
    }
});