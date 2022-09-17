import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-my-day',
  templateUrl: './my-day.component.html',
  styleUrls: ['./my-day.component.css']
})
export class MyDayComponent implements OnInit {
  
  time: number = 0;
  display ;
  interval;
  constructor() { }

  ngOnInit(): void {
  }

  startTimer() {
    console.log("=====>");
    this.interval = setInterval(() => {
      if (this.time === 0) {
        this.time++;
      } else {
        this.time++;
      }
      this.display=this.transform( this.time)
    }, 1000);
  }
  transform(value: number): string {
    var sec_num = value; 
    var hours   = Math.floor(sec_num / 3600);
    var minutes = Math.floor((sec_num - (hours * 3600)) / 60);
    var seconds = sec_num - (hours * 3600) - (minutes * 60);


    return hours+':'+minutes+':'+seconds;           
  }
  pauseTimer() {
    clearInterval(this.interval);
  }

}
