import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BcQuyTienMatComponent } from './bc-quy-tien-mat.component';

describe('BcQuyTienMatComponent', () => {
  let component: BcQuyTienMatComponent;
  let fixture: ComponentFixture<BcQuyTienMatComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BcQuyTienMatComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BcQuyTienMatComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
