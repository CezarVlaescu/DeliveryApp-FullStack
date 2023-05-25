import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MycomandsComponent } from './mycomands.component';

describe('MycomandsComponent', () => {
  let component: MycomandsComponent;
  let fixture: ComponentFixture<MycomandsComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [MycomandsComponent]
    });
    fixture = TestBed.createComponent(MycomandsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
