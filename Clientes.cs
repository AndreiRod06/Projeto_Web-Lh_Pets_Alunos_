class Clientes
{
    public string cpf_cnpj { get; set; }
    public string nome { get; set; } = ""; // Inicialize com um valor padrão
    public string endereco { get; set; } = "";
    public string rg_ie { get; set; } = "";
    public string tipo { get; set; } = "";
    public float valor { get; set; }
    public float valor_imposto { get; set; }
    public float total { get; set; }
}
