import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BcXntComponent } from './bc-xnt.component';

describe('BcXntComponent', () => {
  let component: BcXntComponent;
  let fixture: ComponentFixture<BcXntComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BcXntComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BcXntComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
