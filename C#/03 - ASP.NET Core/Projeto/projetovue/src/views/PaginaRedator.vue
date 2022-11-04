<script>

import router from '@/router.js';

export default{
  name:"RedactorPage",
  data (){
    return{
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
  onMounted(){
    this.mount();
  },
  methods:{
    mount(){
      fetch("https://localhost:7279/api/categorias")
      .then(postagem => postagem.json())
      .then(retorno => this.carregarCategorias(retorno));

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
    adicionarCategorias(){
      
      document.getElementById("categoriasSelect").innerHTML == `<option selected value="-1">Categorias</option>`;

        for(let i = 0; i < this.categorias.length ; i++){
        var categoria = this.categorias[i]
        document.getElementById("categoriasSelect").innerHTML +=
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
      this.adicionarCategoriasRedator();
    },
    adicionarCategoriasRedator(){

        if(this.Usuario.primeiraCategoriaUsuario != 0){
          document.getElementById("selectCategoriasRedator").innerHTML +=
          `<option value="${this.Usuario.primeiraCategoriaUsuario}">${this.pegarNomeCategoria(this.Usuario.primeiraCategoriaUsuario)}</option>`;
        }

        if(this.Usuario.segundaCategoriaUsuario != 0){
          document.getElementById("selectCategoriasRedator").innerHTML +=
          `<option value="${this.Usuario.segundaCategoriaUsuario}">${this.pegarNomeCategoria(this.Usuario.segundaCategoriaUsuario)}</option>`;
        }

        if(this.Usuario.segundaCategoriaUsuario != 0){
          document.getElementById("selectCategoriasRedator").innerHTML +=
          `<option value="${this.Usuario.terceiraCategoriaUsuario}">${this.pegarNomeCategoria(this.Usuario.terceiraCategoriaUsuario)}</option>`;
        }
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
              <h5 class="card-title">{{post.tituloPostagem}}</h5>
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
                              <th scope="col">Usuário</th>
                              <th scope="col">Comentário</th>
                              <th scope="col" v-if="post.categoriaId == this.Usuario.primeiraCategoriaUsuario || 
                                            post.categoriaId == this.Usuario.segundaCategoriaUsuario || 
                                            post.categoriaId == this.Usuario.terceiraCategoriaUsuario">Deletar</th>
                              </tr>
                          </thead>

                            <tbody id="tbody">

                              <tr v-for="comentario in this.comentarios" :key="comentario.id">

                                <td v-if="comentario.postagemId == post.id">{{pegarNomeUsuarioPeloID(comentario.usuarioId)}}</td>
                                <td v-if="comentario.postagemId == post.id">{{comentario.comentario}}</td>

                                <td v-if="comentario.postagemId == post.id"><button class="btn btn-danger" v-on:click="deletarComentario(comentario.id)" 
                                    v-if="post.categoriaId == this.Usuario.primeiraCategoriaUsuario || 
                                    post.categoriaId == this.Usuario.segundaCategoriaUsuario || 
                                    post.categoriaId == this.Usuario.terceiraCategoriaUsuario "
                                    >Deletar</button></td>
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
              </div>
          </div>

</template>

<style src="./styles.css"></style>
