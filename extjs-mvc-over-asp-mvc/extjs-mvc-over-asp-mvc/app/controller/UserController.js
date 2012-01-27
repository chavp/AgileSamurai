Ext.define('Samurai.controller.UserController', {
    extend: 'Ext.app.Controller',

    views: [
        'user.List',
        'user.Edit'
    ],

    stores: [
        'UserStore'
    ],

    models: ['User'],

    init: function () {
        this.control({
            'viewport > userlist': {
                itemdblclick: this.editUser
            },
            'useredit button[action=save]': {
                click: this.updateUser
            }
        });
    },

    updateUser: function (button) {

        var win = button.up('window'),
        form = win.down('form'),
        record = form.getRecord(),
        values = form.getValues();
        console.log(Ext.encode(values));
        record.set(values);
        win.close();

        this.getUserStoreStore().sync();

        console.log("getUsersStore().sync()");
    },

    editUser: function (grid, record) {
        var view = Ext.widget('useredit');

        view.down('form').loadRecord(record);
    },

    onPanelRendered: function () {
        console.log('The panel was rendered');
    }
});