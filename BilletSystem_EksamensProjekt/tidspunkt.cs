using System.Collections.Generic;

namespace BilletSystem_EksamensProjekt
{
    public class tidspunkt
    {
        private List<forestillinger> _tidspunkt;
        private forestillinger _selectedTidspunkt;



        public tidspunkter()
        {
            _tidspunkt = new List<forestillinger>();
            _tidspunkt.Add(new forestillinger("14:00"));
            _tidspunkt.Add(new forestillinger("18:00"));
            _tidspunkt.Add(new forestillinger("20:00"));
            _selectedTidspunkt = _tidspunkt[0];
        }
    }
}