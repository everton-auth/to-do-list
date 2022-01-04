import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-Layout',
  templateUrl: './Layout.component.html',
  styleUrls: ['./Layout.component.scss']
})
export class LayoutComponent implements OnInit {
  user: any = "Everton Auth";
  constructor() { }

  ngOnInit() {
  }

}
