namespace ApiSegundoDS.models
{
    public class Aluno
    {
        public int id {  get; set; }
        public string? nome { get; set; }
        public string? RMA { get; set; }
        public string? Pai { get; set; }
        public string? Mae { get; set; }
        public int EscolaID { get; set; }
        public int ProfessorID { get; set; }
    }
}
