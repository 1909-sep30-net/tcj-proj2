import { TestBed } from '@angular/core/testing';

import { StatedataService } from './statedata.service';

describe('StatedataService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: StatedataService = TestBed.get(StatedataService);
    expect(service).toBeTruthy();
  });
});
