import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BcCongNoNvGiaoHangComponent } from './bc-cong-no-nv-giao-hang.component';

describe('BcCongNoNvGiaoHangComponent', () => {
  let component: BcCongNoNvGiaoHangComponent;
  let fixture: ComponentFixture<BcCongNoNvGiaoHangComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BcCongNoNvGiaoHangComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BcCongNoNvGiaoHangComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
