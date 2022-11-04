<template>
  <div id="masterdiv">
    <form id="form1">
      <h5>Logar:</h5>
      <br>
      <input type="text" placeholder="Nome" id="nomeLogin">
      <br><br>
      <input type="password" placeholder="Senha" id="senhaLogin">
      <br><br>
      <input type="button" class="btn btn-primary" value="Logar" v-on:click="login()">
      <br><br>
    </form>
    <form id="form2">
      <h5>Cadastrar:</h5>
      <br>
      <input type="text" placeholder="Nome" id="nomeCadastro">
      <br> <br>
      <input type="password" placeholder="Senha" id="senhaCadastro">
      <br><br>
      <input type="button" class="btn btn-primary" value="Cadastrar" v-on:click="cadastrar()">
      <br> <br>
    </form>
  </div>
  <div>
    <button class="btn btn-danger" v-on:click="voltar()">Voltar</button>
  </div>
</template>

<style>

  #masterdiv{
    text-align: center;
    margin: 10rem auto;
  }
  #form1,
  #form2{
    display: inline-block;
    margin: 10px 1rem;
    width: fit-content;
    background-color: aliceblue;
    padding: 10px;
    border-radius: 10px;
    vertical-align: bottom;
  }

</style>

<script>
import router from "@/router";

export default{
  name:"LoginPage",
  data (){
    return{
    }
  },
  beforeMount(){
  },
  methods:{
    voltar(){
      router.push(`/`);
    },
    async login(){
      let nome = document.getElementById("nomeLogin").value;
      let senha = document.getElementById("senhaLogin").value;

      if(nome == ""){
        alert("Você deve inserir o nome!")
        return;
      }

      if(senha == ""){
        alert("Você deve inserir a senha!")
        return;
      }

      let vetor = [];

      await fetch("https://localhost:7279/api/usuarios")
      .then(postagem => postagem.json())
      .then(retorno => vetor = retorno); 

      for(let i = 0; i < vetor.length; i++){

        if(vetor[i].nomeUsuario == nome && vetor[i].senhaUsuario == senha){

          sessionStorage.setItem("usuario",vetor[i].id)
          sessionStorage.setItem("usuarioNome",nome)

          if(vetor[i].cargoId == 1){
            router.push('/admin');
          }
          if(vetor[i].cargoId == 2){
            router.push('/redator');
            
          }
          if(vetor[i].cargoId == 3){
            router.push('/leitor');
          }
          return;

        }
      }

      alert("Usuário ou senha inválidos.")

    },
    async cadastrar(){
      let nome = document.getElementById("nomeCadastro").value;
      let senha = document.getElementById("senhaCadastro").value;

      if(nome == ""){
        alert("Você deve inserir o nome!")
        return;
      }

      if(senha == ""){
        alert("Você deve inserir a senha!")
        return;
      }

      const requisicao = new Request("https://localhost:7279/api/usuarios",
          {
            method: "post",
            headers: {
              "Accept": "application/json",
              "Content-Type" : "application/json"
            },
            body: JSON.stringify({
                "nomeUsuario":`${nome}`,
                "senhaUsuario":`${senha}`,
                "cargoId":3,// Necessário colocar aqui o id do cargo LEITOR
                "primeiraCategoriaUsuario":0,
                "segundaCategoriaUsuario":0,
                "terceiraCategoriaUsuario":0
            })
          }
        );

        const executarRequisicao = await fetch(requisicao);
        const retorno = await executarRequisicao.json;
        alert("Cadastrado com sucesso!")

        sessionStorage.setItem("usuario",retorno.id)
        sessionStorage.setItem("usuarioNome",nome)
        router.push('/leitor');

    }
  }
}
</script>