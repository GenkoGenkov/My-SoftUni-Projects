function createSortedList() {

    const repository = [];

    return sortedList = {

        add(element) {

            repository.push(element);
            repository.sort((a, b) => a - b);
        },

        remove(index) {

            if (index >= 0 && index < repository.length) {
                repository.splice(index, 1);
                repository.sort((a, b) => a - b);
            }
        },
        get(index) {

            if (index < 0 || index >= repository.length) {
                throw new Error(`Index doesn't exist`);
            }

            return repository[index];
        },
        get size() {

            return repository.length;
        }
    }
}