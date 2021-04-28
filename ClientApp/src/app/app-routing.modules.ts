import { AdoptedPetsComponent } from './components/adopted-pets/adopted-pets.component';
import { CatsToAdoptComponent } from './components/cats-to-adopt/cats-to-adopt.component';
import { PetDetailsComponent } from './components/pet-details/pet-details.component';
import { DogsToAdoptListComponent } from './components/dogs-to-adopt-list/dogs-to-adopt-list.component';
import { HowToAdoptComponent } from './components/how-to-adopt/how-to-adopt.component';
import { HelpComponent } from './components/help/help.component';
import { AboutFundationComponent } from './components/about-fundation/about-fundation.component';
import { OurSheltersComponent } from './components/our-shelters/our-shelters.component';
import { ContactComponent } from './components/contact/contact.component';
import { PageNotFoundComponent } from './components/page-not-found/page-not-found.component';
import { AccessDeclarationComponent } from './components/access-declaration/access-declaration.component';
import { ProcessingOfPersonalDataComponent } from './components/processing-of-personal-data/processing-of-personal-data.component';
import { PrivacyPolicyComponent } from './components/privacy-policy/privacy-policy.component';
import { HomePageComponent } from './components/home-page/home-page.component';

import { NgModule } from "@angular/core";
import { Routes, RouterModule } from '@angular/router';
import { PriceListComponent } from './components/price-list/price-list.component';
import { FoundHomeDetailsComponent } from './components/foundHome-details/foundHome-details.component';
const routes: Routes = [
    {path: '', redirectTo: '/home', pathMatch: 'full'},
    {path: 'home', component: HomePageComponent},
    {path: 'privacy-policy', component: PrivacyPolicyComponent},
    {path: 'processing-of-personal-data', component: ProcessingOfPersonalDataComponent},
    {path: 'access-declaration', component: AccessDeclarationComponent},
    {path: 'contact', component: ContactComponent},
    {path: 'our-shelters', component: OurSheltersComponent},
    {path: 'fundation', component: AboutFundationComponent},
    {path: 'help', component: HelpComponent},
    {path: 'price-list', component: PriceListComponent},
    {path: 'how-to-adopt', component: HowToAdoptComponent},
    {path: 'dogs-to-adopt-list', component: DogsToAdoptListComponent},
    {path: 'cats-to-adopt-list', component: CatsToAdoptComponent},
    {path: 'adopted',  component: AdoptedPetsComponent},
    {path: 'adopted/:id', component: FoundHomeDetailsComponent},
    {path: 'pet-details/:id', component: PetDetailsComponent},
    {path: '**', component: PageNotFoundComponent}
];

@NgModule({
imports: [RouterModule.forRoot(routes,{
    scrollPositionRestoration: 'enabled',
    anchorScrolling: 'enabled'
  }
    )],
exports: [RouterModule]
})
export class AppRoutingModule {}
