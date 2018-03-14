import { AspNetCoreBoilerplateTemplatePage } from './app.po';

describe('AspNetCoreBoilerplate App', function() {
  let page: AspNetCoreBoilerplateTemplatePage;

  beforeEach(() => {
    page = new AspNetCoreBoilerplateTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
