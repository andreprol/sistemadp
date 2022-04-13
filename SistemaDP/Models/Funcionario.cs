using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDP.Models
{
    public class Funcionario
    {
        [Key]
        public Guid Id { get; set; }

        public enum ativo { nao, sim }

        public Lojas loja_original { get; set; }

        public Lojas loja_anterior { get; set; }

        public Lojas loja_atual { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        [Required(ErrorMessage = "O nome do funcionário é obrigatório")]
        [Display(Name = "Nome do funcionário")]
        public string Nome { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        public string nome_guerra { get; set; }

        public Divisao divisao { get; set; }

        public Cargos cargo_original { get; set; }

        public Cargos cargo_atual { get; set; }

        public string registro_contador { get; set; }

        public Salarios salario { get; set; }

        public EnderecoFuncionario endereco { get; set; }

        [Required(ErrorMessage = "O CPF é obrigatório")]
        public string cpf { get; set; }

        [Required(ErrorMessage = "O RG é obrigatório")]
        public string rg { get; set; }

        public UnidadeDeFederacao uf_rg { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        [Required(ErrorMessage = "A data de admissão é obrigatória")]
        [Display(Name = "Data de expedição")]
        public DateTime expedicao { get; set; }

        public string orgao { get; set; }

        public string carteira_trabalho { get; set; }

        public string serie_ct { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        public DateTime emissao_ct { get; set; }

        public UnidadeDeFederacao uf_ct { get; set; }

        public Bancos banco { get; set; }

        public Instrucao instrucao { get; set; }

        public Admissao admissao { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        public DateTime afastamento { get; set; }

        public string causa_afastamento { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        public DateTime saida { get; set; }

        public enum Sexo { masculino, feminino }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        public string naturalidade { get; set; }

        public enum nacionalidade { brasileiro, estrangeiro }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        public DateTime nascimento { get; set; }

        public UnidadeDeFederacao uf_nascimento { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        public string cidade_nascimento { get; set; }

        public EstadoCivil estado_civil { get; set; }

        public Familiares familiares { get; set; }

        public string pis_pasep { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        public string banco_pis { get; set; }

        public string titulo_eleitor { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        public string zona { get; set; }

        public string secao { get; set; }

        public UnidadeDeFederacao uf_titulo { get; set; }

        public bool desconto_sindicato { get; set; }

        public string tamanho_camisa { get; set; }

        public string tamanho_calca { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        public string observacoes { get; set; }

        //colocar upload de foto

        public TarifasDeOnibus vt { get; set; }

        public PlanoDeSaude plano_saude { get; set; }

        public enum treinamento { nao, sim }

        public enum gerencial { nao, sim }

        public HorariosOriginais horarios_originais { get; set; }

        public HorariosAtuais horarios_atuais { get; set; }

        public HistoricoFerias historico_ferias { get; set; }

        public HistoricoFuncionario historico_funcionario { get; set; }

        public HistoricoSalario historico_salario { get; set; }

        public MotivosAfastamento motivos_afastamento { get; set; }
























        public Funcionario()
        {

        }

    }
}
