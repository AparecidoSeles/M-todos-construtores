namespace Metodos_construtores.classes
{
    public class Produto
    {
        public int Codigo{get; set;}
        public string Nome {get ; set;}
        public string Descricao{get; set;}
        public int Estoque {get; set;}

        // MÉTODO CONSTRUTOR

        public Produto(){

        }

        public Produto(int valor ){
            Codigo = valor;
        }

        public Produto(int codigo , string nome , string descricao , int estoque){
            Codigo = codigo;
            Nome = nome;
            Descricao = descricao;
            Codigo = codigo;
        }

    }
}