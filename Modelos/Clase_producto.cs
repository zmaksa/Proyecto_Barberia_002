
//acuerdate de ponerle eso jej;
using CsvHelper;

using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Text;

namespace Proyecto_Barberia_002
{
    public class Clase_Producto
    {

        //la clase era CLIENTE



        private readonly string rutaArchivo = "productos.csv";


        //Con "DeClase" me refiero a que son de esta clase "Clase_Producto".

        //este es el numero de cuenta xd
        public int IdDelProducto_DeClase { get; set; }

        public string NombreDelProducto_DeClase { get; set; }

        public int CantidadDelProducto_DeClase { get; set; }

        public double PrecioDelProducto_DeClase { get; set; }



        //LEER PERO TODO DEL CSV.
        //ESTE CREA EL ARCHIVO CSV SI NO EXISTE, SI EXISTE LEE TODO LO ANTERIOR QUE TENÍA
        //Y ESO SE PUEDE USAR EN LAS OTTRAS FUNCIONES DE ADELANTE.

        public List<Clase_Producto> LeerTodo()
        {
            //Revisar si el archivo existe
            if (!File.Exists(rutaArchivo)) return new List<Clase_Producto>(); //Sino existe, retornar una lista vacía
            using var reader = new StreamReader(rutaArchivo); //Si existe, leer el archivo
                                                              // Configurar el CsvReader con la cultura invariante
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            // Leer los registros del archivo CSV y convertirlos a una lista de objetos Cliente >Aqui es Producto
            List<Clase_Producto> registros = csv.GetRecords<Clase_Producto>().ToList();

            // Retornar la lista de registros
            return registros;
        }



        //GUARDAR CAMBIOS AL CSV.
        //ESCRIBE LOS REGISTROS DE LA LISTA EN EL ARCHIVO CSV, REEMPLAZANDO EL CONTENIDO ANTERIOR.
        private void GuardarCambios(List<Clase_Producto> lista)
        {
            using var writer = new StreamWriter(rutaArchivo); // Abrir el archivo para escritura
            using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
            csv.WriteHeader<Clase_Producto>(); // Escribir el encabezado del CSV
            csv.NextRecord(); // Mover al siguiente registro

            csv.WriteRecords(lista); // Escribir los registros de la lista en el archivo CSV
        }


        //LEER DATOS ASI NORMAL NOSE XD.
        //AQUI EL QUE DICE "cuenta" ES EL PRODUCTO Y EL NUMERO DE CUENTA ES IDDELPRODUCTO.
        public Clase_Producto? Leer(int cuenta) // Read
        {
            List<Clase_Producto> lista = LeerTodo();
            Clase_Producto? cliente = lista.FirstOrDefault(cliente => cliente.IdDelProducto_DeClase == cuenta);// Buscar el producto por id

            //aqui cliente sería el producto encontrado, no le cambié el nombre xdd.
            return cliente;
        }





        //CREAR PRODUCTO A LA LISTA LLAMADA "lista".
        public void Crear(Clase_Producto nuevo) //Create
        {
            List<Clase_Producto> lista = LeerTodo();

            // Verificar si el producto ya existe
            if (Leer(nuevo.IdDelProducto_DeClase) != null)
            {
                throw new Exception("El producto ya existe.");
            }
            lista.Add(nuevo);
            GuardarCambios(lista);
        }



        //ACTUALIZAR LISTA CREO.
        public void Modificar(Clase_Producto modificado) // Update
        {
            List<Clase_Producto> lista = LeerTodo();
            int index = lista.FindIndex(cliente => cliente.IdDelProducto_DeClase == modificado.IdDelProducto_DeClase);
            if (index >= 0)
            {
                lista[index] = modificado;
                GuardarCambios(lista);
            }
            else
            {
                throw new Exception("El producto no existe.");
            }
        }


        //ELIMINAR PRODUCTO.
        public void Eliminar(int cuenta) // Delete
        {
            List<Clase_Producto> lista = LeerTodo();
            lista.RemoveAll(cliente => cliente.IdDelProducto_DeClase == cuenta);
            GuardarCambios(lista);
        }
    }
}