import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LimanComponent } from './liman.component';

describe('LimanComponent', () => {
  let component: LimanComponent;
  let fixture: ComponentFixture<LimanComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ LimanComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(LimanComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
