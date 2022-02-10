describe('lookupChar function tests', () => {

    it('Return char at index', () => {

        assert.equal(lookupChar('Love', 1), 'o');
    });

    it('Return char at index', () => {

        assert.equal(lookupChar('L', 0), 'L');
    });

    it('Empty string as input', () => {

        assert.equal(lookupChar('', 0), 'Incorrect index');
    });

    it('Return incorrect big index', () => {

        assert.equal(lookupChar('Love', 10), 'Incorrect index');
    });

    it('Negative string index', () => {

        assert.equal(lookupChar('Love', -10), 'Incorrect index');
    });

    it('Return undefined if first parameter is not string', () => {

        assert.equal(lookupChar(100, 10), undefined);
    });

    it('Return undefined with string first parameter and decimal second', () => {

        assert.equal(lookupChar('Love', 10.5), undefined);
    });

    it('Return undefined wirh wrong parameter type', () => {

        assert.equal(lookupChar(10, '10.5'), undefined);
    });
});