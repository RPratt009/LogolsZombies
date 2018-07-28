import { Component } from '@angular/core';//keeep this one
import { GradeReport } from './entities/GradeReport'
import { GradeReportService } from './services/GradeReportService'
@Component({
  selector: 'addStatus',
  templateUrl: 'addStudent.component.html',
  styleUrls: ['addStudent.component.css']
})
export class AddStudentComponent { //we changed our class name
 
//to add new student  to the list we need below codes:
public gradeReport:GradeReport;

public constructor(private gradeReportService: GradeReportService) {
  this.gradeReport = new GradeReport();
}

public insertClick():void {
  this.gradeReportService.insert(this.gradeReport).subscribe(() => {
    console.log("student inserted");
  }, error => console.error(error));
}
}


