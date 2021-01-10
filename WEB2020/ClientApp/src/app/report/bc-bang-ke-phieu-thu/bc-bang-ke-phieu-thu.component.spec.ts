import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BcBangKePhieuThuComponent } from './bc-bang-ke-phieu-thu.component';

describe('BcBangKePhieuThuComponent', () => {
  let component: BcBangKePhieuThuComponent;
  let fixture: ComponentFixture<BcBangKePhieuThuComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BcBangKePhieuThuComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BcBangKePhieuThuComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
