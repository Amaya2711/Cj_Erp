using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Persistence.Entities;

[Keyless]
[Table("PROYECTOS_COMPLETOS")]
public partial class ProyectosCompletos
{
    [Column("OT")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Ot { get; set; }

    [Column("ZONA")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Zona { get; set; }

    [Column("ID_SITE")]
    [StringLength(50)]
    [Unicode(false)]
    public string? IdSite { get; set; }

    [Column("SITE_NAME")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SiteName { get; set; }

    [Column("ESTATUS_CLARO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EstatusClaro { get; set; }

    [Column("DEPARTAMENTO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Departamento { get; set; }

    [Column("FAR_END")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FarEnd { get; set; }

    [Column("TRANSM_")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Transm { get; set; }

    [Column("PROYECTO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Proyecto { get; set; }

    [Column("TORRERA")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Torrera { get; set; }

    [Column("TIPO_TORRE")]
    [StringLength(50)]
    [Unicode(false)]
    public string? TipoTorre { get; set; }

    [Column("ALTURA")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Altura { get; set; }

    [Column("CANTIDAD_SECTORES")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CantidadSectores { get; set; }

    [Column("LPE")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Lpe { get; set; }

    [Column("ON_AIR")]
    [StringLength(50)]
    [Unicode(false)]
    public string? OnAir { get; set; }

    [Column("ACTA_COBERT_")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ActaCobert { get; set; }

    [Column("CAPITALIZACION")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Capitalizacion { get; set; }

    [Column("N_OC")]
    [StringLength(50)]
    [Unicode(false)]
    public string? NOc { get; set; }

    [Column("MONTO_S_CW")]
    [StringLength(50)]
    [Unicode(false)]
    public string? MontoSCw { get; set; }

    [Column("MONTO_S_ENERGIA")]
    [StringLength(50)]
    [Unicode(false)]
    public string? MontoSEnergia { get; set; }

    [Column("MONTO_S_PEXT")]
    [StringLength(50)]
    [Unicode(false)]
    public string? MontoSPext { get; set; }

    [Column("MONTO_S_TI")]
    [StringLength(50)]
    [Unicode(false)]
    public string? MontoSTi { get; set; }

    [Column("MONTO_S_")]
    [StringLength(50)]
    [Unicode(false)]
    public string? MontoS { get; set; }

    [Column("DATOS")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Datos { get; set; }

    [Column("LATITUD")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Latitud { get; set; }

    [Column("LONGITUD")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Longitud { get; set; }

    [Column("DIRECCION")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Direccion { get; set; }

    [Column("CAND_VALIDADO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CandValidado { get; set; }

    [Column("CONTACTO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Contacto { get; set; }

    [Column("TELF_")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Telf { get; set; }

    [Column("INGENIERÍA")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Ingeniería { get; set; }

    [Column("PRIORIDAD_ING")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PrioridadIng { get; set; }

    [Column("PRIORIDAD_IMP")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PrioridadImp { get; set; }

    [Column("ESTATUS_INGENIERIA_PEXT")]
    [StringLength(250)]
    [Unicode(false)]
    public string? EstatusIngenieriaPext { get; set; }

    [Column("GIS_INGENIERIA")]
    [StringLength(50)]
    [Unicode(false)]
    public string? GisIngenieria { get; set; }

    [Column("DATA_ING_TX_CLARO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DataIngTxClaro { get; set; }

    [Column("PEXT")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Pext { get; set; }

    [Column("DIAS_DATA")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DiasData { get; set; }

    [Column("F_DATA_ING_RX")]
    [StringLength(15)]
    [Unicode(false)]
    public string? FDataIngRx { get; set; }

    [Column("HILOS_ASIG")]
    [StringLength(50)]
    [Unicode(false)]
    public string? HilosAsig { get; set; }

    [Column("F_SOL_ASIG_HILOS")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FSolAsigHilos { get; set; }

    [Column("F_RX_ASIG_HILOS")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FRxAsigHilos { get; set; }

    [Column("ID_FAREND")]
    [StringLength(50)]
    [Unicode(false)]
    public string? IdFarend { get; set; }

    [Column("FAREND_SITE_NAME")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FarendSiteName { get; set; }

    [Column("CJ_ING_RESPONSABLE")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CjIngResponsable { get; set; }

    [Column("_DE_HILOS_HABILITAR")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DeHilosHabilitar { get; set; }

    [Column("PRE_DISEÑO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PreDiseño { get; set; }

    [Column("CONTRATA_RESP_DISEÑO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ContrataRespDiseño { get; set; }

    [Column("F_ASIG_INICIO__DISEÑO_CONTRATA")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FAsigInicioDiseñoContrata { get; set; }

    [Column("F_LEV_CAMPO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FLevCampo { get; set; }

    [Column("KMZ")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Kmz { get; set; }

    [Column("REP_FOT_DISEÑO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? RepFotDiseño { get; set; }

    [Column("PLANOS_PDF_CAD")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PlanosPdfCad { get; set; }

    [Column("DIAGRAMA_DE_EMPALME")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DiagramaDeEmpalme { get; set; }

    [Column("REV_DISEÑO_CJ")]
    [StringLength(50)]
    [Unicode(false)]
    public string? RevDiseñoCj { get; set; }

    [Column("PPTO_DISEÑO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PptoDiseño { get; set; }

    [Column("F_DISEÑO_PEXT_ENVIADO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FDiseñoPextEnviado { get; set; }

    [Column("TIEMPO_SIN_VAL")]
    [StringLength(50)]
    [Unicode(false)]
    public string? TiempoSinVal { get; set; }

    [Column("F_DISEÑO_PEXT_VALIDADO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FDiseñoPextValidado { get; set; }

    [Column("ESTATUS_DISEÑO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EstatusDiseño { get; set; }

    [Column("OBSERVACIONES")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Observaciones { get; set; }

    [Column("METRADO_DISEÑO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? MetradoDiseño { get; set; }

    [Column("METRADO_EXISTENTE")]
    [StringLength(50)]
    [Unicode(false)]
    public string? MetradoExistente { get; set; }

    [Column("COD_SAP")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CodSap { get; set; }

    [Column("DESCRIPCIÓN")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Descripción { get; set; }

    [Column("TIPO_SPAM")]
    [StringLength(50)]
    [Unicode(false)]
    public string? TipoSpam { get; set; }

    [Column("SOT_CID_PROY")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SotCidProy { get; set; }

    [Column("ESTATUS_OC")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EstatusOc { get; set; }

    [Column("INGENIERIA_DINAMICA")]
    [StringLength(50)]
    [Unicode(false)]
    public string? IngenieriaDinamica { get; set; }

    [Column("ESTATUS_PRESUPUESTO_INTEGRAL")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EstatusPresupuestoIntegral { get; set; }

    [Column("RED_FLAG_PROVIAS")]
    [StringLength(250)]
    [Unicode(false)]
    public string? RedFlagProvias { get; set; }

    [Column("ESTATUS_DISEÑO2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EstatusDiseño2 { get; set; }

    [Column("FC_INTEGRAL_CJ")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FcIntegralCj { get; set; }

    [Column("UPDATE_02_01")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Update0201 { get; set; }

    [Column("COMENTARIOS_Y_O_DEPENDENCIAS_CLARO")]
    [StringLength(500)]
    [Unicode(false)]
    public string? ComentariosYODependenciasClaro { get; set; }

    [Column("SEGUIMIENTO")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Seguimiento { get; set; }

    [Column("CONTRATA_ING")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ContrataIng { get; set; }

    [Column("AVANCES")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Avances { get; set; }

    [Column("SOLUCIÓN_ENERG_")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SoluciónEnerg { get; set; }

    [Column("POTENCIA_REQ_KW")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PotenciaReqKw { get; set; }

    [Column("_CW")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Cw { get; set; }

    [Column("_ENERG")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Energ { get; set; }

    [Column("_PEXT")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Pext1 { get; set; }

    [Column("_TI")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Ti { get; set; }

    [Column("FECHAS_PEXT")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FechasPext { get; set; }

    [Column("ESTATUS_PEXT")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EstatusPext { get; set; }

    [Column("PRORIDAD_PEXT")]
    [StringLength(250)]
    [Unicode(false)]
    public string? ProridadPext { get; set; }

    [Column("M_FO__EXISTENTE")]
    [StringLength(50)]
    [Unicode(false)]
    public string? MFoExistente { get; set; }

    [Column("M_FO__PROYECTADO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? MFoProyectado { get; set; }

    [Column("ESTATUS_CARTA_USO_POSTES")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EstatusCartaUsoPostes { get; set; }

    [Column("F_SOL_CARTA")]
    [StringLength(15)]
    [Unicode(false)]
    public string? FSolCarta { get; set; }

    [Column("N_DE_POSTES_PROYECTADOS")]
    [StringLength(50)]
    [Unicode(false)]
    public string? NDePostesProyectados { get; set; }

    [Column("POSTE_EXISTENTES_ELECTRICA_BT")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PosteExistentesElectricaBt { get; set; }

    [Column("POSTES_EXISTENTE_AMOV")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PostesExistenteAmov { get; set; }

    [Column("POSTE_EXISTENTES_ELECTRICA_MT")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PosteExistentesElectricaMt { get; set; }

    [Column("TOTAL_POSTES")]
    [StringLength(50)]
    [Unicode(false)]
    public string? TotalPostes { get; set; }

    [Column("TOTAL_POSTES_ELECTRICA")]
    [StringLength(50)]
    [Unicode(false)]
    public string? TotalPostesElectrica { get; set; }

    [Column("CONCESIONARIA")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Concesionaria { get; set; }

    [Column("ESTATUS_EXP_ELECTRICO_PEXT")]
    [StringLength(250)]
    [Unicode(false)]
    public string? EstatusExpElectricoPext { get; set; }

    [Column("ESTATUS_ELECTRICA")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EstatusElectrica { get; set; }

    [Column("N_DE_EXPEDIENTE")]
    [StringLength(50)]
    [Unicode(false)]
    public string? NDeExpediente { get; set; }

    [Column("FECHA_DE_ING_EXPEDIENTE")]
    [StringLength(15)]
    [Unicode(false)]
    public string? FechaDeIngExpediente { get; set; }

    [Column("DIAS_SIN_EXPEDIENTE2")]
    [StringLength(250)]
    [Unicode(false)]
    public string? DiasSinExpediente2 { get; set; }

    [Column("JEFE_CONCESIONARIA")]
    [StringLength(50)]
    [Unicode(false)]
    public string? JefeConcesionaria { get; set; }

    [Column("GESTOR_ZONAL_RESPONSABLE")]
    [StringLength(50)]
    [Unicode(false)]
    public string? GestorZonalResponsable { get; set; }

    [Column("ESTATUS_INSPECCION")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EstatusInspeccion { get; set; }

    [Column("FC_INSPECCIÓN")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FcInspección { get; set; }

    [Column("FECHA_INSPECCION_REAL")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FechaInspeccionReal { get; set; }

    [Column("RESPONSABLE_GESTION")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ResponsableGestion { get; set; }

    [Column("COMENTARIOS")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Comentarios { get; set; }

    [Column("POSTES_OBSERVADOS")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PostesObservados { get; set; }

    [Column("POSTES_FCC_VAL")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PostesFccVal { get; set; }

    [Column("F_VAL_FCC_")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FValFcc { get; set; }

    [Column("MUNICIPALIDAD")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Municipalidad { get; set; }

    [Column("EXPEDIENTE_MUNICIPAL")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ExpedienteMunicipal { get; set; }

    [Column("F_INGRESO_EXP_MUNI")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FIngresoExpMuni { get; set; }

    [Column("FUIIT")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Fuiit { get; set; }

    [Column("COMENTARIO_EXP_MUNICIPAL")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ComentarioExpMunicipal { get; set; }

    [Column("PMA")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Pma { get; set; }

    [Column("CIRA")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Cira { get; set; }

    [Column("PROVIAS")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Provias { get; set; }

    [Column("EVAP")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Evap { get; set; }

    [Column("SERVIDUMBRE")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Servidumbre { get; set; }

    [Column("ESTATUS_PERMISOS_ESPECIALES")]
    [StringLength(250)]
    [Unicode(false)]
    public string? EstatusPermisosEspeciales { get; set; }

    [Column("PERMISOS_ESPECIALES_VALIDADOS")]
    [StringLength(250)]
    [Unicode(false)]
    public string? PermisosEspecialesValidados { get; set; }

    [Column("F_FUIIT")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FFuiit { get; set; }

    [Column("F_PMA")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FPma { get; set; }

    [Column("F_CIRA")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FCira { get; set; }

    [Column("F_PROVIAS")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FProvias { get; set; }

    [Column("F_EVAP")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FEvap { get; set; }

    [Column("F_SERVIDUMBRE")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FServidumbre { get; set; }

    [Column("FC_LICENCIA")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FcLicencia { get; set; }

    [Column("FC_C_LICENCIA")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FcCLicencia { get; set; }

    [Column("LICENCIA")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Licencia { get; set; }

    [Column("FIN_LICENCIA")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FinLicencia { get; set; }

    [Column("DÍAS_PARA_VENCIM_")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DíasParaVencim { get; set; }

    [Column("INICIO_PEXT")]
    [StringLength(50)]
    [Unicode(false)]
    public string? InicioPext { get; set; }

    [Column("FIN_PEXT")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FinPext { get; set; }

    [Column("ESTATUS_PEXT2")]
    [StringLength(250)]
    [Unicode(false)]
    public string? EstatusPext2 { get; set; }

    [Column("FECHAS_CW")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FechasCw { get; set; }

    [Column("ESTATUS_EJECUCION_CW")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EstatusEjecucionCw { get; set; }

    [Column("RED_FLAG_CW")]
    [StringLength(250)]
    [Unicode(false)]
    public string? RedFlagCw { get; set; }

    [Column("TIPO_POSTE")]
    [StringLength(50)]
    [Unicode(false)]
    public string? TipoPoste { get; set; }

    [Column("ALT_POSTE")]
    [StringLength(50)]
    [Unicode(false)]
    public string? AltPoste { get; set; }

    [Column("ESTATUS_POSTE")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EstatusPoste { get; set; }

    [Column("FECHA_POSTE")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FechaPoste { get; set; }

    [Column("TRASLADO_POSTES")]
    [StringLength(50)]
    [Unicode(false)]
    public string? TrasladoPostes { get; set; }

    [Column("FECHA_TRASLADO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FechaTraslado { get; set; }

    [Column("CW_PRELIMINAR")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CwPreliminar { get; set; }

    [Column("FECHA_CW")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FechaCw { get; set; }

    [Column("PARRES")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Parres { get; set; }

    [Column("FECHA_PARRES")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FechaParres { get; set; }

    [Column("PARARRAYOS")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Pararrayos { get; set; }

    [Column("FECHA_PARARRAYOS")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FechaPararrayos { get; set; }

    [Column("FC_PROYECTO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FcProyecto { get; set; }

    [Column("FC_C_PROYECTO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FcCProyecto { get; set; }

    [Column("CWTS")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Cwts { get; set; }

    [Column("FC_CW_INICIADO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FcCwIniciado { get; set; }

    [Column("FC_C_CW_INICIADO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FcCCwIniciado { get; set; }

    [Column("INICIO_CW")]
    [StringLength(50)]
    [Unicode(false)]
    public string? InicioCw { get; set; }

    [Column("FIN_CW")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FinCw { get; set; }

    [Column("FECHAS_TI")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FechasTi { get; set; }

    [Column("ESTUDIO_LOS")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EstudioLos { get; set; }

    [Column("ENVÍO_LOS")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EnvíoLos { get; set; }

    [Column("VALID_LOS")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ValidLos { get; set; }

    [Column("RFTI")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Rfti { get; set; }

    [Column("INICIO_TI")]
    [StringLength(50)]
    [Unicode(false)]
    public string? InicioTi { get; set; }

    [Column("ENLACE_VALIDADO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EnlaceValidado { get; set; }

    [Column("FIN_TI")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FinTi { get; set; }

    [Column("FC_OA")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FcOa { get; set; }

    [Column("FC_ACTA_COBERTURA")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FcActaCobertura { get; set; }

    [Column("FECHAS_ENERG_")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FechasEnerg { get; set; }

    [Column("ESTATUS_ENERGÍA")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EstatusEnergía { get; set; }

    [Column("RED_FLAG_ENERGIA")]
    [StringLength(250)]
    [Unicode(false)]
    public string? RedFlagEnergia { get; set; }

    [Column("CONCESIONARIAS")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Concesionarias { get; set; }

    [Column("TARIFA_REQUERIDA")]
    [StringLength(50)]
    [Unicode(false)]
    public string? TarifaRequerida { get; set; }

    [Column("POTENCIA_REQUERIDA_WATTS_")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PotenciaRequeridaWatts { get; set; }

    [Column("POTENCIA_CONTRATADA_KW")]
    [StringLength(15)]
    [Unicode(false)]
    public string? PotenciaContratadaKw { get; set; }

    [Column("GESTOR")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Gestor { get; set; }

    [Column("LOCALIDAD")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Localidad { get; set; }

    [Column("ESTATUS_EXP_MUNICIPAL_AC")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EstatusExpMunicipalAc { get; set; }

    [Column("F_INGRESO_EXP_AC")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FIngresoExpAc { get; set; }

    [Column("T_TRANSCURRIDO_MUNI_AC")]
    [StringLength(50)]
    [Unicode(false)]
    public string? TTranscurridoMuniAc { get; set; }

    [Column("AUTORIZACION_MUNICIPAL_AC")]
    [StringLength(50)]
    [Unicode(false)]
    public string? AutorizacionMunicipalAc { get; set; }

    [Column("COMENTARIOS2")]
    [StringLength(250)]
    [Unicode(false)]
    public string? Comentarios2 { get; set; }

    [Column("EXP_ELEC_AC")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ExpElecAc { get; set; }

    [Column("N_ATENCION")]
    [StringLength(50)]
    [Unicode(false)]
    public string? NAtencion { get; set; }

    [Column("F__INGRESO_EXPEDIENTE")]
    [StringLength(15)]
    [Unicode(false)]
    public string? FIngresoExpediente { get; set; }

    [Column("T_TRANSCURRIDO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? TTranscurrido { get; set; }

    [Column("FACTIBILIDAD")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Factibilidad { get; set; }

    [Column("FECHA_FACT")]
    [StringLength(15)]
    [Unicode(false)]
    public string? FechaFact { get; set; }

    [Column("DIAS_CON_FACTIBILIDAD")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DiasConFactibilidad { get; set; }

    [Column("MURETE_ADEC")]
    [StringLength(50)]
    [Unicode(false)]
    public string? MureteAdec { get; set; }

    [Column("F_MURETE")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FMurete { get; set; }

    [Column("METRAJE_AC__PROYECTADO")]
    [StringLength(15)]
    [Unicode(false)]
    public string? MetrajeAcProyectado { get; set; }

    [Column("N_DE_POSTES_PROYECTADO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? NDePostesProyectado { get; set; }

    [Column("PRESUPUESTO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Presupuesto { get; set; }

    [Column("CONTRATO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Contrato { get; set; }

    [Column("MEDIDOR_O_SUMINISTRO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? MedidorOSuministro { get; set; }

    [Column("TABLERO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Tablero { get; set; }

    [Column("FC_ENERGIZADO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FcEnergizado { get; set; }

    [Column("ACCIONES_A_TOMAR")]
    [StringLength(50)]
    [Unicode(false)]
    public string? AccionesATomar { get; set; }

    [Column("FC_ENERGÍA_PROVISIONAL")]
    [StringLength(15)]
    [Unicode(false)]
    public string? FcEnergíaProvisional { get; set; }

    [Column("INICIO_ENERGÍA")]
    [StringLength(50)]
    [Unicode(false)]
    public string? InicioEnergía { get; set; }

    [Column("FIN_ENERGÍA")]
    [StringLength(15)]
    [Unicode(false)]
    public string? FinEnergía { get; set; }

    [Column("ENERGÍA_OK")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EnergíaOk { get; set; }

    [Column("COMENTARIOS_AC")]
    [StringLength(250)]
    [Unicode(false)]
    public string? ComentariosAc { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? W42 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? W43 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? W44 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? W45 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? W46 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? W47 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? W48 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? W49 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? W50 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? W51 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? W52 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? W53 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? W54 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? W55 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? W56 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? W57 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? W58 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? W59 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? W60 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? W61 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? W62 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? W63 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? W64 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? W65 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? W66 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? W67 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? W68 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? W69 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? W70 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? W71 { get; set; }

    [Column("W2_W1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? W2W1 { get; set; }

    [Column("IMP_PEXT")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ImpPext { get; set; }

    [Column("ESTATUS_EJECUCION_PEXT")]
    [StringLength(250)]
    [Unicode(false)]
    public string? EstatusEjecucionPext { get; set; }

    [Column("RED_FLAG_PEXT")]
    [StringLength(250)]
    [Unicode(false)]
    public string? RedFlagPext { get; set; }

    [Column("ESTATUS_PERMISOS")]
    [StringLength(250)]
    [Unicode(false)]
    public string? EstatusPermisos { get; set; }

    [Column("VIABILIDAD")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Viabilidad { get; set; }

    [Column("ESTADO_HW")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EstadoHw { get; set; }

    [Column("F_SOL_FO")]
    [StringLength(15)]
    [Unicode(false)]
    public string? FSolFo { get; set; }

    [Column("F_ASIG_FO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FAsigFo { get; set; }

    [Column("F_PAP_FO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FPapFo { get; set; }

    [Column("F_RX_FO")]
    [StringLength(15)]
    [Unicode(false)]
    public string? FRxFo { get; set; }

    [Column("_DIAS_ENTREGA_FO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DiasEntregaFo { get; set; }

    [Column("CODIGO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Codigo { get; set; }

    [Column("DESCRIPTIONS")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Descriptions { get; set; }

    [Column("SPAM")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Spam { get; set; }

    [Column("METRAJE_SOLICITADO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? MetrajeSolicitado { get; set; }

    [Column("SOT_CID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SotCid { get; set; }

    [Column("COD_POSTE")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CodPoste { get; set; }

    [Column("STATUS_DATA_PEXT")]
    [StringLength(250)]
    [Unicode(false)]
    public string? StatusDataPext { get; set; }

    [Column("POSTES_FV_09")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PostesFv09 { get; set; }

    [Column("POSTES_FV_11")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PostesFv11 { get; set; }

    [Column("ESTATUS_POSTES_FV")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EstatusPostesFv { get; set; }

    [Column("POSTES_CAC_09")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PostesCac09 { get; set; }

    [Column("POSTES_CAC_11")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PostesCac11 { get; set; }

    [Column("ESTATUS_POSTES_CAC")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EstatusPostesCac { get; set; }

    [Column("TOTAL_POSTES_FINAL")]
    [StringLength(50)]
    [Unicode(false)]
    public string? TotalPostesFinal { get; set; }

    [Column("ESTATUS_POSTES_GENERAL")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EstatusPostesGeneral { get; set; }

    [Column("ANALISTA_PEXT")]
    [StringLength(250)]
    [Unicode(false)]
    public string? AnalistaPext { get; set; }

    [Column("CONTRATA_PEXT")]
    [StringLength(250)]
    [Unicode(false)]
    public string? ContrataPext { get; set; }

    [Column("F_INIC_EJEC")]
    [StringLength(15)]
    [Unicode(false)]
    public string? FInicEjec { get; set; }

    [Column("F_FIN_PEXT")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FFinPext { get; set; }

    [Column("W_PEXT_EJEC")]
    [StringLength(250)]
    [Unicode(false)]
    public string? WPextEjec { get; set; }

    [Column("POSTES")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Postes { get; set; }

    [Column("TENDIDO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Tendido { get; set; }

    [Column("FUSIONES")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Fusiones { get; set; }

    [Column("PINT")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Pint { get; set; }

    [Column("ACABADOS")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Acabados { get; set; }

    [Column("_DE_HILOS_INSTALADOS")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DeHilosInstalados { get; set; }

    [Column("METRAJE_INSTALADO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? MetrajeInstalado { get; set; }

    [Column("PRIORIDAD")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Prioridad { get; set; }

    [Column("SEGUIMIENTO_PEXT")]
    [StringLength(250)]
    [Unicode(false)]
    public string? SeguimientoPext { get; set; }

    [Column("FÓRMULAS")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Fórmulas { get; set; }

    [Column("VISITA_DE_CANDIDATOS")]
    [StringLength(50)]
    [Unicode(false)]
    public string? VisitaDeCandidatos { get; set; }

    [Column("ENVÍO_DE_SAR")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EnvíoDeSar { get; set; }

    [Column("FIRMA_DE_CONTRATO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FirmaDeContrato { get; set; }

    [Column("INGRESO_DE_CONTRATO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? IngresoDeContrato { get; set; }

    [Column("OTENCIÓN_CIRA")]
    [StringLength(50)]
    [Unicode(false)]
    public string? OtenciónCira { get; set; }

    [Column("OTENCIÓN_PMA")]
    [StringLength(50)]
    [Unicode(false)]
    public string? OtenciónPma { get; set; }

    [Column("OTENCIÓN_DIA")]
    [StringLength(50)]
    [Unicode(false)]
    public string? OtenciónDia { get; set; }

    [Column("OTENCIÓN_DGAC")]
    [StringLength(50)]
    [Unicode(false)]
    public string? OtenciónDgac { get; set; }

    [Column("INGRESO_LICENCIA")]
    [StringLength(50)]
    [Unicode(false)]
    public string? IngresoLicencia { get; set; }

    [Column("REALIZAR_LOS")]
    [StringLength(50)]
    [Unicode(false)]
    public string? RealizarLos { get; set; }

    [Column("EJECUCIÓN_EMS")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EjecuciónEms { get; set; }

    [Column("EJECUCIÓN_EMS_FE")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EjecuciónEmsFe { get; set; }

    [Column("RELEVAMIENTO_DE_TORRE")]
    [StringLength(50)]
    [Unicode(false)]
    public string? RelevamientoDeTorre { get; set; }

    [Column("ENVÍO_PROYECTO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EnvíoProyecto { get; set; }

    [Column("INICIO_DE_CW")]
    [StringLength(50)]
    [Unicode(false)]
    public string? InicioDeCw { get; set; }

    [Column("LISTO_PARA_EQUIPOS")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ListoParaEquipos { get; set; }

    [Column("FIN_DE_CW")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FinDeCw { get; set; }

    [Column("IMP_TI")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ImpTi { get; set; }

    [Column("ESTATUS_EJECUCION_TI")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EstatusEjecucionTi { get; set; }

    [Column("RED_FLAG_TI")]
    [StringLength(250)]
    [Unicode(false)]
    public string? RedFlagTi { get; set; }

    [Column("TECNOLOGÍA")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Tecnología { get; set; }

    [Column("MODELO_ANTENA")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ModeloAntena { get; set; }

    [Column("CANTIDAD_SECTORES2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CantidadSectores2 { get; set; }

    [Column("TIPO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Tipo { get; set; }

    [Column("ESTADO_HW_TI")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EstadoHwTi { get; set; }

    [Column("F_SOL_RF")]
    [StringLength(15)]
    [Unicode(false)]
    public string? FSolRf { get; set; }

    [Column("F_ASIG_RF")]
    [StringLength(15)]
    [Unicode(false)]
    public string? FAsigRf { get; set; }

    [Column("F_PAP_RF")]
    [StringLength(15)]
    [Unicode(false)]
    public string? FPapRf { get; set; }

    [Column("F_RX_RF")]
    [StringLength(15)]
    [Unicode(false)]
    public string? FRxRf { get; set; }

    [Column("_DIAS_ENTREGA_RF")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DiasEntregaRf { get; set; }

    [Column("DF_4G")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Df4g { get; set; }

    [Column("WOTX")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Wotx { get; set; }

    [Column("SCRIPT")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Script { get; set; }

    [Column("FO_PINT")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FoPint { get; set; }

    [Column("SOPORTES_RF")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SoportesRf { get; set; }

    [Column("CONTRATA_TI")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ContrataTi { get; set; }

    [Column("F_ACT_REAL")]
    [StringLength(15)]
    [Unicode(false)]
    public string? FActReal { get; set; }

    [Column("W_ACT_REAL")]
    [StringLength(50)]
    [Unicode(false)]
    public string? WActReal { get; set; }

    [Column("PUESTA_EN_SERVICIO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PuestaEnServicio { get; set; }

    [Column("ENVÍO_ACTA_COBERTURA")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EnvíoActaCobertura { get; set; }

    [Column("FECHA_ACTA_COBERTURA")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FechaActaCobertura { get; set; }

    [Column("CAPITALIZACIÓN")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Capitalización { get; set; }

    [Column("PRIORIDAD_TI")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PrioridadTi { get; set; }

    [Column("SEGUIMIENTO_TI")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SeguimientoTi { get; set; }

    [Column("FÓRMULAS_ENERGÍA")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FórmulasEnergía { get; set; }

    [Column("SOLICITAR_FACTIBILIDAD")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SolicitarFactibilidad { get; set; }

    [Column("OBTENER_FACTIBILIDAD")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ObtenerFactibilidad { get; set; }

    [Column("SOLICITAR_PUNTO_DISEÑO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SolicitarPuntoDiseño { get; set; }

    [Column("OBTENER_PUNTO_DISEÑO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ObtenerPuntoDiseño { get; set; }

    [Column("INGRESO_PROY_CONCESIONARIA")]
    [StringLength(50)]
    [Unicode(false)]
    public string? IngresoProyConcesionaria { get; set; }

    [Column("INICIO_OBRAS_ENERGÍA")]
    [StringLength(50)]
    [Unicode(false)]
    public string? InicioObrasEnergía { get; set; }

    [Column("FIN_OBRAS_ENERGÍA")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FinObrasEnergía { get; set; }

    [Column("INSTALACIÓN_SUMINISTRO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? InstalaciónSuministro { get; set; }

    [Column("FORECAST_CLARO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ForecastClaro { get; set; }

    [Column("FC_GENERAL")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FcGeneral { get; set; }

    [Column("WEEK_ACTIVACION")]
    [StringLength(50)]
    [Unicode(false)]
    public string? WeekActivacion { get; set; }

    [Column("PROY_")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Proy { get; set; }

    [Column("PRIORIDAD_CLARO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PrioridadClaro { get; set; }

    [Column("OT_PAP2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? OtPap2 { get; set; }

    public int? IdZona { get; set; }

    [Column("IdSite")]
    [StringLength(16)]
    public string? IdSite1 { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? CorreSite { get; set; }

    [Column("Status_Claro")]
    public int? StatusClaro { get; set; }

    public int? IdDepartamento { get; set; }

    public int? IdTransmision { get; set; }

    public int? IdProyecto { get; set; }

    public int? IdTorrera { get; set; }

    public int? IdTipoTorre { get; set; }

    public int? IdOnAir { get; set; }

    public int? IdActaCob { get; set; }

    public int? IdCapitalizacion { get; set; }

    public int? IdCandado { get; set; }

    public int? IdContacto { get; set; }

    public int? IdStatusIng { get; set; }

    [Column("GIS_INGENIERIA2")]
    public int? GisIngenieria2 { get; set; }

    [Column("DATA_ING_TX_CLARO2")]
    public int? DataIngTxClaro2 { get; set; }

    [Column("HILOS_ASIG2")]
    public int? HilosAsig2 { get; set; }

    public int? AnalistaIng { get; set; }

    [Column("idContrataResp")]
    public int? IdContrataResp { get; set; }

    [Column("KMZ2")]
    public int? Kmz2 { get; set; }

    [Column("REP_FOT_DISEno")]
    public int? RepFotDiseno { get; set; }

    public int? IdPlanosPdf { get; set; }

    public int? IdDiagramaEmpalme { get; set; }

    public int? PptoDise { get; set; }

    [Column("Status_Diseno")]
    public int? StatusDiseno { get; set; }

    [Column("ESTATUS_OC2")]
    public int? EstatusOc2 { get; set; }

    public int? IdIngDinamica { get; set; }

    public int? PreInt { get; set; }

    [Column("RED_FLAG_PROVIAS2")]
    public int? RedFlagProvias2 { get; set; }

    public int? StatusPext { get; set; }

    public int? PriPext { get; set; }

    public int? StatusCartaPoste { get; set; }

    [Column("CONCESIONARIA2")]
    public int? Concesionaria2 { get; set; }

    public int? StatusExpPext { get; set; }

    public int? IdStatusElectrica { get; set; }

    public int? IdJefeConcesionaria { get; set; }

    public int? IdGestorZonal { get; set; }

    [Column("ESTATUS_INSPECCION2")]
    public int? EstatusInspeccion2 { get; set; }

    public int? IdRespGestion { get; set; }

    public int? IdExpMun { get; set; }

    [Column("MUNICIPALIDAD2")]
    public int? Municipalidad2 { get; set; }

    [Column("FUIIT2")]
    public int? Fuiit2 { get; set; }

    [Column("PMA2")]
    public int? Pma2 { get; set; }

    [Column("CIRA2")]
    public int? Cira2 { get; set; }

    [Column("PROVIAS2")]
    public int? Provias2 { get; set; }

    [Column("EVAP2")]
    public int? Evap2 { get; set; }

    [Column("SERVIDUMBRE2")]
    public int? Servidumbre2 { get; set; }

    public int? StatPermEspe { get; set; }

    public int? PermEspecial { get; set; }

    public int? StatusEjecCw { get; set; }

    [Column("TipoPoste")]
    public int? TipoPoste1 { get; set; }

    public int? AlturaPoste { get; set; }

    public int? StatusPoste { get; set; }

    public int? TrasladoPoste { get; set; }

    [Column("CwPreliminar")]
    public int? CwPreliminar1 { get; set; }

    public int? Parres2 { get; set; }

    public int? Pararrayos2 { get; set; }

    public int? StatusEjecTi { get; set; }

    public int? Tecnologia { get; set; }

    public int? ModAntena { get; set; }

    public int? Tipo2 { get; set; }

    public int? EstHwTi { get; set; }

    public int? Df { get; set; }

    [Column("WOTX2")]
    public int? Wotx2 { get; set; }

    [Column("SCRIPT2")]
    public int? Script2 { get; set; }

    [Column("FO_PINT2")]
    public int? FoPint2 { get; set; }

    [Column("SOPORTES_RF2")]
    public int? SoportesRf2 { get; set; }

    [Column("CONTRATA_TI2")]
    public int? ContrataTi2 { get; set; }

    public int? PtaServ { get; set; }

    public int? EnvActCob { get; set; }

    public int? Capitalizacion2 { get; set; }

    [Column("PRIORIDAD_TI2")]
    public int? PrioridadTi2 { get; set; }

    public int? StatusEnergia { get; set; }

    [Column("CONCESIONARIAS2")]
    public int? Concesionarias2 { get; set; }

    public int? IdGestorEne { get; set; }

    public int? IdLocalidad { get; set; }

    public int? EstExpMunPal { get; set; }

    [Column("idFact")]
    public int? IdFact { get; set; }

    [Column("MureteAdec")]
    public int? MureteAdec1 { get; set; }

    public int? IdPresupuestado { get; set; }

    public int? IdContrato { get; set; }

    public int? IdSuministro { get; set; }

    public int? IdTablero { get; set; }
}
