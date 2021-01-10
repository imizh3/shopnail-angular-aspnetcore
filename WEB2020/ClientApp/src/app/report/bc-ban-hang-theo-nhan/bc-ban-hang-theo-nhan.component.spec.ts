import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BcBanHangTheoNhanComponent } from './bc-ban-hang-theo-nhan.component';

describe('BcBanHangTheoNhanComponent', () => {
  let component: BcBanHangTheoNhanComponent;
  let fixture: ComponentFixture<BcBanHangTheoNhanComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BcBanHangTheoNhanComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BcBanHangTheoNhanComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
