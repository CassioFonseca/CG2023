using CGEntity.Entities;
using CGServer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGDomain.UsesCases
{
    public class BaseUC
    {
        public BaseUC() { }

       /* public TEntidade CriarEntidade<TEntidade>(string value) where TEntidade : BaseEntidade, new ()
        {
            TEntidade novaEntidade = new TEntidade();
            novaEntidade.SetObject(value);
            return novaEntidade;
        }

        public TEntidade CriarEntidade<TEntidade,TDbSet>(TDbSet DbSet) where TEntidade : BaseEntidade, new ()
        {
            TEntidade novaEntidade = new TEntidade();
            novaEntidade.SetObject(DbSet);
            return novaEntidade;
        }

        public static int AdicionarEntidade<TBaseRepo,TDbSet>(TDbSet dbSetEntidade) where TBaseRepo : BaseRepository<TDbSet>, new() where TDbSet : class
        {
            TBaseRepo entidadeRepository = new TBaseRepo();
            entidadeRepository.AdicionarDbSet(dbSetEntidade);
            return 1;
        }

        public static void SalvarEntidade<TBaseRepo>(TBaseRepo entidadeRepository) where TBaseRepo: BaseRepository<TBaseRepo>
        { 
            entidadeRepository.Salvar(); 
        }
        public TEntidade? GetById<TBaseRepo,TEntidade, TDbSet>(TDbSet dsSetEntidade, int id) where TBaseRepo : BaseRepository<TDbSet>, new() where TDbSet : class
        {
            TBaseRepo entidadeRepository = new TBaseRepo();
            TDbSet? dbSetEntidade = entidadeRepository.DbSetGetId(id);
            if (dbSetEntidade == null ) { return default(TEntidade); }
            TEntidade entidade = CriarEntidade<TEntidade>(dbSetEntidade);
            return entidade;
        }*/
    }
}
