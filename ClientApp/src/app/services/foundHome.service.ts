import { FoundHome } from './../models/foundHome';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class FoundHomeService {

  baseUrl ='http://localhost:5000/api/foundhome';

  constructor(private http: HttpClient) { }

  getPets(): Observable<FoundHome[]>{
    return this.http.get<FoundHome[]>(this.baseUrl);
  }

  getPet(id: string): Observable<FoundHome> {
    return this.http.get<FoundHome>(this.baseUrl + '/' + id);
  }
}
