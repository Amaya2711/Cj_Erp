using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

[Keyless]
public partial class DetSolicitud
{
    public int IdCliente { get; set; }

    public int IdProyecto { get; set; }

    [StringLength(8)]
    public string IdSite { get; set; } = null!;

    [Column(TypeName = "numeric(18, 0)")]
    public decimal CorreSite { get; set; }

    [StringLength(50)]
    public string TipoTrabajo { get; set; } = null!;

    [StringLength(10)]
    public string PedidoSap { get; set; } = null!;

    [StringLength(10)]
    public string NroSolicitud { get; set; } = null!;

    [StringLength(6)]
    public string Posicion { get; set; } = null!;

    [StringLength(50)]
    public string Correlativo { get; set; } = null!;

    [StringLength(50)]
    public string? Serie { get; set; }

    [StringLength(10)]
    public string? CodPap { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? CantSap { get; set; }

    [StringLength(20)]
    public string? Centro { get; set; }

    [StringLength(20)]
    public string? Almacen { get; set; }

    [StringLength(20)]
    public string? Lote { get; set; }

    [StringLength(10)]
    public string? Usuario { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Fecha { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Hora { get; set; }

    public int? IdEstado { get; set; }

    [StringLength(500)]
    public string? Observacion { get; set; }

    [StringLength(2500)]
    public string? Comentario { get; set; }

    public int? LinReg { get; set; }

    public int? NroEnvio { get; set; }

    public int? IdClienteOrigen { get; set; }

    public int? IdProyectoOrigen { get; set; }

    [StringLength(8)]
    public string? IdSiteOrigen { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? CorreSiteOrigen { get; set; }

    [StringLength(50)]
    public string? TipoTrabajoOrigen { get; set; }

    [StringLength(150)]
    public string? RutaImagen { get; set; }

    public bool? IdDespacho { get; set; }

    [StringLength(500)]
    public string? ComenEnvio { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaEnvio { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? HoraEnvio { get; set; }

    [StringLength(50)]
    public string? NroGuia { get; set; }

    public int? IdAgencia { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? MontoEnvio { get; set; }

    public int? IdRespEnvio { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaEntrega { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaEnviado { get; set; }

    public int? Aplica { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaRecojo { get; set; }

    [StringLength(50)]
    public string? ImagenEnvio { get; set; }

    public int? IdUbicacion { get; set; }

    public int? IdRespCampo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaCampo { get; set; }

    [StringLength(10)]
    public string? UsuarioMod { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaAprobar { get; set; }

    public int? IdRespAprobar { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaDespacho { get; set; }

    public int? IdRespDespacho { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaSolicitud { get; set; }

    public int? IdRespSolicitud { get; set; }

    [StringLength(50)]
    public string? ImagenSolicitud { get; set; }

    public int? IdRespRecojo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaCierre { get; set; }

    public int? IdRespCierre { get; set; }

    [StringLength(50)]
    public string? UsuarioCreacion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaCreacion { get; set; }

    [StringLength(50)]
    public string? ImagenCierre { get; set; }

    public int? IdRespObs { get; set; }

    public int? IdRespRec { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaRechazar { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaObs { get; set; }

    [StringLength(1000)]
    public string? RutaDesImagen { get; set; }

    public int? NroCierre { get; set; }

    [StringLength(10)]
    public string? NumeroCierre { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? CantDesp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaCruce { get; set; }

    public int? IdRespCruce { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? CantEnvio { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? CantCampo { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? CantCruce { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? CantCierre { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? CantFolio { get; set; }

    [StringLength(50)]
    public string? NroFolio { get; set; }

    [StringLength(50)]
    public string? NroOc { get; set; }

    [StringLength(50)]
    public string? NroPosicion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaTermino { get; set; }

    public int? IdRespTermino { get; set; }

    public int? IdBloqueo { get; set; }

    [StringLength(50)]
    public string? NroGuiaRetorno { get; set; }

    public int? IdAgenciaRetorno { get; set; }

    [StringLength(50)]
    public string? Region { get; set; }

    [StringLength(6)]
    public string? PosicionLog { get; set; }

    [StringLength(250)]
    public string? ImagenExcedente { get; set; }

    public int? IdExcedente { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaExce { get; set; }

    [StringLength(50)]
    public string? NroGuiaExce { get; set; }

    [StringLength(50)]
    public string? ImagenRecojo { get; set; }

    public int? IdAgenciaExce { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaRecojer { get; set; }

    public int? IdRecojer { get; set; }
}
