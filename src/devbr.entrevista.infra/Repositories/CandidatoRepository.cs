using devbr.entrevista.domain.entities;
using DevBr.Entrevista.Domain.Interfaces.Repositories;
using DevBr.Entrevista.Infra.Contents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBr.Entrevista.Infra.Repositories
{
    public class CandidatoRepository: BaseRepository<Candidato>, ICandidatoRepository
    {
        public CandidatoRepository(EntrevistaDbContent context) : base(context)
        {
        }    
    }
}
