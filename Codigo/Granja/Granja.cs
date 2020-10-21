using System;
using System.Collections.Generic;
using Codigo.Robot;
using Codigo.Cultivo;


namespace Codigo.Granja{

    public class Granja{
        
        #region Properties
        private List<Robot.Robot> robots = new List<Robot.Robot>();
        private List<Cultivo.Cultivo> cultivos = new List<Cultivo.Cultivo>();
        private List<Cultivo.Cultivo> domo = new List<Cultivo.Cultivo>();

        #endregion Properties

        #region Getters & Setters

        public List<Robot.Robot> getRobots(){ 
            return robots;
        }

        public void setRobots(Robot.Robot value){ 
            robots.Add(value);
        }

        public List<Cultivo.Cultivo> getCultivos(){ 
            return cultivos;
        }

        public void setCultivos(Cultivo.Cultivo value){ 
            cultivos.Add(value);
        }

        public List<Cultivo.Cultivo> getDomo(){ 
            return domo;
        }

        public void setDomo(Cultivo.Cultivo value){ 
            domo.Add(value);
        }

        #endregion Getters & Setters

        #region Methods

        public void limpiarCultivos(){
            cultivos.Clear();
        }

        public void limpiarDomo(){
            domo.Clear();
        }

        #endregion Methods

    }

}