namespace ApiSegundoDS.models
{
    public class Aluno
    {
        public int id {  get; set; }
        public string? nome { get; set; }
        public string? RMA { get; set; }
        public string? Pai { get; set; }
        public string? Mae { get; set; }
        public Escola Escola { get; set; }
        public Professor Professor { get; set; }
    }
}
