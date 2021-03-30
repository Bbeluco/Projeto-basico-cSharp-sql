using System;
using System.Collections.Generic;
using System.Text;

namespace Loja.DTO
{
    public class usuario_DTO
    {
        public int cod_usuario { get; set; }
        public string nome { get; set; }
        public string login { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public DateTime cadastro { get; set; }
        public string situacao { get; set; }
        public int perfil { get; set; }

    }
}
