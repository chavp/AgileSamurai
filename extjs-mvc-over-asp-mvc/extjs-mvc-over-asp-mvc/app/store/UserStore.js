Ext.define('Samurai.store.UserStore', {
    extend: 'Ext.data.Store',
    model: 'Samurai.model.User',
    autoLoad: true,

    proxy: {
        type: 'ajax',
        api: {
            read: 'app/data/users.json',
            update: 'User/Update'
        },
        reader: {
            type: 'json',
            root: 'users',
            successProperty: 'success'
        }
    }
});