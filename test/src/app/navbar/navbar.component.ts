import { Component, OnInit } from '@angular/core';
import { AuthService } from '../auth.service';
import UserCreate from '../HelpByPros/Models/user'
import { HelpByProsAPISerivce } from '../HelpByPros/HelpByPros-api.service';


@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})

export class NavbarComponent implements OnInit {
  public items: UserCreate = null;

  constructor(   public auth: AuthService,  public HelpByProsApi: HelpByProsAPISerivce ) 
  { 

  }

  ngOnInit() 
  {
    

  }

  get user()
  {
    return this.HelpByProsApi.userC;
  }


}