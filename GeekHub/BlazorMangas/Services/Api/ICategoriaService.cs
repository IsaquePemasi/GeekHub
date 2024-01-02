using BlazorMangas.Models.DTOs;

namespace BlazorMangas.Services.Api;
public interface ICategoriaService
{
    Task<List<CategoriaDTO>> GetCategorias();
    Task<CategoriaDTO> GetCategoria(int id);
}
