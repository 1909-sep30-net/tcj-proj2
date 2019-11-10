import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import CategoryItems from './Models/category-items';


@Injectable({
  providedIn: 'root'
})
export class HelpByProsAPISerivce {

  constructor(private httpClient: HttpClient) { }

  getCategoryList(): Promise<CategoryItems[]>  {
    const url = `${environment.HelpBYProsApiBaseUrl}/forum/category`;
    return this.httpClient.get<CategoryItems[]>(url).toPromise();



  }
}