import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import CategoryItems from './Models/category-items';
import QuestionItems from './Models/question-items';



@Injectable({
  providedIn: 'root'
})
export class HelpByProsAPISerivce {

  constructor(private httpClient: HttpClient) { }

  //Get a list of categories
  getCategoryList(): Promise<CategoryItems[]>  
  {
  
    const url = `${environment.HelpBYProsApiBaseUrl}/forum/category`;
    return this.httpClient.get<CategoryItems[]>(url).toPromise();
  
  }

  
  //For testing only//
  getACategoryQuestioList(x:string): Promise<QuestionItems[]>
  {
  
    const url = `${environment.HelpBYProsApiBaseUrl}/home/category/`+x;
    return this.httpClient.get<QuestionItems[]>(url).toPromise();

  }

  
}