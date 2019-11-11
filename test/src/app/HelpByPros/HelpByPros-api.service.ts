import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import CategoryItems from './Models/category-items';
import QuestionItems from './Models/question-items';
import User from './Models/UserCreate';
import UserProfessional from './Models/Professional';





@Injectable({
  providedIn: 'root'
})
export class HelpByProsAPISerivce {

  constructor(private httpClient: HttpClient) { }

  getCategoryList(): Promise<CategoryItems[]>  {
    const url = `${environment.HelpBYProsApiBaseUrl}/forum/category`;
    return this.httpClient.get<CategoryItems[]>(url).toPromise();
  }

  getACategoryQuestioList(x:string): Promise<QuestionItems[]>{
    const url = `${environment.HelpBYProsApiBaseUrl}/home/category/`+x;
    return this.httpClient.get<QuestionItems[]>(url).toPromise();

  }

  register(User:string):void {
    const url = `${environment.HelpBYProsApiBaseUrl}/user/CreateUser`;
   // this.httpClient.post<User>(url);

  }

  
}