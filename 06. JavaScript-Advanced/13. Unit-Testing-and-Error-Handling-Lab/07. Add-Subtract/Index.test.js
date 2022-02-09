describe('Add Subtract Tests', () => {

    it('returns an object as a result of the function', () => {

        expect(typeof createCalculator()).to.equal('object');

    })

    it('contains the three functions add, subtract, get as properties', () => {

        const object = createCalculator();
        expect(object).haveOwnProperty('add');
        expect(object).haveOwnProperty('subtract');
        expect(object).haveOwnProperty('get');

    })

    it('gets properly', () => {

        const object = createCalculator();
        object.add(3);
        expect(object.get()).to.equal(3);

    })

    it('sums properly', () => {

        const object = createCalculator();
        object.add(3);
        object.add(3);
        expect(object.get()).to.equal(6);
        object.add(5);
        expect(object.get()).to.equal(11);

    })

    it('subtracts properly', () => {

        const object = createCalculator();
        object.add(3);
        object.subtract(2);
        expect(object.get()).to.equal(1);
        object.subtract(10);
        expect(object.get()).to.equal(-9);

    })

    it('calculates properly if a string represantation of a number is given', () => {

        const object = createCalculator();
        object.add('1');
        expect(object.get()).to.equal(1);

    })

    it('returns NaN if not a number or not a string represantation of a number is given', () => {

        const object = createCalculator();
        object.add('blah');
        expect(Number.isNaN(object.get())).to.be.true;

    })
})