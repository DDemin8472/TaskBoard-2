import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { MaterialModule } from '@angular/material';
import 'node_modules/hammerjs/hammer.js';

import { AppComponent } from './app.component';
import { HeaderComponent } from './components/header/header.component';
import { SettingComponent } from './components/setting/setting.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';

@NgModule({
    imports: [BrowserModule, MaterialModule.forRoot()],
    declarations: [AppComponent, HeaderComponent, SettingComponent, DashboardComponent],
    bootstrap: [AppComponent]
})
export class AppModule { }