import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import CategoryItems from 'src/app/HelpByPros/Models/category-items'
import QuestionItems from 'src/app/HelpByPros/Models/question-items'

import { HelpByProsAPISerivce } from 'src/app/HelpByPros/HelpByPros-api.service';
import {FormBuilder, FormGroup} from '@angular/forms';

@Component({
    selector: 'app-category',
    templateUrl: './category.component.html',
    styleUrls: ['./category.component.css'],
  })

  export class CategoryComponent implements OnInit {
    items: CategoryItems[] = null;
    questionItem: QuestionItems[]=null;
    category:string;
    options: FormGroup;


    // this is like a C# getter-only property

  
    getCategoryList(): void {
  
     this.helpbypros.getCategoryList().then(items => this.items= items);
    }

    getACategoryQuestionList(x: string): void {
  
      this.helpbypros.getACategoryQuestioList(x).then(questionItem => this.questionItem= questionItem);
     }
    // if ctor param has access modifier,
    // TS will put that value into a same-name property of the class
    constructor(private helpbypros: HelpByProsAPISerivce,fb: FormBuilder) {
     this.getCategoryList();



    if( this.category!= null){
      this.getACategoryQuestionList(this.category);
    }
  }
  
  
    ngOnInit() {


    }

    
}



