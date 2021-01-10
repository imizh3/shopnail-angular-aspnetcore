import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BcHangTonKhoComponent } from './bc-hang-ton-kho.component';

describe('BcHangTonKhoComponent', () => {
  let component: BcHangTonKhoComponent;
  let fixture: ComponentFixture<BcHangTonKhoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BcHangTonKhoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BcHangTonKhoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
