export class Story {
    constructor(response) {
        this.title = response['title'];
        this.intro = response['intro'];
        this.url = response['url'];
    }
}