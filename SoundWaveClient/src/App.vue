<template>
    <div>       
        <Header :logStatus="logStatus"/>
        <div>
            <TopCharts></TopCharts>
            <MainBody :searchQuery="searchQuery" :idContent="idContent"></MainBody>
        </div>
        <Footer>
        </Footer>
    </div>
</template>

<script>


export default{
    data(){
        return{
            logStatus:true,
            searchQuery:'',
            idContent:0
        }
    
    },
    methods:{

    }
}

</script>

<style>
</style>