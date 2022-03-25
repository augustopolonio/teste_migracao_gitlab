/**
 * This view is an example list of people.
 */
Ext.define('Tutorial.view.main.Users', {
    extend: 'Ext.grid.Panel',
    xtype: 'users',

    requires: [
        'Tutorial.store.Users'
    ],

    title: 'Users',

    store: {
        type: 'users'
    },

    columns: [
        { text: 'Nome',  dataIndex: 'name' },
        { text: 'Email', dataIndex: 'email', flex: 1 },
        { text: 'Data Nascimento', dataIndex: 'birthday_date', flex: 1 }
    ],

    listeners: {
        select: 'onItemSelected'
    }
});
