<script>
   import Router from './router/Router.svelte';
   import Route from './router/Route.svelte';
   import Link from './router/Link.svelte';

   import Home from './routes/home/Home.svelte';
   import AddSource from './routes/add-source/AddSource.svelte';
</script>

<Router>
    <nav class="navbar navbar-expand-lg navbar-light" style="background-color: #e3f2fd;">
        <div class="collapse navbar-collapse" id="navbarColor03">
            <ul class="navbar-nav mr-auto">
                <li class="nav-item"><Link to="/">Home</Link></li>
                <li class="nav-item"><Link to="/new-source">Add News Source</Link></li>
            </ul>
        </div>
    </nav>
   
    <Route path="/"><Home /></Route>
    <Route path="/new-source"><AddSource /></Route>
</Router>
