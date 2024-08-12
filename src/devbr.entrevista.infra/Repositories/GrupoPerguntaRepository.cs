using devbr.entrevista.domain.entities.questionarios;
using DevBr.Entrevista.Domain.Interfaces.Repositories;
using DevBr.Entrevista.Infra.Contents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBr.Entrevista.Infra.Repositories
{
    public class GrupoPerguntaRepository : BaseRepository<GrupoPergunta>, IGrupoPerguntaRepository
    {
        public GrupoPerguntaRepository(EntrevistaDbContent context) : base(context)
        { 

        }
    
    }
}
