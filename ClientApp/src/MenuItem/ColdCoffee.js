﻿import React, { Component } from 'react';
import '../styles/style.css';
export class ColdCoffee extends Component {
    static displayName = ColdCoffee.name;
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
                    <select id="dropdown">
                        <option value="0">Size S</option>
                        <option value="1">Size M</option>
                        <option value="2">Size L</option>
                        <option value="3">Size XL</option>
                    </select>
                </div>

                <div>
                    <label htmlFor="OPTIONS">EXTRA WHIPPED CREAM? </label>
                    <select id="dropdown">
                        <option value="0">No</option>
                        <option value="1">Yes</option>
                    </select>
                </div>

                <div>
                    <label htmlFor="OPTIONS">EXTRA MILK? </label>
                    <select id="dropdown">
                        <option value="0">No</option>
                        <option value="1">Whole Milk</option>
                        <option value="2">Almond Milk</option>
                    </select>
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