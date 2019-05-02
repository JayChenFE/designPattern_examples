const Iterator = arr => {
	let index = 0;

	const next = () => {
		index++;
	};

	const hasNext = () => index < arr.length;

	const getCurrentItem = () => arr[index];

	return {
		next,
		hasNext,
		getCurrentItem
	};
};

const isSameArray = (iterator1, iterator2) => {

	while (iterator1.hasNext() && iterator2.hasNext()) {

		if (iterator1.getCurrentItem() !== iterator2.getCurrentItem()) {
			return false;
		}

		iterator1.next();
		iterator2.next();
	}

	return true;
};

//调用
const iterator1 = Iterator([1, 2, 3]);
const iterator2 = Iterator([1, 2, 3]);
const iterator3 = Iterator([1, 4, 3]);
const iterator4 = Iterator([1, 5, 3]);

console.log(isSameArray(iterator1, iterator2));//true
console.log(isSameArray(iterator3, iterator4));//false