namespace Libros1.Controllers
{
    using System.Collections.Generic;
    using Libros1.Models;
    class LibroController
    {
        private LibroModel modeloLibro = new LibroModel();

        public List<LibroModel> todos()
        {
            return modeloLibro.todos();
        }
        public LibroModel uno(LibroModel libro)
        {
            return modeloLibro.uno(libro);
        }
        public string insertar(LibroModel libro)
        {
            return modeloLibro.insertar(libro);
        }
        public string actualziar(LibroModel libro)
        {
            return modeloLibro.actualizar(libro);
        }
        public string eliminar(LibroModel libro)
        {
            return modeloLibro.eliminar(libro);
        }
    }
}
