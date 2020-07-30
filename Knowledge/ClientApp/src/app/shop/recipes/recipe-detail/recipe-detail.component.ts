import { Component } from '@angular/core';

@Component({
  selector: 'app-recipe-detail',
  templateUrl: './recipe-detail.component.html'
})
export class RecipeDetailComponent {
  public currentCount = 0;

  public incrementCounter() {
    this.currentCount++;
  }
}
