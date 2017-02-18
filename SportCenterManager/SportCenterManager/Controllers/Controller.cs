using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCenterManager
{
    /*
     * 1. Klasy pochodne powinny być odpowiedialne za zamknięcie okna w przypadku próby wylogowania 
     * 2. Ręczne zamknięcie okna lub kliknięcie przycisku wylogowania powinny wywołać metodę ReturnControl
     * 3. Stworenie instancji klasy pochodnej nie powinno wyświetlić okna. Okno staje się widoczne po wywołaniu z zewnątrz
     *    metody ShowView() (jest to zapewnione w metodzie SwitchController() klasy LoginWindowController)
     * 
     * 
     * 
     */

    public abstract class Controller
    {
        protected void ReturnControl(object sender, EventArgs args)
        {
            ReturnControlRequest.Invoke(this, args);
        }

        public abstract void CloseView();
        public abstract void ShowView();

        public event EventHandler ReturnControlRequest;
    }
}
