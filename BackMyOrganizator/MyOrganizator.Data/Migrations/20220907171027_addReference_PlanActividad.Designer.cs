﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyOrganizator.Data.Modelo;

namespace MyOrganizator.Data.Migrations
{
    [DbContext(typeof(MyOrganizatorContext))]
    [Migration("20220907171027_addReference_PlanActividad")]
    partial class addReference_PlanActividad
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyOrganizator.Data.Modelo.AsignacionProyecto", b =>
                {
                    b.Property<int>("IdAsignacionProyecto")
                        .HasColumnType("int");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<int>("IdAsignacionTipoProy")
                        .HasColumnType("int");

                    b.Property<int>("Porcentaje")
                        .HasColumnType("int");

                    b.HasKey("IdAsignacionProyecto")
                        .HasName("PK__Asignaci__2AEDC5E705BE466B");

                    b.ToTable("Asignacion_Proyecto");
                });

            modelBuilder.Entity("MyOrganizator.Data.Modelo.AsignacionTipoProyecto", b =>
                {
                    b.Property<int>("IdAsignacionTipoProy")
                        .HasColumnType("int");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<int>("IdTipoProyecto")
                        .HasColumnType("int");

                    b.Property<int>("Porcentaje")
                        .HasColumnType("int");

                    b.HasKey("IdAsignacionTipoProy")
                        .HasName("PK__Asignaci__FB8453C836A76DE2");

                    b.HasIndex("IdTipoProyecto");

                    b.ToTable("Asignacion_Tipo_Proyecto");
                });

            modelBuilder.Entity("MyOrganizator.Data.Modelo.PlanActividad", b =>
                {
                    b.Property<int>("IdPlanActividad")
                        .HasColumnType("int");

                    b.Property<int?>("AsignacionProyectoIdAsignacionProyecto")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)");

                    b.Property<int>("DuracionMinutos")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime");

                    b.Property<int>("IdProyecto")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoActividad")
                        .HasColumnType("int");

                    b.Property<int?>("IdTipoActividadNavigateIdTipoActividad")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoTiempo")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<int>("OrdenEjecucion")
                        .HasColumnType("int");

                    b.HasKey("IdPlanActividad")
                        .HasName("PK__Plan_Act__1393B5D36306DCEA");

                    b.HasIndex("AsignacionProyectoIdAsignacionProyecto");

                    b.HasIndex("IdTipoActividad");

                    b.HasIndex("IdTipoActividadNavigateIdTipoActividad");

                    b.HasIndex("IdTipoTiempo");

                    b.ToTable("Plan_Actividad");
                });

            modelBuilder.Entity("MyOrganizator.Data.Modelo.Proyecto", b =>
                {
                    b.Property<int>("IdProyecto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)");

                    b.Property<int>("DuracionMinutos")
                        .HasColumnType("int");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<string>("Etiqueta")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime");

                    b.Property<int>("IdAsignacionProyecto")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoProyecto")
                        .HasColumnType("int");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("IdProyecto")
                        .HasName("PK__Proyecto__F4888673BA610081");

                    b.HasIndex("IdAsignacionProyecto");

                    b.HasIndex("IdTipoProyecto");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Proyecto");
                });

            modelBuilder.Entity("MyOrganizator.Data.Modelo.Rol", b =>
                {
                    b.Property<int>("IdRol")
                        .HasColumnType("int");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("date");

                    b.Property<string>("NombreRol")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.HasKey("IdRol")
                        .HasName("PK__Rol__2A49584CB8B5884D");

                    b.ToTable("Rol");
                });

            modelBuilder.Entity("MyOrganizator.Data.Modelo.TiempoReal", b =>
                {
                    b.Property<int>("IdTiempoReal")
                        .HasColumnType("int");

                    b.Property<int>("DuracionMinutos")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaRegistro")
                        .HasColumnType("datetime");

                    b.Property<int>("IdPlanActividad")
                        .HasColumnType("int");

                    b.HasKey("IdTiempoReal")
                        .HasName("PK__Tiempo_R__3411891EE84AACE1");

                    b.HasIndex("IdPlanActividad");

                    b.ToTable("Tiempo_Real");
                });

            modelBuilder.Entity("MyOrganizator.Data.Modelo.TipoActividad", b =>
                {
                    b.Property<int>("IdTipoActividad")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<int>("IdTipoProyecto")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("IdTipoActividad")
                        .HasName("PK__Tipo_Act__3CFA6B037C38C880");

                    b.ToTable("Tipo_Actividad");
                });

            modelBuilder.Entity("MyOrganizator.Data.Modelo.TipoProyecto", b =>
                {
                    b.Property<int>("IdTipoProyecto")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.HasKey("IdTipoProyecto")
                        .HasName("PK__Tipo_Pro__6EFCA3D96E0DE853");

                    b.ToTable("Tipo_Proyecto");
                });

            modelBuilder.Entity("MyOrganizator.Data.Modelo.TipoTiempo", b =>
                {
                    b.Property<int>("IdTipoTiempo")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("IdTipoTiempo")
                        .HasName("PK__Tipo_Tie__3AF868254FF705F1");

                    b.ToTable("Tipo_Tiempo");
                });

            modelBuilder.Entity("MyOrganizator.Data.Modelo.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("Alias")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasDefaultValueSql("('Alias')");

                    b.Property<string>("Clave")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("date");

                    b.Property<int>("IdRol")
                        .HasColumnType("int");

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("PrimerApellido")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasDefaultValueSql("('PrimerApellido')");

                    b.Property<string>("PrimerNombre")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasDefaultValueSql("('PrimerNombre')");

                    b.Property<string>("SegundoApellido")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasDefaultValueSql("('SegundoApellido')");

                    b.Property<string>("SegundoNombre")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasDefaultValueSql("('SegundoNombre')");

                    b.Property<int?>("TipoProyectoIdTipoProyecto")
                        .HasColumnType("int");

                    b.HasKey("IdUsuario")
                        .HasName("PK__Usuario__5B65BF97C61B55D0");

                    b.HasIndex("IdRol");

                    b.HasIndex("TipoProyectoIdTipoProyecto");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("MyOrganizator.Data.Modelo.AsignacionProyecto", b =>
                {
                    b.HasOne("MyOrganizator.Data.Modelo.AsignacionTipoProyecto", "IdAsignacionProyectoNavigation")
                        .WithOne("AsignacionProyecto")
                        .HasForeignKey("MyOrganizator.Data.Modelo.AsignacionProyecto", "IdAsignacionProyecto")
                        .HasConstraintName("FK_Asignacion_Proyecto_Asig_Tipo_Proy")
                        .IsRequired();

                    b.Navigation("IdAsignacionProyectoNavigation");
                });

            modelBuilder.Entity("MyOrganizator.Data.Modelo.AsignacionTipoProyecto", b =>
                {
                    b.HasOne("MyOrganizator.Data.Modelo.TipoProyecto", "IdTipoProyectoNavigation")
                        .WithMany("AsignacionTipoProyectos")
                        .HasForeignKey("IdTipoProyecto")
                        .HasConstraintName("FK_ASIGNACION_TIPO_PROY_TIPO_PROY")
                        .IsRequired();

                    b.Navigation("IdTipoProyectoNavigation");
                });

            modelBuilder.Entity("MyOrganizator.Data.Modelo.PlanActividad", b =>
                {
                    b.HasOne("MyOrganizator.Data.Modelo.AsignacionProyecto", null)
                        .WithMany("PlanActividadIdProyectoNavigations")
                        .HasForeignKey("AsignacionProyectoIdAsignacionProyecto");

                    b.HasOne("MyOrganizator.Data.Modelo.AsignacionProyecto", "IdTipoActividadNavigation")
                        .WithMany("PlanActividadIdTipoActividadNavigations")
                        .HasForeignKey("IdTipoActividad")
                        .HasConstraintName("FK_Plan_Tipo_Actividad")
                        .IsRequired();

                    b.HasOne("MyOrganizator.Data.Modelo.TipoActividad", "IdTipoActividadNavigate")
                        .WithMany()
                        .HasForeignKey("IdTipoActividadNavigateIdTipoActividad");

                    b.HasOne("MyOrganizator.Data.Modelo.TipoProyecto", "IdTipoTiempoNavigation")
                        .WithMany("PlanActividads")
                        .HasForeignKey("IdTipoTiempo")
                        .HasConstraintName("FK_Plan_Tipo_Tiempo")
                        .IsRequired();

                    b.Navigation("IdTipoActividadNavigate");

                    b.Navigation("IdTipoActividadNavigation");

                    b.Navigation("IdTipoTiempoNavigation");
                });

            modelBuilder.Entity("MyOrganizator.Data.Modelo.Proyecto", b =>
                {
                    b.HasOne("MyOrganizator.Data.Modelo.AsignacionProyecto", "IdAsignacionProyectoNavigation")
                        .WithMany("Proyectos")
                        .HasForeignKey("IdAsignacionProyecto")
                        .HasConstraintName("FK_Asignacion_Proyecto")
                        .IsRequired();

                    b.HasOne("MyOrganizator.Data.Modelo.TipoProyecto", "IdTipoProyectoNavigation")
                        .WithMany("Proyectos")
                        .HasForeignKey("IdTipoProyecto")
                        .HasConstraintName("FK_Proyecto_Tipo_Proyecto")
                        .IsRequired();

                    b.HasOne("MyOrganizator.Data.Modelo.Usuario", "IdUsuarioNavigation")
                        .WithMany("Proyectos")
                        .HasForeignKey("IdUsuario")
                        .HasConstraintName("FK_Usuario_Proyecto")
                        .IsRequired();

                    b.Navigation("IdAsignacionProyectoNavigation");

                    b.Navigation("IdTipoProyectoNavigation");

                    b.Navigation("IdUsuarioNavigation");
                });

            modelBuilder.Entity("MyOrganizator.Data.Modelo.TiempoReal", b =>
                {
                    b.HasOne("MyOrganizator.Data.Modelo.PlanActividad", "IdPlanActividadNavigation")
                        .WithMany("TiempoReals")
                        .HasForeignKey("IdPlanActividad")
                        .HasConstraintName("FK_Tiempo_Real_Plan")
                        .IsRequired();

                    b.Navigation("IdPlanActividadNavigation");
                });

            modelBuilder.Entity("MyOrganizator.Data.Modelo.TipoActividad", b =>
                {
                    b.HasOne("MyOrganizator.Data.Modelo.TipoProyecto", "IdTipoActividadNavigation")
                        .WithOne("TipoActividad")
                        .HasForeignKey("MyOrganizator.Data.Modelo.TipoActividad", "IdTipoActividad")
                        .HasConstraintName("FK_Tipo_Actividad_Asignacion_Proyecto")
                        .IsRequired();

                    b.Navigation("IdTipoActividadNavigation");
                });

            modelBuilder.Entity("MyOrganizator.Data.Modelo.Usuario", b =>
                {
                    b.HasOne("MyOrganizator.Data.Modelo.Rol", "IdRolNavigation")
                        .WithMany("Usuarios")
                        .HasForeignKey("IdRol")
                        .HasConstraintName("FK_USUARIO_ROL")
                        .IsRequired();

                    b.HasOne("MyOrganizator.Data.Modelo.TipoProyecto", null)
                        .WithMany("Usuarios")
                        .HasForeignKey("TipoProyectoIdTipoProyecto");

                    b.Navigation("IdRolNavigation");
                });

            modelBuilder.Entity("MyOrganizator.Data.Modelo.AsignacionProyecto", b =>
                {
                    b.Navigation("PlanActividadIdProyectoNavigations");

                    b.Navigation("PlanActividadIdTipoActividadNavigations");

                    b.Navigation("Proyectos");
                });

            modelBuilder.Entity("MyOrganizator.Data.Modelo.AsignacionTipoProyecto", b =>
                {
                    b.Navigation("AsignacionProyecto");
                });

            modelBuilder.Entity("MyOrganizator.Data.Modelo.PlanActividad", b =>
                {
                    b.Navigation("TiempoReals");
                });

            modelBuilder.Entity("MyOrganizator.Data.Modelo.Rol", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("MyOrganizator.Data.Modelo.TipoProyecto", b =>
                {
                    b.Navigation("AsignacionTipoProyectos");

                    b.Navigation("PlanActividads");

                    b.Navigation("Proyectos");

                    b.Navigation("TipoActividad");

                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("MyOrganizator.Data.Modelo.Usuario", b =>
                {
                    b.Navigation("Proyectos");
                });
#pragma warning restore 612, 618
        }
    }
}
