namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {

            //Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            
            bool capacidade = Suite.Capacidade >= hospedes.Count;

            if (capacidade == true)
            {
                Hospedes = hospedes;
            }
            else
            {
                //Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                throw new Exception("A capacidade da suíte é menor que o número de hóspedes.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            //Retorna a quantidade de hóspedes (propriedade Hospedes)
            
            return Hospedes.Count;
        }

        public double CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            double valorDiaria = DiasReservados * Convert.ToDouble(Suite.ValorDiaria);

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            
            if (DiasReservados >= 10)
            {
                valorDiaria = valorDiaria * 0.9;
            }

            return valorDiaria;
        }
    }
}