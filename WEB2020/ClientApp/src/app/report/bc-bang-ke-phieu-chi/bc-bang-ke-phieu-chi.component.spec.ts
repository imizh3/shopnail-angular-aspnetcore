import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BcBangKePhieuChiComponent } from './bc-bang-ke-phieu-chi.component';

describe('BcBangKePhieuChiComponent', () => {
  let component: BcBangKePhieuChiComponent;
  let fixture: ComponentFixture<BcBangKePhieuChiComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BcBangKePhieuChiComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BcBangKePhieuChiComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
