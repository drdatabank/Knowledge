import { Component, OnInit } from '@angular/core';
import { DataService } from '../shared/dataService';
import { EnglishDictionary } from '../shared/englishDictionary';
import { EnglishDictionaryDetails } from '../shared/englishDictionaryDetails';
import { CartDetailsComponent } from './cart-details.component';

@Component({
  selector: 'app-flip-card-component',
  templateUrl: './flip-card.component.html',
  styleUrls: ['./flip-card.component.css']
})
export class FlipCardComponent implements OnInit {
  constructor(private data: DataService) {
  }

  public words: EnglishDictionary[] = [];
  public wordDetail: EnglishDictionaryDetails;
  //public words = [];

  ngOnInit(): void {
    this.data.loadWords()
      .subscribe((success) => {
        if (success) {
          this.words = this.data.words;
        }
      });
  }

  flipCardClick(id: number) {
    //let cartDetailsComponent = new CartDetailsComponent(this.data);
    this.data.loadWordDetail(id)
      //.subscribe((result) => {
        //if (success) {
        //cartDetailsComponent.wordDetail == result;
    //this.wordDetail = result;
    return this.data.loadWordDetail;
        //console.log(result);
        //}
      //});


    
    //this.wordDetail = cartDetailsComponent.wordDetail;
  }

  //getWordDetails(id: number) {
  //  this.data.loadWordDetail(id)
  //    .subscribe((result) => {
  //      //if (success) {
  //      this.wordDetail = result;
  //      console.log(result);
  //      //}
  //    });;

  //  console.log(this.wordDetail);
  //}

}

