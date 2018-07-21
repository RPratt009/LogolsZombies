import { Component } from '@angular/core';
import { PersonStatus } from './entities/PersonStatus'
import { PersonStatusService } from './services/PersonStatusService'

@Component({
  selector: 'zombieReport',
  templateUrl: './zombieReport.component.html',
  styleUrls: ['./zombieReport.component.css']
})
export class ZombieReportComponent {
  public title = 'zombieReport';
  public statuses:PersonStatus[] = [];

  public constructor(personStatusService: PersonStatusService) {
    personStatusService.getAll().subscribe(result => {
      for (let status of result) {
        this.statuses.push(status);
      }
    });
 
  }
}
