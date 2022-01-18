namespace Horus.Dtos
{
    public class ClientSystemModuleDto
    {
        public string FantasyName { get; set; }
        public string Cnpj { get; set; }
        public List<SystemModuleDto> Forms { get; set; }
    }
}