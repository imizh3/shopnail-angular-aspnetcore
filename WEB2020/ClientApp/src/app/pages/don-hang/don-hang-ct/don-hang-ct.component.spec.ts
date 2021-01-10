import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DonHangCtComponent } from './don-hang-ct.component';

describe('DonHangCtComponent', () => {
  let component: DonHangCtComponent;
  let fixture: ComponentFixture<DonHangCtComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DonHangCtComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DonHangCtComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
