var Pirate = Class.create(Person, {
    // redefine the speak method
    say: function (message) {
        return this.name + ': ' + message + ', yarr!';
    }
});

Pirate.allHandsOnDeck = function (n) {
    var voices = [];
    n.times(function (i) {
        voices.push(new Pirate('Sea dog').say(i + 1));
    });
    return voices;
}