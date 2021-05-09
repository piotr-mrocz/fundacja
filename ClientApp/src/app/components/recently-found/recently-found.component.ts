import { RecentlyFoundService } from './../../services/recentlyFound.service';
import { RecentlyFound } from './../../models/recentlyFound';
import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-recently-found',
  templateUrl: './recently-found.component.html',
  styleUrls: ['./recently-found.component.scss']
})
export class RecentlyFoundComponent implements OnInit {

  pets: Observable<RecentlyFound[]>;

  constructor(private http: RecentlyFoundService) { }

  ngOnInit() {
    this.pets = this.http.getPets();
  }

}
