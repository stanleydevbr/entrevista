using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevBr.Entrevista.Infra.Migrations
{
    /// <inheritdoc />
    public partial class entrevistav1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateSequence(
                name: "SequenciaCandidato",
                schema: "dbo");

            migrationBuilder.CreateSequence(
                name: "SequenciaEntrevista",
                schema: "dbo");

            migrationBuilder.CreateSequence(
                name: "SequenciaEntrevistador",
                schema: "dbo");

            migrationBuilder.CreateSequence(
                name: "SequenciaGrupoPergunta",
                schema: "dbo");

            migrationBuilder.CreateSequence(
                name: "SequenciaLinguagem",
                schema: "dbo");

            migrationBuilder.CreateSequence(
                name: "SequenciaNivelConhecimento",
                schema: "dbo");

            migrationBuilder.CreateSequence(
                name: "SequenciaPergunta",
                schema: "dbo");

            migrationBuilder.CreateSequence(
                name: "SequenciaQuestionario",
                schema: "dbo");

            migrationBuilder.CreateSequence(
                name: "SequenciaRelatorio",
                schema: "dbo");

            migrationBuilder.CreateSequence(
                name: "SequenciaResposta",
                schema: "dbo");

            migrationBuilder.CreateTable(
                name: "Candidatos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Codigo = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioCriacao = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioAlteracao = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidatos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Entrevistadores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Cliente = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Familia = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Nivel = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Codigo = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioCriacao = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioAlteracao = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entrevistadores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GrupoPerguntas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Codigo = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioCriacao = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioAlteracao = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrupoPerguntas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Linguagens",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Codigo = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioCriacao = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioAlteracao = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Linguagens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NiveisConhecimento",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Codigo = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioCriacao = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioAlteracao = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NiveisConhecimento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questionarios",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Codigo = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioCriacao = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioAlteracao = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questionarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Entrevistas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataEntrevista = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NivelEsperado = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CandidatoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RelatorioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Codigo = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioCriacao = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioAlteracao = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entrevistas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entrevistas_Candidatos_CandidatoId",
                        column: x => x.CandidatoId,
                        principalTable: "Candidatos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Perguntas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Resposta = table.Column<string>(type: "varchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    GrupoPerguntaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Codigo = table.Column<long>(type: "bigint", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioCriacao = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioAlteracao = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perguntas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Perguntas_GrupoPerguntas_GrupoPerguntaId",
                        column: x => x.GrupoPerguntaId,
                        principalTable: "GrupoPerguntas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EntrevistadorLinguagem",
                columns: table => new
                {
                    EntrevistadorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LinguagemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntrevistadorLinguagem", x => new { x.EntrevistadorId, x.LinguagemId });
                    table.ForeignKey(
                        name: "FK_EntrevistadorLinguagem_Entrevistadores_EntrevistadorId",
                        column: x => x.EntrevistadorId,
                        principalTable: "Entrevistadores",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EntrevistadorLinguagem_Linguagens_LinguagemId",
                        column: x => x.LinguagemId,
                        principalTable: "Linguagens",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EntrevistaEntrevistador",
                columns: table => new
                {
                    EntrevistaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntrevistadorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntrevistaEntrevistador", x => new { x.EntrevistaId, x.EntrevistadorId });
                    table.ForeignKey(
                        name: "FK_EntrevistaEntrevistador_Entrevistadores_EntrevistadorId",
                        column: x => x.EntrevistadorId,
                        principalTable: "Entrevistadores",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EntrevistaEntrevistador_Entrevistas_EntrevistaId",
                        column: x => x.EntrevistaId,
                        principalTable: "Entrevistas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Relatorios",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    PontosFortes = table.Column<string>(type: "nvarchar(800)", maxLength: 800, nullable: false),
                    PontosFracos = table.Column<string>(type: "nvarchar(800)", maxLength: 800, nullable: false),
                    Observacao = table.Column<string>(type: "nvarchar(800)", maxLength: 800, nullable: false),
                    Resultado = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    EntrevistaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Codigo = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioCriacao = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioAlteracao = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relatorios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Relatorios_Entrevistas_EntrevistaId",
                        column: x => x.EntrevistaId,
                        principalTable: "Entrevistas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PerguntaQuestionario",
                columns: table => new
                {
                    PerguntasId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QuestionariosId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerguntaQuestionario", x => new { x.PerguntasId, x.QuestionariosId });
                    table.ForeignKey(
                        name: "FK_PerguntaQuestionario_Perguntas_PerguntasId",
                        column: x => x.PerguntasId,
                        principalTable: "Perguntas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PerguntaQuestionario_Questionarios_QuestionariosId",
                        column: x => x.QuestionariosId,
                        principalTable: "Questionarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RelatorioQuestionario",
                columns: table => new
                {
                    QuestionariosId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RelatoriosId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelatorioQuestionario", x => new { x.QuestionariosId, x.RelatoriosId });
                    table.ForeignKey(
                        name: "FK_RelatorioQuestionario_Questionarios_QuestionariosId",
                        column: x => x.QuestionariosId,
                        principalTable: "Questionarios",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RelatorioQuestionario_Relatorios_RelatoriosId",
                        column: x => x.RelatoriosId,
                        principalTable: "Relatorios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Respostas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Pergunta = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    RespostaCandidato = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    RespostaEsperada = table.Column<string>(type: "VARCHAR(MAX)", nullable: false),
                    CodigoGrupoPergunta = table.Column<int>(type: "int", nullable: false),
                    DescricaoGrupoPergunta = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    NivelConhecimentoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RelatorioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Codigo = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioCriacao = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioAlteracao = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Respostas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Respostas_NiveisConhecimento_NivelConhecimentoId",
                        column: x => x.NivelConhecimentoId,
                        principalTable: "NiveisConhecimento",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Respostas_Relatorios_RelatorioId",
                        column: x => x.RelatorioId,
                        principalTable: "Relatorios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_EntrevistadorLinguagem_LinguagemId",
                table: "EntrevistadorLinguagem",
                column: "LinguagemId");

            migrationBuilder.CreateIndex(
                name: "IX_EntrevistaEntrevistador_EntrevistadorId",
                table: "EntrevistaEntrevistador",
                column: "EntrevistadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Entrevistas_CandidatoId",
                table: "Entrevistas",
                column: "CandidatoId");

            migrationBuilder.CreateIndex(
                name: "IX_PerguntaQuestionario_QuestionariosId",
                table: "PerguntaQuestionario",
                column: "QuestionariosId");

            migrationBuilder.CreateIndex(
                name: "IX_Perguntas_GrupoPerguntaId",
                table: "Perguntas",
                column: "GrupoPerguntaId");

            migrationBuilder.CreateIndex(
                name: "IX_RelatorioQuestionario_RelatoriosId",
                table: "RelatorioQuestionario",
                column: "RelatoriosId");

            migrationBuilder.CreateIndex(
                name: "IX_Relatorios_EntrevistaId",
                table: "Relatorios",
                column: "EntrevistaId");

            migrationBuilder.CreateIndex(
                name: "IX_Respostas_NivelConhecimentoId",
                table: "Respostas",
                column: "NivelConhecimentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Respostas_RelatorioId",
                table: "Respostas",
                column: "RelatorioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EntrevistadorLinguagem");

            migrationBuilder.DropTable(
                name: "EntrevistaEntrevistador");

            migrationBuilder.DropTable(
                name: "PerguntaQuestionario");

            migrationBuilder.DropTable(
                name: "RelatorioQuestionario");

            migrationBuilder.DropTable(
                name: "Respostas");

            migrationBuilder.DropTable(
                name: "Linguagens");

            migrationBuilder.DropTable(
                name: "Entrevistadores");

            migrationBuilder.DropTable(
                name: "Perguntas");

            migrationBuilder.DropTable(
                name: "Questionarios");

            migrationBuilder.DropTable(
                name: "NiveisConhecimento");

            migrationBuilder.DropTable(
                name: "Relatorios");

            migrationBuilder.DropTable(
                name: "GrupoPerguntas");

            migrationBuilder.DropTable(
                name: "Entrevistas");

            migrationBuilder.DropTable(
                name: "Candidatos");

            migrationBuilder.DropSequence(
                name: "SequenciaCandidato",
                schema: "dbo");

            migrationBuilder.DropSequence(
                name: "SequenciaEntrevista",
                schema: "dbo");

            migrationBuilder.DropSequence(
                name: "SequenciaEntrevistador",
                schema: "dbo");

            migrationBuilder.DropSequence(
                name: "SequenciaGrupoPergunta",
                schema: "dbo");

            migrationBuilder.DropSequence(
                name: "SequenciaLinguagem",
                schema: "dbo");

            migrationBuilder.DropSequence(
                name: "SequenciaNivelConhecimento",
                schema: "dbo");

            migrationBuilder.DropSequence(
                name: "SequenciaPergunta",
                schema: "dbo");

            migrationBuilder.DropSequence(
                name: "SequenciaQuestionario",
                schema: "dbo");

            migrationBuilder.DropSequence(
                name: "SequenciaRelatorio",
                schema: "dbo");

            migrationBuilder.DropSequence(
                name: "SequenciaResposta",
                schema: "dbo");
        }
    }
}
