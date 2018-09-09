import Vue from "vue";
import { Component } from "vue-property-decorator";

@Component
export default class AppComponent extends Vue {
    current: any = ['Home'];
    $http: any;

    dataSource: any = [];
    inputPhrase: string = "";
    inputFocused: boolean = false;

    GetApplications() {
        this.$http.get('/api/SampleData/SearchResults', {
        }).then((response: any) => {
            this.dataSource = response.data.Results;
            console.log(response.data);
        }).catch((error: any) => {
            alert(error);
        });
    };

    onBlurInputbox() {
        this.inputFocused = false;
    }

    onFocusInputbox() {
        this.inputFocused = true;
    }

    mounted() {
        this.GetApplications();
    }
}
