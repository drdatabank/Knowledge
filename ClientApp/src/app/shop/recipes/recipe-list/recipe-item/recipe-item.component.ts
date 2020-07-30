import { Component } from '@angular/core';

@Component({
  selector: 'app-recipe-item',
  templateUrl: './recipe-item.component.html'
})
export class RecipeItemComponent {
  public currentCount = 0;

  public incrementCounter() {
    this.currentCount++;
  }
}
