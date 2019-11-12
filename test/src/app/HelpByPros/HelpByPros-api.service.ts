import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import CategoryItems from './Models/category-items';
import QuestionItems from './Models/question-items';
import UserCreate from './Models/user-create';
import User from './Models/user';
import { AuthService } from '../auth.service';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';






@Injectable({
  providedIn: 'root'
})
export class HelpByProsAPISerivce {
  userC:User =null;
  CreateQuestion: QuestionItems;
  constructor(
    private httpClient: HttpClient,   
    auth: AuthService
  ) { 
    console.log("getting")

    auth.userProfile$.subscribe(user => { 
      if (user) {
        this.getUser(user.nickname).catch((err: HttpErrorResponse) => {
         console.log("getting email")
         console.log(err.status)
          if (err.status === 404 || err.status ==0 || err.status==500) {
            // if user does not exist, create
            console.log("erro 404")
            //return this.createUser({email: user.nickname});
            
          } else {
            throw err;
          }
        }).then(apiUser => {
          //this.userC= apiUser;
        });
      }
    });

  }

  //Get a list of categories
  getCategoryList(): Promise<CategoryItems[]>  
  {
  
    const url = `${environment.HelpBYProsApiBaseUrl}/forum/category`;
    return this.httpClient.get<CategoryItems[]>(url).toPromise();
  
  }


  

  getACategoryQuestioList(category:string): Promise<QuestionItems[]>{
    const url = `${environment.HelpBYProsApiBaseUrl}/home/category/${category}`;

    return this.httpClient.get<QuestionItems[]>(url).toPromise();

  }
  getUser(username: string): Promise<User> {
    const url = `${environment.HelpBYProsApiBaseUrl}/user/${username}`;
    return this.httpClient.get<User>(url).toPromise();
  }

  createUser(user: UserCreate): Promise<User> {
    const url = `${environment.HelpBYProsApiBaseUrl}/user/CreateUser`;
    return this.httpClient.post<User>(url, user).toPromise();
  }

  createQuestion(q:QuestionItems): Promise<QuestionItems> {
    const url = `${environment.HelpBYProsApiBaseUrl}/forum/AddQuestion`;
    return this.httpClient.post<QuestionItems>(url, q).toPromise();
  }

  
}