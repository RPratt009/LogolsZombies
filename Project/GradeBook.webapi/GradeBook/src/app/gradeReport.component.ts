import { Component } from '@angular/core';
import { GradeReport } from './entities/GradeReport'
import { GradeReportService } from './services/GradeReportService'

@Component({
  selector: 'gradeReport',
  templateUrl: './gradeReport.component.html',
  styleUrls: ['./gradeReport.component.css']
})
export class GradeReportComponent { //we changed our class name
  public title: string = 'Student Grade Report ';
  public grades: GradeReport[] = [];

  public constructor(gradeReportService: GradeReportService) {
    gradeReportService.getAll().subscribe(result => {
      for (let grade of result) {
        this.grades.push(grade);
      }
    }, error => {
      console.log(error)
    });
  
   } 
}