using System;

namespace Service {
    public class PrimeService { 
        
        public bool IsPrime(int value) {
            return ((value % 2) == 0);
        }

    }
}
