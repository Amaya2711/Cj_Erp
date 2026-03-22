using System;
using System.Collections.Generic;
using DxCjERP.Persistence.Entities;
using Microsoft.EntityFrameworkCore;
using DxCjERPVersion = DxCjERP.Persistence.Entities.Version;

namespace DxCjERP.Persistence.Context;

public partial class DxCjERPDbContext : DbContext
{
    public DxCjERPDbContext()
    {
    }

    public DxCjERPDbContext(DbContextOptions<DxCjERPDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<LogAsignacion> LogAsignacion { get; set; }

    public virtual DbSet<LogCabLogistica> LogCabLogistica { get; set; }

    public virtual DbSet<LogDetLogistica> LogDetLogistica { get; set; }

    public virtual DbSet<LogOperaciones> LogOperaciones { get; set; }

    public virtual DbSet<LogPlanilla> LogPlanilla { get; set; }

    public virtual DbSet<Material> Material { get; set; }

    public virtual DbSet<MaterialSerie> MaterialSerie { get; set; }

    public virtual DbSet<MaterialStock> MaterialStock { get; set; }

    public virtual DbSet<MaterialTrabajo> MaterialTrabajo { get; set; }

    public virtual DbSet<MovEstadosPagos> MovEstadosPagos { get; set; }

    public virtual DbSet<MovMaterial> MovMaterial { get; set; }

    public virtual DbSet<NodoPlantilla> NodoPlantilla { get; set; }

    public virtual DbSet<Ot> Ot { get; set; }

    public virtual DbSet<Pap> Pap { get; set; }

    public virtual DbSet<PlaEvidencia> PlaEvidencia { get; set; }

    public virtual DbSet<PlaNodoPrincipal> PlaNodoPrincipal { get; set; }

    public virtual DbSet<PlaPlantilla> PlaPlantilla { get; set; }

    public virtual DbSet<PlaSegmento> PlaSegmento { get; set; }

    public virtual DbSet<Planilla> Planilla { get; set; }

    public virtual DbSet<PlantillaImagenes> PlantillaImagenes { get; set; }

    public virtual DbSet<PlantillaSeguimientoImagenes> PlantillaSeguimientoImagenes { get; set; }

    public virtual DbSet<Portal> Portal { get; set; }

    public virtual DbSet<Principal> Principal { get; set; }

    public virtual DbSet<Proyecto> Proyecto { get; set; }

    public virtual DbSet<ProyectosCompletos> ProyectosCompletos { get; set; }

    public virtual DbSet<SeguimientoMulta> SeguimientoMulta { get; set; }

    public virtual DbSet<Site> Site { get; set; }

    public virtual DbSet<SolicitudEnvio> SolicitudEnvio { get; set; }

    public virtual DbSet<Ubicacion> Ubicacion { get; set; }

    public virtual DbSet<Ubigeo> Ubigeo { get; set; }

    public virtual DbSet<UpdImportar> UpdImportar { get; set; }

    public virtual DbSet<Usuario> Usuario { get; set; }

    public virtual DbSet<DxCjERPVersion> Version { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LogDetLogistica>(entity =>
        {
            entity.Property(e => e.Correlativo).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<MaterialSerie>(entity =>
        {
            entity.Property(e => e.CorrelativoInt).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<MovMaterial>(entity =>
        {
            entity.Property(e => e.CorrelativoInt).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<NodoPlantilla>(entity =>
        {
            entity.Property(e => e.FechaRegistro).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<Ot>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Ot1, e.StatusRni }).HasName("PK__OT__F1B10FCF533EB461");
        });

        modelBuilder.Entity<PlaEvidencia>(entity =>
        {
            entity.HasKey(e => e.EvidenciaId).HasName("PK__pla_Evid__4D9FCB480497853B");

            entity.HasOne(d => d.Segmento).WithMany(p => p.PlaEvidencia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__pla_Evide__Segme__432CD318");
        });

        modelBuilder.Entity<PlaNodoPrincipal>(entity =>
        {
            entity.HasKey(e => e.NodoId).HasName("PK__pla_Nodo__67D05C8E92962414");
        });

        modelBuilder.Entity<PlaPlantilla>(entity =>
        {
            entity.HasKey(e => e.PlantillaId).HasName("PK__pla_Plan__C5DEB58C3E59D09E");

            entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Nodo).WithMany(p => p.PlaPlantilla)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__pla_Plant__NodoI__3D73F9C2");
        });

        modelBuilder.Entity<PlaSegmento>(entity =>
        {
            entity.HasKey(e => e.SegmentoId).HasName("PK__pla_Segm__DC1DD013A11C1814");

            entity.HasOne(d => d.Plantilla).WithMany(p => p.PlaSegmento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__pla_Segme__Plant__4050666D");
        });

        modelBuilder.Entity<Planilla>(entity =>
        {
            entity.HasKey(e => new { e.IdProyecto, e.IdSite, e.IdTipoTrabajo, e.IdTarea, e.Correlativo, e.IdCliente }).HasName("PK__Planilla__B8F81F4F68897B20");
        });

        modelBuilder.Entity<PlantillaImagenes>(entity =>
        {
            entity.HasKey(e => e.PlantillaImagenId).HasName("PK__Plantill__7DF49F67FC15B482");

            entity.Property(e => e.FechaRegistro).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Evidencia).WithMany(p => p.PlantillaImagenes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Plantilla__Evide__517AF26F");

            entity.HasOne(d => d.Nodo).WithMany(p => p.PlantillaImagenes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Plantilla__NodoI__4E9E85C4");

            entity.HasOne(d => d.Plantilla).WithMany(p => p.PlantillaImagenes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Plantilla__Plant__4F92A9FD");

            entity.HasOne(d => d.Segmento).WithMany(p => p.PlantillaImagenes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Plantilla__Segme__5086CE36");
        });

        modelBuilder.Entity<PlantillaSeguimientoImagenes>(entity =>
        {
            entity.Property(e => e.FechaRegistro).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Portal>(entity =>
        {
            entity.HasKey(e => new { e.Idsolicitud, e.OcPos }).HasName("PK__PORTAL__C230C259A54BD0F7");
        });

        modelBuilder.Entity<Proyecto>(entity =>
        {
            entity.HasKey(e => e.IdProyecto).HasName("PK__Proyecto__F4888673AD222081");

            entity.Property(e => e.IdProyecto).ValueGeneratedNever();
        });

        modelBuilder.Entity<Site>(entity =>
        {
            entity.HasKey(e => new { e.Correlativo, e.IdZona, e.NombreSite, e.IdSite }).HasName("PK__Site__BE7A0F1FE4122DE1");
        });

        modelBuilder.Entity<Ubicacion>(entity =>
        {
            entity.Property(e => e.Fechacreacion).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__Usuario__5B65BF975BE5BC7A");
        });

        modelBuilder.Entity<DxCjERPVersion>(entity =>
        {
            entity.Property(e => e.IdVersion).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
