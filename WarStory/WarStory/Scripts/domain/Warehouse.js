var Warehouse = function (name) {
    this.name = name;
    this.wood = 0;
    this.stone = 0;
    this.iron = 0;
}

Warehouse.prototype.action = function () {
    console.log(this.name + ".action");

    this.wood++;
    this.stone++;
    this.iron++;
}
