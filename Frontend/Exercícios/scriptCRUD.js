// JSON
let alunos = [];

// Indice para efetuar a alteração ou remoção
let indiceSelecionado

//Cadastrar
function cadastrar(){

    // Obter os dados
    let nome = document.getElementById("nome").value;
    let genero = document.getElementById("genero").value;
    let nota1 = document.getElementById("nota1").value;
    let nota2 = document.getElementById("nota2").value;

    // Validações
    if(nome == ""){
        alert("Você deve inserir um nome!")
        return;
    }
    if(nota1 == "" || isNaN(nota1) || nota1 > 10){
        alert("Primeira nota: inserção inválida!");
        return;
    }
    if(nota2 == "" || isNaN(nota2) || nota1 > 10){
        alert("Segunda nota: inserção inválida!");
        return;
    }

    let media = (parseFloat(nota1) + parseFloat(nota2)) / 2;

    // Adicionar no JSON
    alunos.push({
        "nome":nome,
        "genero":genero,
        "nota1":nota1,
        "nota2":nota2,
        "media":media
    })

    // Limpar campos
    limparCampos();

    // Listar dados
    console.table(alunos);
    selecionar();
}

// Selecionar
function selecionar(){

    // Obter o tbody
    let tabela = document.getElementById("tabela");

    // Remover conteúdos do tbody
    tabela.innerHTML = "";

    // Laço de repetição
    for(let i = 0; i < alunos.length; i++){

        // Criar uma linha
        let linha = tabela.insertRow(-1);

        // Colunas
        let coluna1 = linha.insertCell(0);
        let coluna2 = linha.insertCell(1);
        let coluna3 = linha.insertCell(2);
        let coluna4 = linha.insertCell(3);
        let coluna5 = linha.insertCell(4);
        let coluna6 = linha.insertCell(5);
        let coluna7 = linha.insertCell(6);

        // Adicionar valores para cada coluna

        coluna1.innerText = i+1
        coluna2.innerText = alunos[i].nome
        coluna3.innerText = alunos[i].genero
        coluna4.innerText = alunos[i].nota1
        coluna5.innerText = alunos[i].nota2
        coluna6.innerText = alunos[i].media
        coluna7.innerHTML = `<button class="btn btn-success" onclick="selecionarPessoa(${i})">Selecionar</button>`;

    }

    atualizarDashboard();

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
    document.getElementById("nome").value = alunos[indice].nome;
    document.getElementById("genero").value = alunos[indice].genero;
    document.getElementById("nota1").value = alunos[indice].nota1;
    document.getElementById("nota2").value = alunos[indice].nota2;

}

// Limpar campos
function limparCampos(){

    //Limpar os elementos do formulário
    document.getElementById("nome").value = "";
    document.getElementById("nota1").value = "";
    document.getElementById("nota2").value = "";

    //Visibilidade dos botões
    document.getElementById("btnCadastrar").style.display = "inline-block";
    document.getElementById("btnAlterar").style.display = "none";
    document.getElementById("btnRemover").style.display = "none";
    document.getElementById("btnCancelar").style.display = "none";
}

// Remover
function remover(){

    //Remover do JSON
    alunos.splice(indiceSelecionado,1);

    // Limpar campos
    limparCampos();

    // Atualizar tabela
    selecionar();

}

// Alterar
function alterar(){

    // Obter os dados
    let nome = document.getElementById("nome").value;
    let genero = document.getElementById("genero").value;
    let nota1 = document.getElementById("nota1").value;
    let nota2 = document.getElementById("nota2").value;

    // Validações
    if(nome == ""){
        alert("Você deve inserir um nome!")
        return;
    }
    if(nota1 == "" || isNaN(nota1) || nota1 > 10){
        alert("Primeira nota: inserção inválida!");
        return;
    }
    if(nota2 == "" || isNaN(nota2) || nota2 > 10){
        alert("Segunda nota: inserção inválida!");
        return;
    }

    let media = (parseFloat(nota1) + parseFloat(nota2)) / 2;

    // Adicionar no JSON
    alunos[indiceSelecionado] = {
        "nome":nome,
        "genero":genero,
        "nota1":nota1,
        "nota2":nota2,
        "media":media
    }

    // Limpar campos
    limparCampos();

    // Listar dados
    console.table(alunos);
    selecionar();

}

function atualizarDashboard(){

    let machos = 0;
    let femeas = 0;

    let aprovados = 0;
    let emExame = 0;
    let reprovados = 0;

    for(let i = 0; i < alunos.length; i++){

        if(alunos[i].genero == "Macho"){
            machos++;
        }else{
            femeas++;
        }

        if(alunos[i].media >= 7){
            aprovados++;
        }else if (alunos[i].media > 5){
            emExame++;
        }else{
            reprovados++;
        }

    }

    document.getElementById("cadastrados").value = machos+femeas;
    document.getElementById("machos").value = machos;
    document.getElementById("femeas").value = femeas;
    document.getElementById("femeas").value = femeas;
    document.getElementById("aprovados").value = aprovados;
    document.getElementById("emExame").value = emExame;
    document.getElementById("reprovados").value = reprovados;

}

function pesquisarAluno(){

    let nomeASerPesquisado = document.getElementById("nomeAluno").value

    if(nomeASerPesquisado == ""){
        alert("Você deve inserir um nome!");
        return;
    }

    // Obter o tbody
    let tabela = document.getElementById("tabela");

    // Remover conteúdos do tbody
    tabela.innerHTML = "";

    let encontrado = false;

    // Laço de repetição
    for(let i = 0; i < alunos.length; i++){

        if(alunos[i].nome == nomeASerPesquisado){

            // Criar uma linha
            let linha = tabela.insertRow(-1);

            // Colunas
            let coluna1 = linha.insertCell(0);
            let coluna2 = linha.insertCell(1);
            let coluna3 = linha.insertCell(2);
            let coluna4 = linha.insertCell(3);
            let coluna5 = linha.insertCell(4);
            let coluna6 = linha.insertCell(5);
            let coluna7 = linha.insertCell(6);

            // Adicionar valores para cada coluna

            coluna1.innerText = i+1
            coluna2.innerText = alunos[i].nome
            coluna3.innerText = alunos[i].genero
            coluna4.innerText = alunos[i].nota1
            coluna5.innerText = alunos[i].nota2
            coluna6.innerText = alunos[i].media
            coluna7.innerHTML = `<button class="btn btn-success" onclick="selecionarPessoa(${i})">Selecionar</button>`;
            encontrado = true;
        }
    }

    if(encontrado == false){
        alert("Nenhum aluno com esse nome foi encontrado!")
    }

}