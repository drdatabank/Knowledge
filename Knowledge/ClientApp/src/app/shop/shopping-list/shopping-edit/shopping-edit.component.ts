import { Component } from '@angular/core';

@Component({
  selector: 'app-shopping-edit',
  templateUrl: './shopping-edit.component.html'
})
export class ShoppingEditComponent {
  public currentCount = 0;

  public incrementCounter() {
    this.currentCount++;
  }
}
