import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { GradeReportComponent } from './gradeReport.component';//we add this line
import { AddStudentComponent } from './addStudent.component';//we add this line 

import { GradeReportService } from './services/GradeReportService';//we add this line

const appRoutes: Routes = [
  { path: 'addStudent', component: AddStudentComponent },
  { path: 'report', component: GradeReportComponent },
  { path: '', component: GradeReportComponent  }  
];

/*const appRoutes:Routes = [
  {path: 'log' ,component:} 
]*/

@NgModule({
  declarations: [
    AppComponent,
    GradeReportComponent,//we add this one
    AddStudentComponent//we add this one
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    RouterModule.forRoot(
      appRoutes,
        {enableTracing: true })//we add this one
  ],
  providers: [
    GradeReportService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
