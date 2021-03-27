import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-divider',
  template: 
        `<div class=" d-flex justify-content-center mt-5 mb-2">
        <img src="../../../assets/Images/divider.png">
      </div>`
  //styleUrls: ['./divider.component.css']
})
export class DividerComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

}
