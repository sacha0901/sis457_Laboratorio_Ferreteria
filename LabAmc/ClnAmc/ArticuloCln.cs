using CadAmc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace ClnAmc
{
    public class ArticuloCln
    {
        public static int insertar(Articulo producto) // INSERT INTO Articulo VALUES (..., ...)
        {
            using (var contexto = new LabAmcEntities())
            {
                contexto.Articulo.Add(producto);
                contexto.SaveChanges();
                return producto.id;
            }
        }

        public static int actualizar(Articulo producto) // UPDATE Articulo SET campo=valor,... WHERE id = id
        {
            using (var contexto = new LabAmcEntities())
            {
                var existente = contexto.Articulo.Find(producto.id);
                existente.codigo = producto.codigo;
                existente.descripcion = producto.descripcion;
                existente.precio = producto.precio;
                existente.unidad= producto.unidad;
                existente.existenciaMaxima = producto.existenciaMaxima;
                existente.existenciaMinima = producto.existenciaMinima;
                existente.usuarioRegistro = producto.usuarioRegistro;
                return contexto.SaveChanges();
            }
        }

        public static int eliminar(int id, string usuarioRegistro) // UPDATE Articulo SET registroActivo=false, usuarioRegistro=valor WHERE id=id
        {
            using (var contexto = new LabAmcEntities())
            {
                var existente = contexto.Articulo.Find(id);
                existente.registroActivo = false;
                existente.usuarioRegistro = usuarioRegistro;
                return contexto.SaveChanges();
            }
        }

        public static Articulo get(int id) // SELECT * FROM Articulo WHERE id = id
        {
            using (var contexto = new LabAmcEntities())
            {
                return contexto.Articulo.Find(id);
            }
        }

        public static List<Articulo> listar() // SELECT * FROM Articulo WHERE registroActivo=true
        {
            using (var contexto = new LabAmcEntities())
            {
                return contexto.Articulo.Where(x => x.registroActivo.Value).ToList();
            }
        }

        public static List<paArticuloListar_Result> listarPa(string parametro) // EXEC paProductoListar 'valor'
        {
            using (var contexto = new LabAmcEntities())
            {
                return contexto.paArticuloListar(parametro).ToList();
            }
        }
    }
}
