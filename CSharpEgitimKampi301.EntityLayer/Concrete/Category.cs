using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; }//(classNameId) Eğer bu property'nin adı sınıf ile aynı olmazsa sql tarafında primery key olmaz ve otomatik olarak artmaz
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
        public List<Product> Products { get; set; }

    }
}


/*
 Field-Variable-Property
 */
/*
public class className{
    int x;  --> Field (Alan)
    public int y  { get;  set; }  --> Property (Özellik)
    
    public void metod(){
        int z;  --> Variable (Değişken)
    }
 }
 */