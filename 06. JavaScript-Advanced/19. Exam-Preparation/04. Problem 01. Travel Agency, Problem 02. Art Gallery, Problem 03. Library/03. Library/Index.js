describe('Library tests', () => { 

    it('calcPriceOfBook invalid input - name of the book', () => { 

        expect(() => library.calcPriceOfBook(1, 1)).to.throw('Invalid input');

    }); 

    it('calcPriceOfBook invalid input - year of the book', () => { 

        expect(() => library.calcPriceOfBook('jj', 'jj')).to.throw('Invalid input');

    });

    it('calcPriceOfBook valid input with year below 1980', () => { 

        expect(library.calcPriceOfBook('The Little Prince', 1943)).to.equal(`Price of The Little Prince is 10.00` );

    });

    
    it('calcPriceOfBook valid input with year 1980', () => { 

        expect(library.calcPriceOfBook('The Little Prince', 1980)).to.equal(`Price of The Little Prince is 10.00` );

    });

    it('calcPriceOfBook valid input', () => { 

        expect(library.calcPriceOfBook('The Little Prince', 1981)).to.equal(`Price of The Little Prince is 20.00` );

    });

    it('findBook invalid input - empty array', () => { 

        expect(() => library.findBook([], 'The Little Prince')).to.throw('No books currently available');

    });

    it('findBook invalid input - avaliable book', () => { 

        expect(library.findBook(["Troy", "Life Style", "Torronto"], "Troy")).to.equal('We found the book you want.');

    });

    it('findBook invalid input - not avaliable book', () => { 

        expect(library.findBook(["Troy", "Life Style", "Torronto"], "JS")).to.equal('The book you are looking for is not here!');

    });

    it('arrangeTheBooks invalid input - negative number', () => { 

        expect(() => library.arrangeTheBooks(-5)).to.throw('Invalid input');

    });

    it('arrangeTheBooks invalid input - double number', () => { 

        expect(() => library.arrangeTheBooks(4.7)).to.throw('Invalid input');

    });

    it('arrangeTheBooks invalid input - not a integer', () => { 

        expect(() => library.arrangeTheBooks('k')).to.throw('Invalid input');

    });

    it('arrangeTheBooks valid input - less than avaliable space', () => { 

        expect(library.arrangeTheBooks(39)).to.equal('Great job, the books are arranged.');

    });

    it('arrangeTheBooks valid input - more than avaliable space', () => { 

        expect(library.arrangeTheBooks(77)).to.equal('Insufficient space, more shelves need to be purchased.');

    });

    it('arrangeTheBooks valid input - matching avaliable space', () => { 

        expect(library.arrangeTheBooks(40)).to.equal('Great job, the books are arranged.');

    });
}); 