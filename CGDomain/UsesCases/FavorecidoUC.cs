﻿using CGEntity.Entities;
using CGEntity.EntitiesDbSet;
using CGServer.Repository;

namespace CGDomain.UsesCases
{
    public class FavorecidoUC
    {
        public FavorecidoUC() { }

        public int AdicionarFavorecido(string nome) 
        {
            Favorecido favorecido = Criar(nome);
            FavorecidoRepository favorecidoRepository = new FavorecidoRepository();
            favorecidoRepository.AdicionarDbSet(favorecido.DbSetFavorecido);
            Salvar(favorecidoRepository);
            return favorecido.Id;
        }

        public Favorecido Criar(string nome)
        {
            return new Favorecido(nome);
        }
        public Favorecido Criar(DbSetFavorecido dbSetFavorecido)
        {
            return new Favorecido(dbSetFavorecido);
        }

        private void Salvar(FavorecidoRepository favorecidoRepository) 
        {
            favorecidoRepository.Salvar();
        }

        public Favorecido? GetId(int id) 
        {
            FavorecidoRepository favorecidoRepository = new FavorecidoRepository();
            DbSetFavorecido? dbSetFavorecido = favorecidoRepository.DbSetGetId(id);
            if (dbSetFavorecido == null) return null;
            Favorecido favorecido = Criar(dbSetFavorecido);
            return favorecido;
        }
        public Favorecido? GetFirst()
        {
            FavorecidoRepository favorecidoRepository = new FavorecidoRepository();
            DbSetFavorecido? dbSetFavorecido = favorecidoRepository.DbSetGetFirst();
            if (dbSetFavorecido == null) return null;
            Favorecido favorecido = Criar(dbSetFavorecido);
            return favorecido;
        }
    }
}
