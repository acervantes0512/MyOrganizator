// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyOrganizator.Modelo.Tables;

namespace MyOrganizator.Modelo.Migrations
{
    [DbContext(typeof(TimeOrganizatorContext))]
    [Migration("20220907193842_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyOrganizator.Data.Modelo.TipoActividad", b =>
                {
                    b.Property<int>("TipoActividadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<int>("IdTipoProyecto")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TipoProyectoId")
                        .HasColumnType("int");

                    b.HasKey("TipoActividadId");

                    b.HasIndex("TipoProyectoId");

                    b.ToTable("TipoActividad");
                });

            modelBuilder.Entity("MyOrganizator.Data.Modelo.TipoProyecto", b =>
                {
                    b.Property<int>("TipoProyectoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TipoProyectoId");

                    b.ToTable("TipoProyectos");
                });

            modelBuilder.Entity("MyOrganizator.Data.Modelo.TipoActividad", b =>
                {
                    b.HasOne("MyOrganizator.Data.Modelo.TipoProyecto", "TipoProyecto")
                        .WithMany("TiposActividades")
                        .HasForeignKey("TipoProyectoId");

                    b.Navigation("TipoProyecto");
                });

            modelBuilder.Entity("MyOrganizator.Data.Modelo.TipoProyecto", b =>
                {
                    b.Navigation("TiposActividades");
                });
#pragma warning restore 612, 618
        }
    }
}
