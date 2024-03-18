using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sistema_Supermercado_BE
{
    public class Mercaderias
    {
        public DataTable ListaDT { get; set; } = new DataTable();

        //Crea la estructura de la lista de mercaderia
        public Mercaderias()
        {
            ListaDT.TableName = "ListaMercaderias";
            ListaDT.Columns.Add("NombredelaMercaderia");
            ListaDT.Columns.Add("Codigo");
            ListaDT.Columns.Add("MetododePago");

            LeerArchivo();
        }


        public void LeerArchivo()
        {
            if (System.IO.File.Exists("Mercaderias.xml"))
            {
                ListaDT.ReadXml("Mercaderias.xml");
            }
        }
        //inserta un nuevo usuario en la lista usuarios
        public void InsertMercaderia(Mercaderia aMercaderia)
        {
            ListaDT.Rows.Add(); //AGREGO RENGLON VACIO
            int NuevoRenglon = ListaDT.Rows.Count - 1;
            ListaDT.Rows[NuevoRenglon]["NombredelaMercaderia"] = aMercaderia.NombredelaMercaderia;
            ListaDT.Rows[NuevoRenglon]["Codigo"] = aMercaderia.Codigo;
            ListaDT.Rows[NuevoRenglon]["MetododePago"] = aMercaderia.MetodoDePago;

            ListaDT.WriteXml("Mercaderias.xml");
        }
    }
}
