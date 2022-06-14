// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function valida_CadastrarProduto(form) {
    alert("Operação realizada com sucesso!")

    var nomeProduto = document.getElementById("NomeProduto")
    var unidade = document.getElementById("Unidade")
    var quantidade = document.getElementById("Quantidade")
    var precoProduto = document.getElementById("PrecoProduto")

    var caixa_nomeProduto = document.querySelector('.msg-produto');
    var caixa_unidade = document.querySelector('.msg-unidade');
    var caixa_quantidade = document.querySelector('.msg-quantidade');
    var caixa_precoProduto = document.querySelector('.msg-precoProduto');

    caixa_nomeProduto.style.display='none';
    caixa_unidade.style.display='none';
    caixa_quantidade.style.display='none';
    caixa_precoProduto.style.display='none';

    if (nomeProduto.value=="") {
        caixa_nomeProduto.innerHTML = "Nome do Produto obrigatório";
        nomeProduto.focus();
        caixa_nomeProduto.style.display='block';
        return false;
    }

    if (unidade.value=="") {
        caixa_unidade.innerHTML = "Unidade obrigatório";
        unidade.focus();
        caixa_unidade.style.display='block';
        return false;
    }

    if (quantidade.value=="") {
        caixa_unidade.innerHTML = "Quantidade obrigatório";
        quantidade.focus();
        caixa_unidade.style.display='block';
        return false;
    }
    if (precoProduto.value=="") {
        caixa_precoProduto.innerHTML = "Preço obrigatório";
        precoProduto.focus();
        caixa_precoProduto.style.display='block';
        return false;
    }
    nomeProduto.value="";
    unidade.value="";
    quantidade.value="";
    precoProduto.value="";
    nomeProduto.focus;

    return true;
}
function mensagem(){
    alert("Operação realizada com sucesso!")
}

function valida_Email(){
    var nomeProduto = document.getElementById("Email")

    if (Email.value=="") {
        alert("Email obrigatório");
        Email.focus
        return false;
    }

    if (invalid.test(Email.value=false)){
        alert("Email inválido!");
        email.focus
        return false;
    }
}

