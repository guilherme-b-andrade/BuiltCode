import { Injectable, Inject, OnInit } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { getBaseUrl } from "../../main";
import { Patient } from "../../app/model/Patient";


@Injectable({

  providedIn: "root"

})
export class PatientService {

  private baseUrl: string
  public patient: Patient[];
  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {

    this.baseUrl = baseUrl;


  }

  ngOnInit(): void {
    this.patient = [];
  }

  get headers(): HttpHeaders {
    return new HttpHeaders().set('content-type', 'application/json');
  }

  //public getAll(): Observable<patient> {

  //  this.http.get()
  //}

  public save(patient: Patient): Observable<Patient> {


    return this.http.post<Patient>(this.baseUrl + "api/patient", JSON.stringify(patient), { headers: this.headers });
  }

  public getAll(): Observable<Patient[]> {

    return this.http.get<Patient[]>(this.baseUrl + "api/patient");
  }

  public get(patientId: number): Observable<Patient> {

    return this.http.get<Patient>(this.baseUrl + "api/patient/patientId");
  }

  public delete(patient: Patient): Observable<Patient[]> {

    return this.http.post<Patient[]>(this.baseUrl + "api/patient/delete", JSON.stringify(patient), { headers: this.headers });
  }

  public put(patient: Patient): Observable<Patient> {

    return this.http.put<Patient>(this.baseUrl + "api/patient", JSON.stringify(patient), { headers: this.headers });
  }

  public filterByDoctorId(doctorId: number): Observable<Patient[]> {

    return this.http.get<Patient[]>(this.baseUrl + "api/patient/FilterByDoctorId/" + doctorId);
  }
}
