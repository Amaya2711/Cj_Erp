using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

[Table("Db_Operaciones_Cj")]
public partial class DbOperacionesCj
{
    [Key]
    [Column("OT")]
    [StringLength(10)]
    public string Ot { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? FechaInicio { get; set; }

    public int? IdZona { get; set; }

    [StringLength(8)]
    public string? IdSite { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? CorreSite { get; set; }

    [Column("Status_Claro")]
    public int? StatusClaro { get; set; }

    public int? IdDepartamento { get; set; }

    [StringLength(50)]
    public string? IdFarEnd { get; set; }

    public int? IdTransmision { get; set; }

    public int? IdProyecto { get; set; }

    public int? IdTorrera { get; set; }

    public int? IdTipoTorre { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? Altura { get; set; }

    public int? CantSect { get; set; }

    [Column("LPE", TypeName = "datetime")]
    public DateTime? Lpe { get; set; }

    public int? IdOnAir { get; set; }

    public int? IdActaCob { get; set; }

    public int? IdCapitalizacion { get; set; }

    [StringLength(25)]
    public string? NroOc { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? MontoCw { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? MontoEnergia { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? MontoPext { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? MontoTi { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? Monto { get; set; }

    [StringLength(50)]
    public string? Latitud { get; set; }

    [StringLength(50)]
    public string? Longitud { get; set; }

    [StringLength(1000)]
    public string? Direccion { get; set; }

    public int? IdCandado { get; set; }

    public int? IdContacto { get; set; }

    [StringLength(25)]
    public string? Telefono { get; set; }

    public int? IdStatusIng { get; set; }

    [Column("GIS_INGENIERIA")]
    public int? GisIngenieria { get; set; }

    [Column("DATA_ING_TX_CLARO")]
    public int? DataIngTxClaro { get; set; }

    [Column("F_DATA_ING_SOL_TX", TypeName = "datetime")]
    public DateTime? FDataIngSolTx { get; set; }

    [Column("DIAS_DATA")]
    public int? DiasData { get; set; }

    [Column("F_DATA_ING_RX", TypeName = "datetime")]
    public DateTime? FDataIngRx { get; set; }

    [Column("HILOS_ASIG")]
    public int? HilosAsig { get; set; }

    [Column("F_SOL_ASIG_HILOS", TypeName = "datetime")]
    public DateTime? FSolAsigHilos { get; set; }

    [Column("F_RX_ASIG_HILOS", TypeName = "datetime")]
    public DateTime? FRxAsigHilos { get; set; }

    [Column("ID_FAREND")]
    [StringLength(25)]
    public string? IdFarend1 { get; set; }

    public int? AnalistaIng { get; set; }

    public int? NroHilos { get; set; }

    [Column("idContrataResp")]
    public int? IdContrataResp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FecAsigCon { get; set; }

    [Column("F_LEV_CAMPO", TypeName = "datetime")]
    public DateTime? FLevCampo { get; set; }

    [Column("KMZ")]
    public int? Kmz { get; set; }

    [Column("REP_FOT_DISEno")]
    public int? RepFotDiseno { get; set; }

    public int? IdPlanosPdf { get; set; }

    public int? IdDiagramaEmpalme { get; set; }

    public int? PptoDise { get; set; }

    [Column("fecDisenoPext", TypeName = "datetime")]
    public DateTime? FecDisenoPext { get; set; }

    [Column("TIEMPO_SIN_VAL")]
    public int? TiempoSinVal { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FecDisenoPextValidado { get; set; }

    [Column("Status_Diseno")]
    public int? StatusDiseno { get; set; }

    [Column("OBSERVACIONES")]
    [StringLength(1000)]
    public string? Observaciones { get; set; }

    [Column("metradoDiseno", TypeName = "numeric(10, 2)")]
    public decimal? MetradoDiseno { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? MetradoExistente { get; set; }

    [Column("ESTATUS_OC")]
    public int? EstatusOc { get; set; }

    public int? IdIngDinamica { get; set; }

    public int? PreInt { get; set; }

    [Column("RED_FLAG_PROVIAS")]
    public int? RedFlagProvias { get; set; }

    [StringLength(50)]
    public string? SolucionEmerg { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? PotenciaKw { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? PorcenCw { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? PorcenEnergia { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? PorcenPext { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? PorcenTi { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaPext { get; set; }

    public int? StatusPext { get; set; }

    public int? PriPext { get; set; }

    [Column("M_FO_EXISTENTE", TypeName = "numeric(10, 2)")]
    public decimal? MFoExistente { get; set; }

    [Column("M_FO_PROYECTADO", TypeName = "numeric(10, 2)")]
    public decimal? MFoProyectado { get; set; }

    public int? StatusCartaPoste { get; set; }

    [Column("F_SOL_CARTA", TypeName = "datetime")]
    public DateTime? FSolCarta { get; set; }

    [StringLength(150)]
    public string? NroPostesProy { get; set; }

    public int? NroPostesExBt { get; set; }

    public int? NroPostesExAmov { get; set; }

    public int? NroPostesExMt { get; set; }

    public int? TotalPostesElec { get; set; }

    public int? TotalPostes { get; set; }

    [Column("CONCESIONARIA")]
    public int? Concesionaria { get; set; }

    public int? StatusExpPext { get; set; }

    public int? IdStatusElectrica { get; set; }

    [StringLength(50)]
    public string? NroExpediente { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FecIngExpediente { get; set; }

    public int? IdJefeConcesionaria { get; set; }

    public int? IdGestorZonal { get; set; }

    [Column("ESTATUS_INSPECCION")]
    public int? EstatusInspeccion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FecInsp { get; set; }

    public int? IdRespGestion { get; set; }

    public int? PostesObs { get; set; }

    [Column("POSTES_FCC_VAL")]
    public int? PostesFccVal { get; set; }

    [Column("F_VAL_FCC")]
    public int? FValFcc { get; set; }

    public int? IdExpMun { get; set; }

    [Column("MUNICIPALIDAD")]
    public int? Municipalidad { get; set; }

    [Column("fecIngMuni", TypeName = "datetime")]
    public DateTime? FecIngMuni { get; set; }

    [Column("FUIIT")]
    public int? Fuiit { get; set; }

    [StringLength(1500)]
    public string? ComenExpMun { get; set; }

    [Column("PMA")]
    public int? Pma { get; set; }

    [Column("CIRA")]
    public int? Cira { get; set; }

    [Column("PROVIAS")]
    public int? Provias { get; set; }

    [Column("EVAP")]
    public int? Evap { get; set; }

    [Column("SERVIDUMBRE")]
    public int? Servidumbre { get; set; }

    public int? StatPermEspe { get; set; }

    public int? PermEspecial { get; set; }

    [Column("F_FUIIT", TypeName = "datetime")]
    public DateTime? FFuiit { get; set; }

    [Column("F_PMA", TypeName = "datetime")]
    public DateTime? FPma { get; set; }

    [Column("F_CIRA", TypeName = "datetime")]
    public DateTime? FCira { get; set; }

    [Column("F_PROVIAS", TypeName = "datetime")]
    public DateTime? FProvias { get; set; }

    [Column("F_EVAP", TypeName = "datetime")]
    public DateTime? FEvap { get; set; }

    [Column("F_SERVIDUMBRE", TypeName = "datetime")]
    public DateTime? FServidumbre { get; set; }

    [Column("FC_Licencia", TypeName = "datetime")]
    public DateTime? FcLicencia { get; set; }

    public int? Licencia { get; set; }

    [Column("Fin_Licencia", TypeName = "datetime")]
    public DateTime? FinLicencia { get; set; }

    public int? DiasVenc { get; set; }

    public int? StatusEjecCw { get; set; }

    [StringLength(1000)]
    public string? RedFlagCw { get; set; }

    public int? TipoPoste { get; set; }

    public int? AlturaPoste { get; set; }

    public int? StatusPoste { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FecPoste { get; set; }

    public int? TrasladoPoste { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FecTraslado { get; set; }

    public int? CwPreliminar { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaCw { get; set; }

    public int? Parres { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FecParres { get; set; }

    public int? Pararrayos { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FecPararayos { get; set; }

    public int? FcProyecto { get; set; }

    [Column("CWTS")]
    [StringLength(50)]
    public string? Cwts { get; set; }

    [Column("Inicio_CW", TypeName = "datetime")]
    public DateTime? InicioCw { get; set; }

    [Column("Fi_CW", TypeName = "datetime")]
    public DateTime? FiCw { get; set; }

    public int? StatusEjecTi { get; set; }

    [Column("RED_FLAG_TI")]
    [StringLength(1000)]
    public string? RedFlagTi { get; set; }

    public int? Tecnologia { get; set; }

    public int? ModAntena { get; set; }

    public int? CantSectores { get; set; }

    public int? Tipo { get; set; }

    public int? EstHwTi { get; set; }

    [Column("F_SOL_RF", TypeName = "datetime")]
    public DateTime? FSolRf { get; set; }

    [Column("F_ASIG_RF", TypeName = "datetime")]
    public DateTime? FAsigRf { get; set; }

    [Column("F_PAP_RF", TypeName = "datetime")]
    public DateTime? FPapRf { get; set; }

    [Column("F_RX_RF", TypeName = "datetime")]
    public DateTime? FRxRf { get; set; }

    public int? NroDiasRf { get; set; }

    public int? Df { get; set; }

    [Column("WOTX")]
    public int? Wotx { get; set; }

    [Column("SCRIPT")]
    public int? Script { get; set; }

    [Column("FO_PINT")]
    public int? FoPint { get; set; }

    [Column("SOPORTES_RF")]
    public int? SoportesRf { get; set; }

    [Column("CONTRATA_TI")]
    public int? ContrataTi { get; set; }

    [Column("F_ACT_REAL", TypeName = "datetime")]
    public DateTime? FActReal { get; set; }

    [Column("W_ACT_REAL")]
    public int? WActReal { get; set; }

    public int? PtaServ { get; set; }

    public int? EnvActCob { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FecActCob { get; set; }

    public int? Capitalizacion { get; set; }

    [Column("PRIORIDAD_TI")]
    public int? PrioridadTi { get; set; }

    [Column("SEGUIMIENTO_TI")]
    [StringLength(1000)]
    public string? SeguimientoTi { get; set; }

    public int? StatusEnergia { get; set; }

    [StringLength(150)]
    public string? RedCw { get; set; }

    [Column("CONCESIONARIAS")]
    public int? Concesionarias { get; set; }

    [Column("TARIFA_REQUERIDA", TypeName = "numeric(10, 2)")]
    public decimal? TarifaRequerida { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? PotenciaReq { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? PotContratada { get; set; }

    public int? IdGestorEne { get; set; }

    public int? IdLocalidad { get; set; }

    public int? EstExpMunPal { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FecIngExpAc { get; set; }

    [Column("tTransMuniAc")]
    public int? TTransMuniAc { get; set; }

    [Column("COMENTARIOS")]
    [StringLength(2000)]
    public string? Comentarios { get; set; }

    [StringLength(50)]
    public string? ExpElec { get; set; }

    [StringLength(25)]
    public string? NroAtencion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FecIngExp { get; set; }

    [Column("tTrans")]
    public int? TTrans { get; set; }

    [Column("idFact")]
    public int? IdFact { get; set; }

    [Column("fecFact", TypeName = "datetime")]
    public DateTime? FecFact { get; set; }

    [Column("diasFact")]
    public int? DiasFact { get; set; }

    public int? MureteAdec { get; set; }

    [Column("F_MURETE", TypeName = "datetime")]
    public DateTime? FMurete { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? MetrajeProy { get; set; }

    public int? NroPostesproy1 { get; set; }

    public int? IdPresupuestado { get; set; }

    public int? IdContrato { get; set; }

    public int? IdSuministro { get; set; }

    public int? IdTablero { get; set; }

    [Column("Fc_energizado", TypeName = "datetime")]
    public DateTime? FcEnergizado { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FcEneProv { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FecIniEnergia { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FinFecEneriga { get; set; }

    [Column("ComentariosAC")]
    [StringLength(2000)]
    public string? ComentariosAc { get; set; }

    [StringLength(10)]
    public string? W01 { get; set; }

    [StringLength(10)]
    public string? W02 { get; set; }

    [StringLength(10)]
    public string? W03 { get; set; }

    [StringLength(10)]
    public string? W04 { get; set; }

    [StringLength(10)]
    public string? W05 { get; set; }

    [StringLength(10)]
    public string? W06 { get; set; }

    [StringLength(10)]
    public string? W07 { get; set; }

    [StringLength(10)]
    public string? W08 { get; set; }

    [StringLength(10)]
    public string? W09 { get; set; }

    [StringLength(10)]
    public string? W10 { get; set; }

    [StringLength(10)]
    public string? W11 { get; set; }

    [StringLength(10)]
    public string? W12 { get; set; }

    [StringLength(10)]
    public string? W13 { get; set; }

    [StringLength(10)]
    public string? W14 { get; set; }

    [StringLength(10)]
    public string? W15 { get; set; }

    [StringLength(10)]
    public string? W16 { get; set; }

    [StringLength(10)]
    public string? W17 { get; set; }

    [StringLength(10)]
    public string? W18 { get; set; }

    [StringLength(10)]
    public string? W19 { get; set; }

    [StringLength(10)]
    public string? W20 { get; set; }

    [StringLength(10)]
    public string? W21 { get; set; }

    [StringLength(10)]
    public string? W22 { get; set; }

    [StringLength(10)]
    public string? W23 { get; set; }

    [StringLength(10)]
    public string? W24 { get; set; }

    [StringLength(10)]
    public string? W25 { get; set; }

    [StringLength(10)]
    public string? W26 { get; set; }

    [StringLength(10)]
    public string? W27 { get; set; }

    [StringLength(10)]
    public string? W28 { get; set; }

    [StringLength(10)]
    public string? W29 { get; set; }

    [StringLength(10)]
    public string? W30 { get; set; }

    public int? StatusEjecPext { get; set; }

    [Column("redFlagPext")]
    [StringLength(500)]
    public string? RedFlagPext { get; set; }

    public int? IdStatusPext { get; set; }

    public int? Viabilidad { get; set; }

    [Column("ESTADO_HW")]
    public int? EstadoHw { get; set; }

    [Column("F_SOL_FO", TypeName = "datetime")]
    public DateTime? FSolFo { get; set; }

    [Column("F_ASIG_FO", TypeName = "datetime")]
    public DateTime? FAsigFo { get; set; }

    [Column("F_PAP_FO", TypeName = "datetime")]
    public DateTime? FPapFo { get; set; }

    [Column("F_RX_FO", TypeName = "datetime")]
    public DateTime? FRxFo { get; set; }

    public int? NroEntFo { get; set; }

    [Column("COD_POSTE")]
    public int? CodPoste { get; set; }

    [Column("STATUS_DATA_PEXT")]
    public int? StatusDataPext { get; set; }

    public int? PosFib09 { get; set; }

    public int? PosFib11 { get; set; }

    [Column("ESTATUS_POSTES_FV")]
    public int? EstatusPostesFv { get; set; }

    public int? PosCac09 { get; set; }

    public int? PosCac11 { get; set; }

    public int? StatusPostesCac { get; set; }

    public int? TotalPostesFinal { get; set; }

    public int? StatusPostesgral { get; set; }

    public int? AnalistaPext { get; set; }

    [Column("CONTRATA_PEXT")]
    public int? ContrataPext { get; set; }

    [Column("F_INIC_EJEC", TypeName = "datetime")]
    public DateTime? FInicEjec { get; set; }

    [Column("F_FIN_PEXT", TypeName = "datetime")]
    public DateTime? FFinPext { get; set; }

    [Column("W_PEXT_EJEC")]
    public int? WPextEjec { get; set; }

    [Column("POSTES")]
    public int? Postes { get; set; }

    [Column("TENDIDO")]
    public int? Tendido { get; set; }

    [Column("FUSIONES")]
    public int? Fusiones { get; set; }

    [Column("PINT")]
    public int? Pint { get; set; }

    [Column("ACABADOS")]
    public int? Acabados { get; set; }

    public int? NroHilosInstalados { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? MetrajeInstal { get; set; }

    public int? Prioridad { get; set; }

    [StringLength(250)]
    public string? SegPext { get; set; }

    public int? StatusEjecucionTi { get; set; }

    [StringLength(500)]
    public string? RedFlgTi { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FecAct { get; set; }

    [Column("W_ACT")]
    public int? WAct { get; set; }

    public int? IdProyecto1 { get; set; }

    public int? PrioridadClaro { get; set; }

    [Column("Ot_Pap2")]
    public int? OtPap2 { get; set; }

    [Column("usuarioCreacion")]
    [StringLength(15)]
    public string? UsuarioCreacion { get; set; }

    [Column("fechaCreacion", TypeName = "datetime")]
    public DateTime? FechaCreacion { get; set; }

    public int? IdEstado { get; set; }

    [Column("OPE_STAT_INGE_PEXT")]
    public int? OpeStatIngePext { get; set; }

    [Column("Status_Cj")]
    public int? StatusCj { get; set; }

    public int? IdCliente { get; set; }
}
