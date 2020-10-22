using System;
using Codigo.Robot;


namespace Codigo.Robot{

    public class GestorRobot{
        
        #region Properties
        private Robot robotSeleccionado = new Robot();
        #endregion Properties
        
        #region Methods

        public void LiberarRobot(Robot robotSeleccionado){
            robotSeleccionado.setEstado("Disponible");
        }

        public void LlenarAgua(Robot robotSeleccionado){
            robotSeleccionado.setCantAgua(1000);
        }

        public void LlenarSemillas(Robot robotSeleccionado){
            robotSeleccionado.setCantSemillas(1000);
        }

        #endregion Methods
        
    }

}