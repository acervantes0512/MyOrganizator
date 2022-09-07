using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MyOrganizator.Data.Modelo
{
    public partial class MyOrganizatorContext : DbContext
    {
        public MyOrganizatorContext()
        {
        }

        public MyOrganizatorContext(DbContextOptions<MyOrganizatorContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AsignacionProyecto> AsignacionProyectos { get; set; }
        public virtual DbSet<AsignacionTipoProyecto> AsignacionTipoProyectos { get; set; }
        public virtual DbSet<PlanActividad> PlanActividads { get; set; }
        public virtual DbSet<Proyecto> Proyectos { get; set; }
        public virtual DbSet<Rol> Rols { get; set; }
        public virtual DbSet<TiempoReal> TiempoReals { get; set; }
        public virtual DbSet<TipoActividad> TipoActividads { get; set; }
        public virtual DbSet<TipoProyecto> TipoProyectos { get; set; }
        public virtual DbSet<TipoTiempo> TipoTiempos { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=ALEXC\\SQLEXPRESS;Initial Catalog=MyOrganizator;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<AsignacionProyecto>(entity =>
            {
                entity.HasKey(e => e.IdAsignacionProyecto)
                    .HasName("PK__Asignaci__2AEDC5E705BE466B");

                entity.ToTable("Asignacion_Proyecto");

                entity.Property(e => e.IdAsignacionProyecto).ValueGeneratedNever();

                entity.HasOne(d => d.IdAsignacionProyectoNavigation)
                    .WithOne(p => p.AsignacionProyecto)
                    .HasForeignKey<AsignacionProyecto>(d => d.IdAsignacionProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Asignacion_Proyecto_Asig_Tipo_Proy");
            });

            modelBuilder.Entity<AsignacionTipoProyecto>(entity =>
            {
                entity.HasKey(e => e.IdAsignacionTipoProy)
                    .HasName("PK__Asignaci__FB8453C836A76DE2");

                entity.ToTable("Asignacion_Tipo_Proyecto");

                entity.Property(e => e.IdAsignacionTipoProy).ValueGeneratedNever();

                entity.HasOne(d => d.IdTipoProyectoNavigation)
                    .WithMany(p => p.AsignacionTipoProyectos)
                    .HasForeignKey(d => d.IdTipoProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ASIGNACION_TIPO_PROY_TIPO_PROY");
            });

            modelBuilder.Entity<PlanActividad>(entity =>
            {
                entity.HasKey(e => e.IdPlanActividad)
                    .HasName("PK__Plan_Act__1393B5D36306DCEA");

                entity.ToTable("Plan_Actividad");

                entity.Property(e => e.IdPlanActividad).ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaFin).HasColumnType("datetime");

                entity.Property(e => e.FechaInicio).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.PlanActividadIdProyectoNavigations)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Plan_Proyecto");

                entity.HasOne(d => d.IdTipoActividadNavigation)
                    .WithMany(p => p.PlanActividadIdTipoActividadNavigations)
                    .HasForeignKey(d => d.IdTipoActividad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Plan_Tipo_Actividad");

                entity.HasOne(d => d.IdTipoTiempoNavigation)
                    .WithMany(p => p.PlanActividads)
                    .HasForeignKey(d => d.IdTipoTiempo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Plan_Tipo_Tiempo");
            });

            modelBuilder.Entity<Proyecto>(entity =>
            {
                entity.HasKey(e => e.IdProyecto)
                    .HasName("PK__Proyecto__F4888673BA610081");

                entity.ToTable("Proyecto");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Etiqueta)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaFin).HasColumnType("datetime");

                entity.Property(e => e.FechaInicio).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAsignacionProyectoNavigation)
                    .WithMany(p => p.Proyectos)
                    .HasForeignKey(d => d.IdAsignacionProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Asignacion_Proyecto");

                entity.HasOne(d => d.IdTipoProyectoNavigation)
                    .WithMany(p => p.Proyectos)
                    .HasForeignKey(d => d.IdTipoProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Proyecto_Tipo_Proyecto");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Proyectos)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Usuario_Proyecto");
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.HasKey(e => e.IdRol)
                    .HasName("PK__Rol__2A49584CB8B5884D");

                entity.ToTable("Rol");

                entity.Property(e => e.IdRol).ValueGeneratedNever();

                entity.Property(e => e.FechaRegistro).HasColumnType("date");

                entity.Property(e => e.NombreRol)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TiempoReal>(entity =>
            {
                entity.HasKey(e => e.IdTiempoReal)
                    .HasName("PK__Tiempo_R__3411891EE84AACE1");

                entity.ToTable("Tiempo_Real");

                entity.Property(e => e.IdTiempoReal).ValueGeneratedNever();

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.HasOne(d => d.IdPlanActividadNavigation)
                    .WithMany(p => p.TiempoReals)
                    .HasForeignKey(d => d.IdPlanActividad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tiempo_Real_Plan");
            });

            modelBuilder.Entity<TipoActividad>(entity =>
            {
                entity.HasKey(e => e.IdTipoActividad)
                    .HasName("PK__Tipo_Act__3CFA6B037C38C880");

                entity.ToTable("Tipo_Actividad");

                entity.Property(e => e.IdTipoActividad).ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoActividadNavigation)
                    .WithOne(p => p.TipoActividad)
                    .HasForeignKey<TipoActividad>(d => d.IdTipoActividad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tipo_Actividad_Asignacion_Proyecto");
            });

            modelBuilder.Entity<TipoProyecto>(entity =>
            {
                entity.HasKey(e => e.IdTipoProyecto)
                    .HasName("PK__Tipo_Pro__6EFCA3D96E0DE853");

                entity.ToTable("Tipo_Proyecto");

                entity.Property(e => e.IdTipoProyecto).ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

              /*entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.TiposProyectos)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientNoAction)
                    .HasConstraintName("FK_Usuario_Tipo_Proyecto");*/
            });

            modelBuilder.Entity<TipoTiempo>(entity =>
            {
                entity.HasKey(e => e.IdTipoTiempo)
                    .HasName("PK__Tipo_Tie__3AF868254FF705F1");

                entity.ToTable("Tipo_Tiempo");

                entity.Property(e => e.IdTipoTiempo).ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__Usuario__5B65BF97C61B55D0");

                entity.ToTable("Usuario");

                entity.Property(e => e.IdUsuario).ValueGeneratedNever();

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Alias')");

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro).HasColumnType("date");

                entity.Property(e => e.NombreUsuario)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PrimerApellido)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PrimerApellido')");

                entity.Property(e => e.PrimerNombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PrimerNombre')");

                entity.Property(e => e.SegundoApellido)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SegundoApellido')");

                entity.Property(e => e.SegundoNombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SegundoNombre')");

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdRol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_USUARIO_ROL");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
