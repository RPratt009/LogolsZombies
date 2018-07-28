import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { GradeReport } from '../entities/GradeReport';

@Injectable()
export class GradeReportService {
    url: string = "http://localhost:5000/api/GradeReport/";

    constructor(private http: HttpClient) { }

    public getAll() {
        return this.http.get<GradeReport[]>(this.url);
    }

    public get(id: number) {
        return this.http.get<GradeReport>(this.url + id);
    }

    public update(grade: GradeReport) {
        return this.http.put(this.url, grade);
    }

    public insert(grade: GradeReport) {
        return this.http.post(this.url, grade);
    }

    public delete(id: number) {
        return this.http.delete(this.url + id);
    }
}