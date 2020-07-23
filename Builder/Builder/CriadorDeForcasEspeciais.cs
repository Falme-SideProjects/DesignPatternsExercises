namespace Builder
{
    public class CriadorDeForcasEspeciais : CriadorDeSoldado
    {
        public CriadorDeForcasEspeciais()
        {
            _soldado = new SoldadoDeForcasEspeciais();
        }

        public override void Arma()
        {
            _soldado.EscolherArma("Fuzil");
        }

        public override void Foco()
        {
            _soldado.DefinirFoco("Combate em solo");
        }

        public override void Transporte()
        {
            _soldado.EscolherTransporte("Carro de Operações especiais");
        }
    }
}
