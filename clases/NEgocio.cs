using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INYECTOR.clases;
namespace INYECTOR.clases
{
    public class claseNegocio
    {
        private gDatos objData = new gDatos();

        public int AgregarDatos(string Procedure, params object[] Argumentos)
        {
            return objData.Ejecutar(Procedure, Argumentos);
        }
        public DataSet MostraDatos(string Procedure, params object[] Argumentos)
        {
            // aqui extrae datos para la consulta 
            return objData.TraerDataset(Procedure, Argumentos);
        }
    }

}
