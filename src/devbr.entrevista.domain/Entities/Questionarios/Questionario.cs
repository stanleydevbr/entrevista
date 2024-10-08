﻿using DevBr.Core.Dominio.Entidades;

namespace devbr.entrevista.domain.entities.questionarios
{
    public class Questionario : Entity<Questionario>
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool Status { get; set; }
        public List<Pergunta> Perguntas { get; set; }

        public override bool EhValido()
        {
            throw new NotImplementedException();
        }
    }
}
