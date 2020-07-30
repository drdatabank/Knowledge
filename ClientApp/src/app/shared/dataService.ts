import { HttpClient, HttpParams } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { map } from "rxjs/operators";
import { Observable } from "rxjs";
import { EnglishDictionary } from "./englishDictionary";
import { EnglishDictionaryDetails } from "./englishDictionaryDetails";


@Injectable()
export class DataService
  {
    constructor(private http: HttpClient) {
    }

  public words: EnglishDictionary[] = [];
  public wordDetail: EnglishDictionaryDetails = new EnglishDictionaryDetails();

  loadWords(): Observable<boolean> {
    return this.http.get("english/get")
      .pipe(
        map((data: any[]) => {
          this.words = data;
          return true;
        })
      )    
  }


  loadWordDetail(id: number) {
    var url = "english/GetDetails/";// + id;
    const params = new HttpParams()
      .set('id', id.toString());
    let result = this.http.get<EnglishDictionaryDetails>(url, { params });
    result.subscribe((details: EnglishDictionaryDetails) => {
      this.wordDetail.id = details.id;
      this.wordDetail.correctAnswersCount = details.correctAnswersCount;
      this.wordDetail.wrongAnswersCount = details.wrongAnswersCount;
      this.wordDetail.note = details.note;
    });      
  }
}

