var divPrinc = document.getElementById("divPrincipal");

var botao = document.getElementById("botaoAbrirFechar");

botao.addEventListener("click", AbrirFecharDiv);

function AbrirFecharDiv() {
    if (divPrinc.hidden == true) {
        divPrinc.hidden = false;
    }
    else {
        divPrinc.hidden = true;
    }
}