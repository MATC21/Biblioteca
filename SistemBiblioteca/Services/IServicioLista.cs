using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace SistemBiblioteca.Services
{
    public interface IServicioLista 
    {
        Task<List<SelectListItem>> GetListAutor();
        Task<List<SelectListItem>> GetListCategoria();
    }
}
