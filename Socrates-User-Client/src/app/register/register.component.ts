import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { AuthService } from '../shared/auth.service';
import { Router } from '@angular/router';
import { EducatorService } from '../shared/educator.service';
import { User } from '../shared/user.interface';
import { Response } from '@angular/http';
declare var firebase: any;



@Component({
  selector: 'app-register',
  templateUrl: './register.component.html'
})
export class RegisterComponent {
  constructor(private authService: AuthService, private educatorService: EducatorService, private router: Router) { }
  user = {
    firstName: "",
    lastName: "",
    uid: null
  };

  auth = {
    email: "",
    password: ""
  };


  educator = {
    FireBaseUid: 0,
    FirstName: this.user.firstName,
    LastName: this.user.lastName,
    Admin: true,
    SchoolId: null,
    StreetAddress: "",
    City: "",
    State: "",
    Zipcode: 0,
    PhoneNumber: 0,
    EmailAddress: ""
  };



  onSubmit(form: NgForm) {
    this.authService.signUpUser(this.auth.email, this.auth.password);
    if (this.authService.isAuthenticated()) {
      this.setData();
      // this.educator.FireBaseUid = uid.
      console.log(this.educator);
      //this.educatorService.addEducator(this.educator)
    }
  }

  setData() {
    console.log(this.authService.getCurrentUser());
  }
}

