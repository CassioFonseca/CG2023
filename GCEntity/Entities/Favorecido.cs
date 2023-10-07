﻿using CGEntity.EntitiesDbSet;

namespace CGEntity.Entities
{
    public class Favorecido:DbSetFavorecido
    {
        private string _nome;
        public override string Nome
        {
            get { return _nome; }
            set
            {
                if (value != _nome)
                {
                    ValidaNome(value);
                    this._nome = value;
                }
            }
        }
        private void ValidaNome(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("O nome do favorecido não pode ser vazio ou nulo.");
            }
        }
        public Favorecido(int id, string nome)
        {
            if (id == 0) { id = Guid.NewGuid().GetHashCode(); }
            this.Id = id;
            ValidaNome(nome);
            this._nome = nome;
            this.Nome = nome;
            this.Lancamentos = new List<Lancamento>();
        }
    }
}
