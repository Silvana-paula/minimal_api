using MinimalApi.Dominio.Entidades;
using MinimalApi.DTOs;


namespace MinimalApi.Dominio.Interfaces
{
    public interface IAdministradorServico
    {
        Administrador? BuscarPorId(int id);
        Administrador Incluir(Administrador administrador);
        List<Administrador> Todos(int? pagina);
        Administrador? Login(LoginDTO loginDTO);
    }
}
