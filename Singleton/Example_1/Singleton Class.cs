using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Example_1
{
   public class Singleton_Class
   {
        private Singleton_Class()
        {
            //Constructor methodunu private yaptığımız için bu sınıfın örneklemini uygulamadaki başka bir sınıfta alamayacağız
        }
        //Yukarıda constructor private yaptık ve bu sınıfın dışarıda new'lenmesini yani örneklem , instance alınmasını engelledik. Peki bu sınıfın yeteneklerinden nasıl faydalanacağız. 
        private static Singleton_Class _singleton_Class;
        //Yukarıdaki Singleton tipindeki _sigleton_Class isimli değişkenim sınıfımın özelliklerini kullanamda aban yardım edecek , bu değişkenin üzerinden istance alınacak ve 

        //Aşağaıda oluşturduğum Bana Singleton_Class(sınıfımla aynı tip) tipinde dönüş yapacak method eğer _sigleton_Class değişkenim boş ise ona instance alacak değil ise zaten daha önce aldığı instance'i geri döndürecek
        public static Singleton_Class Instance()
        {
            if (_singleton_Class == null)
            {
                //Sınıfın nesnesini sınıfın içerisinde bir şarta bağlı olarak ürettik. Burada nesne üretilecek ve üretilen bu nesne bize aşağıda dönülecek. Ayrıca "_singleton_Class" koyduğumuz if bloğu sayesinde birkez üretilecek ve birdaha üretilmeyecek. Uygulama yaşadığı sürece bu nesne kullanılacak.
                _singleton_Class = new Singleton_Class();
            }
            //"_singleton_Class" nesnesi zaten dolu ise onu hemen bana return edecek.
            return _singleton_Class;    
        }

        //Aşağıdaki instance methoda sadece sınıfınların instance alındığında erişilebilir olduğunu biliyoruz. Lakin burada bu sınıfın insatance alınamayacak. O halde bu methoda yukarı kurmuş oludğumuz sistem üzerinden erişebileceğiz.

        public int Toplam(int s1, int s2)
        {
                return s1 + s2;
        }
        

    }
}
