using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taller.net
{
    public class Areatriangulo
    {
        private int Base;
        private int area;
        private int altura;

      public void setarea(int area)
      {
            this.area = area;
      }
        public int getarea()
        {
            return this.area;
        }
        public void setBase(int Base)
        {
            this.Base = Base;
        }
        public int getBase()
        {
            return this.Base;
        }
        public void setaltura(int altura)
        {
            this.altura = altura;
        }
        public int getaltura()
        
        {
            
            return this.altura;
        }

        public int calcular()
        {
            return (this.getBase() * this.getaltura() / 2);
        }
    }
}
