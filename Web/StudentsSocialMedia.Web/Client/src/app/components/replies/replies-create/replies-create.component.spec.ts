import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RepliesCreateComponent } from './replies-create.component';

describe('RepliesCreateComponent', () => {
  let component: RepliesCreateComponent;
  let fixture: ComponentFixture<RepliesCreateComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RepliesCreateComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RepliesCreateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
