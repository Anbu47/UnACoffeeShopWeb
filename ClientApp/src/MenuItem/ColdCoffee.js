import React, { Component } from "react";
import "../styles/style.css";
import { sizeOptions, whippedCreamOptions, milkOptions } from "./Options";

export class ColdCoffee extends Component {
  static displayName = ColdCoffee.name;

  renderOptions = (options) => {
    return options.map((option) => (
      <option key={option.value} value={option.value}>
        {option.label}
      </option>
    ));
  };

  render() {
    return (
      <>
        <h2>Cold Coffee</h2>
        <iframe
          src="https://drive.google.com/file/d/19AYIBSD8_vu2Kt71BgosKrR0nD1JhoZy/preview"
          width="640"
          height="480"
          allow="autoplay"
        ></iframe>
        <p>Refreshing and chilled beverage perfect for hot weather.</p>
        <p>Item Price: $2.00</p>

        <h2>Options</h2>
        <div>
          <label htmlFor="OPTIONS">SIZE: </label>
          <select id="dropdown">{this.renderOptions(sizeOptions)}</select>
        </div>

        <div>
          <label htmlFor="OPTIONS">EXTRA WHIPPED CREAM? </label>
          <select id="dropdown">
            {this.renderOptions(whippedCreamOptions)}
          </select>
        </div>

        <div>
          <label htmlFor="OPTIONS">EXTRA MILK? </label>
          <select id="dropdown">{this.renderOptions(milkOptions)}</select>
        </div>

        <label htmlFor="notes">Special Instructions:</label>
        <textarea id="notes" name="notes"></textarea>

        <a href="./cart">
          <button type="submit">Add to Cart</button>
        </a>
      </>
    );
  }
}
