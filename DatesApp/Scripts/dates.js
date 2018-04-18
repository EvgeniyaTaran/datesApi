(function() {
	var dateFrom = $("#dateStart");
	var dateTo = $("#dateFinish");
	var submitBtn = $("#submitBtn");
	var message = $("#message");

	function getData() {
		var dateStart = dateFrom.val();
		var dateFinish = dateTo.val();
		return { dateStart, dateFinish };
	}
	function showMessage() {
		message.show();
	}

	function hideMessage() {
		message.hide();
	}

	function bindEvents() {
		submitBtn.click(function (e) {
			var data = getData();
			$.post("api/Dates", data).then((res) => {
				if (res) {
					showMessage();
					setTimeout(hideMessage, 3000);
				};
			});
		});
	}
	bindEvents();
})();
