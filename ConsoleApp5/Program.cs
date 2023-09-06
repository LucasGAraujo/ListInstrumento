
    public abstract class InstrumentoMusical
    {
        private string _nome;
        private string _tipo;

        public string Nome {  get { return _nome; } set { _nome = value.ToUpper(); } }
        public string Tipo { get { return _tipo; } set { _tipo = value.ToUpper(); } }
        public abstract void Tocar();
    }
    public  interface IAfinavel
    {
        void Afinar();
        bool VerifarAfinacao();
    }
    public class Violao : InstrumentoMusical , IAfinavel
    {
        public void Afinar()
        {
            Console.WriteLine("Afinando o vilão....");
        }

        public override void Tocar()
        {
            Console.WriteLine("Violão tocando...");
        }

        public bool VerifarAfinacao()
        {
            Console.WriteLine("Verificando afinação do violão...");
            return true;
        }
    }
    public class Guitarra : InstrumentoMusical, IAfinavel
    {
        public void Afinar()
        {
            Console.WriteLine("Afinando o Guitarra....");
        }

        public override void Tocar()
        {
            Console.WriteLine("Guitarra tocando...");
        }

        public bool VerifarAfinacao()
        {
            Console.WriteLine("Verificando afinação do Guitarra...");
            return true;
        }
    }
    public class Baixo : InstrumentoMusical, IAfinavel
    {
        public void Afinar()
        {
            Console.WriteLine("Afinando o Baixo....");
        }

        public override void Tocar()
        {
            Console.WriteLine("Baixo tocando ...");
        }

        public bool VerifarAfinacao()
        {
            Console.WriteLine("Verificando afinação do Baixo...");
            return true;
        }
    }

    public class Triangulo : InstrumentoMusical
    {
        
        public override void Tocar()
        {
            Console.WriteLine("Triangulo tocando...");
        }

        
    }
public class program
{
    public static void Main(string[] args)
    {
        try
        {
            List<InstrumentoMusical> instrumentoMusicals = new List<InstrumentoMusical>();


            instrumentoMusicals.Add(new Violao { Nome = "Violão Classico ",Tipo = "Corda"});
            instrumentoMusicals.Add(new Guitarra { Nome = "Guitarra vermelha ", Tipo = "Corda" });
            instrumentoMusicals.Add(new Baixo { Nome = "Baixo 6 cordas ", Tipo = "Corda" }); 
            instrumentoMusicals.Add(new Triangulo { Nome = "Triangulo comum", Tipo = "clink" });
            
            foreach(var instrumento in instrumentoMusicals)
            {
                
                if (instrumento is IAfinavel afinavel) 
                {
                    Console.WriteLine($"DÁ PARA AFINAR O INSTRUMENTO {instrumento.Nome}");
                    afinavel.VerifarAfinacao();
                    afinavel.Afinar();
                }else 
                {
                    Console.WriteLine($"Não DÁ PARA AFINAR O INSTRUMENTO{instrumento.Nome}");
                }
                instrumento.Tocar();
                Console.WriteLine();
            }
        }
        catch(Exception ex) 
        {
            Console.WriteLine(ex.ToString());
        }
        finally 
        {
            Console.WriteLine("programa encerrado");
        }
    }
    }
