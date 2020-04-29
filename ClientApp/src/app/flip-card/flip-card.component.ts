import { Component, OnInit } from '@angular/core';
import { DataService } from '../shared/dataService';
import { EnglishDictionary } from '../shared/englishDictionary';

@Component({
  selector: 'app-flip-card-component',
  templateUrl: './flip-card.component.html',
  styleUrls: ['./flip-card.component.css']
})
export class FlipCardComponent implements OnInit {
  constructor(private data: DataService) {
  }

  public words: EnglishDictionary[] = [];

  ngOnInit(): void {
    this.data.loadWords();
    this.words = this.data.words;

    //this.data.loadWords()
    //  .subscribe(success => {
    //    if (success) {
    //      this.words = this.data.words;
    //    }
    //  });
    //}}
  }
}
