Ext.define('Tutorial.store.Users', {
    extend: 'Ext.data.Store',

    alias: 'store.users',

    model: 'Tutorial.model.Users',

    data: { items: [
        { name: 'Jean Luc', email: "jeanluc.picard@enterprise.com", birthday_date: "555-111-1111" },
        { name: 'Worf', email: "worf.moghsson@enterprise.com", birthday_date: "555-222-2222" },
        { name: 'Deanna', email: "deanna.troi@enterprise.com", birthday_date: "555-333-3333" },
        { name: 'Data', email: "mr.data@enterprise.com", birthday_date: "555-555-5555" },
        { name: 'Data 2', email: "mr.data2@enterprise.com", birthday_date: "555-555-5555" },
        { name: 'teste1', email: "teste1@enterprise.com", birthday_date: "555-555-5555" },
    ]},

    proxy: {
        type: 'memory',
        reader: {
            type: 'json',
            rootProperty: 'items'
        }
    }
});
