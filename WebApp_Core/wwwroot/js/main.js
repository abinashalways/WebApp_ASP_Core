var empId = document.querySelector("#EmpId");
var eName = document.querySelector("#EName");
var designation = document.querySelector("#Designation");
var dos = document.querySelector("#DOJ");
var salary = document.querySelector("#Salary");
var deptNo = document.querySelector("#Deptno");


var btn = document.getElementById("clear-btn");

btn.addEventListener("click", () => {
    empId.Foreach(_input => empId.textContent = " "),
    alert("clicked");
    //eName.value = " ",
    //designation.value = "",

});


console.log(btn);
console.log(empId.value);
console.log(eName.value);

console.log(designation.value);

console.log(dos.value);

console.log(deptNo.value);

