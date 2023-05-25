import { TestBed } from '@angular/core/testing';

import { KfcmenuService } from './kfcmenu.service';

describe('KfcmenuService', () => {
  let service: KfcmenuService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(KfcmenuService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
