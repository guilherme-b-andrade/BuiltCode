import { Component, OnInit } from "@angular/core"
import { Doctor } from "../model/doctor";
import { ActivatedRoute, Router } from "@angular/router";
import { DoctorService } from "../../services/doctor/doctor.service";

@Component({
  selector: "doctor",
  templateUrl: './doctor.component.html',
  styleUrls: ['./doctor.component.css']

})

export class DoctorComponent implements OnInit  {
  public doctor;
  public returnUrl: string;


  constructor(private router: Router, private activatedRouter: ActivatedRoute,
    private doctorService: DoctorService) {
  }


  ngOnInit(): void {
    this.returnUrl = this.activatedRouter.snapshot.queryParams['returnUrl'];
    this.doctor = new Doctor();
  }

  save() {
    this.doctorService.save(this.doctor).subscribe(
      data => {

      },
      err => {

      }
    )
  };

  getAll() {
    this.doctorService.getAll().subscribe(
      data => {

      },
      err => {

      }
    )
  };
}
  //virtual ICollection<Patient> Patients

