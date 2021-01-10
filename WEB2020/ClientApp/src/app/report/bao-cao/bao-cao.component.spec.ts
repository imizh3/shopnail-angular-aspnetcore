import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BaoCaoComponent } from './bao-cao.component';

describe('BaoCaoComponent', () => {
  let component: BaoCaoComponent;
  let fixture: ComponentFixture<BaoCaoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BaoCaoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BaoCaoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
