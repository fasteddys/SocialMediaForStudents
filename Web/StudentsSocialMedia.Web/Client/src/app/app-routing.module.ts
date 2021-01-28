import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { SignInComponent } from './auth/sign-in/sign-in.component';
import { SignUpComponent } from './auth/sign-up/sign-up.component';
import { CommentsCreateComponent } from './components/comments/comments-create/comments-create.component';
import { CommentsListComponent } from './components/comments/comments-list/comments-list.component';
import { HomeCreateComponent } from './components/home/home-create/home-create.component';
import { HomeListComponent } from './components/home/home-list/home-list.component';
import { PostsCreateComponent } from './components/posts/posts-create/posts-create.component';
import { PostsListComponent } from './components/posts/posts-list/posts-list.component';
import { ProfilesCreateComponent } from './components/profiles/profiles-create/profiles-create.component';
import { ProfilesListComponent } from './components/profiles/profiles-list/profiles-list.component';
import { RepliesCreateComponent } from './components/replies/replies-create/replies-create.component';
import { RepliesListComponent } from './components/replies/replies-list/replies-list.component';
import { SettingsCreateComponent } from './components/settings/settings-create/settings-create.component';
import { SettingsListComponent } from './components/settings/settings-list/settings-list.component';
import { HomeComponent } from './home/home.component';

const routes: Routes = [
  { path: '', pathMatch: 'full', component: HomeComponent },
  { path: 'sign-in', pathMatch: 'full', component: SignInComponent },
  { path: 'sign-up', pathMatch: 'full', component: SignUpComponent },
  {
    path: 'comments', children: [
      { path: '', component: CommentsListComponent },
      { path: 'all', component: CommentsListComponent },
      { path: 'create', component: CommentsCreateComponent },
    ]
  },
  {
    path: 'home', children: [
      { path: '', component: HomeListComponent },
      { path: 'all', component: HomeListComponent },
      { path: 'create', component: HomeCreateComponent },
    ]
  },
  {
    path: 'profiles', children: [
      { path: '', component: ProfilesListComponent},
      { path: 'all', component: ProfilesListComponent },
      { path: 'create', component: ProfilesCreateComponent },
    ]
  },
  {
    path: 'posts', children: [
      { path: '', component: PostsListComponent },
      { path: 'all', component: PostsListComponent },
      { path: 'create', component: PostsCreateComponent },
    ]
  },
  {
    path: 'replies', children: [
      { path: '', component: RepliesListComponent },
      { path: 'all', component: RepliesListComponent },
      { path: 'create', component: RepliesCreateComponent },
    ]
  },
  {
    path: 'settings', children: [
      { path: '', component: SettingsListComponent },
      { path: 'all', component: SettingsListComponent },
      { path: 'create', component: SettingsCreateComponent },
    ]
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
