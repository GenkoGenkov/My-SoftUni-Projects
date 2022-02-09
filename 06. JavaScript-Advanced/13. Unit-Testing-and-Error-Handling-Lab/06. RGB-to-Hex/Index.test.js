describe('rgbToHexColor function testing', () => {

    it('should return undefined if red is bellow zero', () => {

        assert.equal(rgbToHexColor(-1, 20, 50), undefined);
    });

    it('should return undefined if red is more than 255', () => {

        assert.equal(rgbToHexColor(280, 20, 50), undefined);
    });

    it('should return undefined if green is bellow zero', () => {

        assert.equal(rgbToHexColor(15, -3, 50), undefined);
    });

    it('should return undefined if green is more than 255', () => {

        assert.equal(rgbToHexColor(20, 280, 50), undefined);
    });

    it('should return undefined if blue is bellow zero', () => {

        assert.equal(rgbToHexColor(15, 15, -3), undefined);
    });

    it('should return undefined if blue is more than 255', () => {

        assert.equal(rgbToHexColor(20, 20, 500), undefined);
    });

    it('should return correct answer if all inputs are in range', () => {

        assert.equal(rgbToHexColor(38, 54, 77), '#26364D');
        assert.equal(rgbToHexColor(255, 0, 0), '#FF0000');
        assert.equal(rgbToHexColor(0, 255, 0), '#00FF00');
        assert.equal(rgbToHexColor(0, 0, 255), '#0000FF');
    });

    it('should return undefined if any of the input parameters are of an invalid type ', () => {

        assert.equal(rgbToHexColor(38, '54', 77), undefined);
    });

    it('should return undefined if any of the input parameters are of an invalid type ', () => {

        assert.equal(rgbToHexColor('38', 54, 77), undefined);
    });

    it('should return undefined if any of the input parameters are of an invalid type ', () => {

        assert.equal(rgbToHexColor(38, 54, '77'), undefined);
    });

    it('should return undefined if any of the input parameters are of an invalid type ', () => {

        assert.equal(rgbToHexColor(38, undefined, 77), undefined);
    });

    it('should return undefined if any of the input parameters are of an invalid type ', () => {

        assert.equal(rgbToHexColor(38, null, 77), undefined);
    });
});