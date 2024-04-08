using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3.Entities
{
    public class Endereco
    {
        #region Propriedades

        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string Uf { get; set; }
        public string Cep { get; set; }

        #endregion

        #region Relacionamentos

        public Cliente Cliente { get; set; }

        #endregion
    }
}
