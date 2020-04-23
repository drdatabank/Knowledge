import { Component } from '@angular/core';

@Component({
  selector: 'app-flip-card-component',
  templateUrl: './flip-card.component.html',
  styleUrls: ['./flip-card.component.css']
})
export class FlipCardComponent {
  public currentCount = 0;

  public incrementCounter() {
    this.currentCount++;
  }
}
