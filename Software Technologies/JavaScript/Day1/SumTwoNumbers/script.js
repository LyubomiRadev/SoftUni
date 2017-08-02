var sumBtn = document.getElementById("sum_btn");

sumBtn.onclick = function(e) {
    e.preventDefault();
    var numberOne = Number(document.getElementById("numer_one").value) ;
    var numberTwo = Number(document.getElementById("number_two").value);

    var sum = numberOne +   numberTwo;

    var resultField = document.getElementById("result");

    resultField.value = sum;
}
/**
function sum() {
    var numberOne = Number(document.getElementById("numer_one").value) ;
    var numberTwo = Number(document.getElementById("number_two").value);

    var sum = numberOne +   numberTwo;

    var resultField = document.getElementById("result");

    resultField.value = sum;
}
*/
