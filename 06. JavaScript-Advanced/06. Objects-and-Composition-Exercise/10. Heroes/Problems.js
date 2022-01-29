function solve() {

    let fighter = (name) => {

        let state = {

            name,
            health: 100,
            stamina: 100
        }

        return Object.assign(state, canFight(state));
    };

    let mage = (name) => {

        let state = {

            name,
            health: 100,
            mana: 100
        }

        return Object.assign(state, canCast(state));
    };

    let canCast = (state) => ({

        cast: (spell) => {

            console.log(`${state.name} cast ${spell}`);
            state.mana--;
        }
    });

    let canFight = (state) => ({

        fight: () => {

            console.log(`${state.name} slashes at the foe!`);
            state.stamina--;
        }
    });

    return { mage: mage, fighter: fighter };
}