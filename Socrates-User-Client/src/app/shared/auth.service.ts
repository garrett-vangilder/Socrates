import { Injectable } from '@angular/core';
import { RouterModule, Router } from '@angular/router';
import { Subject, Observable } from 'rxjs/Rx';
import { User } from './user.interface';

declare var firebase: any;


@Injectable()
export class AuthService {

  constructor(private router: Router) { }
  signUpUser(email: string, password: string) {
    firebase.auth().createUserWithEmailAndPassword(email, password)
      .catch((error) => {
        var errorCode = error.code;
        var errorMessage = error.message;
        console.log(errorCode, errorMessage);
      })
  }

  signInUser(email: string, password: string) {
    firebase.auth().signInWithEmailAndPassword(email, password)
      .catch(function (error) {
        // Handle Errors here.
        var errorCode = error.code;
        var errorMessage = error.message;
        console.log(errorMessage);
      });
  }

  isAuthenticated(): Observable<boolean> {
    const subject = new Subject<boolean>();
    var user = firebase.auth().onAuthStateChanged(function (user) {
      console.log(user);
      if (user) {
        subject.next(true);
      } else {
        subject.next(false);
      }
    });
    return subject.asObservable();
  }

  getCurrentUser() {
    var user = firebase.User;
    return user;
  }

  logout() {
    firebase.auth().signOut();
    this.router.navigate(['/'])
  }

}