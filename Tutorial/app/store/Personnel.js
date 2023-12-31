Ext.define('Tutorial.store.Personnel', {
    extend: 'Ext.data.Store',

    alias: 'store.personnel',

    model: 'Tutorial.model.Personnel',

    data: { items: [
        { name: 'Jean Luc', email: "jeanluc.picard@enterprise.com", phone: "555-111-1111" },
        { name: 'Worf',     email: "worf.moghsson@enterprise.com",  phone: "555-222-2222" },
        { name: 'Deanna',   email: "deanna.troi@enterprise.com",    phone: "555-333-3333" },
        { name: 'Data', email: "mr.data@enterprise.com", phone: "555-555-5555" },
        { name: 'Data 2', email: "mr.data2@enterprise.com", phone: "555-555-5555" },
    ]},

    proxy: {
        type: 'memory',
        reader: {
            type: 'json',
            rootProperty: 'items'
        }
    }
});
