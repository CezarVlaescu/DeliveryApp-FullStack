import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class OrderDetailsService {

  constructor() { }

  fooddetails = [
    {
      id : 1,
      name : "Carbonara Pasta",
      description: "Our special italian food",
      price : 9.99,
      image : "https://images.unsplash.com/photo-1560434019-4558f9a9e2a1?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=387&q=80",
      restaurantby : "Marty"
    },
    {
      id : 2,
      name : "American Bucket",
      description: "Delicious Chicken",
      price : 19.99,
      image : "https://images.unsplash.com/photo-1513639776629-7b61b0ac49cb?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=867&q=80",
      restaurantby : "KFC"
    },
    {
      id : 3,
      name : "Oreo Cheesecake",
      description: "Oreo desert for hot days",
      price : 50.99,
      image : "https://res.cloudinary.com/swiggy/image/upload/fl_lossy,f_auto,q_auto,w_1024/wtj8esaeslvlscv8glj6",
      restaurantby : "LolitaIceCream"
    },
    {
      id : 4,
      name : "BigMac Menu",
      description: "Our main menu with french fries and cold soda ",
      price : 15.99,
      image : "https://images.unsplash.com/photo-1619881589316-56c7f9e6b587?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=774&q=80",
      restaurantby : "McDonalds"
    },
    {
      id : 5,
      name : "Masala Roll",
      description: "A mix with mashed potatos and veggies",
      price : 4.99,
      image : "https://res.cloudinary.com/swiggy/image/upload/fl_lossy,f_auto,q_auto,w_1024/l2ng6gtge30sqaafqng7",
      restaurantby : "Wok&Roll"
    },

  ]
}
