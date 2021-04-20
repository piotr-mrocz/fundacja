import { PetDetailsComponent } from './components/pet-details/pet-details.component';
import { DogsToAdoptListComponent } from './components/dogs-to-adopt-list/dogs-to-adopt-list.component';
import { HowToAdoptComponent } from './components/how-to-adopt/how-to-adopt.component';
import { OurSheltersComponent } from './components/our-shelters/our-shelters.component';
import { ContactComponent } from './components/contact/contact.component';
import { AboutFundationComponent } from './components/about-fundation/about-fundation.component';
import { HelpComponent } from './components/help/help.component';
import { PageNotFoundComponent } from './components/page-not-found/page-not-found.component';
import { AccessDeclarationComponent } from './components/access-declaration/access-declaration.component';
import { ProcessingOfPersonalDataComponent } from './components/processing-of-personal-data/processing-of-personal-data.component';
import { PrivacyPolicyComponent } from './components/privacy-policy/privacy-policy.component';
import { DividerComponent } from './components/divider/divider.component';
import { HomePageComponent } from './components/home-page/home-page.component';
import { FooterComponent } from './components/footer/footer.component';
import { NavComponent } from './components/nav/nav.component';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.modules';
import { PriceListComponent } from './components/price-list/price-list.component';

@NgModule({
  declarations: [
    AppComponent,
    NavComponent,
    FooterComponent,
    HomePageComponent,
    DividerComponent,
    PrivacyPolicyComponent,
    ProcessingOfPersonalDataComponent,
    AccessDeclarationComponent,
    PageNotFoundComponent,
    HelpComponent,
    AboutFundationComponent,
    ContactComponent,
    OurSheltersComponent,
    PriceListComponent,
    HowToAdoptComponent,
    DogsToAdoptListComponent,
    PetDetailsComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    AppRoutingModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
