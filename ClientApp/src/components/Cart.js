import React, { Component } from 'react';
import '../styles/style.css';
export class Cart extends Component {
    static displayName = Cart.name;

    render() {
        return (
            <div>
                <h1>Cart</h1>

                <table>
                    <thead>
                        <tr>
                            <th>No.</th>
                            <th>Item</th>
                            <th>Price</th>
                        </tr>
                    </thead>
                    <tbody>
                        {/* Populate this section dynamically using JavaScript or server-side rendering */}
                        <tr>
                            <td>1</td>
                            <td>Cold Coffee, Size S, Whipped Cream</td>
                            <td>$2.5</td>
                        </tr>
                        <tr>
                            <td>2</td>
                            <td>Bagel</td>
                            <td>$3.00</td>
                        </tr>
                        {/* Add more rows for each item in the cart */}
                    </tbody>
                    <tfoot>
                        <tr>
                            <td colspan="2">Total:</td>
                            <td>$6.50</td> {/* Calculate and display the total dynamically */}
                        </tr>
                    </tfoot>
                </table>

                <a href="/"><button type="submit">Checkout</button></a>
            </div>
        );
    }
}