var Person = Class.create(Vulnerable, {
    initialize: function (name) {
        this.name = name;
        this.health = 100;
        this.dead = false;
    },
    say: function (message) {
        return this.name + ': ' + message;
    }
});
