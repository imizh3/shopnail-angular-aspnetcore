import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AutoSanphamComponent } from './auto-sanpham.component';

describe('AutoSanphamComponent', () => {
  let component: AutoSanphamComponent;
  let fixture: ComponentFixture<AutoSanphamComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AutoSanphamComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AutoSanphamComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
