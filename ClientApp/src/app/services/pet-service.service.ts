import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Pet } from '../models/pet';
import { Observable } from 'rxjs';
import { tap, map, filter } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class PetServiceService {

  private url = 'http://localhost:5000/api/pet';

  constructor(private http: HttpClient) { }


  getPets(species: string): Observable<Pet[]>{
    return this.http.get<Pet[]>(this.url +'?Species=' + species);
  }

  getPet(id: string): Observable<Pet> {
    return this.http.get<Pet>(this.url + '/' + id);
  }
}
 