import { startWith, map, filter } from 'rxjs/operators';
import { ProductService } from './../../@core/mock/product.service';
import { Observable, of } from 'rxjs';
import { Component, OnInit, ChangeDetectionStrategy, forwardRef, OnDestroy, Input, Output, EventEmitter } from '@angular/core';
import { NG_VALUE_ACCESSOR, ControlValueAccessor, FormControl } from '@angular/forms';


const noop = () => {
};
@Component({
  selector: 'ngx-auto-sanpham',
  templateUrl: './auto-sanpham.component.html',
  styleUrls: ['./auto-sanpham.component.scss'],
  changeDetection: ChangeDetectionStrategy.OnPush,
  providers: [
    {
      provide: NG_VALUE_ACCESSOR,
      useExisting: forwardRef(() => AutoSanphamComponent),
      multi: true,
    },
  ],

})
export class AutoSanphamComponent implements ControlValueAccessor, OnInit, OnDestroy {

  options: any[];
  filteredControlOptions$: Observable<any[]>;
  inputFormControl: FormControl;

  @Input() placeholder: string;
  @Output() selectedItem: EventEmitter<any> = new EventEmitter();

  constructor( private productService: ProductService) { }

  ngOnInit(): void {
    this.options = this.productService.products;
    this.filteredControlOptions$ = of(this.options);
    this.inputFormControl = new FormControl();
    this.filteredControlOptions$ = this.inputFormControl.valueChanges
      .pipe(
        startWith(''),
        map(filterString => this.filter(filterString)),
      );
  }

  private filter(value: string): string[] {
    try {
      const filterValue = value.toLowerCase();
      return this.options.filter(optionValue => optionValue.tendaydu.toLowerCase().includes(filterValue)).slice(0, 100);
    } catch {
      return [];
    }
  }

  onModelChange(value: string) {
    this.value = value;
    this.filteredControlOptions$ = of(this.filter(value));
  }

  viewHandle(value: any) {
    return value.tendaydu ? value.tendaydu : value;
  }

  innerValue: any = '';

  private onTouchedCallback: () => void = noop;
  private onChangeCallback: (_: any) => void = noop;

  get value(): any {
    return this.innerValue;
  }

  set value(v: any) {
    if (v !== this.innerValue) {
      this.innerValue = v;
      this.onChangeCallback(v);
    }
  }

  onBlur() {
    this.onTouchedCallback();
  }
  writeValue(value: any) {
    if (value !== this.innerValue) {
      this.innerValue = value;
    }
  }
  ngOnDestroy(): void {
    this.innerValue = '';
  }
  registerOnChange(fn: any) {
    this.onChangeCallback = fn;
  }

  registerOnTouched(fn: any) {
    this.onTouchedCallback = fn;
  }


}
