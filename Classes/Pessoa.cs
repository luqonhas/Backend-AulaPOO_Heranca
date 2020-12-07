using System;

namespace Backend_AulaPOO_Heranca.Classes
{
    public class Pessoa
    {
        public string nome;
        public int idade;
        public string DarBoasVindas(string nomeUsuario){
            return "Olá " + nomeUsuario +"! Seja bem vindo(a)!";
        }
    }
}