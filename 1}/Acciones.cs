using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel; // Agrega esta línea al inicio del archivo

namespace _1_
{
    internal class Acciones
    {
        private List<string> Nombres = new List<string>();

        public List<string> Obtenernombre()
        {
            return Nombres; 

        }


        public bool AgregarNombre(string nombre)
        {
            try
            {
                Nombres.Add(nombre);
                    return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

                public bool Eliminarnombres(string nombre)
                {
                    try
                    {
                        if (Nombres.Contains(nombre))
                        {
                            Nombres.Remove(nombre);
                            return true;
                        }
                        else
                        {
                            return false;
                         }
                    }
                        
                    catch (Exception)
                    {
                        return false; 
                    }
                }

                public bool ExportarNombresAExcel(string rutaArchivo)
                {
                    try
                    {
                        using (var workbook = new XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("Nombres");
                            worksheet.Cell(1, 1).Value = "Nombre";

                            for (int i = 0; i < Nombres.Count; i++)
                            {
                                worksheet.Cell(i + 2, 1).Value = Nombres[i];
                            }

                            workbook.SaveAs(rutaArchivo);
                        }
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
}
    }