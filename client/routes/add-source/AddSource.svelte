
 <script>
    import { createForm } from "svelte-forms-lib";
    import { AddSourceService } from '../shared/add-source-service';

    const addSourceService = new AddSourceService();

    const { form, handleChange, handleSubmit } = createForm({
      initialValues: {
        name: "",
        url: ""
      },
      onSubmit: values => {
        addSourceService.saveSource(values.name, values.url);
      }
    });
</script>

<form on:submit={handleSubmit}>
    <div class="form-group">
        <label for="name">Name</label>
        <input
            id="name"
            name="name"
            class="form-control"
            on:change={handleChange}
            bind:value={$form.name}
        />
    </div>
    <div class="form-group">
        <label for="email">Rss Url</label>
        <input
            id="url"
            name="url"
            class="form-control"
            on:change={handleChange}
            bind:value={$form.url}
        />
    </div>
    <button type="submit" class="btn btn-primary">Submit</button>
</form>
