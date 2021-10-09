using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public interface iTriangulo {
    int perimetro();
    void area();
}
public interface iTrianguloComp
{
    void ComparaT();
}


namespace AtiviII
{
    class Triangulos:iTriangulo
    {
        public int adjacente;
        public int oposto;
        public int hipotenusa;
        //Construtores
        public Triangulos(int adjacente, int oposto, int hipotenusa)
        {
            this.adjacente = adjacente;
            this.oposto = oposto;
            this.hipotenusa = hipotenusa;
        }
        public Triangulos(int adjacente, int oposto)
        {
            this.adjacente = adjacente;
            this.oposto = oposto;
        }
        public Triangulos()
        {
            this.adjacente = 20;
            this.oposto = 28;
            this.hipotenusa = 30;
        }
    
        //Metodo Get
        public int GetAdj() {
            return this.adjacente;
        }
        public int GetOpo()
        {
            return this.oposto;
        }
        public int GetHipo()
        {
            return this.hipotenusa;
        }
        //Metodo Set
        public void SetAdj(int vNovoA) {
            this.adjacente = vNovoA;
        }
        public void SetOpo(int vNovoO)
        {
            this.oposto = vNovoO;
        }
        public void SetHipo(int vNovoH)
        {
            this.hipotenusa = vNovoH;
        }
        //Metedo calcula perimetro
        public int perimetro()
        {
            int perimetro = this.adjacente + this.oposto + this.hipotenusa;
            return perimetro;
        }
        //Metedo calcula area
        public void area()
        {
            float area = ((adjacente * oposto) / 2);
            Console.WriteLine(" O valor do area = {0} ", area);

        }
        //Metedo hipotenusa
        public void calculaHipot()
        {
            int hipot = (this.GetOpo() / this.GetAdj());
            Console.WriteLine(" O valor do hipotenusa é = {0} ",hipot);
            this.SetHipo(hipot);
        }
    }
    //metodo static compara triangulos
    public static class ComparaTriang
    {
        public static void ComparaT(int perimetro1, int perimetro2)
        {
            if (perimetro1 > perimetro2)
            {
                Console.WriteLine(" T1 possui maoir área = {0}", perimetro1);
            }
            else
            {
                if (perimetro1 < perimetro2)
                {
                    Console.WriteLine(" T2 possui maoir área = {0}", perimetro2);
                }
                else
                {
                    Console.WriteLine(" Triangulos possuem áreas iguais");
                }
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            
            Triangulos triangulos1 = new Triangulos(1, 15, 6);
            Triangulos triangulos = new Triangulos();

            Console.WriteLine("Valor Fixo Cateto Adjacente {0}", triangulos.GetAdj());
            Console.WriteLine("Valor Fixo Cateto Adjacente {0}", triangulos.GetOpo());
            Console.WriteLine("Valor Fixo Cateto Adjacente {0}", triangulos.GetHipo());
            //metodo perimetro 
            Console.WriteLine("Valor perimetro  T1 = {0}", triangulos1.perimetro());
            //metodo area
            triangulos1.area();
            //metodo hipotenusa
            Triangulos triangulos2 = new Triangulos(1, 15);
            triangulos2.calculaHipot();
            
            //metodo compara tringulos 
            ComparaTriang.ComparaT(triangulos1.perimetro(), triangulos2.perimetro());
            
        }

    }
}

   
