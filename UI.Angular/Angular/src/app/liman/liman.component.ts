import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { LimanModel } from '../models/limanmodel';

@Component({
  selector: 'app-liman',
  templateUrl: './liman.component.html',
  styleUrls: ['./liman.component.css']
})
export class LimanComponent implements OnInit {
  limanList: LimanModel[] | undefined;
  seciliLimanId: number | undefined;

  constructor(private http: HttpClient) { }


  ngOnInit(): void {
    this.getLiman();
  }

  getLiman() {
    this.http.get<LimanModel[]>('https://localhost:44303/api/liman/getall').subscribe(data => this.limanList = data)
  }

  getPersonel(limanid: number) {
    if (this.seciliLimanId == undefined) {
      this.seciliLimanId = limanid;
    } else {
      this.seciliLimanId = undefined;
    }
  }

}
