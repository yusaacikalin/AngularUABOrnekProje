using API.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class PersonelController : Controller
    {
        [HttpGet("getall")]
        public string GetAll(string id)
        {
            #region Data

            List<PersonelModel> model = new List<PersonelModel>();
            if (id == "1")
            {
                PersonelModel personel = new PersonelModel();
                personel.id = 1;
                personel.Adi = "Yuşa";
                personel.Soyadi = "Açıkalın";
                model.Add(personel);
                PersonelModel personel2 = new PersonelModel();
                personel2.id = 2;
                personel2.Adi = "Adile";
                personel2.Soyadi = "Karci";
                model.Add(personel2);
                PersonelModel personel3 = new PersonelModel();
                personel3.id = 3;
                personel3.Adi = "Hasan Fatih";
                personel3.Soyadi = "Kavi";
                model.Add(personel3);
            }
            else if (id == "2")
            {
                PersonelModel personel = new PersonelModel();
                personel.id = 4;
                personel.Adi = "Serhat";
                personel.Soyadi = "Denek";
                model.Add(personel);
                PersonelModel personel2 = new PersonelModel();
                personel2.id = 5;
                personel2.Adi = "Gökhan";
                personel2.Soyadi = "Çavdar";
                model.Add(personel2);
                PersonelModel personel3 = new PersonelModel();
                personel3.id = 6;
                personel3.Adi = "Kasım";
                personel3.Soyadi = "Demirel";
                model.Add(personel3);
            }
            else if (id == "3")
            {
                PersonelModel personel = new PersonelModel();
                personel.id = 7;
                personel.Adi = "Yunus";
                personel.Soyadi = "Ankut";
                model.Add(personel);
                PersonelModel personel2 = new PersonelModel();
                personel2.id = 8;
                personel2.Adi = "Tolgay";
                personel2.Soyadi = "Balcı";
                model.Add(personel2);
                PersonelModel personel3 = new PersonelModel();
                personel3.id = 9;
                personel3.Adi = "Buğra";
                personel3.Soyadi = "Öçalan";
                model.Add(personel3);
            }
            else if (id == "4")
            {
                PersonelModel personel = new PersonelModel();
                personel.id = 10;
                personel.Adi = "Evrim";
                personel.Soyadi = "Mutlu";
                model.Add(personel);
                PersonelModel personel2 = new PersonelModel();
                personel2.id = 11;
                personel2.Adi = "Murat";
                personel2.Soyadi = "Sayın";
                model.Add(personel2);
                PersonelModel personel3 = new PersonelModel();
                personel3.id = 12;
                personel3.Adi = "Volkan";
                personel3.Soyadi = "Sarıoğlu";
                model.Add(personel3);
            }
            else if (id == "5")
            {
                PersonelModel personel = new PersonelModel();
                personel.id = 13;
                personel.Adi = "Ahmet";
                personel.Soyadi = "Adıgüzel";
                model.Add(personel);
                PersonelModel personel2 = new PersonelModel();
                personel2.id = 14;
                personel2.Adi = "Mehmet";
                personel2.Soyadi = "Soyadıgüzel";
                model.Add(personel2);
                PersonelModel personel3 = new PersonelModel();
                personel3.id = 15;
                personel3.Adi = "Ali";
                personel3.Soyadi = "Akça";
                model.Add(personel3);
            }
            else if (id == "6")
            {
                PersonelModel personel = new PersonelModel();
                personel.id = 16;
                personel.Adi = "Veli";
                personel.Soyadi = "Vur";
                model.Add(personel);
                PersonelModel personel2 = new PersonelModel();
                personel2.id = 17;
                personel2.Adi = "Hüseyin";
                personel2.Soyadi = "Kur";
                model.Add(personel2);
                PersonelModel personel3 = new PersonelModel();
                personel3.id = 18;
                personel3.Adi = "Canan";
                personel3.Soyadi = "Yılmaz";
                model.Add(personel3);
            }
            #endregion

            return JsonSerializer.Serialize(model);
        }
    }
}
