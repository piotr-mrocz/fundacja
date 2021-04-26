import { DatePipe } from '@angular/common';
import { PetServiceService } from './../../services/pet-service.service';
import { Component, OnInit } from '@angular/core';
import { Pet } from 'src/app/models/pet';
import { Observable } from 'rxjs';
import { tap, map, filter } from 'rxjs/operators';

@Component({
  selector: 'app-dogs-to-adopt-list',
  templateUrl: './dogs-to-adopt-list.component.html',
  styleUrls: ['./dogs-to-adopt-list.component.css']
})
export class DogsToAdoptListComponent implements OnInit {

  pets: Observable<Pet[]>;
  
  constructor(private http: PetServiceService) { }

  ngOnInit() { 
    this.pets = this.http.getPets('Pies');
  }
}
  