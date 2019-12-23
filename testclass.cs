using System;
using System.Collections.Generic;
using System.Text;

namespace iinheritancelab3
{
    class testclass
    {
        public testclass()
        {
            animal a = new Cat();
            animal f= new fish();
            animal g = new goat();
            a.sound();
            f.sound();
            g.sound();
        }
    }
}
