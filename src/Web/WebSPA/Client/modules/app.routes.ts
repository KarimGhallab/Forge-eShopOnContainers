import { RouterModule, Routes } from "@angular/router";
import { BasketComponent } from "./basket/basket.component";
import { CatalogComponent } from "./catalog/catalog.component";

export const routes: Routes = [
  { path: "", redirectTo: "catalog", pathMatch: "full" },
  { path: "basket", component: BasketComponent },
  { path: "catalog", component: CatalogComponent },
  
  
  
];

export const routing = RouterModule.forRoot(routes);
