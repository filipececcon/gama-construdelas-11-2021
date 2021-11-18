namespace Aplicativo
{
    class Automovel
    {
        public string Marca { get; set; }

        public double PotenciaMotor { get; set; }

        public string Nome { get; set; }

        public string Placa { get; set; }

        public string MostraDados()
        {
            return $"Marca: {Marca}, Potencia: {PotenciaMotor}, Nome: {Nome}";
        }
    }
}
