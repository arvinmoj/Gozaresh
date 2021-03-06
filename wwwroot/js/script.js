$("#date3").MdPersianDateTimePicker({
    targetTextSelector: "#inputDate3",
    monthsToShow: [1, 1],
});

$(document).ready(function () {
    $(".menu").click(function () {
        $("#Panel").toggle();
    });
});

$(document).ready(function () {
    $(".main").click(function () {
        $("#Panel").hide();
    });
});

$(document).ready(function () {
    $(".menu").scrollLeft(function () {
        $("#Panel").toggle();
    });
});

function separateNum(value, input) {
    /* seprate number input 3 number */
    var nStr = value + '';
    nStr = nStr.replace(/\,/g, "");
    x = nStr.split('.');
    x1 = x[0];
    x2 = x.length > 1 ? '.' + x[1] : '';
    var rgx = /(\d+)(\d{3})/;
    while (rgx.test(x1)) {
        x1 = x1.replace(rgx, '$1' + ',' + '$2');
    }
    if (input !== undefined) {

        input.value = x1 + x2;
    } else {
        input.value = x1 + x2;
    }
}

function number_3_3(num, sep) {
    var number = typeof num === "number" ? num.toString() : num,
        separator = typeof sep === "undefined" ? ',' : sep;
    return number.replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1" + separator);
}

function addComma(str) {
    var objRegex = new RegExp('(-?[0-9]+)([0-9]{3})');

    while (objRegex.test(str)) {
        str = str.replace(objRegex, '$1,$2');
    }

    return str;
}

function removeComma(str) {
    var myString = '',
        chrCode;

    for (var i = str.length - 1; i >= 0; --i) {
        chrCode = str.charCodeAt(i);

        // 44 = comma
        if (chrCode != 44) {
            myString = String.fromCharCode(chrCode) + myString;
        }

    }

    return myString;
}


String.prototype.toEnglishDigit = function () {
    var find = ['۰', '۱', '۲', '۳', '۴', '۵', '۶', '۷', '۸', '۹'];
    var replace = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9'];
    var replaceString = this; var regex; for (var i = 0; i < find.length; i++) {
        regex = new RegExp(find[i], "g"); replaceString = replaceString.replace(regex, replace[i]);
    }
    return replaceString;
}


function Click() {

    var date = document.querySelector('[aria-label="date3"]').value;
    var dateTime = date.substring(0, 4);
   

    var persionDate = new Date().toLocaleDateString('fa-IR');
    var yearpersionDate = persionDate.substring(0, 4);
    var yearsDateTime = yearpersionDate.substring(2,4);


    var MonthPersion = date.substring(5,7).toEnglishDigit();

    if (yearpersionDate === dateTime) {

        if (MonthPersion === "01" || MonthPersion === "02" || MonthPersion === "03" )
        {
            document.getElementById('SetDate').value =  "بهار" + " " + yearsDateTime  ;
        }
        if (MonthPersion === "04" || MonthPersion === "05" || MonthPersion === "06" )
        {
            document.getElementById('SetDate').value =  "تابستان" + " " + yearsDateTime  ;
        }
        if (MonthPersion === "07" || MonthPersion === "08" || MonthPersion === "09" )
        {
            document.getElementById('SetDate').value =  "پاییز" + " " + yearsDateTime  ;
        }
        if (MonthPersion === "10" || MonthPersion === "11" || MonthPersion === "12" )
        {
            document.getElementById('SetDate').value =  "زمستان" + " " + yearsDateTime  ;
        }
    }
    else {
        document.getElementById('SetDate').value =  "سال قبل" ;
    }

}