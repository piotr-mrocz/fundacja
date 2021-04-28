import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, ParamMap } from '@angular/router';
import { Observable } from 'rxjs';
import { switchMap } from 'rxjs/operators';
import { FoundHome } from 'src/app/models/foundHome';
import { FoundHomeService } from 'src/app/services/foundHome.service';
import { Location } from '@angular/common';

@Component({
  selector: 'app-foundHome-details',
  templateUrl: './foundHome-details.component.html',
  styleUrls: ['./foundHome-details.component.css']
})
export class FoundHomeDetailsComponent implements OnInit {

  petDetails: Observable<FoundHome>;
  constructor(private http: FoundHomeService, private route: ActivatedRoute, private location: Location) { }

  ngOnInit() {
    this.petDetails = this.route.paramMap.pipe(
      switchMap((params: ParamMap) => this.http.getPet(params.get('id')))
    );
  }

  comeBack() {
    this.location.back();
  }

}
