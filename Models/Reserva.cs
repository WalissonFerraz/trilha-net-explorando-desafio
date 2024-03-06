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
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido

            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                // READY! TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                if(Suite.Capacidade < hospedes.Count && Suite.Capacidade > 0)
                {
                    Console.WriteLine(value: "A suíte escolhida não pode acomodar mais que " + $"{Suite.Capacidade} pessoas.");
                }
                else if (Suite.Capacidade < 0)
                {
                    Console.WriteLine(value: "A capacidade da suíte não pode ser menor que zero!");
                }
                
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // READY! TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            int quantidadeDeHospedes = 0;
            try{
                if (Hospedes.Count > 0)
                {
                    quantidadeDeHospedes = Hospedes.Count;
                }
            }
            catch(Exception)
            {
                Console.WriteLine(value: "Nenhum hóspede foi cadastrado.");
            }
            return quantidadeDeHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            // READY! TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            decimal valor = 0;
                valor = DiasReservados * Suite.ValorDiaria;
                // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
                if (DiasReservados >= 10)
                {
                    valor *= 0.9M;
                }
            return valor;
        }
    }
}