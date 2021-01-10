import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { KhuyenMaiCtComponent } from './khuyen-mai-ct.component';

describe('KhuyenMaiCtComponent', () => {
  let component: KhuyenMaiCtComponent;
  let fixture: ComponentFixture<KhuyenMaiCtComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ KhuyenMaiCtComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(KhuyenMaiCtComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
