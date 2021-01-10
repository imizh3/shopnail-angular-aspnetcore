import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BcHangXuatTraComponent } from './bc-hang-xuat-tra.component';

describe('BcHangXuatTraComponent', () => {
  let component: BcHangXuatTraComponent;
  let fixture: ComponentFixture<BcHangXuatTraComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BcHangXuatTraComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BcHangXuatTraComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
