using DevBr.Entrevista.Application.Interfaces.Applications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBr.Entrevista.Application.Services
{
    public class CandidatoAppService : ICandidatoAppService
    {

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
