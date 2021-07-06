import { TestBed } from '@angular/core/testing';

import { GameShopAPIService } from './game-shop-api.service';

describe('GameShopAPIService', () => {
  let service: GameShopAPIService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(GameShopAPIService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
