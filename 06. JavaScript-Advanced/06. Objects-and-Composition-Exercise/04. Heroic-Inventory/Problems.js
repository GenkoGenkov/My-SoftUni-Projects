function solve(input) {

    let result = [];

    for (let item of input) {

        let [name, level, items] = item.split(' / ');
        level = Number(level);
        items = items ? items.split(', ') : [];

        result.push({ name, level, items });
    }

    console.log(JSON.stringify(result));

}