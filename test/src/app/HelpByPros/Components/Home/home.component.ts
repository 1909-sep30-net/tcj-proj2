import { Component, OnInit } from '@angular/core';
import CategoryItems from 'src/app/HelpByPros/Models/category-items'
import { HelpByProsAPISerivce } from 'src/app/HelpByPros/HelpByPros-api.service';

@Component({
    selector: 'app-home',
    templateUrl: './home.component.html',
    styleUrls: ['./home.component.css']
  })

  export class HomeComponent implements OnInit {
    items: CategoryItems[] = null;
  
    // this is like a C# getter-only property

  
    getCategoryList(): void {
  
     this.helpbypros.getCategoryList().then(items => this.items= items);
      
    }
  
    // if ctor param has access modifier,
    // TS will put that value into a same-name property of the class
    constructor(private helpbypros: HelpByProsAPISerivce) {
      this.getCategoryList();
      console.log(this.items);
    }
  
    ngOnInit() {
    }
}