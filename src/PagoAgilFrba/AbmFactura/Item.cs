using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.AbmFactura
{
    public class Item
    {         

        public String nombreItem;
        public Decimal montoItem;
        public Int16 cantidadItem;

        public Item(String nombre, Decimal monto, Int16 cantidad) {

            nombreItem = nombre;
            montoItem = monto;
            cantidadItem = cantidad;
        }

    }
}
