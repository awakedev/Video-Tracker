import { BrowserModule } from '@angular/platform-browser';
import { NgModule, InjectionToken } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
 
import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { VideoListComponent } from './video-list/video-list.component';
import { AddVideoComponent } from './add-video/add-video.component';
 
@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    VideoListComponent,
    AddVideoComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: VideoListComponent, pathMatch: 'full' },
      { path: 'addvideo', component: AddVideoComponent }
    ])
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
