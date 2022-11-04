<script>

import router from '@/router.js';

export default{
  name:"AdminPage",
  data (){
    return{
      cargos: [],
      postagens: [],
      categorias: [],
      comentarios: [],
      comentariosSelecionados: [],
      Usuario: [],
      usuarios: [],
      loggedUserID: 13,
      loggedUserName: "Admin"
    }
  },
  beforeMount(){
    this.mount();
  },
  methods:{
    mount(){
      fetch("https://localhost:7279/api/categorias")
      .then(postagem => postagem.json())
      .then(retorno => this.carregarCategorias(retorno));

      fetch("https://localhost:7279/api/cargos")
      .then(postagem => postagem.json())
      .then(retorno => this.carregarCargos(retorno));

      fetch("https://localhost:7279/api/postagens")
      .then(postagem => postagem.json())
      .then(retorno => this.carregarPostagens(retorno)); 

      fetch(`https://localhost:7279/api/comentarios`)
      .then(postagem => postagem.json())
      .then(retorno => this.carregarComentarios(retorno));

      this.loggedUserID = sessionStorage.getItem("usuario");
      this.loggedUserName = sessionStorage.getItem("usuarioNome");

      fetch(`https://localhost:7279/api/usuarios/${this.loggedUserID}`)
      .then(postagem => postagem.json())
      .then(retorno => this.carregarUsuarioLogado(retorno)); 

      fetch(`https://localhost:7279/api/usuarios`)
      .then(postagem => postagem.json())
      .then(retorno => this.carregarUsuarios(retorno));

    },
    deslogar(){
      router.push(`/`);
      sessionStorage.clear();
    },
    carregarCategorias(retorno){

        this.categorias = retorno;
        this.adicionarCategorias();
    },
    carregarUsuarios(retorno){

        this.usuarios = retorno;
    },
    carregarCargos(retorno){

        this.cargos = retorno;
    },
    adicionarCategorias(){
      
        document.getElementById("categoriasSelect").innerHTML = `<option selected value="-1">Categorias</option>`;
        document.getElementById("selectCategoriasRedator").innerHTML = `<option selected value="-1">Categorias</option>`;

        for(let i = 0; i < this.categorias.length ; i++){
        var categoria = this.categorias[i]
        document.getElementById("categoriasSelect").innerHTML +=
        `<option value="${categoria.id}">${categoria.nomeCategoria}</option>`;
        document.getElementById("selectCategoriasRedator").innerHTML +=
        `<option value="${categoria.id}">${categoria.nomeCategoria}</option>`;
            
        }
    },

    // ///////////////////////////
    carregarPostagens(retorno){

        this.postagens = retorno;
        this.postagens.sort(({id:a}, {id:b}) => a-b);
        this.postagens.reverse();
    },
    carregarComentarios(retorno){

       this.comentarios = retorno;
       this.comentarios.sort(({id:a}, {id:b}) => a-b);
    },
    carregarUsuarioLogado(retorno){

      this.Usuario = retorno;
    },
    pegarNomeCategoria(id){

      for(let i = 0; i < this.categorias.length;i++ ){
        
        if(this.categorias[i].id == id){
          return this.categorias[i].nomeCategoria;
        }
      }
      return "DELETADO";
    },
    pegarNomeUsuarioPeloID(id){

      for(let i = 0; i < this.usuarios.length;i++ ){
        
        if(this.usuarios[i].id == id){
          return this.usuarios[i].nomeUsuario;
        }
      }
      return "DELETADO";

    },
    
    // //////////////////////////

    // Todas as postagens <<<<<<<<<<<<<<

    async adicionarPostagens(){

      await fetch("https://localhost:7279/api/postagens")
      .then(postagem => postagem.json())
      .then(retorno => this.carregarPostagens(retorno)); 

    },

    // Postagens por categoria <<<<<<<<<<<

    async adicionarPostagensPorCategoria(){

      let categoria = document.getElementById("categoriasSelect").value;

      if(categoria == -1){
        this.adicionarPostagens();
        return;
      }
      this.postagens = await this.carregarPorCategoria(categoria);
    },
    async carregarPorCategoria(termo){

      let vetor = [];

      await fetch(`https://localhost:7279/api/postagens/categoria/${termo}`)
        .then(postagem => postagem.json())
        .then(retorno => vetor = retorno);

      return vetor;

    },

    // Postagens por pesquisa <<<<<<<<<<<<<

    async adicionarPostagensPorPesquisa(){

      let termo = document.getElementById("textoPesquisa").value;

      if(termo == ""){
        this.adicionarPostagens();
        document.getElementById("categoriasSelect").value = -1;
        return;
      }

      this.postagens = await this.carregarPorPesquisa(termo);
      document.getElementById("categoriasSelect").value = -1;
    },
    async carregarPorPesquisa(termo){

      let vetor = [];

      await fetch(`https://localhost:7279/api/postagens/titulo/${termo}`)
        .then(postagem => postagem.json())
        .then(retorno => vetor = retorno);

        return vetor;

    },

    // Comentários <<<<<<<<<<<

    CarregarComentariosPorPost(id){
      
      this.comentariosSelecionados.splice(0,this.comentariosSelecionados.length);

      for(let i = 0; i < this.comentarios.length; i++){

        if(this.comentarios[i].postagemId == id){

          this.comentariosSelecionados.push(this.comentarios[i])
        }
      }

    },
    async adicionarComentario(postID){

      let comentario = document.getElementById(`textoComentario${postID}`).value;

      const requisicao = new Request("https://localhost:7279/api/comentarios",
          {
            method: "POST",
            headers: {
              "Accept": "application/json",
              "Content-Type" : "application/json"
            },
            body: JSON.stringify({
                "usuarioId":this.loggedUserID,
                "usuarioNome":this.loggedUserName,
                "postagemId":postID,
                "comentario":`${comentario}`
            })
          }
        );
        await fetch(requisicao);
        this.mount();
    },
    async deletarComentario(id){

    const requisicao = new Request(`https://localhost:7279/api/comentarios/${id}`,
          {
            method: "DELETE",
            headers: {
              "Accept": "application/json",
              "Content-Type" : "application/json"
            },
            body: JSON.stringify({
              "id":id
            })
          }
        );
      await fetch(requisicao);

      this.mount();
    },

    // Adicionar postagens <<<<<<<<<<<<<<<<<<<<<<<<<<

    async AdicionarPostagem(){

      let titulo = document.getElementById("tituloPost").value;
      let texto = document.getElementById("textoPost").value;

      let select = document.getElementById("selectCategoriasRedator");
      let categoria = document.getElementById("selectCategoriasRedator").value;
      let categoriaNome = select.options[select.selectedIndex].text;

      if(titulo == ""){
        alert("Você deve inserir um título!")
        return;
      }

      if(texto == ""){
        alert("Você deve inserir o texto!")
        return;
      }

      if(categoria == -1){
        alert("Você deve selecionar uma categoria!")
        return;
      }

      const requisicao = new Request("https://localhost:7279/api/postagens",
        {
          method: "POST",
          headers: {
            "Accept": "application/json",
            "Content-Type" : "application/json"
          },
          body: JSON.stringify({
              "tituloPostagem":titulo,
              "textoPostagem":texto,
              "usuarioId":this.loggedUserID,
              "usuarioNome":this.loggedUserName,
              "categoriaId":categoria,
              "categoriaNome":categoriaNome
          })
        }
      );

      await fetch(requisicao);
      this.mount();
    },

    // Deletar Postagens <<<<<<<<<<<<
    async deletarPostagem(id){

      const requisicao = new Request(`https://localhost:7279/api/postagens/${id}`,
        {
          method: "DELETE",
          headers: {
            "Accept": "application/json",
            "Content-Type" : "application/json"
          },
          body: JSON.stringify({
              "id":id
          })
        }
      );

      await fetch(requisicao);
      this.mount();
    },

    // Alterar postagem
    async alterarPostagem(id){

      let novoTitulo = document.getElementById(`newTitle${id}`).value;

      if(novoTitulo == ""){
        alert("Você deve escrever o título!")
        return;
      }

      let novoTexto = document.getElementById(`newText${id}`).value;

      if(novoTexto == ""){
        alert("Você deve escrever o texto!")
        return;
      }
      
      let novaCategoria = document.getElementById(`selectAlterar${id}`).value;

      let post = [];

      for(let i = 0; i < this.postagens.length; i++){

        if(this.postagens[i].id == id){
          post = this.postagens[i];
          break;
        }
      }

      const requisicao = new Request(`https://localhost:7279/api/postagens/${id}`,
        {
          method: "put",
          headers: {
            "Accept": "application/json",
            "Content-Type" : "application/json"
          },
          body: JSON.stringify({
                "id": id,
                "tituloPostagem": novoTitulo,
                "textoPostagem": novoTexto,
                "usuarioId": post.usuarioId,
                "categoriaId": novaCategoria
          })
        }
      );

      let retorno = await fetch(requisicao);
      console.table(retorno);
      this.mount();
    },

    // Alterar Categorias
    async alterarCategoria(id){

      let novoNome = document.getElementById(`nomeCategoria${id}`).value;

      const requisicao = new Request(`https://localhost:7279/api/categorias/${id}`,
        {
          method: "put",
          headers: {
            "Accept": "application/json",
            "Content-Type" : "application/json"
          },
          body: JSON.stringify({
                "id": id,
                "nomeCategoria": novoNome
          })
        }
      );

      await fetch(requisicao);
      this.mount();
    },

    // Deletar categorias

    async deletarCategoria(id){
      const requisicao = new Request(`https://localhost:7279/api/categorias/${id}`,
        {
          method: "DELETE",
          headers: {
            "Accept": "application/json",
            "Content-Type" : "application/json"
          },
          body: JSON.stringify({
                "id": id,
          })
        }
      );

      await fetch(requisicao);
      this.mount();
    },

    // Adicionar categorias

    async adicionarCategoria(){

      let novoNome = document.getElementById("nomeCategoria").value;

      const requisicao = new Request(`https://localhost:7279/api/categorias/`,
        {
          method: "post",
          headers: {
            "Accept": "application/json",
            "Content-Type" : "application/json"
          },
          body: JSON.stringify({
                "nomeCategoria": novoNome
          })
        }
      );

      await fetch(requisicao);
      this.mount();
    },

    // Alterar usuário

    async alterarUsuario(id){

      let novoNome = document.getElementById(`nomeUsuario${id}`).value;

      if(novoNome == ""){
        alert("Você deve inserir um nome!")
        return;
      }

      let novaSenha = document.getElementById(`senhaUsuario${id}`).value;

      if(novaSenha == ""){
        alert("Você deve inserir uma senha!")
        return;
      }

      let novoCargo = document.getElementById(`cargoUsuario${id}`).value;

      if(novaSenha == ""){
        alert("Você deve inserir um cargo!")
        return;
      }

      let cargoEncontrado = false;

      for(let i = 0; i < this.cargos.length; i++){

        if(this.cargos[i].id == novoCargo){
          cargoEncontrado = true;
          break;
        }
      }

      if(cargoEncontrado == false){
        alert("Cargo inválido!")
        return;
      }

      let novaCategoria1 = document.getElementById(`categoria1Usuario${id}`).value;
      let novaCategoria2 = document.getElementById(`categoria2Usuario${id}`).value;
      let novaCategoria3 = document.getElementById(`categoria3Usuario${id}`).value;

      let categoria1Encontrada = false;
      let categoria2Encontrada = false;
      let categoria3Encontrada = false;

      for(let i = 0; i < this.categorias.length; i++){

        if(novaCategoria1 == this.categorias[i].id || novaCategoria1 == 0){
          categoria1Encontrada = true;
        }

        if(novaCategoria2 == this.categorias[i].id || novaCategoria2 == 0){
          categoria2Encontrada = true;
        }

        if(novaCategoria3 == this.categorias[i].id || novaCategoria3 == 0){
          categoria3Encontrada = true;
        }

      }

      if(novaCategoria1 == 0 && novaCategoria2 == 0 && novaCategoria3 == 0 && novoCargo == 2){
        alert("Você deve cadastrar uma categoria!");
        return;
      }

      if(categoria1Encontrada == false){
        alert("Categoria 1 inválida!");
        return;
      }

      if(categoria2Encontrada == false){
        alert("Categoria 2 inválida!");
        return;
      }

      if(categoria3Encontrada == false){
        alert("Categoria 3 inválida!");
        return;
      }

      const requisicao = new Request(`https://localhost:7279/api/usuarios/${id}`,
        {
          method: "put",
          headers: {
            "Accept": "application/json",
            "Content-Type" : "application/json"
          },
          body: JSON.stringify({
            "id":id,
            "nomeUsuario":novoNome,
            "senhaUsuario":novaSenha,
            "cargoId": novoCargo,
            "primeiraCategoriaUsuario":novaCategoria1,
            "segundaCategoriaUsuario":novaCategoria2,
            "terceiraCategoriaUsuario":novaCategoria3,
          })
        }
      );

      await fetch(requisicao);
      this.mount();

      alert("Usuário alterado com sucesso!")

    },

    // Deletar usuário

    async deletarUsuario(id){

      const requisicao = new Request(`https://localhost:7279/api/usuarios/${id}`,
        {
          method: "delete",
          headers: {
            "Accept": "application/json",
            "Content-Type" : "application/json"
          },
          body: JSON.stringify({
            "id":id,
          })
        }
      );

      await fetch(requisicao);
      this.mount();

      alert("Usuário deletado com sucesso!")

    },

    async cadastrarUsuario(){

    let novoNome = document.getElementById(`nomeNovoUsuario`).value;

      if(novoNome == ""){
        alert("Você deve inserir um nome!")
        return;
      }

      for(let i = 0; i < this.usuarios.length; i++){

        if(this.usuarios[i].nomeUsuario == novoNome){
          alert("Esse usuário já existe!")
          return;
        }
      }

      let novaSenha = document.getElementById(`senhaNovoUsuario`).value;

      if(novaSenha == ""){
        alert("Você deve inserir uma senha!")
        return;
      }

      let novoCargo = document.getElementById(`cargoNovoUsuario`).value;

      if(novaSenha == ""){
        alert("Você deve inserir um cargo!")
        return;
      }

      let cargoEncontrado = false;

      for(let i = 0; i < this.cargos.length; i++){

        if(this.cargos[i].id == novoCargo){
          cargoEncontrado = true;
          break;
        }
      }

      if(cargoEncontrado == false){
        alert("Cargo inválido!")
        return;
      }

      let novaCategoria1 = document.getElementById(`categoria1NovoUsuario`).value;
      let novaCategoria2 = document.getElementById(`categoria2NovoUsuario`).value;
      let novaCategoria3 = document.getElementById(`categoria3NovoUsuario`).value;

      let categoria1Encontrada = false;
      let categoria2Encontrada = false;
      let categoria3Encontrada = false;

      for(let i = 0; i < this.categorias.length; i++){

        if(novaCategoria1 == this.categorias[i].id || novaCategoria1 == 0){
          categoria1Encontrada = true;
        }

        if(novaCategoria2 == this.categorias[i].id || novaCategoria2 == 0){
          categoria2Encontrada = true;
        }

        if(novaCategoria3 == this.categorias[i].id || novaCategoria3 == 0){
          categoria3Encontrada = true;
        }

      }

      if(novaCategoria1 == 0 && novaCategoria2 == 0 && novaCategoria3 == 0 && novoCargo == 2){
        alert("Você deve cadastrar uma categoria!");
        return;
      }

      if(categoria1Encontrada == false){
        alert("Categoria 1 inválida!");
        return;
      }

      if(categoria2Encontrada == false){
        alert("Categoria 2 inválida!");
        return;
      }

      if(categoria3Encontrada == false){
        alert("Categoria 3 inválida!");
        return;
      }

      const requisicao = new Request(`https://localhost:7279/api/usuarios`,
        {
          method: "post",
          headers: {
            "Accept": "application/json",
            "Content-Type" : "application/json"
          },
          body: JSON.stringify({
            "nomeUsuario":novoNome,
            "senhaUsuario":novaSenha,
            "cargoId": novoCargo,
            "primeiraCategoriaUsuario":novaCategoria1,
            "segundaCategoriaUsuario":novaCategoria2,
            "terceiraCategoriaUsuario":novaCategoria3,
          })
        }
      );

      await fetch(requisicao);
      this.mount();

      alert("Usuário cadastrado com sucesso!")
    }

  }
}

