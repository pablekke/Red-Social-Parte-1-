﻿using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion
{
    public class Comentario:Publicacion, IValidacion
    {
        public Comentario(string titulo, string contenido, Privacidad priv, Miembro autor) :base(titulo, contenido, priv, autor) { }

        public override void EsValido()
        {
            base.EsValido();
        }

        public override int CalcularVA()
        {
            return base.CalcularVA();
        }
    }
}
