import { Component } from '@angular/core';
import { AuthService } from '../auth.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html'
})
export class HomeComponent {
  auth = {
    email: "",
    password: ""
  }

  constructor(private authService: AuthService) { }

  onSubmit() {
    this.authService.signInUser(this.auth.email, this.auth.password);
  }
}
