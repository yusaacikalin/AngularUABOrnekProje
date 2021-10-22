import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PersonellerComponent } from './personeller.component';

describe('PersonellerComponent', () => {
  let component: PersonellerComponent;
  let fixture: ComponentFixture<PersonellerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PersonellerComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PersonellerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
