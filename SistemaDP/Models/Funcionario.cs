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

        private enum ativo { nao, sim }

        private Lojas loja_original { get; set; }

        private Lojas loja_anterior { get; set; }

        private Lojas loja_atual { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        [Required(ErrorMessage = "O nome do funcionário é obrigatório")]
        [Display(Name = "Nome do funcionário")]
        private string Nome { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        private string nome_guerra { get; set; }

        private Divisao divisao { get; set; }

        private Cargos cargo_original { get; set; }

        private Cargos cargo_atual { get; set; }

        private string registro_contador { get; set; }

        private Salarios salario { get; set; }

        private EnderecoFuncionario endereco { get; set; }

        [Required(ErrorMessage = "O CPF é obrigatório")]
        private string cpf { get; set; }

        [Required(ErrorMessage = "O RG é obrigatório")]
        private string rg { get; set; }

        private UnidadeDeFederacao uf_rg { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        [Required(ErrorMessage = "A data de admissão é obrigatória")]
        [Display(Name = "Data de expedição")]
        private DateTime expedicao { get; set; }

        private string orgao { get; set; }

        private string carteira_trabalho { get; set; }

        private string serie_ct { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        private DateTime emissao_ct { get; set; }

        private UnidadeDeFederacao uf_ct { get; set; }

        private Bancos banco { get; set; }

        private Instrucao instrucao { get; set; }

        private Admissao admissao { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        private DateTime afastamento { get; set; }

        private string causa_afastamento { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        private DateTime saida { get; set; }

        private enum Sexo { masculino, feminino }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        private string naturalidade { get; set; }

        private enum nacionalidade { brasileiro, estrangeiro }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        private DateTime nascimento { get; set; }

        private UnidadeDeFederacao uf_nascimento { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        private string cidade_nascimento { get; set; }

        private EstadoCivil estado_civil { get; set; }

        private Familiares familiares { get; set; }

        private string pis_pasep { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        private string banco_pis { get; set; }

        private string titulo_eleitor { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        private string zona { get; set; }

        private string secao { get; set; }

        private UnidadeDeFederacao uf_titulo { get; set; }

        private bool desconto_sindicato { get; set; }

        private string tamanho_camisa { get; set; }

        private string tamanho_calca { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        private string observacoes { get; set; }

        //colocar upload de foto

        private TarifasDeOnibus vt { get; set; }

        private PlanoDeSaude plano_saude { get; set; }

        private enum treinamento { nao, sim }

        private enum gerencial { nao, sim }

        private HorariosOriginais horarios_originais { get; set; }

        private HorariosAtuais horarios_atuais { get; set; }

        private HistoricoFerias historico_ferias { get; set; }

        private HistoricoFuncionario historico_funcionario { get; set; }

        private HistoricoSalario historico_salario { get; set; }

        private MotivosAfastamento motivos_afastamento { get; set; }
























        public Funcionario()
        {

        }

    }
}
