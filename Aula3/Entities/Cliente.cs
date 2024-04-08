using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3.Entities
{
    public class Cliente
    {
        #region Propriedades

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }

        #endregion

        #region Relacionamentos

        public Endereco Endereco { get; set; }

        #endregion
    }
}
