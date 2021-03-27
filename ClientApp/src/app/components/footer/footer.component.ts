import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-footer',
  templateUrl: './footer.component.html',
  styleUrls: ['./footer.component.css']
})
export class FooterComponent implements OnInit {

  year = new Date().getFullYear();
  footerText = `© ${this.year} - Fundacja Zawsze Razem`;
 
  constructor() { }

  ngOnInit() {
  }

}