</script>

<template>
    <div>
        <nav class="navbar navbar-expand-lg bg-light">
            <div class="container-fluid">
              <a class="navbar-brand" href="#">
                <img src="./D.png" width="45" height="45" alt="logo.png">
                <b>  Blog da Dilma</b>
              </a>
              <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
              </button>
              
              <div class="collapse navbar-collapse" id="navbarNav">
                <ul class="navbar-nav">
                  <li class="nav-item">
                    <a class="nav-link active" aria-current="page" href="#" v-on:click="this.deslogar()">Logoff</a>
                  </li>
                </ul>
                <ul class="navbar-nav ms-auto">
                  <select name="Categorias" class="form-select" id="categoriasSelect" v-on:change="this.adicionarPostagensPorCategoria()">
                    <option selected value="-1">Categorias</option>
                  </select>
                </ul>
                <ul class="navbar-nav ms-auto">
                  <form class="d-flex" role="search">
                    <input class="form-control" type="search" placeholder="Título" aria-label="Search" id="textoPesquisa" v-on:keyup="this.adicionarPostagensPorPesquisa()">
                  </form>
                </ul>
              </div>
            </div>
          </nav>
    </div>

    <div id="contas" style="width: 80%">
        <div class="accordion" id="accordionContas" style="width:50%, margin 0 auto;" >
            <div class="accordion-item">
              <h2 class="accordion-header" id="accordionHeaderContas">
                    <button class="accordion-button" type="button" data-bs-toggle="collapse" data-bs-target="#bodyContas" aria-expanded="true" aria-controls="bodyContas">
                      Contas
                    </button>
                  </h2>
                  
                  <div id="bodyContas" class="accordion-collapse collapse" aria-labelledby="panelsStayOpen-headingOne">
                    <div class="accordion-body">

                        <table class="table" style="margin: 0 auto">

                        <thead>
                            <tr>
                            <th scope="col">ID</th>
                            <th scope="col">Nome</th>
                            <th scope="col">Senha</th>
                            <th scope="col">Cargo</th>
                            <th scope="col">Categoria 1</th>
                            <th scope="col">Categoria 2</th>
                            <th scope="col">Categoria 3</th>
                            <th scope="col">Alterar</th>
                            <th scope="col">Deletar</th>
                            </tr>
                        </thead>

                        <tbody id="tbodyContas">
                          <tr v-for="usuario in this.usuarios" :key="usuario.id">
                            <td v-if="usuario.cargoId != 1">{{usuario.id}}</td>
                            <td v-if="usuario.cargoId != 1"><input type="text" style="width: 10em;" v-bind:id="'nomeUsuario'+usuario.id" v-bind:value="usuario.nomeUsuario"></td>
                            <td v-if="usuario.cargoId != 1"><input type="text" style="width: 10em;" v-bind:id="'senhaUsuario'+usuario.id" v-bind:value="usuario.senhaUsuario"></td>
                            <td v-if="usuario.cargoId != 1"><input type="text" style="width: 5em;" v-bind:id="'cargoUsuario'+usuario.id" v-bind:value="usuario.cargoId"></td>
                            <td v-if="usuario.cargoId != 1"><input type="text" style="width: 5em;" v-bind:id="'categoria1Usuario'+usuario.id" v-bind:value="usuario.primeiraCategoriaUsuario"></td>
                            <td v-if="usuario.cargoId != 1"><input type="text" style="width: 5em;" v-bind:id="'categoria2Usuario'+usuario.id" v-bind:value="usuario.segundaCategoriaUsuario"></td>
                            <td v-if="usuario.cargoId != 1"><input type="text" style="width: 5em;" v-bind:id="'categoria3Usuario'+usuario.id" v-bind:value="usuario.terceiraCategoriaUsuario"></td>
                             <td v-if="usuario.cargoId != 1"><button class="btn btn-warning" v-on:click="alterarUsuario(usuario.id)">Alterar</button></td>
                              <td v-if="usuario.cargoId != 1"><button class="btn btn-danger" v-on:click="deletarUsuario(usuario.id)">Deletar</button></td>
                          </tr>
                        </tbody>

                        </table>

                    </div>
                <form action="">
                    <label for="nomeUsuario">Adicionar Usuário:</label>
                    <br>
                    <input type="text" id="nomeNovoUsuario" placeholder="Nome">
                    <input type="text" id="senhaNovoUsuario" placeholder="Senha">
                    <br> <br>
                    <input type="text" style="width: 5em;" id="cargoNovoUsuario" placeholder="Cargo">
                    <br> <br>
                    <input type="text" style="width: 7em;" id="categoria1NovoUsuario" placeholder="Categoria 1">
                    <input type="text" style="width: 7em;" id="categoria2NovoUsuario" placeholder="Categoria 2">
                    <input type="text" style="width: 7em;" id="categoria3NovoUsuario" placeholder="Categoria 3">
                    <br> <br>
                    <input type="button" class="btn btn-primary" value="Adicionar" v-on:click="cadastrarUsuario()">
                </form>
                </div>
            </div>
        </div>
    </div>

    <div id="categorias" style="width: 80%">
        <div class="accordion" id="accordionCategorias" style="width:50%, margin 0 auto;" >
            <div class="accordion-item">
              <h2 class="accordion-header" id="accordionHeaderCategorias">
                    <button class="accordion-button" type="button" data-bs-toggle="collapse" data-bs-target="#bodyCategorias" aria-expanded="true" aria-controls="bodyCategorias">
                      Categorias
                    </button>
                  </h2>
                  
                  <div id="bodyCategorias" class="accordion-collapse collapse" aria-labelledby="panelsStayOpen-headingOne">
                    <div class="accordion-body">

                        <table class="table">

                        <thead>
                            <tr>
                            <th scope="col">ID</th>
                            <th scope="col">Nome</th>
                            <th scope="col">Alterar</th>
                            <th scope="col">Deletar</th>
                            </tr>
                        </thead>

                        <tbody id="tbodyCategorias">
                            <tr>
                              <td>0</td>
                              <td>Categoria nula</td>
                              <td>-----</td>
                              <td>-----</td>
                            </tr>
                            <tr v-for="categoria in categorias" :key="categoria.id">
                              <td>{{categoria.id}}</td>
                              <td><input type="text" v-bind:id="'nomeCategoria'+categoria.id" v-bind:value="categoria.nomeCategoria"></td>
                              <td><button class="btn btn-warning" v-on:click="alterarCategoria(categoria.id)">Alterar</button></td>
                              <td><button class="btn btn-danger" v-on:click="deletarCategoria(categoria.id)">Deletar</button></td>
                            </tr>
                        </tbody>

                        </table>

                    </div>
                <form action="">
                    <label for="nomeUsuario">Adicionar Categoria:</label>
                    <br> <br>
                    <input type="text" id="nomeCategoria" placeholder="Nome">
                    <br> <br>
                    <input type="button" class="btn btn-primary" value="Adicionar" v-on:click="adicionarCategoria()">
                </form>
                </div>
            </div>
        </div>
    </div>

    <div id="redacao" style="width: 80%;">
        <div class="accordion" id="accordionRedacao" style="width:50%, margin 0 auto;" >
            <div class="accordion-item">
              <h2 class="accordion-header" id="accordionHeaderRedacao">
                    <button class="accordion-button" type="button" data-bs-toggle="collapse" data-bs-target="#bodyRedacao" aria-expanded="true" aria-controls="bodyRedacao">
                      Redação
                    </button>
                  </h2>
                  
                  <div id="bodyRedacao" class="accordion-collapse collapse" aria-labelledby="panelsStayOpen-headingOne">
                    <div class="accordion-body">

                        <select name="" id="selectCategoriasRedator">
                            <option value="-1">Categoria</option>
                        </select>
                        <br> <br>
                        <input type="text" placeholder="Título" id="tituloPost">
                        <br> <br>
                        <textarea name="text" id="textoPost" cols="50" rows="5"></textarea>
                        <br> <br>
                        <input type="button" value="Postar" class="btn btn-success" v-on:click="this.AdicionarPostagem()">
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div id="posts">
      <div class="card" style="width: 80%;margin: 10px auto;" v-for="post in this.postagens" :key="post.id">
          <div class="card-body">

              <h5 class="card-title">{{post.tituloPostagem}}, ID:{{post.id}}</h5>
              <h6 class="card-subtitle mb-2 text-muted">Redator: {{pegarNomeUsuarioPeloID(post.usuarioId)}}, Categoria: {{pegarNomeCategoria(post.categoriaId)}}</h6>
              {{post.textoPostagem}}
              <br> <br>

              <div class="accordion" v-bind:id="'accordion'+post.id" style="width:50%, margin 0 auto;" >
                  <div class="accordion-item">
                      <h2 class="accordion-header" v-bind:id="'accordionHeader'+post.id">
                      <button class="accordion-button" type="button" data-bs-toggle="collapse" v-bind:data-bs-target="'#accordionBody'+post.id" aria-expanded="true" v-bind:aria-controls="'accordionBody'+post.id">
                          Comentários
                      </button>
                      </h2>
                      <div v-bind:id="'accordionBody'+post.id" class="accordion-collapse collapse" aria-labelledby="panelsStayOpen-headingOne">
                      <div class="accordion-body">
                          <table class="table">

                          <thead>
                              <tr>
                              <th scope="col">ID</th>
                              <th scope="col">Usuário</th>
                              <th scope="col">Comentário</th>
                              <th scope="col">Deletar</th>
                              </tr>
                          </thead>

                            <tbody id="tbody">
                  
                              <tr v-for="comentario in this.comentarios" :key="comentario.id">
                                <td v-if="comentario.postagemId == post.id">{{comentario.id}}</td>
                                <td v-if="comentario.postagemId == post.id">{{ pegarNomeUsuarioPeloID(comentario.usuarioId)}}</td>
                                <td v-if="comentario.postagemId == post.id">{{comentario.comentario}}</td>
                                <td v-if="comentario.postagemId == post.id"><button class="btn btn-danger" v-on:click="deletarComentario(comentario.id)">Deletar</button></td>
                              </tr>

                          </tbody>

                          </table>

                          </div>
                            <form action="">
                                <label for="textoComentario">Adicionar comentário:</label>
                                <br>
                                <textarea name="text" v-bind:id="'textoComentario'+post.id"></textarea>
                                <br>
                                <input type="button" class="btn btn-primary" value="Adicionar" v-on:click="adicionarComentario(post.id)">
                            </form>
                        </div>

                      </div>
                      </div>
                  </div>
                  <div class="accordion" v-bind:id="'accordionAlterar'+post.id" style="width:50%, margin 0 auto;" >
                  <div class="accordion-item">
                      <h2 class="accordion-header" v-bind:id="'accordionAlterarHeader'+post.id">
                      <button class="accordion-button" type="button" data-bs-toggle="collapse" v-bind:data-bs-target="'#accordionAlterarBody'+post.id" aria-expanded="true" v-bind:aria-controls="'accordionAlterarBody'+post.id">
                          Alterar
                      </button>
                      </h2>
                      <div v-bind:id="'accordionAlterarBody'+post.id" class="accordion-collapse collapse" aria-labelledby="panelsStayOpen-headingOne">
                        <div class="accordion-body">
                          <button class="btn btn-danger" v-on:click="deletarPostagem(post.id)">Deletar Post</button>
                          <br><br>
                          <input type="text" placeholder="Novo título" v-bind:id="'newTitle'+post.id">
                          <input type="text" placeholder="Novo texto" v-bind:id="'newText'+post.id">
                          <br>
                          Categoria:
                          <select v-bind:id="'selectAlterar'+post.id">
                            <option v-for="categoria in this.categorias" :key="categoria.id" v-bind:value="categoria.id">{{categoria.nomeCategoria}}</option>
                          </select>
                          Alterar Post:
                          <input type="button" value="Alterar" class="btn btn-warning" v-on:click="alterarPostagem(post.id)">
                        </div>
                      </div>
                  </div>
                </div>
              </div>
          </div>

</template>

<style src="./styles.css"></style>


