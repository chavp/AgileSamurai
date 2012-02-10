// define a module
var Vulnerable = {
    wound: function (hp) {
        this.health -= hp;
        if (this.health < 0) this.kill();
    },
    kill: function () {
        this.dead = true;
    }
};