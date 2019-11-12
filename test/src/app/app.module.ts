import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavbarComponent } from './navbar/navbar.component';
import { ProfileComponent } from './profile/profile.component';
import { RegisterComponent } from  '../app/HelpByPros/Components/register/register.component'
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {CategoryComponent} from './HelpByPros/Components/Category/category.component'
import {MatSidenavModule} from '@angular/material/sidenav'; 
import {MatToolbarModule} from '@angular/material'; 
import {MatCheckboxModule} from '@angular/material'; 
import {MatFormFieldModule} from '@angular/material'; 
import { MatSliderModule } from '@angular/material/slider';
import { MatOptionModule } from '@angular/material';
import { LayoutModule } from '@angular/cdk/layout';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { MatListModule } from '@angular/material/list';
import { HomeComponent } from './home/home.component';
import { QuestionsComponent } from './HelpByPros/Components/Category/questions/questions.component';
import { StatedataService } from './statedata.service';
import { PostquestionComponent } from './HelpByPros/Components/postquestion/postquestion.component';



@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    ProfileComponent,
    RegisterComponent,
    CategoryComponent,
    HomeComponent,
    QuestionsComponent,
    PostquestionComponent,
  ],
  imports: [
    BrowserModule,
    FormsModule,
    RouterModule.forRoot([   
      { path: '', component: HomeComponent },
      { path: 'profile', component: ProfileComponent },
      { path: 'categories', component: CategoryComponent },
      { path: 'categories/questions', component: QuestionsComponent},
      { path: 'categories/questions/postquestion', component: PostquestionComponent}    
    ]),
    AppRoutingModule,
    HttpClientModule,
    ReactiveFormsModule,
    BrowserAnimationsModule,
    MatSidenavModule,
    MatToolbarModule,
    MatCheckboxModule,
    MatFormFieldModule,
    MatSliderModule,
    MatOptionModule,
    LayoutModule,
    MatButtonModule,
    MatIconModule,
    MatListModule,
    FormsModule,
  ],

  //subscribe to different services
  providers: [CategoryComponent, StatedataService],

  bootstrap: [AppComponent]
})
export class AppModule { }
