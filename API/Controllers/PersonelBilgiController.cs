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
    public class PersonelBilgiController : Controller
    {
        [HttpGet("getall")]
        public string GetAll(string id)
        {
            #region Data
            PersonelBilgiModel personel = new PersonelBilgiModel();
            if (id == "1")
            {
                personel.tc = "33403133358";
                personel.adi = "Yuşa";
                personel.soyadi = "Açıkalın";
                personel.boyu = "Uzun";
                personel.kangrubu = "A-";
            }
            else if (id == "2")
            {
                personel.tc = "17266240750";
                personel.adi = "Adile";
                personel.soyadi = "Karci";
                personel.boyu = "Orta";
                personel.kangrubu = "AB+";
            }
            else if (id == "3")
            {
                personel.tc = "20086321462";
                personel.adi = "Hasan Fatih";
                personel.soyadi = "Kavi";
                personel.boyu = "orta";
                personel.kangrubu = "B+";
            }
            else if (id == "4")
            {
                personel.tc = "22013753520";
                personel.adi = "Serhat";
                personel.soyadi = "Denek";
                personel.boyu = "Kısa";
                personel.kangrubu = "A+";
            }
            else if (id == "5")
            {
                personel.tc = "66364181960";
                personel.adi = "Gökhan";
                personel.soyadi = "Çavdar";
                personel.boyu = "Uzun";
                personel.kangrubu = "0+";
            }
            else if (id == "6")
            {
                personel.tc = "42988766066";
                personel.adi = "Kasım";
                personel.soyadi = "Demirel";
                personel.boyu = "Orta";
                personel.kangrubu = "A+";
            }
            else if (id == "7")
            {
                personel.tc = "23578432936";
                personel.adi = "Yunus";
                personel.soyadi = "Ankut";
                personel.boyu = "Kısa";
                personel.kangrubu = "A-";
            }
            else if (id == "8")
            {
                personel.tc = "10451311242";
                personel.adi = "Tolgay";
                personel.soyadi = "Balcı";
                personel.boyu = "Orta";
                personel.kangrubu = "AB-";
            }
            else if (id == "9")
            {
                personel.tc = "13844486244";
                personel.adi = "Buğra";
                personel.soyadi = "Öçalan";
                personel.boyu = "Uzun";
                personel.kangrubu = "B+";
            }
            else if (id == "10")
            {
                personel.tc = "12312312312";
                personel.adi = "Evrim";
                personel.soyadi = "Mutlu";
                personel.boyu = "Orta";
                personel.kangrubu = "0+";
            }
            else if (id == "11")
            {
                personel.tc = "52426377792";
                personel.adi = "Murat";
                personel.soyadi = "Sayın";
                personel.boyu = "Kısa";
                personel.kangrubu = "A+";
            }
            else if (id == "12")
            {
                personel.tc = "11005133600";
                personel.adi = "Volkan";
                personel.soyadi = "Sarıoğlu";
                personel.boyu = "Orta";
                personel.kangrubu = "AB-";
            }
            else if (id == "13")
            {
                personel.tc = "12312312313";
                personel.adi = "Ahmet";
                personel.soyadi = "Adıgüzel";
                personel.boyu = "Kısa";
                personel.kangrubu = "A-";
            }
            else if (id == "14")
            {
                personel.tc = "12312312314";
                personel.adi = "Mehmet";
                personel.soyadi = "Soyadıgüzel";
                personel.boyu = "Kısa";
                personel.kangrubu = "B+";
            }
            else if (id == "15")
            {
                personel.tc = "12312312315";
                personel.adi = "Ali";
                personel.soyadi = "Akça";
                personel.boyu = "Kısa";
                personel.kangrubu = "0+";
            }
            else if (id == "16")
            {
                personel.tc = "12312312317";
                personel.adi = "Veli";
                personel.soyadi = "Vur";
                personel.boyu = "Kısa";
                personel.kangrubu = "A+";
            }
            else if (id == "17")
            {
                personel.tc = "12312312318";
                personel.adi = "Hüseyin";
                personel.soyadi = "Kur";
                personel.boyu = "Kısa";
                personel.kangrubu = "A-";
            }
            else if (id == "18")
            {
                personel.tc = "12312312319";
                personel.adi = "Canan";
                personel.soyadi = "Yılmaz";
                personel.boyu = "Kısa";
                personel.kangrubu = "AB+";
            }
            #endregion

            return JsonSerializer.Serialize(personel);
        }
    }
}
