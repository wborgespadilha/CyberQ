// JSON
let pessoas = [];

// Indice para efetuar a alteração ou remoção
let indiceSelecionado

//Cadastrar
function cadastrar(){

    // Obter os dados
    let nome = document.getElementById("nome").value;
    let idade = document.getElementById("idade").value;
    let cidade = document.getElementById("cidade").value;

    // Adicionar no JSON
    pessoas.push({
        "nome":nome,
        "idade":idade,
        "cidade":cidade
    })

    // Limpar campos
    limparCampos();

    // Listar dados
    console.table(pessoas);
    selecionar();
}

// Selecionar
function selecionar(){

    // Obter o tbody
    let tabela = document.getElementById("tabela");

    // Remover conteúdos do tbody
    tabela.innerHTML = "";

    // Laço de repetição
    for(let i = 0; i < pessoas.length; i++){

        // Criar uma linha
        let linha = tabela.insertRow(-1);

        // Colunas
        let coluna1 = linha.insertCell(0);
        let coluna2 = linha.insertCell(1);
        let coluna3 = linha.insertCell(2);
        let coluna4 = linha.insertCell(3);
        let coluna5 = linha.insertCell(4);

        // Adicionar valores para cada coluna

        coluna1.innerText = i+1
        coluna2.innerText = pessoas[i].nome
        coluna3.innerText = pessoas[i].idade
        coluna4.innerText = pessoas[i].cidade
        coluna5.innerHTML = `<button class="btn btn-success" onclick="selecionarPessoa(${i})">Selecionar</button>`;

    }

}

// Selecionar pessoa
function selecionarPessoa(indice){

    // Atribuir ao indiceSelecionado
    indiceSelecionado = indice;

    // Visibilidade dos botões
    document.getElementById("btnCadastrar").style.display = "none";
    document.getElementById("btnAlterar").style.display = "inline-block";
    document.getElementById("btnRemover").style.display = "inline-block";
    document.getElementById("btnCancelar").style.display = "inline-block";

    // Exibir dados no formulário
    document.getElementById("nome").value = pessoas[indice].nome;
    document.getElementById("idade").value = pessoas[indice].idade;
    document.getElementById("cidade").value = pessoas[indice].cidade;

}

// Limpar campos
function limparCampos(){

    //Limpar os elementos do formulário
    document.getElementById("nome").value = "";
    document.getElementById("idade").value = "";
    document.getElementById("cidade").value = "";

    //Visibilidade dos botões
    document.getElementById("btnCadastrar").style.display = "inline-block";
    document.getElementById("btnAlterar").style.display = "none";
    document.getElementById("btnRemover").style.display = "none";
    document.getElementById("btnCancelar").style.display = "none";
}

// Remover
function remover(){

    //Remover do JSON
    pessoas.splice(indiceSelecionado,1);

    // Limpar campos
    limparCampos();

    // Atualizar tabela
    selecionar();

}

// Alterar
function alterar(){

    // Obter os dados
    let nome = document.getElementById("nome").value;
    let idade = document.getElementById("idade").value;
    let cidade = document.getElementById("cidade").value;

    // Alterar dados no JSON
    pessoas[indiceSelecionado] = {
        "nome":nome,
        "idade":idade,
        "cidade":cidade
    };

    // Limpar campos
    limparCampos();

    // Listar dados
    console.table(pessoas);
    selecionar();
}


