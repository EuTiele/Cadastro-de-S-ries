using System.Collections.Generic;

namespace Cadastro_de_S_ries.Interfaces.Classes
{
    public interface IRepositorio<T>
    {
          List<T> Lista();
        T RetornaPorId(int id);        
        void Insere(T entidade);        
        void Exclui(int id);        
        void Atualiza(int id, T entidade);
        int ProximoId();
    }
}