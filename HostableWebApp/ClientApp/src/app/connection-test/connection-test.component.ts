import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-connection-test',
  templateUrl: './connection-test.component.html'
})
export class ConnectionTestComponent {

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    this.http.get<any>(this.baseUrl + 'api/ConnectionTest/Get').subscribe(result => {
      console.log(result);
    }, error => console.error(error));
  }

  public testDBConnection(): void {
    this.http.get<any>(this.baseUrl + 'api/ConnectionTest/GetDB').subscribe(result => {
      console.log(result);
    }, error => console.error(error));
  }
}
