namespace ApiFipe.Domain.Fabricante.Carros
{
    public class Carro
    {
        public int CodigoFipe { get; set; }
        public int IdCarro { get; set; }
        public int IdModelo { get; set; }
        public string? NomeCarro { get; set; }
        public string? DsAnoModelo { get; set; }
        public string? DsCombustivel { get; set; }
        public string? DsCodigoFipe { get; set; }
        public string? DsMesReferencia { get; set; }
        public string? DsTipoVeiculo { get; set; }
        public string? DsSiglaCombustivel { get; set; }
        public decimal? VlValor { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DtInclusao { get; set; }
        public DateTime? DtAlteracao { get; set; }
        public bool? BtAtivo { get; set; }
        public Fabricante? Fabricante { get; set; }
    }
}
