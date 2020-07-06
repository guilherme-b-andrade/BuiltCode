import { Component, OnInit } from "@angular/core"
import { Doctor } from "../model/doctor";
import { ActivatedRoute, Router } from "@angular/router";
import { DoctorService } from "../../services/doctor/doctor.service";

@Component({
  selector: "doctor",
  templateUrl: './doctor.component.html',
  styleUrls: ['./doctor.component.css']

})

export class DoctorComponent implements OnInit {
  public doctors: Doctor[];
  public returnUrl: string;


  ngOnInit(): void {
   
    this.returnUrl = this.activatedRouter.snapshot.queryParams['returnUrl'];

  }

  constructor(private router: Router, private activatedRouter: ActivatedRoute,
    private doctorService: DoctorService) {

    this.doctorService.getAll()
      .subscribe(
        data => {
          this.doctors = data
        },
        err => {
          console.log(err.error);
        }

      )
  }

  public createDoctor() {

    return this.router.navigate(['/create-doctor']);
  }

  public delete(doctor: Doctor) {
    var value = confirm("Deseja realmente deletar o médico selecionado?");
    if (value == true ) {

      this.doctorService.delete(doctor)
        .subscribe(
          data => {
            this.doctors = data;
          },
          err => {

            console.log(err.errors);
            
          })

    }
  }
  public edit(doctor: Doctor) {

    sessionStorage.setItem('doctorSession', JSON.stringify(doctor));
    this.router.navigate(['/edit-doctor']);
    
  }

  

}
  //virtual ICollection<Patient> Patients

