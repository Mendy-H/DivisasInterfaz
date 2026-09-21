namespace DivisasInterfaz
{
    class Divisas
    {
        private float pesos;

        public Divisas() { this.pesos = 0; }
        public Divisas(float pesos) { this.pesos = pesos; }

        public float Pesos
        {
            get { return pesos; }
            set { pesos = value; }
        }

        public float Dolar() { return this.pesos / 16.97f; }
        public float Euro() { return this.pesos / 19.69f; }
        public float Libra() { return this.pesos / 22.94f; }
        public float Yen() { return this.pesos / 0.11f; }
    }
}