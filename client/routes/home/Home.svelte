<script>
   import { NewsService } from './news-service';
   import { AddSourceService } from '../shared/add-source-service';
   import { onMount } from 'svelte';
 
   const newsService = new NewsService();
   const newsSourceService = new AddSourceService();
 
   let stories = [];
   let selected;
   const newsSources = newsSourceService.getSources(); 

   onMount(async () => {
       if(newsSources.length > 0) { 
           stories = await newsService.getNewsStories(newsSources[0].url);
       }
   });
</script>

<div>
    <div class="btn-group" style="margin-top:10px;margin-bottom:10px;">
        <select bind:value={selected} on:change="{async () => stories = await newsService.getNewsStories(selected)}">
            {#each newsSources as source}
                <option value={source.url}>{source.name}</option>
            {/each}
        </select>
    </div>
	{#each stories as story}
		<div class="card" style="width: 100%;margin-bottom:10px;">
          <div class="card-body">
            <h5 class="card-title">{story.title}</h5>
            <p class="card-text">{story.intro}</p>
            <a target="_blank" href="{story.url}">Read article</a>
         </div>
        </div>
	{/each}
</div>