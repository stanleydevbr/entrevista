using DevBr.Core.Aplicacao.Services;
using DevBr.Entrevista.Application.Interfaces.Applications;
using DevBr.Entrevista.Application.ViewsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBr.Entrevista.Application.Services
{
    public class CandidatoAppService : AppServiceCore<CandidatoViewModel>, ICandidatoAppService
    {

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
