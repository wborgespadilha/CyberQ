let estoque = [];
let categorias = [];
let cesta = [];

let quantidadeProdutos = 0;

window.onload = function(){
    fetch("https://ralflima.com/api/produtos.json")
    .then(postagem => postagem.json())
    .then(retorno => carregar(retorno))
}

function carregar(retorno){

    estoque = retorno;

    estoque.forEach(element => {
        quantidadeProdutos++;
    });

    atualizarProdutos();
    adicionarCategorias();
    carregarCategorias();

}

/*

Funções categorias

*/

function adicionarCategorias(){

    // Percorre o estoque
    for(let i = 0; i < quantidadeProdutos ; i++){

        let containsCategory = false;

        // Percorre as categorias
        for(let j = 0; j < categorias.length; j++){

            // Se a categoria do produto já está na lista não faz nada
            if(estoque[i].categoria == categorias[j].categoria){
                containsCategory = true;
                break;
            }
        }

        // Caso a categoria do produto não exista na lista, adiciona ela
        if(containsCategory == false){
           categorias.push({"categoria":estoque[i].categoria})
        }
    }
}

function carregarCategorias(){

    for(let i = 0; i < categorias.length; i++){

        // Cria uma opção de acordo com a lista de categorias
        var opcao = document.createElement('option');
        opcao.value = categorias[i].categoria;
        opcao.innerHTML = categorias[i].categoria;

        //Adiciona no select
        document.getElementById("categorias").appendChild(opcao);
    }

}

/*

Função principal tela produtos

*/

function atualizarProdutos(){

    // Limpa todos os produtos
    document.getElementById("produtos").innerHTML = "";

    for(let i = 0; i < quantidadeProdutos; i++){

        // Setando valores
        let stringQNTD = `Quantidade Máxima: ${estoque[i].estoque}`
        let stringValor = `R$${parseFloat(estoque[i].valor).toFixed(2)}`
        let stringCategoria = `Categoria: ${estoque[i].categoria}`
        let stringCodigo = `Código: ${estoque[i].codigo}`

        // Adicionando um card na div produtos
        document.getElementById("produtos").innerHTML += 
            `<div class="card" >
                <img src="${estoque[i].imagem}" class="card-img-top">
                <div class="card-body">
                    <h5 class="card-title">${estoque[i].nome}</h5>
                    <p class="card-text">${stringCodigo}</p>
                    <p class="card-text">${stringValor}</p>
                    <p class="card-text">${stringCategoria}</p>
                    <label for="${i}">${stringQNTD}</label>
                    <input type="number" id="${i}" placeholder="Quantidade" min="0">
                    <br><br>
                    <input="button" class="btn btn-primary" onclick="adicionarNaCesta(${i})">Adicionar à cesta</a>
                </div>
            </div>`;
    }
}

/*

Funções da cesta

*/

function adicionarNaCesta(indice){

    let qntd = parseInt(document.getElementById(`${indice}`).value);
    let codigo = estoque[indice].codigo;

    // Valdações de quantidades
    if(qntd == "" || qntd == 0){
        alert("Você deve inserir a quantidade!");
        return;
    }

    if(qntd < 0){
        alert("Você deve inserir valores positivos!");
        return;
    }

    // Percorrendo o estoque até achar o produto
    for(let i = 0; i < quantidadeProdutos; i++)
    {
        if(estoque[i].codigo == codigo){

            // Validação estoque
            let quantidadeProduto = qntd;

            if(cesta.length == 0){

                if(quantidadeProduto > estoque[i].estoque){
                    alert("Não há estoque suficiente!");
                    return;
                }
            }

            for(let j = 0; j < cesta.length; j++){

                if(cesta[j].nome == estoque[i].nome)
                {
                    quantidadeProduto += parseInt(cesta[j].quantidade);
                }

                if(quantidadeProduto > estoque[i].estoque)
                {
                    alert("Não há estoque suficiente!");
                    return;
                }
            }
            
            // Adicionando item
            let total = qntd * estoque[i].valor;

            cesta.push({
                "nome":estoque[i].nome,
                "valor":estoque[i].valor,
                "quantidade":qntd,
                "total":total
            })

            atualizarCesta();
            break;

        }
    }

}

