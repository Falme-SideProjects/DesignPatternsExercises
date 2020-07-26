namespace Visitor
{
    public class Chefao : IJogo
    {
        public string NomeChefao { get; set; }
        public string PontosVida { get; set; }

        public void Visitante(IVisitor visitante)
        {
            visitante.Identificar(this);
        }
    }
}