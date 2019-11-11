import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ProfileComponent } from './profile/profile.component';
import { HTTP_INTERCEPTORS } from '@angular/common/http';
import { InterceptorService } from './interceptor.service';
import { RegisterComponent } from './HelpByPros/Components/register/register.component';
import { CategoryComponent } from './HelpByPros/Components/Category/category.component';

const routes: Routes = [
  {path:'category', component:CategoryComponent},
  {path: 'profile',component: ProfileComponent},
  
];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
  providers: [
    {
      provide: HTTP_INTERCEPTORS,
      useClass: InterceptorService,
      multi: true
    }
  ]
})
export class AppRoutingModule { }
