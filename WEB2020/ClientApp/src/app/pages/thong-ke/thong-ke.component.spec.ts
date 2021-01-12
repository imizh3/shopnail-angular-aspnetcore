import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ThongKeComponent } from './thong-ke.component';

describe('ThongKeComponent', () => {
  let component: ThongKeComponent;
  let fixture: ComponentFixture<ThongKeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ThongKeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ThongKeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
