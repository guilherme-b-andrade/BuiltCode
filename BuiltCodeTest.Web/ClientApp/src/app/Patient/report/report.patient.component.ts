import { Component, OnInit } from "@angular/core"
import { Patient } from "../../model/patient";
import { ActivatedRoute, Router } from "@angular/router";
import { PatientService } from "../../../services/patient/patient.service";
import { DoctorService } from "../../../services/doctor/doctor.service";
import { Doctor } from "../../model/doctor";

@Component({
  selector: "report-patient",
  templateUrl: './report.patient.component.html',
  styleUrls: ['./report.patient.component.css']

})

export class ReportPatientComponent implements OnInit {
  public patients: Patient[];
  public doctors: Doctor[];
  public patient: Patient;
  public returnUrl: string;
  public message: string;



  ngOnInit(): void {
  
    this.returnUrl = this.activatedRouter.snapshot.queryParams['returnUrl'];
    this.patient = new Patient();
    this.patients = [];
  }

  constructor(private router: Router, private activatedRouter: ActivatedRoute,
    private patientService: PatientService, private doctorService: DoctorService) {


   
     

    this.doctorService.getAll()
      .subscribe(
        data => {
          this.doctors = data;
        },
        err => {
          this.message = err.error;
        }

      )
  }



  public filterByDoctorId(): void {

    console.log(this.patient.doctorId);

    this.patientService.filterByDoctorId(this.patient.doctorId).subscribe(
      data => {
        this.patients = data;
      },
      err => {
        this.message = err.error;
        this.patients =[];
      }

    )

  }
}
  //virtual ICollection<Patient> Patients

