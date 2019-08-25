import './polyfills';
import { ApplicationRef } from "@angular/core";
import { enableDebugTools } from "@angular/platform-browser";
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';
import { AppModule } from './app/app.module';

//platformBrowserDynamic().bootstrapModule(AppModule);

platformBrowserDynamic().bootstrapModule(AppModule).then((module) => {
  let applicationRef = module.injector.get(ApplicationRef);
  let appComponent = applicationRef.components[0];
  enableDebugTools(appComponent);
});
