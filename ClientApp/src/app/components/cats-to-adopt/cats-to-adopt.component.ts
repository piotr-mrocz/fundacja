import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { Pet } from 'src/app/models/pet';
import { PetServiceService } from 'src/app/services/pet-service.service';

@Component({
  selector: 'app-cats-to-adopt',
  templateUrl: './cats-to-adopt.component.html',
  styleUrls: ['./cats-to-adopt.component.css']
})
export class CatsToAdoptComponent implements OnInit {

  pets: Observable<Pet[]>;
  constructor(private http: PetServiceService) { }

  ngOnInit() {
    this.pets = this.http.getPets("Kot");
  }

}
