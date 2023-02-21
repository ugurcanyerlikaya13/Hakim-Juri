using System;

namespace ConsoleApp1
{
    internal class random : Random
    {
        private int v1;
        private int v2;

        public random(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }
}