import { Component } from "@angular/core"

@Component({
  selector: "doctor",
  templateUrl: './doctor.component.html',
  styleUrls: ['./doctor.component.css']

}) 

export class DoctorComponent {
  public id: number;
  public name: string;
  public crm: number;
  public crmUf: string;

  public obterNome(): string {
    return "Teste2";
  }
  //virtual ICollection<Patient> Patients
}
