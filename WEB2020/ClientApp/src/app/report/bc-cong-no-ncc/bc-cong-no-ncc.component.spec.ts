import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BcCongNoNccComponent } from './bc-cong-no-ncc.component';

describe('BcCongNoNccComponent', () => {
  let component: BcCongNoNccComponent;
  let fixture: ComponentFixture<BcCongNoNccComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BcCongNoNccComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BcCongNoNccComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
