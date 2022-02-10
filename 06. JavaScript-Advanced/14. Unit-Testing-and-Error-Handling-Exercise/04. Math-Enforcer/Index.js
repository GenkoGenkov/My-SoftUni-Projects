describe('mathEnforcer function tests', () => {

    describe('add five function tests', () => {

        it('Should return undefined with string', () => {

            assert(mathEnforcer.addFive('Test') === undefined);
        });

        it('Should return undefined with array', () => {

            assert(mathEnforcer.addFive([]) === undefined);
        });

        it('Should return undefined with object', () => {

            assert(mathEnforcer.addFive({}) === undefined);
        });

        it('Should return undefined with undefined', () => {

            assert(mathEnforcer.addFive(undefined) === undefined);
        });

        it('Should return undefined with null', () => {

            assert(mathEnforcer.addFive(null) === undefined);
        });

        it('Positive integer number + 5', () => {

            assert(mathEnforcer.addFive(5) === 10);
        });

        it('Negative integer number + 5', () => {

            assert(mathEnforcer.addFive(-5) === 0);
        });

        it('Decimal number + 5', () => {

            assert(mathEnforcer.addFive(5.5) === 10.5);
        });

    });

    describe('subtract ten function tests', () => {

        it('Should return undefined with string', () => {

            assert(mathEnforcer.subtractTen('Test') === undefined);
        });

        it('Should return undefined with array', () => {

            assert(mathEnforcer.subtractTen([]) === undefined);
        });

        it('Should return undefined with object', () => {

            assert(mathEnforcer.subtractTen({}) === undefined);
        });

        it('Should return undefined with undefined', () => {

            assert(mathEnforcer.subtractTen(undefined) === undefined);
        });

        it('Should return undefined with null', () => {

            assert(mathEnforcer.subtractTen(null) === undefined);
        });

        it('Positive integer number - 10', () => {

            assert(mathEnforcer.subtractTen(5) === -5);
        });

        it('Negative integer number - 10', () => {

            assert(mathEnforcer.subtractTen(-5) === -15);
        });

        it('Decimal number - 10', () => {

            assert(mathEnforcer.subtractTen(15.5) === 5.5);
        });

    });

    describe('sum of two numbers function tests', () => {

        it('Two positive integer numbers', () => {

            assert(mathEnforcer.sum(10, 20) === 30);
        });

        it('Two negative integer numbers', () => {

            assert(mathEnforcer.sum(-10, -20) === -30);
        });

        it('Two decimal integer numbers', () => {

            assert(mathEnforcer.sum(10.5, 20.5) === 31);
        });

        it('First parameter string, second number', () => {

            assert(mathEnforcer.sum('10.5', 20.5) === undefined);
        });

        it('First parameter number, second string', () => {

            assert(mathEnforcer.sum(20.5, '') === undefined);
        });
    });
});