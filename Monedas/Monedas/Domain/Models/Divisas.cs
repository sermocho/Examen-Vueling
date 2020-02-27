namespace Monedas.Domain.Models
{
    public class Divisas
    {
        public int Id { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public string rate { get; set; }

        public Divisas(string _from, string _to, string _rate)
        {
            this.from = _from;
            this.to = _to;
            this.rate = _rate;
        }

    }
}