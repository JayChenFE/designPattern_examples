// var each = function(arr, callback) {

// 	for (var i = 0; i < arr.length; i++) {
// 		//把下标和元素当作参数传给callback函数
// 		callback.call(arr[i], i, arr[i]);
// 	}
// };

// //调用
// each([1, 2, 3], function(i, n) {
// 	console.log([i, n]);
// });


var each = function(arr, callback) {

	for (var i = 0; i < arr.length; i++) {
		if (callback(arr[i], i) === false) {
			return false;
		}
	}
};

var isSameArray = function(arr1, arr2) {

	if (arr1.length !== arr2.length) {
		return false;
	}

	var isSame = each(arr1, function(item, index) {
		
		if (item !== arr2[index]) {
			return false;
		}
	});

	if (isSame === false) {
		return false;
	}

	return true;
};

//调用
console.log(isSameArray([1,2,3], [1,2,3]));//true
console.log(isSameArray([1,2,3], [1,2,4]));//false