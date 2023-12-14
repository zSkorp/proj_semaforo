using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semaforo
{
    internal class Luzes
    {

        private byte estado;
        
        public Luzes()
        {
            this.estado = 129;
        }

        public void setVerde(int rua)
        {
            if (rua == 1)
            {
                this.estado = (byte)((int)this.estado & 248);
                this.estado = (byte)((int)this.estado | 1);
            }
            else
            {
                this.estado = (byte)((int)this.estado & 31);
                this.estado = (byte)((int)this.estado | 32);
            }
        }

        public void setAmarelo(int rua)
        {
            if (rua == 1)
            {
                this.estado = (byte)((int)this.estado & 248);
                this.estado = (byte)((int)this.estado | 2);
            }
            else
            {
                this.estado = (byte)((int)this.estado & 31);
                this.estado = (byte)((int)this.estado | 64);
            }
        }

        public void setVermelho(int rua)
        {
            if (rua == 1)
            {
                this.estado = (byte)((int)this.estado & 248);
                this.estado = (byte)((int)this.estado | 4);
            }
            else
            {
                this.estado = (byte)((int)this.estado & 31);
                this.estado = (byte)((int)this.estado | 128);
            }
        }

        public byte getEstado()
        {
            return this.estado;
        }

        public int getEstado(int rua)
        {
            int aux;
            if (rua == 1)
            {
                aux = (int)this.estado & 7;
            }
            else
            {
                aux = (int)this.estado & 224;
                aux = aux / 32;
            }

            if (aux == 4)
                aux = 3;

                return aux;
        }
    }
}
