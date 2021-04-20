import { PetServiceService } from './../../services/pet-service.service';
import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { Pet } from 'src/app/models/pet';
import { ActivatedRoute, ParamMap } from '@angular/router';
import { switchMap, tap } from 'rxjs/operators';
import { Location } from '@angular/common';

@Component({
  selector: 'app-pet-details',
  templateUrl: './pet-details.component.html',
  styleUrls: ['./pet-details.component.css']
})
export class PetDetailsComponent implements OnInit {

  petDetails: Observable<Pet>;

  constructor(private http: PetServiceService, private route: ActivatedRoute, private location: Location) { }

  ngOnInit() {
    this.petDetails = this.route.paramMap.pipe(
      switchMap((params: ParamMap) => this.http.getPet(params.get('id')))
    );
  }
  
  comeBack() {
    this.location.back();
  }
 
}
