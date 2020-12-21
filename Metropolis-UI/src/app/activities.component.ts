import { ApiService } from './api.service';
import { Component } from '@angular/core';


@Component({
    selector:'activities',
    templateUrl:'./activities.component.html'
})

export class ActivitiesComponent{

    activity: any={}
    activities: any
    
    
    constructor(private api: ApiService){
        this.api.getActivity().subscribe(res => { 
            this.activities = res
        })
    }

    /*ngOnInIt(){
        this.api.getActivity().subscribe(res => { 
            this.activities = res
        })
        
    }*/
    post(activity: any){

        this.api.postActivity(activity);
    }

}