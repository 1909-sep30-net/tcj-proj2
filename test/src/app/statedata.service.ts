//Stores state-related data as a service.

import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class StatedataService 
{

  ////////////////
  //What question list are we looking at?
  qList;


  constructor() 
  { 
      this.qList = "";
  }

  //set question-list type
  setqListType(qLType: string)
  {
    this.qList = qLType;
  }

  getqListType()
  {
    return this.qList;
  }

}
