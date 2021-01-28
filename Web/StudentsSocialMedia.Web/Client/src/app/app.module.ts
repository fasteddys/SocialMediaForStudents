import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { FooterComponent } from './shared/footer/footer.component';
import { NavBarComponent } from './shared/nav-bar/nav-bar.component';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { JwtInterceptor } from './core/interceptors/jwt.interceptor';
import { BaseUrlInterceptor } from './core/interceptors/base-url.interceptor';
import { SignInComponent } from './auth/sign-in/sign-in.component';
import { SignUpComponent } from './auth/sign-up/sign-up.component';
import { CommentsListComponent } from './components/comments/comments-list/comments-list.component';
import { CommentsCreateComponent } from './components/comments/comments-create/comments-create.component';
import { HomeListComponent } from './components/home/home-list/home-list.component';
import { HomeCreateComponent } from './components/home/home-create/home-create.component';
import { ProfilesListComponent } from './components/profiles/profiles-list/profiles-list.component';
import { ProfilesCreateComponent } from './components/profiles/profiles-create/profiles-create.component';
import { PostsListComponent } from './components/posts/posts-list/posts-list.component';
import { PostsCreateComponent } from './components/posts/posts-create/posts-create.component';
import { RepliesListComponent } from './components/replies/replies-list/replies-list.component';
import { RepliesCreateComponent } from './components/replies/replies-create/replies-create.component';
import { SettingsListComponent } from './components/settings/settings-list/settings-list.component';
import { SettingsCreateComponent } from './components/settings/settings-create/settings-create.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    FooterComponent,
    NavBarComponent,
    SignInComponent,
    SignUpComponent,
    CommentsListComponent,
    CommentsCreateComponent,
    HomeListComponent,
    HomeCreateComponent,
    ProfilesListComponent,
    ProfilesCreateComponent,
    PostsListComponent,
    PostsCreateComponent,
    RepliesListComponent,
    RepliesCreateComponent,
    SettingsListComponent,
    SettingsCreateComponent,
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    ReactiveFormsModule,
  ],
  providers: [
    { provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true },
    { provide: HTTP_INTERCEPTORS, useClass: BaseUrlInterceptor, multi: true },
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
