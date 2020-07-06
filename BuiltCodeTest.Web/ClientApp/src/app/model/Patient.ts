import { Doctor } from "./doctor";

export class Patient {
  public id: number;
  public name: string;
  public birthDate: Date;
  public cpf: string;
  public doctorId: number;
  public doctor: Doctor;

  }
