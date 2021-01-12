import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { QuanTriComponent } from './quan-tri.component';

describe('QuanTriComponent', () => {
  let component: QuanTriComponent;
  let fixture: ComponentFixture<QuanTriComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ QuanTriComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(QuanTriComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
