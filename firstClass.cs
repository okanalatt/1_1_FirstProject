using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_1_FirstProject
{
    internal class firstClass
    {
        public firstClass()
        {
            //Bu birinci sınıfın yapıcı metodu
            //Bu bir yapıcı metot, sınıfın bir örneği oluşturulduğunda otomatik olarak çağrılır.
        }
        #region Property Örnekleri
        public int PropertyOrnek { get; set; } // Public property with get and set accessors
        #endregion
        #region Property ve Field Örnegi
        private int _fieldOrnek; // Private field
        public int fieldOrnek
        {
            get { return _fieldOrnek; } // Getter for the field
            set { _fieldOrnek = value; } // Setter for the field
        }
        #endregion
        enum Myenum
        {
            Eleman1, // Enum member 1
            Eleman2 // Enum member 2
        }
    }
}
