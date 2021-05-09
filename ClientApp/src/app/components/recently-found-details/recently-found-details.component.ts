import { RecentlyFoundService } from './../../services/recentlyFound.service';
import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { RecentlyFound } from 'src/app/models/recentlyFound';
import { ActivatedRoute, ParamMap } from '@angular/router';
import { switchMap, tap } from 'rxjs/operators';
import { Location } from '@angular/common';

@Component({
  selector: 'app-recently-found-details',
  templateUrl: './recently-found-details.component.html',
  styleUrls: ['./recently-found-details.component.scss']
})
export class RecentlyFoundDetailsComponent implements OnInit {

  pet: Observable<RecentlyFound>;

  constructor(private http: RecentlyFoundService, private route: ActivatedRoute, private location: Location) { }

  ngOnInit() {
    this.pet = this.route.paramMap.pipe(
      switchMap((params: ParamMap) => this.http.getPet(params.get('id')))
    );
  }

  comeBack() {
    this.location.back();
  }
  
}
