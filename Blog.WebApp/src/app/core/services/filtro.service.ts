import { EventEmitter, Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs/internal/BehaviorSubject';

@Injectable({
  providedIn: 'root',
})
export class FiltroService {
  constructor() {}

  filtroUpdated: EventEmitter<any> = new EventEmitter();

  private _value: any;
  private _valueObs$ = new BehaviorSubject(null);

  setValue(newValue: any): void {
    this._value = newValue;
  }

  get getNewValue(): any {
    return this._value;
  }

  setObservableValue(newValue: any): void {
    this._valueObs$.next(newValue);
    this.filtroUpdated.emit(newValue);
  }

  get getNewObservableValue(): any {
    return this._valueObs$;
  }
}
