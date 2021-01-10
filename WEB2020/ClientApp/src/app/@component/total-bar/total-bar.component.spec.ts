import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TotalBarComponent } from './total-bar.component';

describe('TotalBarComponent', () => {
  let component: TotalBarComponent;
  let fixture: ComponentFixture<TotalBarComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TotalBarComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TotalBarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
