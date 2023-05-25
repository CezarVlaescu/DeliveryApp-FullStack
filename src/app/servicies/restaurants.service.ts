import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class RestaurantsService {

  constructor() { }

  restaurantdetails = [
    {
      id : 1,
      name : "Marty",
      description: "We deliver the best food in town, for everyone, anytime", 
      image : "https://images.unsplash.com/photo-1517248135467-4c7edcad34c4?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1170&q=80",
      isActive : true,
      standardDeliveryMaxDist : 150,
      standardDeliveryPrice : 20,
      openHour : 8,
      closedHour : 20,
      dayProgram : "Monday to Sunday"
    },
    {
      id : 2,
      name : "KFC",
      description: "Our chicken is the best, the delivery too", 
      image : "https://images.unsplash.com/photo-1637851682487-fa13fce5150f?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=527&q=80",
      isActive : true,
      standardDeliveryMaxDist : 120,
      standardDeliveryPrice : 30,
      openHour : 10,
      closedHour : 22,
      dayProgram : "Monday to Sunday"
    },
    {
      id : 3,
      name : "McDonalds",
      description: "Get your favorite burgers from here", 
      image : "https://images.unsplash.com/photo-1583779791512-eeccdee5c5dd?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1170&q=80",
      isActive : true,
      standardDeliveryMaxDist : 20,
      standardDeliveryPrice : 50,
      openHour : 9,
      closedHour : 23,
      dayProgram : "Monday to Sunday"
    },
    {
      id : 4,
      name : "Wok&Roll",
      description: "Your indian couisine, with special delivery one click from you", 
      image : "https://images.unsplash.com/photo-1563379926898-05f4575a45d8?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1170&q=80",
      isActive : true,
      standardDeliveryMaxDist : 250,
      standardDeliveryPrice : 10,
      openHour : 10,
      closedHour : 20,
      dayProgram : "Monday to Friday",
      closedProgram : "Weekend"
    },
    {
      id : 5,
      name : "Lolita IceCream",
      description: "Get your deserts and your smile on your face", 
      image : "https://images.unsplash.com/photo-1625758600922-4085dd859395?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=387&q=80",
      isActive : true,
      standardDeliveryMaxDist : 50,
      standardDeliveryPrice : 5,
      openHour : 11,
      closedHour : 19,
      dayProgram : "Monday to Friday",
      closedProgarm : "Weekend"
    },

  ]
}
