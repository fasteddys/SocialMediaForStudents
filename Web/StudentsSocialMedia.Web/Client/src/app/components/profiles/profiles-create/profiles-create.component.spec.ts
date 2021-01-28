import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProfilesCreateComponent } from './profiles-create.component';

describe('ProfilesCreateComponent', () => {
  let component: ProfilesCreateComponent;
  let fixture: ComponentFixture<ProfilesCreateComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ProfilesCreateComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ProfilesCreateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
