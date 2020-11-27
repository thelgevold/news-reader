import { Story } from './story';

export class NewsService {
    async getNewsStories(url) {
        const response = await fetch(`/api/news?url=${encodeURIComponent(url)}`);
        return (await response.json()).map(r => new Story(r));
    }
}