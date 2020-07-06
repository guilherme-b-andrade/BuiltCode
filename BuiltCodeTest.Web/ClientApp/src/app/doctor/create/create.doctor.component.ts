import { Component, OnInit } from "@angular/core"
import { Doctor } from "../../model/doctor";
import { ActivatedRoute, Router } from "@angular/router";
import { DoctorService } from "../../../services/doctor/doctor.service";

@Component({
  selector: "create-doctor",
  templateUrl: './create.doctor.component.html',
  styleUrls: ['./create.doctor.component.css']

})

export class CreateDoctorComponent implements OnInit {
  public doctor: Doctor;
  public enable_spinner: boolean;
  public message: string;
  public wasSave: boolean;

  public returnUrl: string;


  constructor(private router: Router, private activatedRouter: ActivatedRoute,
    private doctorService: DoctorService) {
  }


  ngOnInit(): void {
    this.returnUrl = this.activatedRouter.snapshot.queryParams['returnUrl'];
    this.doctor = new Doctor();
  }

  public save() {
    this.enable_spinner = true;
    this.doctorService.save(this.doctor).subscribe(
      data => {
 
        this.enable_spinner = false;
        this.wasSave = true;
        this.message = "";
        this.router.navigate(['/doctor']);
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