function atualizarCesta(){

    document.getElementById("totalCompra").value = "";

    let tabela = document.getElementById("tabela");

    tabela.innerHTML = "";
    tabela.innerHTML +=
     `<thead class="thead-light">
        <tr>
            <th scope="col">ID</th>
            <th scope="col">Nome</th>
            <th scope="col">Quantidade</th>
            <th scope="col">Valor</th>
            <th scope="col">Total</th>
        </tr>
    </thead>`;


    for(let i = 0; i < cesta.length; i++){

        var row = tabela.insertRow(-1);

        var cell1 = row.insertCell(0);
        var cell2 = row.insertCell(1);
        var cell3 = row.insertCell(2);
        var cell4 = row.insertCell(3);
        var cell5 = row.insertCell(4);

        // Adicionando itens
        cell1.innerHTML = `${i}`;
        cell2.innerHTML = `${cesta[i].nome}`;
        cell3.innerHTML = `${cesta[i].quantidade}`;
        cell4.innerHTML = `R$${cesta[i].valor}`;
        cell5.innerHTML = `R$${parseFloat(cesta[i].total).toFixed(2)}`;

        // Adicionando total da compra
        let totalAntigo = parseFloat(document.getElementById("totalCompra").value);
        let totalDaCesta = parseFloat(cesta[i].total).toFixed(2);
        let cestaMaisAntigo = parseFloat(cesta[i].total + totalAntigo).toFixed(2)

        document.getElementById("totalCompra").value = isNaN(totalAntigo) ? totalDaCesta : cestaMaisAntigo;

    }
}

function comprar(){

    if(document.getElementById("totalCompra").value == 0 || document.getElementById("totalCompra").value == ""){

        alert("Você não colocou nada no carrinho!")
        return;
    }

    // Reduzindo estoque
    // Percorre estoque
    for(let i = 0; i < quantidadeProdutos; i++){

        // Percorre cesta
        for(let j = 0; j < cesta.length; j++){

            // Se o produto do estoque foi comprado, diminui
            if(estoque[i].nome == cesta[j].nome)
            {
                estoque[i].estoque = parseInt(parseInt(estoque[i].estoque) - parseInt(cesta[j].quantidade));
            }
        }
    }

    // Limpando cesta
    cesta.splice(0,cesta.length);
    atualizarCesta();
    atualizarProdutos();

    // Retornando sucesso
    alert("Comprado com sucesso!");
}

function cancelar(){

    if(document.getElementById("totalCompra").value == 0 || document.getElementById("totalCompra").value == ""){

        alert("Você não colocou nada no carrinho!")
        return;
    }

    // Limpando cesta
    cesta.splice(0,cesta.length);
    atualizarCesta();

    // Retornando sucesso
    alert("Compra cancelada!");
}

function removerProduto(){

    // Validações
    if(document.getElementById("totalCompra").value == 0 || document.getElementById("totalCompra").value == ""){

        alert("Você não colocou nada no carrinho!")
        return;
    }

    let codigoRemover = document.getElementById("codigoRemover").value;
    if(codigoRemover == ""){
        alert("Você deve inserir um ID!")
        return;
    }

    // Remover e atualizar cesta
    cesta.splice(codigoRemover,1);
    atualizarCesta();

}

