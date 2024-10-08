﻿using DevBr.Entrevista.Application.ViewsModels.Questionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBr.Entrevista.Application.ViewsModels.Entrevistas
{
    public class RespostaViewModel
    {
        public Guid Id { get; set; }
        public string Pergunta { get; set; }
        public string RespostaCandidato { get; set; }
        public string RespostaEsperada { get; set; }
        public NivelConhecimentoViewModel NivelConhecimento { get; set; }
        public RelatorioViewModel Relatorio { get; set; }
        public GrupoViewModel GrupoPergunta { get; set; }


    }
}
