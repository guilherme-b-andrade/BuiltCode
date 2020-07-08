import { Component, OnInit } from "@angular/core"
import { Doctor } from "../../model/doctor";
import { ActivatedRoute, Router } from "@angular/router";
import { DoctorService } from "../../../services/doctor/doctor.service";

@Component({
  selector: "edit-doctor",
  templateUrl: './edit.doctor.component.html',
  styleUrls: ['./edit.doctor.component.css']

})

export class EditDoctorComponent implements OnInit {
  public doctor;
  public enable_spinner: boolean;
  public message: string;
  public wasSave: boolean;
  public returnUrl: string;


  constructor(private router: Router, private activatedRouter: ActivatedRoute,
    private doctorService: DoctorService) {
  }


  ngOnInit(): void {
    var doctorSession = sessionStorage.getItem('doctorSession');
    if (doctorSession) {
      this.doctor = JSON.parse(doctorSession);
    }
    else {
      this.doctor = new Doctor();
    }
  }

  save() {

    this.doctorService.save(this.doctor).
      subscribe(
        data => {
          this.enable_spinner = false;
          this.wasSave = true;
          this.message = "";
          this.router.navigate(['/doctor']);

        },
        err => {
          this.enable_spinner = false;
          this.wasSave = false;
          this.message = err.error
        });
  }

}

