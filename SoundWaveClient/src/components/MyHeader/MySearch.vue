<template>
    <div>
        <nav class="my-serach navbar bg-body-tertiary">
         <div class="container-fluid">
         <a class="navbar-brand">&#128270</a>
    <form class="d-flex" role="search">
      <input class="form-control me-2" type="search" placeholder="Search" aria-label="Search">
      <button class="btn btn-outline-success" type="submit">Search</button>
    </form>
  </div>
</nav>
    </div>
</template>

<script>
export default{
    name:'my-search',
    data(){

    },
    methods:{

    }
}

</script>

<style>
    .my-serach{
        border-radius: 10px;
    }
    .btn:hover{
        background-color: blueviolet;
    }
</style>