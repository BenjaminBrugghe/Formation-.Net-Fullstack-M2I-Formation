// Arrow and Classic function()

const link = document.querySelector('#idLink');
const result = document.querySelector('#idResult');

// Propagation d'un Event Click

link.addEventListener('click', (event) => {
    console.log(`Arrow Function() : This => ${this} and event source is : ${event}`); // This = window
});
link.addEventListener('click', function () {
    console.log(`Classic Function() : This => ${this}`); // This = Button
});

// Appel de fonction depuis l'event click du bouton

function clickFunction() {
    result.innerHTML += "<h3>C'est cliqué!</h3>";
}
function clickAlert() {
    alert("Je m'affiche dans une alerte.");
}
function clickConfirm() {
    let response = confirm("Etes-vous sûr ?");
    result.innerHTML += response === true ? "<h3>C'est confirmé!</h3>" : "<h3>Ce n'est pas confirmé!</h3>";
};