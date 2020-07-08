import { Component, OnInit } from "@angular/core"
import { Patient } from "../../model/patient";
import { ActivatedRoute, Router } from "@angular/router";
import { PatientService } from "../../../services/patient/patient.service";
import { DoctorService } from "../../../services/doctor/doctor.service";
import { Doctor } from "../../model/doctor";

@Component({
  selector: "edit-patient",
  templateUrl: './edit.patient.component.html',
  styleUrls: ['./edit.patient.component.css']

})

export class EditPatientComponent implements OnInit {
  public doctors: Doctor[];
  public patient;
  public enable_spinner: boolean;
  public message: string;
  public wasSave: boolean;
  public returnUrl: string;


  constructor(private router: Router, private activatedRouter: ActivatedRoute,
    private patientService: PatientService) {

  }


  ngOnInit(): void {
    var patientSession = sessionStorage.getItem('patientSession');
    if (patientSession) {
      this.patient = JSON.parse(patientSession);
    }
    else {
      this.patient = new Patient();
    }
  }

  save() {

    this.patientService.save(this.patient).
      subscribe(
        data => {
          this.enable_spinner = false;
          this.wasSave = true;
          this.message = "";
          this.router.navigate(['/patient']);

        },
        err => {
          this.enable_spinner = false;
          this.wasSave = false;
          this.message = err.error
        });
  }
}

