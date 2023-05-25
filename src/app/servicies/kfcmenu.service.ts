import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class KfcmenuService {

  constructor() { }

  fooddetails = [
    {
      id : 1,
      name : "Smart Menu",
      description: "Student best friend, all you need to not get hungry",
      price : 9.99,
      image : "https://plus.unsplash.com/premium_photo-1683657860371-8934e8feca70?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=387&q=80",
    },
    {
      id : 2,
      name : "American Bucket",
      description: "Feel like an American with our bucket full of chicken and some french fries",
      price : 19.99,
      image : "https://images.unsplash.com/photo-1513639776629-7b61b0ac49cb?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=867&q=80",
    },
    {
      id : 3,
      name : "Dublu Booster",
      description: "Ingredients : bread, one buc of chicken, salad, our special sauce",
      price : 3.99,
      image : "https://images.unsplash.com/photo-1523798724321-364e1951df59?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=389&q=80",
    }]
}
