import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BcNhapTraLaiComponent } from './bc-nhap-tra-lai.component';

describe('BcNhapTraLaiComponent', () => {
  let component: BcNhapTraLaiComponent;
  let fixture: ComponentFixture<BcNhapTraLaiComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BcNhapTraLaiComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BcNhapTraLaiComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
