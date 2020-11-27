export class AddSourceService {

    constructor() {
        this.key = 'news-sources';        
    }

    saveSource(name, url) {
        let sources = this.getSources();
        sources.push({ name, url });
        localStorage.setItem(this.key, JSON.stringify(sources));
    }

    getSources() {
        if (!localStorage.getItem(this.key)) {
            return [];
        }
        let sources = JSON.parse(localStorage.getItem(this.key));
        sources.sort((a, b) => (a.name > b.name) ? 1 : -1);
        return sources;
    }
}