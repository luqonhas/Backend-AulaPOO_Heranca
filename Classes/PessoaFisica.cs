namespace Backend_AulaPOO_Heranca.Classes
{
    public class PessoaFisica:Pessoa
    {
        public string cpf;
        public string rg;
        public bool ValidarCPF(string documentoCPF){
            if(documentoCPF != "" && documentoCPF.Length > 14){
                return true;
            }
            return false;
        }
    }
}