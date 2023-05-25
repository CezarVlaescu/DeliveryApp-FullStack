import { Component, OnInit } from '@angular/core';
import { RestaurantsService } from 'src/app/servicies/restaurants.service';

@Component({
  selector: 'app-restaurants',
  templateUrl: './restaurants.component.html',
  styleUrls: ['./restaurants.component.css']
})
export class RestaurantsComponent implements OnInit {
  constructor(private service:RestaurantsService) { }
  restaurantsData:any;
  ngOnInit(): void {
      this.restaurantsData = this.service.restaurantdetails;
  }
  getRestaurantStatus() : string {
    const currentDateTime = new Date();
    const currentDay = currentDateTime.getDay();
    const currentHour = currentDateTime.getHours();

    if(currentDay === 0 || currentDay === 6){
      return 'Closed';
    }
    const openingHour = this.restaurantsData.openHour;
    const closingHour = this.restaurantsData.closedHour;

    if(currentHour < openingHour || currentHour > closingHour){
      return 'Closed';
    }
    return 'Open now!'
  }

  // method to check if the restaurant is closed and not able to access the menu
  //isRestaurantClosed(restaurantsData:RestaurantsService) : boolean{
    //const status = this.RestaurantsService.getRestaurantStatus(restaurantsData);
    //return status !== 'Open now';
  //}

}
