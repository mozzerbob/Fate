import { Component, OnInit } from '@angular/core';
import {MaterialModule} from '../material/material.module';

@Component({
  selector: 'app-play-area',
  templateUrl: './play-area.component.html',
  styleUrls: ['./play-area.component.css']
})
export class PlayAreaComponent implements OnInit {

  LandingPage = "Landing Page";

  constructor() { }

  ngOnInit() {
  }

}
