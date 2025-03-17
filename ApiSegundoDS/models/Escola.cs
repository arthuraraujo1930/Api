namespace ApiSegundoDS.models
{
    public class Escola
    {

        public int id { get; set; }
        public string? nome { get; set; }
        public string? CNPJ { get; set; }
        public int AlunoID { get; set; }
        public int ProfessorID { get; set; }
    }
}