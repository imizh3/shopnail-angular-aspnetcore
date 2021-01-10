import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MenuReportComponent } from './menu-report.component';

describe('MenuReportComponent', () => {
  let component: MenuReportComponent;
  let fixture: ComponentFixture<MenuReportComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MenuReportComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MenuReportComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
