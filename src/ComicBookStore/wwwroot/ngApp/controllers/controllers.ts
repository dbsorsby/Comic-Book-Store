namespace ComicBookStore.Controllers {

    export class HomeController {

        public comics;// = [{

        //    imageUrl: 'https://d1466nnw0ex81e.cloudfront.net/n_iv/600/607357.jpg',
        //    title: 'Batman',
        //    price: 2.99


        //}, {

        //        imageUrl: 'https://d1466nnw0ex81e.cloudfront.net/n_iv/600/898547.jpg',
        //        title: 'Wolverine',
        //        price: 5.99


        //    }, {

        //        imageUrl: 'http://i.newsarama.com/images/i/000/114/819/original/Essential_Thor_Vol_1_6.jpg?1381260572',
        //        title: 'Thor',
        //        price: 1.99


        //    }, {

        //        imageUrl: 'http://www.newkadia.com/Covers/L/I/Iron%20Man%20Legacy/ironmanlegacy1.jpg',
        //        title: 'Iron Man',
        //        price: '1.99'


        //    }, {

        //        imageUrl: 'http://assets.nydailynews.com/polopoly_fs/1.45607.1313760142!/img/httpImage/image.jpg_gen/derivatives/gallery_1200/gal-comics-amazing-fantasy-15-jpg.jpg',
        //        title: 'Spiderman',
        //        price: 1000000.00


        //    }];

        public start: number = 0;

        constructor(private $http: ng.IHttpService) {
            this.$http.get('/api/comics/featured')
                .then((response) => {
                    this.comics = response.data
                })
                .catch((response) => {
                    alert('There was an error!')
                });

        }

        public moveLeft() {
            if (this.start > 0) {
                this.start--;
            }
        }

        public moveRight() {
            if (this.start < this.comics.length - 4) {
            this.start++
            }
        }
    }


}