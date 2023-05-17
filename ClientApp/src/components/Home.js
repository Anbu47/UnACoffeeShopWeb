import React, { Component } from 'react';
import '../styles/style.css';
export class Home extends Component {
  static displayName = Home.name;

  render() {
    return (
        <div>
            {/*<header>*/}
            {/*    <nav>*/}
            {/*        <ul classname="nav-links">*/}
            {/*            <li><a href="index.js">home</a></li>*/}
            {/*            <li><a href="menu.js">menu</a></li>*/}
            {/*            <li><a href="cart.js">cart</a></li>*/}
            {/*        </ul>*/}
            {/*    </nav>*/}
            {/*</header>*/}

            <main>
                <div className="profile">
                    <h1>Welcome to Gemo Coffee Shop</h1>
                    <p className="description">Passion meets perfection in every cup.</p>
                </div>
                <a href="/menu" className="menu-link">
                    <button>Check Menu</button>
                </a>
            </main>
        </div>
        );
    }
}
