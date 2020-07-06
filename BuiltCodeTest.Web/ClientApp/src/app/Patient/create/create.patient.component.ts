import { Component, OnInit } from "@angular/core"
import { Patient } from "../../model/patient";
import { ActivatedRoute, Router } from "@angular/router";
import { PatientService } from "../../../services/patient/patient.service";

@Component({
  selector: "create-patient",
  templateUrl: './create.patient.component.html',
  styleUrls: ['./create.patient.component.css']

})

export class CreatePatientComponent implements OnInit {
  public patient: Patient;
  public enable_spinner: boolean;
  public message: string;
  public wasSave: boolean;

  public returnUrl: string;


  constructor(private router: Router, private activatedRouter: ActivatedRoute,
    private patientService: PatientService) {
  }


  ngOnInit(): void {
    this.returnUrl = this.activatedRouter.snapshot.queryParams['returnUrl'];
    this.patient = new Patient();
  }

  public save() {
    this.enable_spinner = true;
    this.patientService.save(this.patient).subscribe(
      data => {
 
        this.enable_spinner = false;
        this.wasSave = true;
        this.message = "";
        this.router.navigate(['/patient']);
      },
      err => {
        this.enable_spinner = false;
        this.wasSave = false;
        this.message = err.error;
      }
    )
  };
}
  //virtual ICollection<Patient> Patients

