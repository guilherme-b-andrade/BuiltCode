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
}
  //virtual ICollection<Patient> Patients

