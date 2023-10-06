using CGEntity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGServer.Repository
{
    public class FavorecidoRepository
    {
        public int Id { get; }
        private string _nome;
        public string Nome
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
        public ICollection<Lancamento> Lancamentos { get; set; }

        private void ValidaNome(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("O nome do favorecido não pode ser vazio ou nulo.");
            }
        }
        public FavorecidoRepository(int id, string nome)
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