function alterarProduto(){

    // Validações
    if(document.getElementById("totalCompra").value == 0 || document.getElementById("totalCompra").value == ""){

        alert("Você não colocou nada no carrinho!")
        return;
    }

    let IDAlterar = document.getElementById("codigoAlterar").value;
    let quantidadeAlterar = document.getElementById("quantidadeAlterar").value;
    
    if(IDAlterar == ""){
        alert("Você deve inserir um ID!")
        return;
    }

    if(quantidadeAlterar == ""){
        alert("Você deve inserir a nova quantidade!")
        return;
    }

    // Validação de estoque
    // Percorrendo o estoque
    for(let i = 0; i < quantidadeProdutos; i++)
    {

        if(estoque[i].nome == cesta[IDAlterar].nome){

            let quantidadeProduto = quantidadeAlterar;

            // Percorrendo a cesta
            for(let j = 0; j < cesta.length; j++){

                if(cesta[j].nome == estoque[i].nome)
                {
                    if(j != IDAlterar){

                        quantidadeProduto += cesta[j].quantidade;  
                    }
                    
                    if(quantidadeProduto > estoque[i].estoque)
                    {
                        alert("Não há estoque suficiente!");
                        return;
                    }   
                } 
            }


        }
    }

    // Alterando quantidade
    cesta[IDAlterar].quantidade = quantidadeAlterar;
    cesta[IDAlterar].total = quantidadeAlterar * cesta[IDAlterar].valor;
    atualizarCesta();

}

/*

Funções do form de pesquisa

*/

function procurarPorNome(){

    // Validação de nome
    let name = document.getElementById("nomeProduto").value;

    if(name == ""){
        return;
    }

    // Atualização de produtos
    atualizarProdutosFiltrado(name.toLowerCase());
}

function atualizarProdutosFiltrado(name){

    // Limpa todos os produtos

    document.getElementById("produtos").innerHTML = "";

    // Adiciona produtos seguindo a condição

    for(let i = 0; i < quantidadeProdutos; i++){

        // Condição
        if(estoque[i].nome.toLowerCase().includes(name)){

        // Setando valores

        let stringQNTD = `Quantidade Máxima: ${estoque[i].estoque}`
        let stringValor = `R$${parseFloat(estoque[i].valor).toFixed(2)}`
        let stringCategoria = `Categoria: ${estoque[i].categoria}`
        let stringCodigo = `Código: ${estoque[i].codigo}`

        // Adicionando card na div produtos

        document.getElementById("produtos").innerHTML += 
            `<div class="card" >
                <img src="${estoque[i].imagem}" class="card-img-top">
                <div class="card-body">
                    <h5 class="card-title">${estoque[i].nome}</h5>
                    <p class="card-text">${stringCodigo}</p>
                    <p class="card-text">${stringValor}</p>
                    <p class="card-text">${stringCategoria}</p>
                    <label for="${i}">${stringQNTD}</label>
                    <input type="number" id="${i}" placeholder="Quantidade" min="0">
                    <br><br>
                    <input="button" class="btn btn-primary" onclick="adicionarNaCesta(${i})">Adicionar à cesta</a>
                </div>
            </div>`;
        }
    }
}

function procurarPorCategoria(){

    // Validação
    let categoria = document.getElementById("categorias").value;

    if(categoria == ""){
        atualizarProdutos()
        return;
    }

    // Atualização de produtos
    atualizarProdutosCategoria(categoria);

}

function atualizarProdutosCategoria(categoria){

    // Limpa todos os produtos
    document.getElementById("produtos").innerHTML = "";

    // Adiciona produtos seguindo a condição
    for(let i = 0; i < quantidadeProdutos; i++){

        // Condição
        if(estoque[i].categoria == categoria){

        // Setando valores
        let stringQNTD = `Quantidade Máxima: ${estoque[i].estoque}`
        let stringValor = `R$${parseFloat(estoque[i].valor).toFixed(2)}`
        let stringCategoria = `Categoria: ${estoque[i].categoria}`
        let stringCodigo = `Código: ${estoque[i].codigo}`

        // Adiciona um card na div produtos
        document.getElementById("produtos").innerHTML += 
            `<div class="card" >
                <img src="${estoque[i].imagem}" class="card-img-top">
                <div class="card-body">
                    <h5 class="card-title">${estoque[i].nome}</h5>
                    <p class="card-text">${stringCodigo}</p>
                    <p class="card-text">${stringValor}</p>
                    <p class="card-text">${stringCategoria}</p>
                    <label for="${i}">${stringQNTD}</label>
                    <input type="number" id="${i}" placeholder="Quantidade" min="0">
                    <br><br>
                    <input="button" class="btn btn-primary" onclick="adicionarNaCesta(${i})">Adicionar à cesta</a>
                </div>
            </div>`;
        }
    }
}
