import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BcKhuyenMaiTheoChtrinhComponent } from './bc-khuyen-mai-theo-chtrinh.component';

describe('BcKhuyenMaiTheoChtrinhComponent', () => {
  let component: BcKhuyenMaiTheoChtrinhComponent;
  let fixture: ComponentFixture<BcKhuyenMaiTheoChtrinhComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BcKhuyenMaiTheoChtrinhComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BcKhuyenMaiTheoChtrinhComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
