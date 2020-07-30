import { Component } from '@angular/core';
import { style } from '@angular/animations';

@Component({
  selector: 'app-srver',
  templateUrl: './server.component.html',
  styles: [`
.online {
color: white;
}`]
})
export class ServerComponent {
  serverId: number = 10;
  serverStatus: string = 'offline';
  constructor() {
    this.serverStatus = Math.random() > 0.5 ? 'online' : 'ofline';
  }




  getServerStatus() {
    return this.serverStatus;
  }
  getColor() {
    return this.serverStatus === 'online' ? 'green' : 'red';
  }
}
