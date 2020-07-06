import { Component, OnInit } from "@angular/core"
import { Patient } from "../model/patient";
import { ActivatedRoute, Router } from "@angular/router";
import { PatientService } from "../../services/patient/patient.service";
import { DoctorService } from "../../services/doctor/doctor.service";
import { Doctor } from "../model/doctor";

@Component({
  selector: "patient",
  templateUrl: './patient.component.html',
  styleUrls: ['./patient.component.css']

})

export class PatientComponent implements OnInit {
  public patients: Patient[];
  public doctors: Doctor[];
  public returnUrl: string;


  ngOnInit(): void {
   
    this.returnUrl = this.activatedRouter.snapshot.queryParams['returnUrl'];

  }

  constructor(private router: Router, private activatedRouter: ActivatedRoute,
    private patientService: PatientService, private doctorService: DoctorService) {



    this.patientService.getAll()
      .subscribe(
        data => {
          this.patients = data
        },
        err => {
          console.log(err.error);
        }

      )
  }

  public createPatient() {
  
    this.doctorService.getAll()
      .subscribe(
        data => {
          this.doctors = data;
        },
        err => {
          console.log(err.error);
        }

      )
    return this.router.navigate(['/create-patient']);
  }

  public delete(patient: Patient) {
    var value = confirm("Deseja realmente deletar o médico selecionado?");
    if (value == true ) {

      this.patientService.delete(patient)
        .subscribe(
          data => {
            this.patients = data;
          },
          err => {

            console.log(err.errors);
            
          })

    }
  }
  public edit(patient: Patient) {

    sessionStorage.setItem('patientSession', JSON.stringify(patient));
    this.router.navigate(['/edit-patient']);
    
  }

  

}
  //virtual ICollection<Patient> Patients

