import { Injectable, Inject } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { getBaseUrl } from "../../main";
import { Doctor } from "../../app/model/doctor";


@Injectable({

  providedIn: "root"

})
export class DoctorService {

  private baseUrl: string
  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {

    this.baseUrl = baseUrl;


  }

  //public getAll(): Observable<Doctor> {

  //  this.http.get()
  //}

  public save(doctor: Doctor): Observable<Doctor> {

    const headers = new HttpHeaders().set('content-type', 'application/json');
    var body = {
      name: doctor.name,
      crm: doctor.crm,
      crmUf: doctor.crmUf,
    }

    return this.http.post<Doctor>(this.baseUrl + "api/doctor", body, { headers });
  }

  public getAll(): Observable<Doctor> {

    const headers = new HttpHeaders().set('content-type', 'application/json');
   

    return this.http.get<Doctor>(this.baseUrl + "api/doctor", { headers });
  }
  public delete(): Observable<Doctor> {

    const headers = new HttpHeaders().set('content-type', 'application/json');


    return this.http.get<Doctor>(this.baseUrl + "api/patient", { headers });
  }

}
