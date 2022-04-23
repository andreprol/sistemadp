using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaDP.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admissao",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    data_admissao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admissao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bancos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    numero_banco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    descricao_banco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    agencia_banco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    conta_banco = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bancos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cargos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    abreviacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    diasexp = table.Column<int>(type: "int", nullable: false),
                    diasprorr = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Divisao",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    numero_divisao = table.Column<int>(type: "int", nullable: false),
                    descricao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Divisao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EnderecoLojas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    rua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    numero = table.Column<int>(type: "int", nullable: false),
                    complemento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnderecoLojas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EstadoCivil",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoCivil", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Eventos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    numero_evento = table.Column<int>(type: "int", nullable: false),
                    descricao_evento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    data_evento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eventos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Familiares",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nome_pai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nome_mae = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nome_filho = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nasc_filho = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Familiares", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HistoricoFerias",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    datainicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    datafim = table.Column<DateTime>(type: "datetime2", nullable: false),
                    datagozo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    valorferias = table.Column<int>(type: "int", nullable: false),
                    abonoferias = table.Column<int>(type: "int", nullable: false),
                    diasgozo = table.Column<int>(type: "int", nullable: false),
                    diasvendidos = table.Column<int>(type: "int", nullable: false),
                    valorvendido = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricoFerias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HistoricoFuncionario",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    descricao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricoFuncionario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HistoricoSalario",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    data_mod_salario = table.Column<DateTime>(type: "datetime2", nullable: false),
                    salario_inicial = table.Column<int>(type: "int", nullable: false),
                    salario_atual = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricoSalario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HorariosAtuais",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    data_entrada_abertura = table.Column<DateTime>(type: "datetime2", nullable: false),
                    data_saida_abertura = table.Column<DateTime>(type: "datetime2", nullable: false),
                    data_entrada_inter = table.Column<DateTime>(type: "datetime2", nullable: false),
                    data_saida_inter = table.Column<DateTime>(type: "datetime2", nullable: false),
                    data_entrada_noite = table.Column<DateTime>(type: "datetime2", nullable: false),
                    data_saida_noite = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HorariosAtuais", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HorariosOriginais",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    data_entrada_abertura = table.Column<DateTime>(type: "datetime2", nullable: false),
                    data_saida_abertura = table.Column<DateTime>(type: "datetime2", nullable: false),
                    data_entrada_inter = table.Column<DateTime>(type: "datetime2", nullable: false),
                    data_saida_inter = table.Column<DateTime>(type: "datetime2", nullable: false),
                    data_entrada_noite = table.Column<DateTime>(type: "datetime2", nullable: false),
                    data_saida_noite = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HorariosOriginais", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Instrucao",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    descricao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instrucao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MotivosAfastamento",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    data_afastamento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotivosAfastamento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlanoDeSaude",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    plano = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanoDeSaude", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Salarios",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    cargo_original = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cargo_atual = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    salario_original = table.Column<int>(type: "int", nullable: false),
                    salario_atual = table.Column<int>(type: "int", nullable: false),
                    data_modificao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TarifasDeOnibus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tarifa_original = table.Column<int>(type: "int", nullable: false),
                    tarifa_atual = table.Column<int>(type: "int", nullable: false),
                    tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    data_modificacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TarifasDeOnibus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnidadeDeFederacao",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sigla = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnidadeDeFederacao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lojas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sigla = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    razao_social = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cnpj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    inscricao_estadual = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cod_amil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    endereco_lojasId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lojas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lojas_EnderecoLojas_endereco_lojasId",
                        column: x => x.endereco_lojasId,
                        principalTable: "EnderecoLojas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EnderecoFuncionario",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    rua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    numero = table.Column<int>(type: "int", nullable: false),
                    complemento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    unidade_federacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    telefone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnderecoFuncionario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EnderecoFuncionario_UnidadeDeFederacao_unidade_federacaoId",
                        column: x => x.unidade_federacaoId,
                        principalTable: "UnidadeDeFederacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Funcionario",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    loja_originalId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    loja_anteriorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    loja_atualId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nome_guerra = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    divisaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    cargo_originalId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    cargo_atualId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    registro_contador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    salarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    enderecoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    cpf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    uf_rgId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    expedicao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    orgao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    carteira_trabalho = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    serie_ct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    emissao_ct = table.Column<DateTime>(type: "datetime2", nullable: false),
                    uf_ctId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    bancoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    instrucaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    admissaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    afastamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    causa_afastamento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    saida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    naturalidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    uf_nascimentoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    cidade_nascimento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    estado_civilId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    familiaresId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    pis_pasep = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    banco_pis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    titulo_eleitor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    zona = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    secao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    uf_tituloId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    desconto_sindicato = table.Column<bool>(type: "bit", nullable: false),
                    tamanho_camisa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tamanho_calca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    observacoes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    plano_saudeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    horarios_originaisId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    horarios_atuaisId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    historico_feriasId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    historico_funcionarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    historico_salarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    motivos_afastamentoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Funcionario_Admissao_admissaoId",
                        column: x => x.admissaoId,
                        principalTable: "Admissao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Funcionario_Bancos_bancoId",
                        column: x => x.bancoId,
                        principalTable: "Bancos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Funcionario_Cargos_cargo_atualId",
                        column: x => x.cargo_atualId,
                        principalTable: "Cargos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Funcionario_Cargos_cargo_originalId",
                        column: x => x.cargo_originalId,
                        principalTable: "Cargos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Funcionario_Divisao_divisaoId",
                        column: x => x.divisaoId,
                        principalTable: "Divisao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Funcionario_EnderecoFuncionario_enderecoId",
                        column: x => x.enderecoId,
                        principalTable: "EnderecoFuncionario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Funcionario_EstadoCivil_estado_civilId",
                        column: x => x.estado_civilId,
                        principalTable: "EstadoCivil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Funcionario_Familiares_familiaresId",
                        column: x => x.familiaresId,
                        principalTable: "Familiares",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Funcionario_HistoricoFerias_historico_feriasId",
                        column: x => x.historico_feriasId,
                        principalTable: "HistoricoFerias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Funcionario_HistoricoFuncionario_historico_funcionarioId",
                        column: x => x.historico_funcionarioId,
                        principalTable: "HistoricoFuncionario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Funcionario_HistoricoSalario_historico_salarioId",
                        column: x => x.historico_salarioId,
                        principalTable: "HistoricoSalario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Funcionario_HorariosAtuais_horarios_atuaisId",
                        column: x => x.horarios_atuaisId,
                        principalTable: "HorariosAtuais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Funcionario_HorariosOriginais_horarios_originaisId",
                        column: x => x.horarios_originaisId,
                        principalTable: "HorariosOriginais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Funcionario_Instrucao_instrucaoId",
                        column: x => x.instrucaoId,
                        principalTable: "Instrucao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Funcionario_Lojas_loja_anteriorId",
                        column: x => x.loja_anteriorId,
                        principalTable: "Lojas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Funcionario_Lojas_loja_atualId",
                        column: x => x.loja_atualId,
                        principalTable: "Lojas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Funcionario_Lojas_loja_originalId",
                        column: x => x.loja_originalId,
                        principalTable: "Lojas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Funcionario_MotivosAfastamento_motivos_afastamentoId",
                        column: x => x.motivos_afastamentoId,
                        principalTable: "MotivosAfastamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Funcionario_PlanoDeSaude_plano_saudeId",
                        column: x => x.plano_saudeId,
                        principalTable: "PlanoDeSaude",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Funcionario_Salarios_salarioId",
                        column: x => x.salarioId,
                        principalTable: "Salarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Funcionario_TarifasDeOnibus_vtId",
                        column: x => x.vtId,
                        principalTable: "TarifasDeOnibus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Funcionario_UnidadeDeFederacao_uf_ctId",
                        column: x => x.uf_ctId,
                        principalTable: "UnidadeDeFederacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Funcionario_UnidadeDeFederacao_uf_nascimentoId",
                        column: x => x.uf_nascimentoId,
                        principalTable: "UnidadeDeFederacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Funcionario_UnidadeDeFederacao_uf_rgId",
                        column: x => x.uf_rgId,
                        principalTable: "UnidadeDeFederacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Funcionario_UnidadeDeFederacao_uf_tituloId",
                        column: x => x.uf_tituloId,
                        principalTable: "UnidadeDeFederacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EnderecoFuncionario_unidade_federacaoId",
                table: "EnderecoFuncionario",
                column: "unidade_federacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_admissaoId",
                table: "Funcionario",
                column: "admissaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_bancoId",
                table: "Funcionario",
                column: "bancoId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_cargo_atualId",
                table: "Funcionario",
                column: "cargo_atualId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_cargo_originalId",
                table: "Funcionario",
                column: "cargo_originalId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_divisaoId",
                table: "Funcionario",
                column: "divisaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_enderecoId",
                table: "Funcionario",
                column: "enderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_estado_civilId",
                table: "Funcionario",
                column: "estado_civilId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_familiaresId",
                table: "Funcionario",
                column: "familiaresId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_historico_feriasId",
                table: "Funcionario",
                column: "historico_feriasId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_historico_funcionarioId",
                table: "Funcionario",
                column: "historico_funcionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_historico_salarioId",
                table: "Funcionario",
                column: "historico_salarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_horarios_atuaisId",
                table: "Funcionario",
                column: "horarios_atuaisId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_horarios_originaisId",
                table: "Funcionario",
                column: "horarios_originaisId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_instrucaoId",
                table: "Funcionario",
                column: "instrucaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_loja_anteriorId",
                table: "Funcionario",
                column: "loja_anteriorId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_loja_atualId",
                table: "Funcionario",
                column: "loja_atualId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_loja_originalId",
                table: "Funcionario",
                column: "loja_originalId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_motivos_afastamentoId",
                table: "Funcionario",
                column: "motivos_afastamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_plano_saudeId",
                table: "Funcionario",
                column: "plano_saudeId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_salarioId",
                table: "Funcionario",
                column: "salarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_uf_ctId",
                table: "Funcionario",
                column: "uf_ctId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_uf_nascimentoId",
                table: "Funcionario",
                column: "uf_nascimentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_uf_rgId",
                table: "Funcionario",
                column: "uf_rgId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_uf_tituloId",
                table: "Funcionario",
                column: "uf_tituloId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_vtId",
                table: "Funcionario",
                column: "vtId");

            migrationBuilder.CreateIndex(
                name: "IX_Lojas_endereco_lojasId",
                table: "Lojas",
                column: "endereco_lojasId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Eventos");

            migrationBuilder.DropTable(
                name: "Funcionario");

            migrationBuilder.DropTable(
                name: "Admissao");

            migrationBuilder.DropTable(
                name: "Bancos");

            migrationBuilder.DropTable(
                name: "Cargos");

            migrationBuilder.DropTable(
                name: "Divisao");

            migrationBuilder.DropTable(
                name: "EnderecoFuncionario");

            migrationBuilder.DropTable(
                name: "EstadoCivil");

            migrationBuilder.DropTable(
                name: "Familiares");

            migrationBuilder.DropTable(
                name: "HistoricoFerias");

            migrationBuilder.DropTable(
                name: "HistoricoFuncionario");

            migrationBuilder.DropTable(
                name: "HistoricoSalario");

            migrationBuilder.DropTable(
                name: "HorariosAtuais");

            migrationBuilder.DropTable(
                name: "HorariosOriginais");

            migrationBuilder.DropTable(
                name: "Instrucao");

            migrationBuilder.DropTable(
                name: "Lojas");

            migrationBuilder.DropTable(
                name: "MotivosAfastamento");

            migrationBuilder.DropTable(
                name: "PlanoDeSaude");

            migrationBuilder.DropTable(
                name: "Salarios");

            migrationBuilder.DropTable(
                name: "TarifasDeOnibus");

            migrationBuilder.DropTable(
                name: "UnidadeDeFederacao");

            migrationBuilder.DropTable(
                name: "EnderecoLojas");
        }
    }
}
