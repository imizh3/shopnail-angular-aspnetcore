import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BcNhapMuaComponent } from './bc-nhap-mua.component';

describe('BcNhapMuaComponent', () => {
  let component: BcNhapMuaComponent;
  let fixture: ComponentFixture<BcNhapMuaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BcNhapMuaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BcNhapMuaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
