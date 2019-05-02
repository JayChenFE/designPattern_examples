var Iterator = function(arr) {
	var index = 0;

	var next = function() {
		index++;
	};

	var hasNext = function() {
		return index < arr.length;
	};

	var getCurrentItem = function() {
		return arr[index];
	};

	return {
		next: next,
		hasNext: hasNext,
		getCurrentItem: getCurrentItem
	};
};

var isSameArray = function(iterator1, iterator2) {

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
var iterator1 = Iterator([1, 2, 3]);
var iterator2 = Iterator([1, 2, 3]);
var iterator3 = Iterator([1, 4, 3]);
var iterator4 = Iterator([1, 5, 3]);

console.log(isSameArray(iterator1, iterator2));//true
console.log(isSameArray(iterator3, iterator4));//false