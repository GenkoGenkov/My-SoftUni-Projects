describe('Test numbers', () => {

    it('sumNumbers should work with valid number', () => {

        expect(testNumbers.sumNumbers(3, 5)).to.equal('8.00');

    });

    it('sumNumbers should work with negative number', () => {

        expect(testNumbers.sumNumbers(3, -5)).to.equal('-2.00');

    });

    it('sumNumbers should work with floating point', () => {

        expect(testNumbers.sumNumbers(1.5555, 0.3333)).to.equal('1.89');

    });

    it('sumNumbers should return undefined with string parameters', () => {

        expect(testNumbers.sumNumbers('1', '2')).to.equal(undefined);
        expect(testNumbers.sumNumbers(1, '2')).to.equal(undefined);
        expect(testNumbers.sumNumbers('1', 2)).to.equal(undefined);

    });

    it('sumNumbers should return undefined with one invalid parameter', () => {

        expect(testNumbers.sumNumbers(null, null)).to.equal(undefined);
        expect(testNumbers.sumNumbers(1, null)).to.equal(undefined);
        expect(testNumbers.sumNumbers(null, 2)).to.equal(undefined);

    });

    it('numberChecker should work with odd value', () => {

        expect(testNumbers.numberChecker(1)).to.contain('odd');

    });

    it('numberChecker should work with even value', () => {

        expect(testNumbers.numberChecker(2)).to.contain('even');

    });

    it('numberChecker should work with odd value as string', () => {

        expect(testNumbers.numberChecker('1')).to.contain('odd');

    });

    it('numberChecker should work with even value as string', () => {

        expect(testNumbers.numberChecker('2')).to.contain('even');

    });

    it('numberChecker should work with empty string', () => {

        expect(testNumbers.numberChecker('')).to.contain('even');

    });

    it('numberChecker should detect invalid parameter', () => {

        expect(() => testNumbers.numberChecker('a')).to.throw();

    });

    it('averageSumArray should work with integers', () => {

        expect(testNumbers.averageSumArray([1, 2, 3])).to.equal(2);

    });

    it('averageSumArray should work with floating numbers', () => {

        expect(testNumbers.averageSumArray([1.5, 2.5, 3.5])).to.equal(2.5);

    });

});