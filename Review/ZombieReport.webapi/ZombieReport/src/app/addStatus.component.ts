import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { PersonStatus } from './entities/PersonStatus'
import { PersonStatusService } from './services/PersonStatusService'

@Component({
  selector: 'addStatus',
  templateUrl: './addStatus.component.html',
  styleUrls: ['./addStatus.component.css']
})
export class AddStatusComponent {
  public title = 'addStatus';
  public personStatus:PersonStatus;

  public constructor(private personStatusService: PersonStatusService, private router: Router) {
    this.personStatus = new PersonStatus();
  }

  public insertClick():void {
    this.personStatusService.insert(this.personStatus).subscribe(() => {
      console.log("person inserted");
      this.router.navigate(['report']);
    }, error => console.error(error));
  }
}
