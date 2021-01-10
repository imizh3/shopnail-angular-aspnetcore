import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ThemDonHangCtComponent } from './them-don-hang-ct.component';

describe('ThemDonHangCtComponent', () => {
  let component: ThemDonHangCtComponent;
  let fixture: ComponentFixture<ThemDonHangCtComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ThemDonHangCtComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ThemDonHangCtComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
