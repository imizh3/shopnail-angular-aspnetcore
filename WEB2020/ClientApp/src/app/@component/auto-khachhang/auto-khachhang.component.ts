import { LIB } from './../../@core/utils/LIB';
import { Component, OnInit, ChangeDetectionStrategy, forwardRef, OnDestroy, Input, Output, EventEmitter } from '@angular/core';
import { FormControl } from '@angular/forms';
import { Observable, of } from 'rxjs';
import { startWith, map, filter } from 'rxjs/operators';
import { ControlValueAccessor, NG_VALUE_ACCESSOR } from '@angular/forms';
import { DataService } from '../../@core/mock/data.service';

const noop = () => {
};

@Component({
  selector: 'ngx-auto-khachhang',
  templateUrl: './auto-khachhang.component.html',
  styleUrls: ['./auto-khachhang.component.scss'],
  changeDetection: ChangeDetectionStrategy.OnPush,
  providers: [
    {
      provide: NG_VALUE_ACCESSOR,
      useExisting: forwardRef(() => AutoKhachhangComponent),
      multi: true,
    },
  ],
})


export class AutoKhachhangComponent implements ControlValueAccessor, OnInit, OnDestroy {

  options: any;
  filteredControlOptions$: Observable<any[]>;
  filteredNgModelOptions$: Observable<any[]>;
  inputFormControl: FormControl;

  @Input() placeholder: string;
  @Output() selectedItem: EventEmitter<any> = new EventEmitter();

  constructor(private data: DataService, private lib: LIB) {

  }
  ngOnDestroy(): void {
    this.innerValue = '';
  }

  ngOnInit() {
    this.data.LoadKhachhang().subscribe(d => {
      this.options = d;
      this.filteredControlOptions$ = of(this.options);
      this.filteredNgModelOptions$ = of(this.options);
    });
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
      // tslint:disable-next-line: max-line-length
      return this.options.filter(optionValue => optionValue.tenkhachhang.toLowerCase().includes(filterValue)
        || this.lib.xoa_dau(optionValue.tenkhachhang.toLowerCase()).includes(this.lib.xoa_dau(filterValue))
        || optionValue.dienthoai.toLowerCase().includes(filterValue)
        || optionValue.diachi.toLowerCase().includes(filterValue)
        || this.lib.xoa_dau(optionValue.diachi.toLowerCase()).includes(this.lib.xoa_dau(filterValue)),
      ).slice(0, 100);
    } catch {
      return [];
    }
  }

  onModelChange(value: string) {
    this.value = value;
    this.filteredControlOptions$ = of(this.filter(value));
  }

  viewHandle(value: any) {
    return value.tenkhachhang ? value.tenkhachhang : value;
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

  registerOnChange(fn: any) {
    this.onChangeCallback = fn;
  }

  registerOnTouched(fn: any) {
    this.onTouchedCallback = fn;
  }
}
