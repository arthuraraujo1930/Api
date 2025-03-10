namespace ApiSegundoDS.models
{
    public class Escola
    {

        public int id { get; set; }
        public string? nome { get; set; }
        public Professor Professor { get; set; }
    }
}