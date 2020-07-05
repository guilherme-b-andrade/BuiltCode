import { Component } from "@angular/core"
import { Doctor } from "../model/doctor";

@Component({
  selector: "doctor",
  templateUrl: './doctor.component.html',
  styleUrls: ['./doctor.component.css']

})

export class DoctorComponent {
  public doctor;


  constructor() {
    this.doctor = new Doctor();
  }
}
  //virtual ICollection<Patient> Patients

