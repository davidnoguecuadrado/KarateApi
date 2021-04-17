﻿// <auto-generated />
using System;
using Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Context.Migrations
{
    [DbContext(typeof(Contex))]
    [Migration("20210416144408_dsf")]
    partial class dsf
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Categorias", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("Domain.Club", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Clave")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UsuarioID");

                    b.ToTable("Club");
                });

            modelBuilder.Entity("Domain.ClubCategoria", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoriasID")
                        .HasColumnType("int");

                    b.Property<int>("ClubID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CategoriasID");

                    b.HasIndex("ClubID");

                    b.ToTable("ClubCategoria");
                });

            modelBuilder.Entity("Domain.Contenido", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NivelID")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("NivelID");

                    b.ToTable("Contenido");
                });

            modelBuilder.Entity("Domain.ContenidoVideo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContenidoID")
                        .HasColumnType("int");

                    b.Property<int>("VideoID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ContenidoID");

                    b.HasIndex("VideoID");

                    b.ToTable("ContenidoVideo");
                });

            modelBuilder.Entity("Domain.Deportista", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("UsuarioID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UsuarioID");

                    b.ToTable("Deportista");
                });

            modelBuilder.Entity("Domain.DeportistaClub", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClubID")
                        .HasColumnType("int");

                    b.Property<int?>("DeportistaID")
                        .HasColumnType("int");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ClubID");

                    b.HasIndex("DeportistaID");

                    b.ToTable("DeportistaClub");
                });

            modelBuilder.Entity("Domain.DeportistasBaneados", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClubID")
                        .HasColumnType("int");

                    b.Property<int?>("DeportistaID")
                        .HasColumnType("int");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.HasIndex("ClubID");

                    b.HasIndex("DeportistaID");

                    b.ToTable("DeportistasBaneados");
                });

            modelBuilder.Entity("Domain.DeportistasNiveles", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Clave")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DeportistaID")
                        .HasColumnType("int");

                    b.Property<int?>("NivelID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("DeportistaID");

                    b.HasIndex("NivelID");

                    b.ToTable("DeportistasNiveles");
                });

            modelBuilder.Entity("Domain.Invitaciones", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClubID")
                        .HasColumnType("int");

                    b.Property<int?>("DeportistaID")
                        .HasColumnType("int");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.HasIndex("ClubID");

                    b.HasIndex("DeportistaID");

                    b.ToTable("Invitaciones");
                });

            modelBuilder.Entity("Domain.Nivel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClubCategoriaID")
                        .HasColumnType("int");

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ClubCategoriaID");

                    b.ToTable("Nivel");
                });

            modelBuilder.Entity("Domain.Usuario", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Domain.Video", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Video");
                });

            modelBuilder.Entity("Domain.Club", b =>
                {
                    b.HasOne("Domain.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Domain.ClubCategoria", b =>
                {
                    b.HasOne("Domain.Categorias", "Categorias")
                        .WithMany()
                        .HasForeignKey("CategoriasID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Club", "Club")
                        .WithMany()
                        .HasForeignKey("ClubID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categorias");

                    b.Navigation("Club");
                });

            modelBuilder.Entity("Domain.Contenido", b =>
                {
                    b.HasOne("Domain.Nivel", "Nivel")
                        .WithMany()
                        .HasForeignKey("NivelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Nivel");
                });

            modelBuilder.Entity("Domain.ContenidoVideo", b =>
                {
                    b.HasOne("Domain.Contenido", "Contenido")
                        .WithMany()
                        .HasForeignKey("ContenidoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Video", "Video")
                        .WithMany()
                        .HasForeignKey("VideoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contenido");

                    b.Navigation("Video");
                });

            modelBuilder.Entity("Domain.Deportista", b =>
                {
                    b.HasOne("Domain.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Domain.DeportistaClub", b =>
                {
                    b.HasOne("Domain.Club", "Club")
                        .WithMany()
                        .HasForeignKey("ClubID");

                    b.HasOne("Domain.Deportista", "Deportista")
                        .WithMany()
                        .HasForeignKey("DeportistaID");

                    b.Navigation("Club");

                    b.Navigation("Deportista");
                });

            modelBuilder.Entity("Domain.DeportistasBaneados", b =>
                {
                    b.HasOne("Domain.Club", "Club")
                        .WithMany()
                        .HasForeignKey("ClubID");

                    b.HasOne("Domain.Deportista", "Deportista")
                        .WithMany()
                        .HasForeignKey("DeportistaID");

                    b.Navigation("Club");

                    b.Navigation("Deportista");
                });

            modelBuilder.Entity("Domain.DeportistasNiveles", b =>
                {
                    b.HasOne("Domain.Deportista", "Deportistas")
                        .WithMany()
                        .HasForeignKey("DeportistaID");

                    b.HasOne("Domain.Nivel", "Nivel")
                        .WithMany()
                        .HasForeignKey("NivelID");

                    b.Navigation("Deportistas");

                    b.Navigation("Nivel");
                });

            modelBuilder.Entity("Domain.Invitaciones", b =>
                {
                    b.HasOne("Domain.Club", "Club")
                        .WithMany()
                        .HasForeignKey("ClubID");

                    b.HasOne("Domain.Deportista", "Deportista")
                        .WithMany()
                        .HasForeignKey("DeportistaID");

                    b.Navigation("Club");

                    b.Navigation("Deportista");
                });

            modelBuilder.Entity("Domain.Nivel", b =>
                {
                    b.HasOne("Domain.ClubCategoria", "ClubCategoria")
                        .WithMany()
                        .HasForeignKey("ClubCategoriaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClubCategoria");
                });
#pragma warning restore 612, 618
        }
    }
}
