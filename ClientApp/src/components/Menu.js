import React, { Component } from "react";
import "./Menu.css";

class MenuItem extends Component {
  render() {
    const { title, description, price, link } = this.props;

    return (
      <li>
        <h3>{title}</h3>
        <p className="description">{description}</p>
        <p className="price">{price}</p>
        <a href={link} className="item-link">
          <button>+</button>
        </a>
      </li>
    );
  }
}

export class Menu extends Component {
  static displayName = "Menu";

  render() {
    return (
      <div className="menu">
        <div className="category">
          <h2>Drinks</h2>
          <ul>
            <MenuItem
              title="Cold Coffee"
              description="Intense and aromatic black coffee."
              price="$2.00"
              link="/ColdCoffee"
            />
            <MenuItem
              title="Hot Coffee"
              description="Better taste with Chocolate sauce."
              price="$2.00"
              link="/HotCoffee"
            />
            <MenuItem
              title="Blended Coffee"
              description="Try me! You will know what satisfying feeling is."
              price="$3.00"
              link="/Drinks/BlendedCoffee.html"
            />
            <MenuItem
              title="Milk Tea"
              description="I swear this is better than your ex."
              price="$2.25"
              link="/Drinks/MilkTea.html"
            />
          </ul>
        </div>

        <div className="category">
          <h2>Foods</h2>
          <ul>
            <MenuItem
              title="Bagel"
              description="Supa yummy with sweet taste."
              price="$3.00"
              link="/Foods/Bagel.html"
            />
            <MenuItem
              title="Sandwich"
              description="Homemade 100% with love."
              price="$3.00"
              link="/Foods/Sandwich.html"
            />
          </ul>
        </div>
      </div>
    );
  }
}
