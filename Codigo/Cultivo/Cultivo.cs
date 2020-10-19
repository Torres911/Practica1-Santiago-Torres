using System;


namespace Codigo.Cultivos{

    public class Cultivo{

        #region Properties
        private string Estado;
        private int Temperatura;
        private string TipoCultivo;

        #endregion Properties

        #region Getters & Setters

        public string getEstado(){
            return Estado;
        }

        public void setEstado(string est){
            this.Estado = est;
        }

        public int Temperatura(){
            return Temperatura;
        }

        public void setTemperatura(int temp){
            this.Temperatura = temp;
        }

        public string getTipoCultivo(){
            return TipoCultivo;
        }

        public void setTipoCultivo(string tc){
            this.TipoCultivo = tc;
        }

        #endregion Getters & Setters

    }
}