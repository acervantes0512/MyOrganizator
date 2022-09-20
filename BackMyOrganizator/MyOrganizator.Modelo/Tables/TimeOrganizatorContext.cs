using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MyOrganizator.Modelo.Tables
{
    public partial class TimeOrganizatorContext : DbContext
    {
        public TimeOrganizatorContext()
        {
        }

        public TimeOrganizatorContext(DbContextOptions<TimeOrganizatorContext> options)
            : base(options)
        {
        }
        public virtual DbSet<AsignacionProyectoPorDia> AsignacionesProyectoPorDia { get; set; }
        public virtual DbSet<AsignacionTipoProyectoPorDia> AsignacionesTipoProyectoPorDia { get; set; }
        public virtual DbSet<PlanActividad> PlanActividads { get; set; }
        public virtual DbSet<Proyecto> Proyectos { get; set; }
        public virtual DbSet<Rol> Rols { get; set; }
        public virtual DbSet<TiempoReal> TiempoReals { get; set; }
        public virtual DbSet<TipoActividad> TipoActividads { get; set; }
        public virtual DbSet<TipoProyecto> TipoProyectos { get; set; }
        public virtual DbSet<TipoTiempo> TipoTiempos { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Parametros> Parametros { get; set; }
        public virtual DbSet<DiaSemana> DiaSemana { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=ALEXC\\SQLEXPRESS;Initial Catalog=TimeOrganizator;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
