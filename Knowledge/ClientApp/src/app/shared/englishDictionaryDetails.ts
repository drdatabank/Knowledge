
  export class EnglishDictionaryDetails {
    id: number;
    englishDictionaryId: number;
    englishWordsListId?: number;
    correctAnswersCount: number;
    wrongAnswersCount: number;
    englishWordsGroupId?: number;
    modificationDate?: Date;
    userId?: number;
    correctWrittenCount: number;
    wrongWrittenCount?: number;
    note?: string;
    englishWordsGroup?: any;
    englishDictionaryDetails_EnglishWordsList: any[];
  }
