import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { RecentlyFound } from '../models/recentlyFound';

@Injectable({
  providedIn: 'root'
})
export class RecentlyFoundService {

  baseUrl = 'http://localhost:5000/api/recentlyfound';

  constructor(private http: HttpClient) { }

  getPets(): Observable<RecentlyFound[]> {
    return this.http.get<RecentlyFound[]>(this.baseUrl);
  }

  getPet(id: string): Observable<RecentlyFound> {
    return this.http.get<RecentlyFound>(this.baseUrl + '/' + id)
  }

}
