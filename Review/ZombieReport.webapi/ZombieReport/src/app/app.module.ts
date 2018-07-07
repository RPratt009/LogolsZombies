import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { ZombieReportComponent } from './zombieReport.component';
import { AddStatusComponent } from './addStatus.component';

import { PersonStatusService } from './services/PersonStatusService';

const appRoutes: Routes = [
  { path: 'addStatus', component: AddStatusComponent },
  { path: 'report', component: ZombieReportComponent },
  { path: '', component: ZombieReportComponent }
];

@NgModule({
  declarations: [
    AppComponent
    ,ZombieReportComponent
    ,AddStatusComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot(
      appRoutes,
      { enableTracing: true } // <-- debugging purposes only
    )
  ],
  providers: [
    PersonStatusService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
