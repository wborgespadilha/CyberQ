<template>
  <div class="Home-crud">
    <form>
      <input type="text" v-model="obj.nome" placeholder="Nome do curso" class="form-control">
      <input type="number" v-model="obj.valor" placeholder="Valor do curso" class="form-control">
      <input type="button" value="Cadastrar" v-on:click="cadastrar()" v-if="treinamentoSelecionado == false" class="btn btn-primary">
      <input type="button" value="Alterar" v-on:click="alterar()" v-if="treinamentoSelecionado == true" class="btn btn-warning">
      <input type="button" value="Remover" v-on:click="remover()" v-if="treinamentoSelecionado == true" class="btn btn-danger">
      <input type="button" value="Cancelar" v-on:click="cancelar()" v-if="treinamentoSelecionado == true" class="btn btn-dark">
    </form>

    <table class="table" v-if="treinamentoSelecionado == false">

      <thead>
        <tr>
          <th>#</th>
          <th>Treinamento</th>
          <th>Valor</th>
          <th>Selecionar</th>
        </tr>
      </thead>

      <tbody v-for="(treinamento, indice) in treinamentos" v-bind:key="treinamento.id">
        <tr>
          <td>{{indice+1}}</td>
          <td>{{treinamento.nome}}</td>
          <td>{{treinamento.valor}}</td>
          <td><button class="btn btn-success" v-on:click="selecionar(indice)">Selecionar</button></td>
        </tr>
      </tbody>

    </table>
  </div>
</template>

<script>
// import { onBeforeMount } from 'vue';

  export default 
  {
    name: 'Home-crud',
    data()
    {
      return{
        treinamentos: {},
        obj: {},
        treinamentoSelecionado: false
      }
    },
    beforeMount(){
      this.listar();
    },
    methods: 
    {
      async listar(){
        const requisicao = await fetch ("https://localhost:7207/api/Treinamento");
        const retorno = await requisicao.json();
        this.treinamentos = retorno;
      },
      async cadastrar(){
        const requisicao = new Request("https://localhost:7207/api/Treinamento",
          {
            method: "post",
            headers: {
              "Accept": "application/json",
              "Content-Type" : "application/json"
            },
            body: JSON.stringify(this.obj)
          }
        );

        const executarRequisicao = await fetch(requisicao);
        const retorno = await executarRequisicao.json();
        this.treinamentos.push(retorno);  

      },
      selecionar(indice){
        this.treinamentoSelecionado = true;
        this.obj = this.treinamentos[indice];
      },
      cancelar(){
        this.treinamentoSelecionado = false;
        this.obj = {};
      },
      async alterar(){
        const requisicao = new Request(`https://localhost:7207/api/Treinamento/${this.obj.id}`,
          {
            method: "PUT",
            headers: {
              "Accept": "application/json",
              "Content-Type" : "application/json"
            },
            body: JSON.stringify(this.obj)
          }
        );

        await fetch(requisicao);

        await this.listar();
        this.cancelar();
      },
      async remover(){
        const requisicao = new Request(`https://localhost:7207/api/Treinamento/${this.obj.id}`,
          {
            method: "DELETE",
            headers: {
              "Accept": "application/json",
              "Content-Type" : "application/json"
            },
            body: JSON.stringify(this.obj)
          }
        );

        await fetch(requisicao);

        await this.listar();
        this.cancelar();
      }
      
    }
  };

</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
h3 {
  margin: 40px 0 0;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}
</style>
