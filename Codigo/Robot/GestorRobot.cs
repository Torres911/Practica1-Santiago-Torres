using System;
using Codigo.Robot;


namespace Codigo.Robot{

    public class GestorRobot{

        #region Properties

        private Robot robotSeleccionado;

        #endregion Properties

        #region Methods

        public void LiberarRobot(){
            robotSeleccionado.setEstado("Disponible");
        }

        public void LlenarAgua(){
            robotSeleccionado.setCantAgua(1000);
        }

        public void LlenarSemillas(){
            robotSeleccionado.setCantSemillas(1000);
        }

        #endregion Methods
        
    }

}