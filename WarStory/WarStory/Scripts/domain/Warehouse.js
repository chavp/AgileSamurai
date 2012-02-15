var Warehouse = function (config) {
    this.name = config.name;
    this.wood = parseInt(config.wood);
    this.stone = parseInt(config.stone);
    this.iron = parseInt(config.iron);

    this.forestLv = parseInt(config.forestLv);
    this.mineLv = parseInt(config.mineLv);
    this.mountainLv = parseInt(config.mountainLv);
}

Warehouse.prototype.action = function () {
    //console.log(this.name + ".action");

    this.wood = this.wood + this.forestLv;
    this.stone = this.stone + this.mountainLv;
    this.iron = this.iron + this.mineLv;
}
