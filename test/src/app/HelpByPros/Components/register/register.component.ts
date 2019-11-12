import { Component, OnInit } from '@angular/core';
import CreateUser from 'src/app/HelpByPros/Models/user-create'

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  user: CreateUser = null;

  getCategoryList(): void {
  
   // this.helpbypros.getCategoryList().then(items => this.items= items);
   }
  constructor() { }

  ngOnInit() {
  }

}
