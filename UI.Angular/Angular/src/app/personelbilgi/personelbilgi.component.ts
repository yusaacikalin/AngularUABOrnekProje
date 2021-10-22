import { HttpClient } from '@angular/common/http';
import { Component, Input, OnInit } from '@angular/core';
import { PersonelBilgiModel } from '../models/personelbilgimodel';

@Component({
  selector: 'app-personelbilgi',
  templateUrl: './personelbilgi.component.html',
  styleUrls: ['./personelbilgi.component.css']
})
export class PersonelbilgiComponent implements OnInit {
  personelBilgi: PersonelBilgiModel = { adi: "", soyadi: "", boyu: "", kangrubu: "", tc: "" };

  @Input() PersonelId: number = 0;

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getPersonelBilgi(this.PersonelId);
  }

  getPersonelBilgi(personelId: number) {
    this.http.get<PersonelBilgiModel>('https://localhost:44303/api/PersonelBilgi/getall?id=' + this.PersonelId).subscribe(data => this.personelBilgi = data)
  }
}
