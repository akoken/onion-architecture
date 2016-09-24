import { Component, OnInit } from '@angular/core';

import { StoreService } from '../shared/store.service';

@Component({
    moduleId: module.id,
    templateUrl: 'home.component.html'
})
export class HomeComponent implements OnInit {
    categories: Object[];

    constructor(private storeService: StoreService) { }

    ngOnInit() {
        this.storeService.getCategories()
            .subscribe(categories => this.categories = categories);
    }
}