using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Observer
{
    public  interface Abonnement //Observer
    {
        public void Sinformer(Journaliste journaliste);//update avec la technique Pop 
    }
}
