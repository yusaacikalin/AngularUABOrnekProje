import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PersonelbilgiComponent } from './personelbilgi.component';

describe('PersonelbilgiComponent', () => {
  let component: PersonelbilgiComponent;
  let fixture: ComponentFixture<PersonelbilgiComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PersonelbilgiComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PersonelbilgiComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
