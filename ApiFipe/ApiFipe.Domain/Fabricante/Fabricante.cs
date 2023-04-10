namespace ApiFipe.Domain.Fabricante.Carros
{
    public  class Fabricante
    {
        public int IdFabricante { get; set; }
        public string? NomeFabricante { get; set; }
        public string? DsSigla { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DtInclusao { get; set; }
        public DateTime? DtAlteracao { get; set; }
        public bool? BtAtivo { get; set; }
    }
 
}
