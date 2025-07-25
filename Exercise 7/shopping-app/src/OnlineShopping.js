// OnlineShopping.js
import React, { Component } from 'react';
import Cart from './Cart';

class OnlineShopping extends Component {
  render() {
    const CartInfo = [
      { itemname: 'Laptop', price: 20000 },
      { itemname: 'TV', price: 120000 },
      { itemname: 'Washing Machine', price: 50000 },
      { itemname: 'Mobile', price: 30000 },
      { itemname: 'Fridge', price: 70000 }
    ];

    return (
      <div className="mydiv">
        <h1 style={{ textAlign: "center", color: "green" }}>Items Ordered :</h1>
        <Cart item={CartInfo} />
      </div>
    );
  }
}

export default OnlineShopping;
