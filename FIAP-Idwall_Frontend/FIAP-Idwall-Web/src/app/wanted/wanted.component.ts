import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-wanted',
  templateUrl: './wanted.component.html',
  styleUrls: ['./wanted.component.scss'],
})
export class WantedComponent implements OnInit {
  public wantedList: any;

  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    this.getWanted();
  }

  public getWanted(): any {
    this.http.get('https://localhost:5001/api/FiapIdwall').subscribe(
      (response) => (this.wantedList = response),
      (error) => console.log(error)
    );
  }
}
