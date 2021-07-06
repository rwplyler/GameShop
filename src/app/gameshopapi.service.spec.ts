import { TestBed } from '@angular/core/testing';

import { GameshopapiService } from './gameshopapi.service';

describe('GameshopapiService', () => {
  let service: GameshopapiService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(GameshopapiService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
