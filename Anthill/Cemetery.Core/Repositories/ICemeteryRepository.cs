using Cemetery.Core.Corpses.DTOs;
using System.Collections.Generic;

namespace Cemetery.Core.Repositories
{
    interface ICemeteryRepository
    {
        IReadOnlyCollection<CorpsesDTO> GetCorpses();
    }
}
