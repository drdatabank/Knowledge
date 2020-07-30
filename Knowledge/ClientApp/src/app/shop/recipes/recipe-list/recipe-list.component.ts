import { Component } from '@angular/core';

@Component({
  selector: 'app-recipe-list',
  templateUrl: './recipe-list.component.html'
})
export class RecipeListComponent {
  public currentCount = 0;

  public incrementCounter() {
    this.currentCount++;
  }
}
