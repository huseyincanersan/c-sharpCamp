using MenuItemProject.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace MenuItemProject.Service
{
    public class ListCreator
    {
        private static List<Car> carList;

        public static List<Car> CarList { get => carList; set => carList = value; }

        public static List<Car> getCars()
        {
            CarList = new List<Car>();
            CarList.Add(new Car
            {
                Id=0
            ,
                Brand = "Honda"
            ,
                Model = "Civic"
            ,
                Details = "Honda Civic, Honda tarafından ilk olarak küçük araç olarak üretilmeye başlandı. Küçük araç olarak üretilen Civic, zamanla değişikliklere uğrayarak hem daha lüks hem de boyut olarak daha büyüyerek kompakt araç sınıfına doğru adım atmış oldu. Teknik olarak orta boy bir araç da olsa şu an hala kompakt sınıfında kabul edilir. Honda Civic, günümüzde Honda Accord ve Honda Jazz arasında kalır. 2006 yılı itibarıyla dünya çapında 16,5 milyon satış rakamına ulaşmış, bunun 7,3 milyonu Amerika Birleşik Devletleri'de satılmıştır. Bir dönem Kanada'da en çok satan araç olmuştur."
            ,
                Year = "2019"
            ,
                ImgSource = ImageSource.FromUri(new Uri("https://upload.wikimedia.org/wikipedia/commons/thumb/8/86/2017_Honda_Civic_EX_VTEC_CVT_1.0_Front.jpg/1920px-2017_Honda_Civic_EX_VTEC_CVT_1.0_Front.jpg"))
            }

            );

            CarList.Add(new Car
            {
                Id=1,

                Brand = "Mazda"
        ,
                Model = "6"
        ,
                Details = "Japonya’da bilinen adıyla Mazda Atenza,Japon üretici Mazda tarafından 2002 yılından bu yana üretilen geniş aile otomobilidir. Mazda6, lansmanından bu yana dünya çapında bir milyon ünitenin üzerine satış gerçekleştirmiş ve bu önemli satış kilometre taşına önceki tüm Mazda modellerinden daha hızlı ulaşmıştır.",
                Year = "2013"
        ,
                ImgSource = ImageSource.FromUri(new Uri("https://upload.wikimedia.org/wikipedia/commons/thumb/c/cd/2014_Mazda_6_%28GJ%29_Sports_sedan_%282015-11-07%29_01.jpg/1920px-2014_Mazda_6_%28GJ%29_Sports_sedan_%282015-11-07%29_01.jpg"))
            }

        );
            CarList.Add(new Car
            {
                Id=2,
                Brand = "Seat"
        ,
                Model = "Leon"
        ,
                Details = "İlk iki nesil Leon, Volkswagen Grubu A platformunun iki farklı çeşidini kullandı ve birçok aksamı Volkswagen Grubu otomobiller ile aynıydı. Üçüncü nesil; Audi A3 Mk3, Volkswagen Golf Mk7 ve Škoda Octavia Mk3 tarafından da kullanılan Volkswagen Grubu MQB platformunu kullanır.",
                Year = "2013"
        ,
                ImgSource = ImageSource.FromUri(new Uri("https://upload.wikimedia.org/wikipedia/commons/thumb/c/c0/Seat_Leon_1.4_TSI_Start%26Stop_Style_%28III%29_%E2%80%93_Frontansicht%2C_10._August_2013%2C_Ratingen.jpg/1920px-Seat_Leon_1.4_TSI_Start%26Stop_Style_%28III%29_%E2%80%93_Frontansicht%2C_10._August_2013%2C_Ratingen.jpg"))
            }

        );
            CarList.Add(new Car
            {
                Id= 3,
                Brand = "Toyota"
        ,
                Model = "Supra"
        ,
                Details = ", Toyota tarafından 1978-2002 yılları arasında ve 2019 yılından bu yana üretilen spor otomobil modelidir. Araç, Toyota Celica'nın temelinde geliştirilmiş olup 1986 yılında üçüncü nesli Celica'nın bir parçası olmaktan çıkmış ve bağımsız bir model olmuştur",
                Year = "2019"
        ,
                ImgSource = ImageSource.FromUri(new Uri("https://upload.wikimedia.org/wikipedia/commons/thumb/7/77/Toyota_Supra_GR_Genf_2019_1Y7A5650.jpg/1920px-Toyota_Supra_GR_Genf_2019_1Y7A5650.jpg"))
            }

        );
            CarList.Add(new Car
            {
                Id=4,
                Brand = "Audi"
        ,
                Model = "Q8"
        ,
                Details = "Audi Q8, Audi tarafından 2018 yılından bu yana üretilen bir üst orta sınıf lüks crossover SUV modelidir.[4] Araç, ilk olarak 2017 Kuzey Amerika Uluslararası Otomobil Fuarı'nda tanıtılmış olup[5] başlıca rakipleri BMW X6 ve Mercedes-Benz GLE Coupe'dir."
        ,
                Year = "2018"
        ,
                ImgSource = ImageSource.FromUri(new Uri("https://upload.wikimedia.org/wikipedia/commons/thumb/0/0f/Audi_SQ8_at_IAA_2019_IMG_0308.jpg/1920px-Audi_SQ8_at_IAA_2019_IMG_0308.jpg"))
            }

        );
            CarList.Add(new Car
            {
                Id = 5,
                Brand = "VolksWagen"
   ,
                Model = "Golf"
   ,
                Details = "Volkswagen Golf'ün ilk nesli olan Golf I 1974 yılında üretilmeye başlandı. ABD ve Kanada'da 1975'ten 1984 yılına kadar Volkswagen Rabbit ve Latin Amerika'da Volkswagen Caribe isimleriyle pazara sunuldu.",
                Year = "2012"
   ,
                ImgSource = ImageSource.FromUri(new Uri("https://upload.wikimedia.org/wikipedia/commons/thumb/4/44/VW_Golf_1.6_TDI_BlueMotion_Technology_Comfortline_%28VII%29_%E2%80%93_Frontansicht%2C_31._Dezember_2012%2C_D%C3%BCsseldorf.jpg/1920px-VW_Golf_1.6_TDI_BlueMotion_Technology_Comfortline_%28VII%29_%E2%80%93_Frontansicht%2C_31._Dezember_2012%2C_D%C3%BCsseldorf.jpg"))
            }

   );
            CarList.Add(new Car
            {
                Id=6,
                Brand = "BMW"
   ,
                Model = "850i"
   ,
                Details = "BMW E31, BMW 8 Serisi'nin ilk neslidir. BMW tarafından, 1990'dan 1999'a kadar V8 veya V12 motorla güçlendirilmiş bir grand tourerdır. 1990 yılında orijinal E24 tabanlı 6 Serisi'nin yerini alması sebebiyle, yaygın bir yanılgı olarak 8 Serisinin halefi olarak geliştirildiği yönündeydi. Aslında, 6 Serisi'nden oldukça yüksek bir fiyat ve performansla, farklı bir pazara yönelik tamamen yeni bir model sınıfındaydı.",
                Year = "1999"
   ,
                ImgSource = ImageSource.FromUri(new Uri("https://upload.wikimedia.org/wikipedia/commons/thumb/3/36/BMW_850i_E31_-_Flickr_-_Alexandre_Pr%C3%A9vot_Crop.jpg/1920px-BMW_850i_E31_-_Flickr_-_Alexandre_Pr%C3%A9vot_Crop.jpg"))
            }

   );
            CarList.Add(new Car
            {
                Id=7,
                Brand = "Mercedes"
   ,
                Model = "SL 320"
   ,
                Details = "Mercedes-Benz R129 SL, 1989'dan 2001'e kadar Mercedes-Benz tarafından üretilen bir roadster . R129, 1989'da R107'nin yerini aldı ve 2003 model yılında 2002'de üretilmeye başlanan R230 SL Sınıfı'na yerini bıraktı",
                Year = "2001"
   ,
                ImgSource = ImageSource.FromUri(new Uri("https://upload.wikimedia.org/wikipedia/commons/9/96/Mercedes-Benz_SL_320_%28R_129%2C_1._Facelift%29_%E2%80%93_Frontansicht%2C_9._November_2014%2C_D%C3%BCsseldorf.jpg"))
            }

   );

            return CarList;
        }
    }
}
