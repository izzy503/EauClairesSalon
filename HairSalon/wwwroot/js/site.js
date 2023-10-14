document.addEventListener("DOMContentLoaded", function () {

  var myButton = document.getElementById("myButton");
  if (myButton) {
    myButton.addEventListener("click", function () {
      alert("Button clicked!");
    });
  }


  var toggleElement = document.getElementById("toggleElement");
  var toggleButton = document.getElementById("toggleButton");
  if (toggleButton && toggleElement) {
    toggleButton.addEventListener("click", function () {
      if (toggleElement.style.display === "none" || toggleElement.style.display === "") {
        toggleElement.style.display = "block";
      } else {
        toggleElement.style.display = "none";
      }
    });
  }


});
