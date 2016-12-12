import { Injectable, EventEmitter } from '@angular/core';
import { Headers, Http, Response } from '@angular/http';
import 'rxjs/Rx';

@Injectable()
export class EducatorService {

    constructor(private http: Http) { }

    getEducators() {
        const headers = new Headers({
            "Content-Type": "application/json"
        })
        return this.http.get('http://webapi20161209105729.azurewebsites.net/educators');
    }

    addEducator(educator) {
        const body = JSON.stringify(educator);
        const headers = new Headers({
            "Content-Type": "application/json"
        })
        return this.http.post('http://webapi20161209105729.azurewebsites.net/educators', body, { headers: headers });
    }

}