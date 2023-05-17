import { Menu } from "./components/Menu";
import { Cart } from "./components/Cart";
import { Home } from "./components/Home";
import { ColdCoffee } from "./MenuItem/ColdCoffee";

const AppRoutes = [
  {
    path: "/",
    element: <Home />
  },
  {
      path: '/menu',
    element: <Menu />
  },
  {
      path: '/cart',
    element: <Cart />
    },
    {
        path: "/coldcoffee",
        element: <ColdCoffee />
    },
];

export default AppRoutes;
