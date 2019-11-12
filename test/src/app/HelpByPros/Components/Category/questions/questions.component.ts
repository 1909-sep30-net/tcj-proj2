import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { StatedataService } from 'src/app/statedata.service';
import { HelpByProsAPISerivce } from 'src/app/HelpByPros/HelpByPros-api.service';

//import { category } from './HelpByPros/Components/category';

@Component({
  selector: 'app-questions',
  templateUrl: './questions.component.html',
  styleUrls: ['./questions.component.css']
})
export class QuestionsComponent implements OnInit 
{

  //Get the list of questions

  //id the category of question
  category;
  questionList;

  constructor( private route: ActivatedRoute , private helpbypros: HelpByProsAPISerivce , private sdService: StatedataService) 
  { 

  }

    getACategoryQuestionList(x: string): void 
    {
  
        this.helpbypros.getACategoryQuestioList(x).then(questionList => this.questionList= questionList);
    
    }

  ngOnInit() 
  {
    //set the question-list type.
    this.category = this.sdService.getqListType();

    //get the list
    this.getACategoryQuestionList(this.category);
  }

}
