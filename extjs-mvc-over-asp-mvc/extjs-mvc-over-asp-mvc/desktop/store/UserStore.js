Ext.define('Samurai.store.UserStore', {
    extend: 'Ext.data.Store',
    model: 'Samurai.model.User',
    autoLoad: true,
    autoSync: true,

    proxy: {
        type: 'ajax',
        api: {
            read: 'User/GetUsers',
            update: 'User/Update'
        },
        reader: {
            type: 'json',
            root: 'users',
            successProperty: 'success'
        }
    }
});