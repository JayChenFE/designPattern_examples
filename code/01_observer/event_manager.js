//ES5
var EventManager = (function() {
	var events = {};

	function on(evt, handler) {

		if (typeof handler !== 'function') {
			throw new TypeError('handler is not a function!');
			return;
		}

		events[evt] = events[evt] || [];
		events[evt].push(handler);
	}

	function trigger(evt, args) {
		if (!events[evt]) {
			return;
		}

		events[evt].forEach(function(handler) {
			handler(args);
		})
	}

	function off(evt) {
		delete events[evt];
	}

	return {
		on: on,
		trigger: trigger,
		off: off
	};
})();


//ES6
const EventManager = ((() => {
	const events = {};

	function on(evt, handler) {

		if (typeof handler !== 'function') {
			throw new TypeError('handler is not a function!');
			return;
		}

		events[evt] = events[evt] || [];
		events[evt].push(handler);
	}

	function trigger(evt, args) {
		if (!events[evt]) {
			return;
		}

		events[evt].forEach(handler => {
			handler(args);
		})
	}

	function off(evt) {
		delete events[evt];
	}

	return {
		on,
		trigger,
		off
	};
}))();

//调用
EventManager.on('text:change', function(val) {
	console.log('text:change...  now val is ' + val);
});
EventManager.trigger('text:change', '饥人谷');
EventManager.off('text:change');