namespace BugTracker.Controllers {

    export class HomeController {
        public bugList;
        constructor(private $http: ng.IHttpService, private $state: ng.ui.IStateService) {
            $http.get("/api/bugs")
                .then((response) => {
                    this.bugList = response.data;
                })
        }

        resolve() {
            this.bugList[0].IsResolved == true;
            this.$state.go('resolved');

        }
    }

    export class CreateController {
        public createdItem;
        public title;
        public description;
        public severity;
        
        constructor(private $http: ng.IHttpService) {
            
        }

        submit() {
            console.log('im posting!');
            this.$http.post("/api/bugs", {
                title: this.title,
                description: this.description,
                severity: this.severity

            })
        }
    }


    export class SecretController {
        public secrets;

        constructor($http: ng.IHttpService) {
            $http.get('/api/secrets').then((results) => {
                this.secrets = results.data;
            });
        }
    }


    export class AboutController {
        public message = 'Hello from the about page!';
    }

}
