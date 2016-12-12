import { Routes, RouterModule } from '@angular/router';
import { RegisterComponent } from './register/register.component';
import { HomeComponent } from './shared/home/home.component';

const APP_ROUTES: Routes = [
    { path: "", component: HomeComponent },
    { path: "register", component: RegisterComponent },
];

export const routing = RouterModule.forRoot(APP_ROUTES);