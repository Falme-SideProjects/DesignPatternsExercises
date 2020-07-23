namespace Builder
{
    public class CriadorDeInfantariaLeve : CriadorDeSoldado
    {
        public CriadorDeInfantariaLeve()
        {
            _soldado = new SoldadoDeInfantariaLeve();
        }

        public override void Arma()
        {
            _soldado.EscolherArma("Ataque Aéreo");
        }

        public override void Foco()
        {
            _soldado.DefinirFoco("Resposta Rápida Aérea");
        }

        public override void Transporte()
        {
            _soldado.EscolherTransporte("Helicoptero de ataque do exercito");
        }
    }
}
