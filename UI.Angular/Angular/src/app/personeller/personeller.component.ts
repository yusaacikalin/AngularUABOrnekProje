import { HttpClient } from '@angular/common/http';
import { Component, Input, OnInit } from '@angular/core';
import { PersonelModel } from '../models/personelmodel';


@Component({
  selector: 'app-personeller',
  templateUrl: './personeller.component.html',
  styleUrls: ['./personeller.component.css']
})
export class PersonellerComponent implements OnInit {
  personelList: PersonelModel[] | undefined;
  seciliPersonelId: number | undefined;

  @Input() seciliLimanId: number = 0;

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getPersonel(this.seciliLimanId);
  }

  getPersonel(limanid: number) {
    this.http.get<PersonelModel[]>('https://localhost:44303/api/Personel/getall?id=' + limanid).subscribe(data => this.personelList = data)
  }

  getPersonelBilgileri(personelid: number) {
    if (this.seciliPersonelId == undefined) {
      this.seciliPersonelId = personelid;
    } else {
      this.seciliPersonelId = undefined;
    }
  }

}
