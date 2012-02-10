var Logger = Class.create({
    initialize: function () {
        this.log = [];
    },
    write: function (message) {
        this.log.push(message);
    }
});