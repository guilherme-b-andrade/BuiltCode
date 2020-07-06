import { Injectable, Inject, OnInit } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { getBaseUrl } from "../../main";
import { Doctor } from "../../app/model/doctor";


@Injectable({

  providedIn: "root"

})
export class DoctorService implements OnInit {

  private baseUrl: string;
  public doctor: Doctor[];

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {

    this.baseUrl = baseUrl;

  }
  ngOnInit(): void {
    this.doctor = [];
  }

  get headers(): HttpHeaders {
    return new HttpHeaders().set('content-type', 'application/json');
  }

  //public getAll(): Observable<Doctor> {

  //  this.http.get()
  //}

  public save(doctor: Doctor): Observable<Doctor> {


    return this.http.post<Doctor>(this.baseUrl + "api/doctor", JSON.stringify(doctor), { headers: this.headers });
  }

  public getAll(): Observable<Doctor[]> {

    return this.http.get<Doctor[]>(this.baseUrl + "api/doctor");
  }

  public get(doctorId: number): Observable<Doctor> {

    return this.http.get<Doctor>(this.baseUrl + "api/doctor/doctorId");
  }

  public delete(doctor: Doctor): Observable<Doctor[]> {

    return this.http.post<Doctor[]>(this.baseUrl + "api/doctor/delete", JSON.stringify(doctor), { headers: this.headers });
  }

  public put(doctor: Doctor): Observable<Doctor> {

    return this.http.put<Doctor>(this.baseUrl + "api/doctor", JSON.stringify(doctor), { headers: this.headers });
  }
}
