using System;

namespace _01_15
{
    public struct Duration
    {
        /* Variáveis para guardar os segundos, minutos, horas, dias,
         * semanas e anos.
         * Só podem ser modificados dentro do struct mas podem
         * ser lidos fora dele.
         */
        public int Seconds { get; }

        public int Minutes {
            get {
                return Seconds / 60;
            }
        }

        public int Hours {
            get {
                return Minutes / 60;
            }
        }

        public int Days {
            get {
                return Hours / 24;
            }
        }

        public int Weeks {
            get {
                return Days / 7;
            }
        }

        public int Years {
            get {
                return Days / 365;
            }
        }

        public Duration(int seconds) {
            Seconds = seconds;
        }
    }
}
