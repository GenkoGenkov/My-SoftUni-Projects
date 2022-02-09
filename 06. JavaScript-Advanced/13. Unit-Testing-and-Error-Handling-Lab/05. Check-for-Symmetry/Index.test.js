describe('isSymmetric function testing', () => {

    it('Input data should be of the correct type', () => {

        assert.equal(isSymmetric(10), false);
        assert.equal(isSymmetric('10'), false);
        assert.equal(isSymmetric({}), false);
        assert.equal(isSymmetric(undefined), false);
        assert.equal(isSymmetric(null), false);
    });

    it('Should return true if the input array is symmetric with numbers', () => {

        assert.equal(isSymmetric([1, 2, 3, 2, 1]), true);
    });

    it('Should return false if the input array is not symmetric with numbers', () => {

        assert.equal(isSymmetric([1, 2, 3, 6, 8]), false);
    });

    it('Should return true if the input array is symmetric with strings', () => {

        assert.equal(isSymmetric(['a', 'b', 'c', 'b', 'a']), true);
    });

    it('Should return false if the input array is not symmetric with strings', () => {

        assert.equal(isSymmetric(['a', 'b', 'c', 'd', 'a']), false);
    });

    it('returns false if array is symmetric but with mixed data types', () => {

        assert.equal(isSymmetric([1,2,2,'1']), false);

    });
});