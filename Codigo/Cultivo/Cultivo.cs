using System;


namespace Codigo.Cultivo{

    public class Cultivo{

        #region Properties

        private int Temperatura;
        private int TipoCultivo;

        #endregion Properties

        #region Getters & Setters

        public int getTemperatura(){
            return Temperatura;
        }

        public void setTemperatura(int temp){
            this.Temperatura = temp;
        }

        public int getTipoCultivo(){
            return TipoCultivo;
        }

        public void setTipoCultivo(int tc){
            this.TipoCultivo = tc;
        }

        #endregion Getters & Setters

        #region Methods

        public Cultivo(){
            Random rand  = new Random();
            TipoCultivo = rand.Next(1,4);
            Temperatura = rand.Next(0,100);
        }

        #endregion Methods

    }
}