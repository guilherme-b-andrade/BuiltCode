import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { DoctorComponent } from './doctor/doctor.component';
import { Doctor } from './model/doctor';
import { DoctorService } from '../services/doctor/doctor.service';
import { PatientService } from '../services/patient/patient.service';
import { CreateDoctorComponent } from './doctor/create/create.doctor.component';
import { EditDoctorComponent } from './doctor/edit/edit.doctor.component';
import { CreatePatientComponent } from './patient/create/create.patient.component';
import { EditPatientComponent } from './patient/edit/edit.patient.component';
import { PatientComponent } from './Patient/patient.component';
import { ReportPatientComponent } from './Patient/report/report.patient.component';


@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    DoctorComponent,
    PatientComponent,
    CreateDoctorComponent,
    EditDoctorComponent,
    CreatePatientComponent,
    EditPatientComponent,
    ReportPatientComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'doctor', component: DoctorComponent },
      { path: 'create-doctor', component: CreateDoctorComponent },
      { path: 'edit-doctor', component: EditDoctorComponent },
      { path: 'patient', component: PatientComponent },
        { path: 'create-patient', component: CreatePatientComponent },
      { path: 'edit-patient', component: EditPatientComponent },
      { path: 'report-patient', component: ReportPatientComponent }

    ])
  ],
  providers: [DoctorService, PatientService],
  bootstrap: [AppComponent]
})
export class AppModule { }
