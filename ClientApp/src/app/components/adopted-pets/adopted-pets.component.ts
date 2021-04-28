import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { FoundHome } from 'src/app/models/foundHome';
import { FoundHomeService } from 'src/app/services/foundHome.service';
import { PetServiceService } from 'src/app/services/pet-service.service';

@Component({
  selector: 'app-adopted-pets',
  templateUrl: './adopted-pets.component.html',
  styleUrls: ['./adopted-pets.component.css']
})
export class AdoptedPetsComponent implements OnInit {

  pets: Observable<FoundHome[]>;
  constructor(private http: FoundHomeService) { }

  ngOnInit() {
    this.pets = this.http.getPets();
  }

}
