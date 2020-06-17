import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { map } from "rxjs/operators";
import { Observable } from "rxjs";


@Injectable()
export class DataService
  {
    constructor(private http: HttpClient) {
    }

  public words:any = [];

  loadWords(): Observable<boolean> {
    return this.http.get("english/get")
      .pipe(
        map((data: any[]) => {
          this.words = data;
          return true;
        })
      )
    
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

