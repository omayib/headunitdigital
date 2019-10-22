using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace headunitdigital
{
    class Controller
    {
        private Engine engine;
        private EventListener eventListener;

        public Controller(Engine engine)
        {
            this.engine = engine;
        }

        public void acceleratePedalPressed()
        {
            this.engine.speedUp();
            updateDisplay();
        }

        private void updateDisplay()
        {
            eventListener.updateDisplay(
               this.engine.getCurrentSpeed().ToString(),
               this.engine.getCurrentRpm().ToString(),
               this.engine.getCUrrentFuel().ToString());
        }

        public void breakPedalPressed()
        {
            this.engine.speedDown();
            updateDisplay();
        }
        public void addDisplayListener(EventListener presenter)
        {
            this.eventListener = presenter;
            updateDisplay();
        }

    }
}
