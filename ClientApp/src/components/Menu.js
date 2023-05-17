import React, { Component } from 'react';
import './Menu.css';
export class Menu extends Component {
    static displayName = Menu.name;

    render() {
        return (
            <div className="menu">
                <div className="category">
                    <h2>Drinks</h2>
                    <ul>
                        <li>
                            <h3>Cold Coffee</h3>
                            <p className="description">Intense and aromatic black coffee.</p>
                            <p className="price">$2.00</p>
                            <a href="/ColdCoffee" className="item-link">
                                <button>+</button>
                            </a>
                        </li>
                        <li>
                            <h3>Hot Coffee</h3>
                            <p className="description">Better taste with Chocolate sauce.</p>
                            <p className="price">$2.00</p>
                            <a href="/HotCoffee" className="item-link">
                                <button>+</button>
                            </a>
                        </li>
                        <li>
                            <h3>Blended Coffee</h3>
                            <p className="description">Try me! You will know what satisfying feeling is.</p>
                            <p className="price">$3.00</p>
                            <a href="./Drinks/BlendedCoffee.html" className="item-link">
                                <button>+</button>
                            </a>
                        </li>
                        <li>
                            <h3>Milk Tea</h3>
                            <p className="description">I swear this is better than your ex.</p>
                            <p className="price">$2.25</p>
                            <a href="./Drinks/MilkTea.html" className="item-link">
                                <button>+</button>
                            </a>
                        </li>
                    </ul>
                </div>

                <div className="category">
                    <h2>Foods</h2>
                    <ul>
                        <li>
                            <h3>Bagel</h3>
                            <p className="description">Supa yummy with sweet taste.</p>
                            <p className="price">$3.00</p>
                            <a href="./Foods/Bagel.html" className="item-link">
                                <button>+</button>
                            </a>
                        </li>
                        <li>
                            <h3>Sandwich</h3>
                            <p className="description">Homemade 100% with love.</p>
                            <p className="price">$3.00</p>
                            <a href="./Foods/Sandwich.html" className="item-link">
                                <button>+</button>
                            </a>
                        </li>
                    </ul>
                </div>
            </div>
        );
    }
}
