using System;


namespace Codigo.Robot{

    public class Robot{

        #region Properties
        private string Estado;
        private int CantAgua;
        private int CantSemillas;

        #endregion Properties
        
        #region Getters & Setters

        public string getEstado(){
            return Estado;
        }

        public void setEstado(string est){
            this.Estado = est;
        }

        public int CantAgua(){
            return CantAgua;
        }

        public void setCantAgua(int canta){
            this.CantAgua = canta;
        }

        public int getCantSemillas(){
            return CantSemillas;
        }

        public void setCantSemillas(int cants){
            this.CantSemillas = cants;
        }

        #endregion Getters & Setters

    }
}