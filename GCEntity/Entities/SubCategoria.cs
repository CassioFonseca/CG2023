namespace CGEntity.Entities
{
    public class SubCategoria
    {
        public int Id { get; }
        private string _descricao;
        public string Descricao
        {
            get { return _descricao; }
            set
            {
                if (value != _descricao)
                {
                    ValidaDescricao(value);
                    this._descricao = value;
                }
            }
        }
        public int? CategoriaDespesaID { get; set; }
        public SubCategoria(int id, string descricao, int categoriaDespesaId)
        {
            if (id == 0) { id = Guid.NewGuid().GetHashCode(); }
            this.Id = id;
            ValidaDescricao(descricao);
            this._descricao = descricao;
            this.Descricao = descricao;
            if (categoriaDespesaId > 0) { this.CategoriaDespesaID = categoriaDespesaId; }
            else { this.CategoriaDespesaID = null; }
        }
        private void ValidaDescricao(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("O nome do favorecido não pode ser vazio ou nulo.");
            }
        }

    }
}
