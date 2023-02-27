var allCustomers = [];
var selectCustomerRowEl;

function checkReverseWord() {
  const inputWord = document.querySelector("#to-reversed").value;
  var reversedWord = reverseWord(inputWord);
  document.querySelector("#reversed-word").value = reversedWord;
}

function reverseWord(str) {
  return str.split("").reverse().join("");
}

function checkPalindrom() {
  document.querySelector("#palindrom-result").textContent = "";
  const inputWord = document.querySelector("#to-palindrom").value.toLowerCase();
  const reversedWord = reverseWord(inputWord);

  var palindromResult;
  if (inputWord === reversedWord) {
    palindromResult = "It is palindrom!";
  } else if (inputWord == "") {
    palindromResult = "Please type a word!";
  } else {
    palindromResult = "It's not palindrom!";
  }
  document.querySelector("#palindrom-result").textContent = palindromResult;
}

function addCustomer() {
  const table = document.getElementById("tblCustomer");

  const newCustomer = {
    Name: document.querySelector("#customer-name").value,
    Surname: document.querySelector("#customer-surname").value,
    Age: document.querySelector("#customer-age").value,
    Gender: document.querySelector("#customer-gender").value,
  };
  if (newCustomer.Name != "" && newCustomer.Surname != "") {
    createCustomerTableRow(newCustomer, table);
    resetCustomerValues();

  } else {
    alert("Please type correct Name and Surname!");
  }
}

function createCustomerTableRow(customer, tableEl) {
  let rowEl = tableEl.insertRow();

  rowEl.addEventListener("click", (event) => {
    selectCustomerRow(event.currentTarget);
  });

  let nameEl = rowEl.insertCell(0);
  nameEl.innerHTML = customer.Name;

  let surnameEl = rowEl.insertCell(1);
  surnameEl.innerHTML = customer.Surname;

  let ageEl = rowEl.insertCell(2);
  ageEl.innerHTML = customer.Age;

  let genderIdEl = rowEl.insertCell(3);
  genderIdEl.innerHTML = customer.Gender;
}

function selectCustomerRow(rowEl) {
  if (selectCustomerRowEl != undefined) {
    selectCustomerRowEl.classList.remove("selected");
  }

  selectCustomerRowEl = rowEl;
  selectCustomerRowEl.classList.add("selected");


  document.querySelector("#selected-customer-name").value =
    selectCustomerRowEl.cells[0].innerHTML;
  document.querySelector("#selected-customer-surname").value =
    selectCustomerRowEl.cells[1].innerHTML;
  document.querySelector("#selected-customer-age").value =
    selectCustomerRowEl.cells[2].innerHTML;
  document.querySelector("#selected-customer-gender").value =
    selectCustomerRowEl.cells[3].innerHTML;
}

// MULTIPLY FUNCTION
function multiply(a, b) {
  if (!isNaN(a) && !isNaN(b)) {
    result = a * b;
  } else result = "Not numbers";

  return result;
}

function checkLastNumber() {
  const inputWord = document.querySelector("#check-string").value;

  index = inputWord.length - 1;
  var firstpart = inputWord.substring(0, index);
  var secondpart = inputWord.substring(index, inputWord.length);
  var result;
  if (isNaN(secondpart)) {
    result = inputWord + "1";
  } else {
    while (true) {
      index--;
      secondpart++;
      result = firstpart + secondpart;
      firstpart = inputWord.substring(0, index);
      secondpart = inputWord.substring(index, inputWord.length);

      if (isNaN(secondpart)) {
        break;
      }
      result = firstpart + secondpart;
    }
  }

  document.querySelector("#check-string-result").textContent = result;
}

function tryMultiply() {
  var a = document.querySelector("#multi-a").value;
  var b = document.querySelector("#multi-b").value;

  var c = multiply(a, b);
  document.querySelector("#multiply-result").textContent = "Result = " + c;
}

function resetCustomerValues(){
  document.querySelector("#customer-name").value = " ";
  document.querySelector("#customer-surname").value = " ";
  document.querySelector("#customer-age").value = " ";
  document.querySelector("#customer-gender").value = " ";
}