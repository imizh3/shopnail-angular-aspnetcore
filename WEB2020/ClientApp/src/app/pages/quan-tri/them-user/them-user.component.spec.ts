import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ThemUserComponent } from './them-user.component';

describe('ThemUserComponent', () => {
  let component: ThemUserComponent;
  let fixture: ComponentFixture<ThemUserComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ThemUserComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ThemUserComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
