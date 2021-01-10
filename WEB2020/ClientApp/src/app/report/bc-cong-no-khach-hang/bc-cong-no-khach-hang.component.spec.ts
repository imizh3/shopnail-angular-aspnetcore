import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BcCongNoKhachHangComponent } from './bc-cong-no-khach-hang.component';

describe('BcCongNoKhachHangComponent', () => {
  let component: BcCongNoKhachHangComponent;
  let fixture: ComponentFixture<BcCongNoKhachHangComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BcCongNoKhachHangComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BcCongNoKhachHangComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
