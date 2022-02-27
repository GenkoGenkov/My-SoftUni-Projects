const pizzUni = require('./Solution.js');
const {expect, assert} = require('chai');

describe('Pizza place tests', () => {
    
    it('makeAnOrder should return confirmation message when pizza is ordered', () => {
        
        let order = {

            orderedPizza: 'Margarita'
        };

        expect(pizzUni.makeAnOrder(order)).to.equal(`You just ordered ${order.orderedPizza}`);

    });

    it('makeAnOrder should return confirmation message when pizza and drink is ordered', () => {
        
        let order = {

            orderedPizza: 'Capricciosa',
            orderedDrink: 'Coke'
        };

        expect(pizzUni.makeAnOrder(order)).to.equal(`You just ordered ${order.orderedPizza} and ${order.orderedDrink}.`);

    });

    it('makeAnOrder should throw when no pizza is ordered', () => {
        
        let order = {};

        expect(() => pizzUni.makeAnOrder(order)).to.throw();

    });

    it('makeAnOrder should throw when there is only drink', () => {
        
        let order = {

            orderedDrink: 'Pepsi'
        };

        expect(() => pizzUni.makeAnOrder(order)).to.throw();

    });

    it('makeAnOrder should throw when no order is given', () => {

        expect(() => pizzUni.makeAnOrder(order)).to.throw();

    });

    it('getRemainingWork should return complited orders', () => {

        let statusArr = [
            {pizzaName: 'Margarita', status: 'ready'}
        ];

        expect(pizzUni.getRemainingWork(statusArr)).to.equal('All orders are complete!');

    });

    it('getRemainingWork should return complited orders with two pizzas', () => {

        let statusArr = [
            {pizzaName: 'Margarita', status: 'ready'},
            {pizzaName: 'Italiana', status: 'ready'}
        ];

        expect(pizzUni.getRemainingWork(statusArr)).to.equal('All orders are complete!');

    });

    it('getRemainingWork should return remaining pizzas when there is one pending order', () => {

        let statusArr = [
            {pizzaName: 'Margarita', status: 'preparing'},
            {pizzaName: 'Italiana', status: 'ready'}
        ];

        expect(pizzUni.getRemainingWork(statusArr)).to.equal(`The following pizzas are still preparing: Margarita.`);

    });

    it('getRemainingWork should return remaining pizzas when there are more pending orders', () => {

        let statusArr = [
            {pizzaName: 'Margarita', status: 'preparing'},
            {pizzaName: 'Italiana', status: 'preparing'}
        ];

        expect(pizzUni.getRemainingWork(statusArr)).to.equal(`The following pizzas are still preparing: Margarita, Italiana.`);

    });

    it('orderType should return total sum when type of order is Delivery', () => {

        let totalSum = 10;
        let orderType = 'Delivery';
        
        expect(pizzUni.orderType(totalSum, orderType)).to.equal(totalSum);

    });

    it('orderType should return total sum with discount when type of order is Carry Out', () => {

        let totalSum = 10;
        let orderType = 'Carry Out';
        
        expect(pizzUni.orderType(totalSum, orderType)).to.equal(9);

    });

    it('orderType should return total sum with discount when using floating point number', () => {

        let totalSum = 10.50;
        let orderType = 'Carry Out';
        
        expect(pizzUni.orderType(totalSum, orderType)).to.equal(9.45);

    });
});
