import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BcTongHopKhuyenMaiComponent } from './bc-tong-hop-khuyen-mai.component';

describe('BcTongHopKhuyenMaiComponent', () => {
  let component: BcTongHopKhuyenMaiComponent;
  let fixture: ComponentFixture<BcTongHopKhuyenMaiComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BcTongHopKhuyenMaiComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BcTongHopKhuyenMaiComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
