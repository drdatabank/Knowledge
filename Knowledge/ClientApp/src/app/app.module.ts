import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { ApiAuthorizationModule } from 'src/api-authorization/api-authorization.module';
import { AuthorizeGuard } from 'src/api-authorization/authorize.guard';
import { AuthorizeInterceptor } from 'src/api-authorization/authorize.interceptor';
import { FlipCardComponent } from './flip-card/flip-card.component';
import { CartDetailsComponent } from './flip-card/cart-details.component';
import { ServerComponent } from './server/server.component';
import { ShopComponent } from './shop/shop.component';
import { HeaderComponent } from './shop/header/header.component';
import { RecipesComponent } from './shop/recipes/recipes.component';

import { ShoppingListComponent } from './shop/shopping-list/shopping-list.component';
import { ShoppingEditComponent } from './shop/shopping-list/shopping-edit/shopping-edit.component';

import { DataService } from './shared/dataService';
import { RecipeListComponent } from './shop/recipes/recipe-list/recipe-list.component';
import { RecipeItemComponent } from './shop/recipes/recipe-list/recipe-item/recipe-item.component';
import { RecipeDetailComponent } from './shop/recipes/recipe-detail/recipe-detail.component';



@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FlipCardComponent,
    FetchDataComponent,
    CartDetailsComponent,
    ServerComponent,
    ShopComponent,
    HeaderComponent,
    RecipeListComponent,
    RecipesComponent,
    RecipeDetailComponent,
    RecipeItemComponent,
    ShoppingListComponent,
    ShoppingEditComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ApiAuthorizationModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'flip-card', component: FlipCardComponent },
      { path: 'fetch-data', component: FetchDataComponent, canActivate: [AuthorizeGuard] },
      { path: 'server', component: ServerComponent },
      { path: 'shop', component: ShopComponent },
    ])
  ],
  providers: [
    DataService,
    { provide: HTTP_INTERCEPTORS, useClass: AuthorizeInterceptor, multi: true }
    
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
