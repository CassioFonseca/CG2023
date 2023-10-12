using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CGEntity.EntitiesDbSet;
using CGEntity.Entities;
using CGServer.Context;
using Microsoft.EntityFrameworkCore;

namespace CGServer.Repository
{

    public class RepoFavorecido: BaseRepository<DbSetFavorecido>
    {
        public RepoFavorecido():base()
        {
            
        }

    }

}
