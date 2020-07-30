import { Component } from "@angular/core";
import { DataService } from "../shared/dataService";
import { EnglishDictionaryDetails } from "../shared/englishDictionaryDetails";


@Component({
  selector: 'cart-detils',
  templateUrl: './cart-details.component.html'
})
export class CartDetailsComponent {
  constructor(private data: DataService) {
  } 
}
