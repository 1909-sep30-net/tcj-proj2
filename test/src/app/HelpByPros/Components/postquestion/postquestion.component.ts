import { Component, OnInit } from '@angular/core';
import QuestionItems from 'src/app/HelpByPros/Models/question-items'
import { HelpByProsAPISerivce } from '../../HelpByPros-api.service';
import CategoryItems from '../../Models/category-items';
import { AuthService } from 'src/app/auth.service';
import { CategoryComponent } from '../Category/category.component';

import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-postquestion',
  templateUrl: './postquestion.component.html',
  styleUrls: ['./postquestion.component.css']
})
export class PostquestionComponent implements OnInit 
  {
    
    items: CategoryItems[] = null;
    model: QuestionItems;
    submitted: boolean;


    getCategoryList(): void 
    {
  
      this.helpbypros.getCategoryList().then(items => this.items= items);

    }

   AddQuection(QuestionItems:QuestionItems)
   {
     this.helpbypros.createQuestion(QuestionItems);
   }
 
    onSubmit() { this.submitted = true; this.AddQuection(this.model); }

  constructor(  private route: ActivatedRoute , public helpbypros: HelpByProsAPISerivce,public auth: AuthService) 
  { 

  
    this.getCategoryList();
    
    if( this.items!=null)
    {
      this.model = new QuestionItems(this.items[0].name,"Type Your Question", "Additional Informatino", "member2",0);
      console.log(this.items[0].name);
    }
    
    else
    {
      this.model = new QuestionItems("ComputerScience","Do androids dream of electric sheep?", "Or do they lay silent as they sleep?", "fds",0);
    }

    this.submitted=false;

  }

  ngOnInit() 
  {
      if( this.items!=null)
      {
        this.model = new QuestionItems(this.items[0].name,"Type Your Question", "Additional Informatino", "member2",0);
      }

  }

}
