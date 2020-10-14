﻿namespace CL.Core.Shared.ModelViews
{
    public class NovoEndereco
    {
        ///<example>49000000</example>
        public int CEP { get; set; }

        ///<example>SE</example>
        public string Estado { get; set; }

        ///<example>Aracaju</example>
        public string Cidade { get; set; }

        ///<example>Rua A</example>
        public string Logradouro { get; set; }

        ///<example>15</example>
        public string Numero { get; set; }

        ///<example>Ao lado do posto</example>
        public string Complemento { get; set; }
    }
}