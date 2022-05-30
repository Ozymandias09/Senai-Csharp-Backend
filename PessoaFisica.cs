namespace meuscode
{
    public class PessoaFisica : Pessoa
    {
        public string? cpf { get; set; }

        public DateTime dataNascimento { get; set; }
        //public override void PagarImposto(float salario){

        //}
        public bool ValidarDataNascimento (DateTime dataNascimento)
        {
            DateTime dataAtual = DateTime.Today;
            double anos = (DateTime.Today - dataNascimento).TotalDays/365;
            if(anos>=18){
                return true;
            }else return false;
        }
        
        
    }
}