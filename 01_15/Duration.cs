using System;

namespace Duration
{
    public struct Duration
    {
        /* Variáveis para guardar os segundos, minutos, horas, dias,
         * semanas e anos.
         * Só podem ser modificados dentro do struct mas podem
         * ser lidos fora dele.
         */
        public int Seconds { get; private set; }
        public int Minutes { get; private set; }
        public int Hours { get; private set; }
        public int Days { get; private set; }
        public int Weeks { get; private set; }
        public int Years { get; private set; }

        /* Método para definir valores nas varíáveis de cima 
         * com valores gerados aleatoriamente.
         */
        public void InsertTime() {
            Random random = new Random();
            Seconds = random.Next(0, 60);
            Minutes = random.Next(0, 60);
            Hours = random.Next(0, 24);
            Days = random.Next(0, 365);
            Weeks = random.Next(0, 52);
            Years = random.Next(0, 1000);
        }
    }
}
