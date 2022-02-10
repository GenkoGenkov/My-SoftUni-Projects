describe('isOddOrEven tests', () => {

    it('should return undefined if the parameter is number', () => {

        assert.equal(isOddOrEven(10), undefined);
    });

    it('should return undefined if the parameter is object', () => {

        assert.equal(isOddOrEven({}), undefined);
    });

    it('should return undefined if the parameter is array', () => {

        assert.equal(isOddOrEven([]), undefined);
    });

    it('should return undefined if the parameter is undefined', () => {

        assert.equal(isOddOrEven(undefined), undefined);
    });

    it('should return undefined if the parameter is null', () => {

        assert.equal(isOddOrEven(null), undefined);
    });

    it('should return even', () => {

        assert.equal(isOddOrEven('Hi'), 'even');
    });

    it('should return odd', () => {

        assert.equal(isOddOrEven('Hello'), 'odd');
    });
});