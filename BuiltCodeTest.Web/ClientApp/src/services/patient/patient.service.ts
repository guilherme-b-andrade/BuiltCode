import { Injectable, Inject } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { getBaseUrl } from "../../main";
import { Patient } from "../../app/model/Patient";


@Injectable({

  providedIn: "root"

})
export class PatientService {

  private baseUrl: string
  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {

    this.baseUrl = baseUrl;


  }


  public save(patient: Patient): Observable<Patient> {

  const headers = new HttpHeaders().set('content-type', 'application/json');
  var body = {
    name: patient.name,
    bithDate: patient.birthDate,
    cpf: patient.cpf,
    doctorId: patient.doctorId
  }

  return this.http.post<Patient>(this.baseUrl + "api/patient", body, { headers });
}

  public getAll(): Observable < Patient > {

  const headers = new HttpHeaders().set('content-type', 'application/json');


  return this.http.get<Patient>(this.baseUrl + "api/patient", { headers });
}

  public delete (): Observable < Patient > {

  const headers = new HttpHeaders().set('content-type', 'application/json');


  return this.http.get<Patient>(this.baseUrl + "api/patient", { headers });
}

}
