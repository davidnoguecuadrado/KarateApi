using Microsoft.EntityFrameworkCore.Migrations;

namespace Context.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Correo = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Video",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Video", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Club",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioID = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<int>(type: "int", nullable: false),
                    Clave = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Club", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Club_Usuario_UsuarioID",
                        column: x => x.UsuarioID,
                        principalTable: "Usuario",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Deportista",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deportista", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Deportista_Usuario_UsuarioID",
                        column: x => x.UsuarioID,
                        principalTable: "Usuario",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClubCategoria",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClubID = table.Column<int>(type: "int", nullable: false),
                    CategoriasID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClubCategoria", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ClubCategoria_Categorias_CategoriasID",
                        column: x => x.CategoriasID,
                        principalTable: "Categorias",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClubCategoria_Club_ClubID",
                        column: x => x.ClubID,
                        principalTable: "Club",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DeportistaClub",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClubID = table.Column<int>(type: "int", nullable: true),
                    DeportistaID = table.Column<int>(type: "int", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeportistaClub", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DeportistaClub_Club_ClubID",
                        column: x => x.ClubID,
                        principalTable: "Club",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DeportistaClub_Deportista_DeportistaID",
                        column: x => x.DeportistaID,
                        principalTable: "Deportista",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DeportistasBaneados",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClubID = table.Column<int>(type: "int", nullable: true),
                    DeportistaID = table.Column<int>(type: "int", nullable: true),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeportistasBaneados", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DeportistasBaneados_Club_ClubID",
                        column: x => x.ClubID,
                        principalTable: "Club",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DeportistasBaneados_Deportista_DeportistaID",
                        column: x => x.DeportistaID,
                        principalTable: "Deportista",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Invitaciones",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClubID = table.Column<int>(type: "int", nullable: true),
                    DeportistaID = table.Column<int>(type: "int", nullable: true),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invitaciones", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Invitaciones_Club_ClubID",
                        column: x => x.ClubID,
                        principalTable: "Club",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Invitaciones_Deportista_DeportistaID",
                        column: x => x.DeportistaID,
                        principalTable: "Deportista",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Nivel",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClubCategoriaID = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nivel", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Nivel_ClubCategoria_ClubCategoriaID",
                        column: x => x.ClubCategoriaID,
                        principalTable: "ClubCategoria",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contenido",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NivelID = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contenido", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Contenido_Nivel_NivelID",
                        column: x => x.NivelID,
                        principalTable: "Nivel",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DeportistasNiveles",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeportistaID = table.Column<int>(type: "int", nullable: true),
                    NivelID = table.Column<int>(type: "int", nullable: true),
                    Clave = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeportistasNiveles", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DeportistasNiveles_Deportista_DeportistaID",
                        column: x => x.DeportistaID,
                        principalTable: "Deportista",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DeportistasNiveles_Nivel_NivelID",
                        column: x => x.NivelID,
                        principalTable: "Nivel",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContenidoVideo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContenidoID = table.Column<int>(type: "int", nullable: false),
                    VideoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContenidoVideo", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ContenidoVideo_Contenido_ContenidoID",
                        column: x => x.ContenidoID,
                        principalTable: "Contenido",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContenidoVideo_Video_VideoID",
                        column: x => x.VideoID,
                        principalTable: "Video",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Club_UsuarioID",
                table: "Club",
                column: "UsuarioID");

            migrationBuilder.CreateIndex(
                name: "IX_ClubCategoria_CategoriasID",
                table: "ClubCategoria",
                column: "CategoriasID");

            migrationBuilder.CreateIndex(
                name: "IX_ClubCategoria_ClubID",
                table: "ClubCategoria",
                column: "ClubID");

            migrationBuilder.CreateIndex(
                name: "IX_Contenido_NivelID",
                table: "Contenido",
                column: "NivelID");

            migrationBuilder.CreateIndex(
                name: "IX_ContenidoVideo_ContenidoID",
                table: "ContenidoVideo",
                column: "ContenidoID");

            migrationBuilder.CreateIndex(
                name: "IX_ContenidoVideo_VideoID",
                table: "ContenidoVideo",
                column: "VideoID");

            migrationBuilder.CreateIndex(
                name: "IX_Deportista_UsuarioID",
                table: "Deportista",
                column: "UsuarioID");

            migrationBuilder.CreateIndex(
                name: "IX_DeportistaClub_ClubID",
                table: "DeportistaClub",
                column: "ClubID");

            migrationBuilder.CreateIndex(
                name: "IX_DeportistaClub_DeportistaID",
                table: "DeportistaClub",
                column: "DeportistaID");

            migrationBuilder.CreateIndex(
                name: "IX_DeportistasBaneados_ClubID",
                table: "DeportistasBaneados",
                column: "ClubID");

            migrationBuilder.CreateIndex(
                name: "IX_DeportistasBaneados_DeportistaID",
                table: "DeportistasBaneados",
                column: "DeportistaID");

            migrationBuilder.CreateIndex(
                name: "IX_DeportistasNiveles_DeportistaID",
                table: "DeportistasNiveles",
                column: "DeportistaID");

            migrationBuilder.CreateIndex(
                name: "IX_DeportistasNiveles_NivelID",
                table: "DeportistasNiveles",
                column: "NivelID");

            migrationBuilder.CreateIndex(
                name: "IX_Invitaciones_ClubID",
                table: "Invitaciones",
                column: "ClubID");

            migrationBuilder.CreateIndex(
                name: "IX_Invitaciones_DeportistaID",
                table: "Invitaciones",
                column: "DeportistaID");

            migrationBuilder.CreateIndex(
                name: "IX_Nivel_ClubCategoriaID",
                table: "Nivel",
                column: "ClubCategoriaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContenidoVideo");

            migrationBuilder.DropTable(
                name: "DeportistaClub");

            migrationBuilder.DropTable(
                name: "DeportistasBaneados");

            migrationBuilder.DropTable(
                name: "DeportistasNiveles");

            migrationBuilder.DropTable(
                name: "Invitaciones");

            migrationBuilder.DropTable(
                name: "Contenido");

            migrationBuilder.DropTable(
                name: "Video");

            migrationBuilder.DropTable(
                name: "Deportista");

            migrationBuilder.DropTable(
                name: "Nivel");

            migrationBuilder.DropTable(
                name: "ClubCategoria");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Club");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
