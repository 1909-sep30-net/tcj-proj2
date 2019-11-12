import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import CategoryItems from 'src/app/HelpByPros/Models/category-items'
import QuestionItems from 'src/app/HelpByPros/Models/question-items'

import { HelpByProsAPISerivce } from 'src/app/HelpByPros/HelpByPros-api.service';
import {FormBuilder, FormGroup} from '@angular/forms';
import { StatedataService } from 'src/app/statedata.service';

@Component({
    selector: 'app-category,', 
    templateUrl: './category.component.html',
    styleUrls: ['./category.component.css'],
  })

  export class CategoryComponent implements OnInit 
  {
    
    

    //declare variables
    categories: CategoryItems[] = null;
    questionItem: QuestionItems[] = null;
    categoryStr: string;
    options: FormGroup;


    // this is like a C# getter-only property
    getCategoryList(): void 
    {
  
      this.helpbypros.getCategoryList().then(items => this.categories= items);

    }

    getACategoryQuestionList(x: string): void 
    {
  
        this.helpbypros.getACategoryQuestioList(x).then(questionItem => this.questionItem= questionItem);
    
    }


    // if ctor param has access modifier,
    // TS will put that value into a same-name property of the class
    constructor( private sdService: StatedataService, private helpbypros: HelpByProsAPISerivce, fb: FormBuilder ) 
    {
        

        this.getCategoryList();



        if( this.categoryStr!= null)
        {
          this.getACategoryQuestionList(this.categoryStr);
        }
    }

    //set the current question-list type
    setqCatState(val)
    {
      this.sdService.setqListType(val);
    }
  
  
  ngOnInit() 
  {


  }

    
}



