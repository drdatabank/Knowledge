import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { map } from "rxjs/operators";


@Injectable()
export class DataService
  {
    constructor(private http: HttpClient) {

    }

  public words:any = [];

  loadWords() {
    this.http.get("english/get")
      .subscribe( response => this.words = response);
    return true;


    //this.http.get("english/get")
    //  .subscribe(
    //    map((data: any[]) => {
    //      this.words = data;
    //      return true;
    //    }));
  }

  //loadWords() {
  //  this.words = [{
  //    englishWord: "word1",
  //    polishWord: "słowo1"
  //  },
  //  {
  //    englishWord: "word2",
  //    polishWord: "słowo2"
  //  },
  //  {
  //    englishWord: "word3",
  //    polishWord: "słowo3"
  //  },
  //  ];

  //  return true;
  //}

  }

